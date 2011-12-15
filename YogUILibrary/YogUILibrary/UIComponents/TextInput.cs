using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using YogUILibrary.Code.Managers;
namespace YogUILibrary.Code.UIComponents
{
    public class TextInput : UIComponent
    {

        private Action lambdaTextChanged = null;
        private Action lambdaTextEnter;
        public TextDrawer tdI;
        public string input = "";
        public bool selected = false;
        private string mainDelim;

        public int cursorPos = 0;

        private int interval = 20;
        private int defInterval = 20;
        //The timer for holding down a key before it repeats. If it has not begun auto-repeating, this counts up to that, and is then used for the auto-repeat interval.
        private int keyRepeatWaitCount = 0;
        //How many frames a key has to be held down to auto-repeat.
        private int keyRepeatWait = 30;
        //How many frames it takes per auto-repeat.
        private int keyRepeatInterval = 3;
        //The key being held down.
        private string keyRepeatHeld = "";
        private bool keyRepeatRapid = false;

        public int selectionStart = -1;
        public int selectionEnd = -1;

        public int offset = 0;
        public int numCharsAllowed = 0;

        public override Rectangle BoundBox
        {
            get
            {
                Vector2 size = tdI.font.MeasureString(tdI.text);
                return new Rectangle(
                    (int)tdI.Position.X,
                    (int)tdI.Position.Y,
                    (int)(size.X * tdI.scale),
                    (int)(size.Y * tdI.scale));
            }
        }

        public string offsetText
        {
            get
            {
                if (offset >= input.Length) offset = input.Length;
                if (offset < 0) offset = 0;
                string input2 = "";
                for (int i = offset; i < offset + numCharsAllowed && i < input.Length; i++) { input2 += input[i]; }
                return input2;
            }
        }

        public string selectedText
        {
            get
            {
                Vector2 selection = getFixedSelection();
                if (selection.X < 0 || selection.Y < 0 || selection.X == selection.Y) return "";
                string ret = "";
                for (int i = (int)selection.X; i < selection.Y; i++)
                {
                    ret += input[i];
                }
                return ret;
            }
        }


        public TextInput(Vector2 position, SpriteFont font, Color color, Action lambdaTextEnter, string input = "", Action lambdaTextChanged = null)
        {
            this.input = input;
            this.lambdaTextEnter = lambdaTextEnter;
            this.lambdaTextChanged = lambdaTextChanged;
            tdI = new TextDrawer(font, input, position, color, TextAlign.Left);
            this.bindKeys();
            base.UIC_Initialize();
        }

        public void SetPosition(Vector2 position)
        {
            tdI.Position = position;
        }

        private bool ShiftHeld()
        {
            return InputManager.isKeyPressed(Keys.LeftShift) || InputManager.isKeyPressed(Keys.RightShift);
        }

