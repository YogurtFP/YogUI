using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using YogUILibrary.Managers;
namespace YogUILibrary.UIComponents
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

        public bool scaleToText = false;

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
                if (numCharsAllowed == -1) return input;
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
            string[] toBindUpper = "B D E F G H I J K L M N O P Q R S T U W Y Z ) ! @ # $ % ^ & * ( ? > < \" : } { _ + 0 1 2 3 4 5 6 7 8 9".Split(' ');
            string[] toBindLower = "b d e f g h i j k l m n o p q r s t u w y z 0 1 2 3 4 5 6 7 8 9 / . , ' ; ] [ - = 0 1 2 3 4 5 6 7 8 9".Split(' ');
            Keys[] toBind = { Keys.B, Keys.D, Keys.E, Keys.F, Keys.G, Keys.H, Keys.I, Keys.J, Keys.K, Keys.L, Keys.M, Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T, Keys.U, Keys.W, Keys.Y, Keys.Z
                            , Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.OemQuestion, Keys.OemPeriod, Keys.OemComma, Keys.OemQuotes,
                            Keys.OemSemicolon, Keys.OemCloseBrackets, Keys.OemOpenBrackets, Keys.OemMinus, Keys.OemPlus, Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9};

            for (int i = 0; i < toBindUpper.Length; i++)
            {
                String upper = toBindUpper[i];
                String lower = toBindLower[i];
                Keys bind = toBind[i];
                InputManager.BindKey(() => { string a = ShiftHeld() ? keyPressed(upper) : keyPressed(lower); }, bind);
                InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, bind, false, false);
            }

            InputManager.BindKey(() =>
            {
                if (!(active && selected)) return;
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
            InputManager.BindKey(() =>
            {
                if (!(active && selected)) return;
                if (ShiftHeld())
                {
                    keyPressed("C");
                }
                else
                {
                    if (InputManager.isKeyPressed(Keys.LeftControl) || InputManager.isKeyPressed(Keys.RightControl))
                    {
                        Copy();
                    }
                    else
                    {
                        keyPressed("c");
                    }
                }
            }, Keys.C);
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
                        Paste();
                    }
                    else
                    {
                        keyPressed("v");
                    }
                }
            }, Keys.V);
            InputManager.BindKey(() =>
            {
                if (!(active && selected)) return;
                if (ShiftHeld())
                {
                    keyPressed("X");
                }
                else
                {
                    if (InputManager.isKeyPressed(Keys.LeftControl) || InputManager.isKeyPressed(Keys.RightControl))
                    {
                        Cut();
                    }
                    else
                    {
                        keyPressed("x");
                    }
                }
            }, Keys.X);
            InputManager.BindKey(() => { keyPressed(" "); }, Keys.Space);
            InputManager.BindKey(() => { keyPressed("backspace"); }, Keys.Back, true);
            InputManager.BindKey(() => { if (active && selected) { if (lambdaTextEnter != null) lambdaTextEnter(); } }, Keys.Enter);
            InputManager.BindKey(() => { keyPressed("left"); }, Keys.Left, true);
            InputManager.BindKey(() => { keyPressed("right"); }, Keys.Right, true);


            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.A, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.C, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.V, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.X, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Space, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Back, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Left, false, false);
            InputManager.BindKey(() => { keyRepeatHeld = ""; keyRepeatWaitCount = 0; }, Keys.Right, false, false);
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
            if (selection.Y == -1) selection.Y = cursorPos;
            int placeToRemove = (int)selection.Y - 1;
            int amountToRemove = 1;
            if (selection.X >= 0 && selection.Y >= 0 && selection.X != selection.Y)
            {
                placeToRemove = (int)selection.X;
                amountToRemove = (int)(selection.Y - selection.X);
            }
            if (amountToRemove + placeToRemove > input.Length || placeToRemove < 0) return;
            input = (input.Length > 0) ? input.Remove(placeToRemove, amountToRemove) : "";
            cursorPos = (int)selection.Y - amountToRemove;
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
            if (cursorPos - offset > numCharsAllowed && numCharsAllowed != -1) offset += ((cursorPos - offset) - numCharsAllowed);
            if (cursorPos - offset < 0) offset--;

            float length = getCharLength();

            Vector2 selection = getFixedSelection();
            if (selection.X != -1 && selection.Y != -1 && (selection.X != selection.Y))
            {
                selection.X -= offset;
                selection.Y -= offset;
                if (selection.Y > numCharsAllowed && numCharsAllowed != -1) selection.Y = numCharsAllowed;
                if (selection.X < 0) selection.X = 0;
                selection.X *= length;
                selection.Y *= length;
                selection.X -= 2;
                selection.Y += 2;
                selection.X += tdI.BoundBox.Left;
                selection.Y += tdI.BoundBox.Left;
                DrawManager.Draw_Box(new Vector2(selection.X, tdI.BoundBox.Top + 2), new Vector2(selection.Y, tdI.BoundBox.Bottom - 4), Color.Blue * .5f, sb, 0f, 25);
            }

            tdI.Position = Position;
            if (active)
                tdI.Draw(sb);
            int cursorDiff = cursorPos - offset;
            float xToDrawDelim = cursorDiff * length;
            xToDrawDelim -= 2;
            if (mainDelim != null)
                sb.DrawString(tdI.font, mainDelim, tdI.Position + new Vector2(xToDrawDelim, 0), tdI.color);
            //base.Draw();
        }

        internal void Copy()
        {
            if (selectedText != "")
            {
                System.Windows.Forms.Clipboard.SetText(selectedText);
            }
        }
        internal void Paste()
        {
            if (System.Windows.Forms.Clipboard.ContainsText())
                keyPressed(System.Windows.Forms.Clipboard.GetText());
        }

        internal void Cut()
        {
            Copy();
            keyPressed("backspace");
        }


        internal void SetActive(bool active)
        {
            this.active = active;
            tdI.SetActive(active);
        }
    }
}