        private void bindKeys()
        {

            InputManager.BindKey(() =>
            {
                if(!(active && selected)) return;
                if (ShiftHeld())
                {
                    keyPressed("A");
                }
                else
                {
                    if (InputManager.isKeyPressed(Keys.LeftControl) || InputManager.isKeyPressed(Keys.RightControl))
                    {
                        selectionStart = 0;
                        selectionEnd = input.Length;
                    }
                    else
                    {
                        keyPressed("a");
                    }
                }
            }, Keys.A);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("B") : keyPressed("b"); }, Keys.B);
            InputManager.BindKey(() =>
            {
                if(!(active && selected)) return;
                if (ShiftHeld())
                {
                    keyPressed("C");
                }
                else
                {
                    if (InputManager.isKeyPressed(Keys.LeftControl) || InputManager.isKeyPressed(Keys.RightControl))
                    {
                        System.Windows.Forms.Clipboard.SetText(selectedText != "" ? selectedText : System.Windows.Forms.Clipboard.GetText());
                    }
                    else
                    {
                        keyPressed("c");
                    }
                }
            }, Keys.C);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("D") : keyPressed("d"); }, Keys.D);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("E") : keyPressed("e"); }, Keys.E);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("F") : keyPressed("f"); }, Keys.F);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("G") : keyPressed("g"); }, Keys.G);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("H") : keyPressed("h"); }, Keys.H);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("I") : keyPressed("i"); }, Keys.I);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("J") : keyPressed("j"); }, Keys.J);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("K") : keyPressed("k"); }, Keys.K);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("L") : keyPressed("l"); }, Keys.L);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("M") : keyPressed("m"); }, Keys.M);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("N") : keyPressed("n"); }, Keys.N);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("O") : keyPressed("o"); }, Keys.O);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("P") : keyPressed("p"); }, Keys.P);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("Q") : keyPressed("q"); }, Keys.Q);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("R") : keyPressed("r"); }, Keys.R);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("S") : keyPressed("s"); }, Keys.S);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("T") : keyPressed("t"); }, Keys.T);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("U") : keyPressed("u"); }, Keys.U);
            InputManager.BindKey(() =>
            {
                if (!(active && selected)) return;
                if (ShiftHeld())
                {
                    keyPressed("V");
                }
                else
                {
                    if (InputManager.isKeyPressed(Keys.LeftControl) || InputManager.isKeyPressed(Keys.RightControl))
                    {
                        keyPressed(System.Windows.Forms.Clipboard.GetText());
                    }
                    else
                    {
                        keyPressed("v");
                    }
                }
            }, Keys.V);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("W") : keyPressed("w"); }, Keys.W);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("X") : keyPressed("x"); }, Keys.X);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("Y") : keyPressed("y"); }, Keys.Y);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("Z") : keyPressed("z"); }, Keys.Z);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed(")") : keyPressed("0"); }, Keys.D0);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("!") : keyPressed("1"); }, Keys.D1);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("@") : keyPressed("2"); }, Keys.D2);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("#") : keyPressed("3"); }, Keys.D3);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("$") : keyPressed("4"); }, Keys.D4);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("%") : keyPressed("5"); }, Keys.D5);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("^") : keyPressed("6"); }, Keys.D6);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("&") : keyPressed("7"); }, Keys.D7);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("*") : keyPressed("8"); }, Keys.D8);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("(") : keyPressed("9"); }, Keys.D9);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("?") : keyPressed("/"); }, Keys.OemQuestion);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed(">") : keyPressed("."); }, Keys.OemPeriod);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("<") : keyPressed(","); }, Keys.OemComma);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("\"") : keyPressed("'"); }, Keys.OemQuotes);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed(":") : keyPressed(";"); }, Keys.OemSemicolon);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("}") : keyPressed("]"); }, Keys.OemCloseBrackets);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("{") : keyPressed("["); }, Keys.OemOpenBrackets);
            InputManager.BindKey(() => { keyPressed(" "); }, Keys.Space);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("_") : keyPressed("-"); }, Keys.OemMinus);
            InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed("+") : keyPressed("="); }, Keys.OemPlus);
            InputManager.BindKey(() => { keyPressed("backspace"); }, Keys.Back, true);
            InputManager.BindKey(() => { if (active && selected) { if (lambdaTextEnter != null) lambdaTextEnter(); } }, Keys.Enter);
            InputManager.BindKey(() => { keyPressed("left"); }, Keys.Left, true);
            InputManager.BindKey(() => { keyPressed("right"); }, Keys.Right, true);


            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.A, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.B, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.C, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.E, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.F, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.G, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.H, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.I, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.J, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.K, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.L, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.M, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.N, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.O, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.P, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Q, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.R, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.S, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.T, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.U, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.V, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.W, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.X, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Y, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Z, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D0, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D1, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D2, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D3, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D4, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D5, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D6, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D7, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D8, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.D9, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemQuestion, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemPeriod, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemComma, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemQuotes, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemSemicolon, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemCloseBrackets, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemOpenBrackets, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Space, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemMinus, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.OemPlus, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Back, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Left, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; keyRepeatWaitCount = 0; }, Keys.Right, false, false);
        }
        private string keyPressed(string key)
        {
            if (!(active && selected)) return "";
            string before = "";
            string after = "";
            int lowerLimit = cursorPos;
            int upperLimit = cursorPos;
            int removeCursorPos = 1;
            Vector2 selection = getFixedSelection();
            if (selection.X >= 0 && selection.Y >= 0 && selection.X != selection.Y)
            {
                lowerLimit = (int)selection.X;
                upperLimit = (int)selection.Y;
                removeCursorPos = (int)(selection.Y - selection.X);
            }
            for (int i = 0; i < lowerLimit; i++)
            {
                before += input[i];
            }
            for (int i = upperLimit; i < input.Length; i++)
            {
                after += input[i];
            }
            if (key == keyRepeatHeld)
            {
                if (keyRepeatRapid)
                {
                    if (keyRepeatWaitCount < keyRepeatInterval)
                        keyRepeatWaitCount++;
                    else
                    {
                        keyRepeatWaitCount = 0;
                        if (key == "backspace")
                        {
                            backSpace();
                        }
                        else if (key == "left")
                        {
                            cursorPos -= (cursorPos > 0) ? 1 : 0;
                        }
                        else if (key == "right")
                        {
                            cursorPos += (cursorPos < input.Length) ? 1 : 0;
                        }
                        else
                        {
                            input = before + key + after;
                            cursorPos = (before + key).Length;
                        }
                    }
                }
                else
                {
                    if (keyRepeatWaitCount < keyRepeatWait)
                    {
                        keyRepeatWaitCount++;
                    }
                    else
                    {
                        keyRepeatWaitCount = 0;
                        keyRepeatRapid = true;
                    }
                }
            }
            else
            {
                keyRepeatHeld = key;
                keyRepeatWaitCount = 0;
                keyRepeatRapid = false;
                if (key == "backspace")
                {
                    backSpace();
                }
                else if (key == "left")
                {
                    cursorPos -= (cursorPos > 0) ? 1 : 0;
                }
                else if (key == "right")
                {
                    cursorPos += (cursorPos < input.Length) ? 1 : 0;
                }
                else
                {
                    input = before + key + after;
                    cursorPos = (before + key).Length;
                }
            }
            if (lambdaTextChanged != null) lambdaTextChanged();
            selectionEnd = -1;
            selectionStart = -1;
            return "";
        }

        private void backSpace()
        {
            Vector2 selection = getFixedSelection();
            int placeToRemove = cursorPos - 1;
            int amountToRemove = 1;
            if (selection.X >= 0 && selection.Y >= 0 && selection.X != selection.Y)
            {
                placeToRemove = (int)selection.X;
                amountToRemove = (int)(selection.Y - selection.X);
            }
            if (amountToRemove + placeToRemove > input.Length || placeToRemove < 0) return;
            input = (input.Length > 0) ? input.Remove(placeToRemove, amountToRemove) : "";
            cursorPos -= amountToRemove;
        }

        public override void Update(GameTime time)
        {
            string delim = mainDelim;
            interval--;
            if (interval <= 0)
            {
                interval = defInterval;
                mainDelim = (mainDelim == "") ? "|" : "";
            }
            if (!selected)
                mainDelim = "";

            tdI.text = offsetText;

            if (active)
                tdI.Update(time);

            base.Update(time);
        }

        public override void OnMouseClick()
        {
            //base.OnMouseClick();
        }

        public override void OnMouseOver()
        {

            //base.OnMouseOver();
        }

        public override void OnMouseOff()
        {
            //base.OnMouseOver();
        }

        public float getCharLength()
        {
            return tdI.font.MeasureString(" ").X;
        }

        public Vector2 getFixedSelection()
        {
            Vector2 ret = new Vector2();
            ret.X = (selectionStart > selectionEnd) ? selectionEnd : selectionStart;
            ret.Y = (selectionStart > selectionEnd) ? selectionStart : selectionEnd;
            return ret;
        }

        public override void Draw(SpriteBatch sb)
        {
            if (cursorPos < 0) cursorPos = 0;
            if (cursorPos > input.Length) cursorPos = input.Length;
            if (cursorPos - offset > numCharsAllowed) offset += ((cursorPos - offset) - numCharsAllowed);
            if (cursorPos - offset < 0) offset--;

            float length = getCharLength();

            Vector2 selection = getFixedSelection();
            if (selection.X != -1 && selection.Y != -1 && (selection.X != selection.Y))
            {
                selection.X -= offset;
                selection.Y -= offset;
                if (selection.Y > numCharsAllowed) selection.Y = numCharsAllowed;
                if (selection.X < 0) selection.X = 0;
                selection.X *= length;
                selection.Y *= length;
                selection.X -= 2;
                selection.Y += 2;
                selection.X += tdI.BoundBox.Left;
                selection.Y += tdI.BoundBox.Left;
                DrawManager.Draw_Box(new Vector2(selection.X, tdI.BoundBox.Top + 2), new Vector2(selection.Y, tdI.BoundBox.Bottom - 4), Color.Blue * .5f, sb, 0f, 25);
            }

            if (active)
                tdI.Draw(sb);
            int cursorDiff = cursorPos - offset;
            float xToDrawDelim = cursorDiff * length;
            xToDrawDelim -= 2;
            if (mainDelim != null)
                sb.DrawString(tdI.font, mainDelim, tdI.Position + new Vector2(xToDrawDelim, 0), Color.White);
            //base.Draw();
        }


        internal void SetActive(bool active)
        {
            this.active = active;
            tdI.SetActive(active);
        }
    }
}
