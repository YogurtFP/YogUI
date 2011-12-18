using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUILibrary.Code.Managers;
namespace YogUILibrary.Code.UIComponents
{
    public class TextField : UIComponent
    {
        TextInput input;
        Color textColor = Color.White, borderColor = Color.White, backgroundColor = Color.Black;
        Vector2 topLeft, bottomRight;
        Action<string> onTextEnter, onTextChanged;
        string oldInput = "";
        private bool dragging = false, hovering = false;
        private float width, height;
        private string defaultText = "";

        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)(topLeft.X), (int)(topLeft.Y), (int)(bottomRight.X - topLeft.X), (int)(bottomRight.Y - topLeft.Y));
            }
        }

        public TextField(Vector2 position, float width, float height, Color textColor, Color backColor, Color borderColor, SpriteFont font, Action<string> onTextEnter, Action<string> onTextChanged = null)
        {
            this.topLeft = position;
            this.bottomRight = new Vector2(topLeft.X + width, topLeft.Y + height);
            this.width = width;
            this.height = height;
            input = new TextInput(new Vector2(topLeft.X + 2, topLeft.Y), font, textColor, () => { TextEnter(); }, "", () => { TextChanged(); });
            this.textColor = textColor;
            this.backgroundColor = backColor;
            this.borderColor = borderColor;
            this.onTextEnter = onTextEnter;
            this.onTextChanged = onTextChanged;
            base.UIC_Initialize();
            input.numCharsAllowed = numCharsAllowed();

            InputManager.BindMouse(() =>
            {
                if (hovering)
                    input.selected = true;
                else
                    input.selected = false;

                float charLength = input.getCharLength();
                float xDist = InputManager.GetMousePos().X - input.BoundBox.Left;
                int pos = (int)MathHelper.Clamp(xDist / charLength, 0, input.input.Length - input.offset);
                pos += input.offset;
                input.cursorPos = pos;
                input.selectionStart = pos;
                input.selectionEnd = -1;
                if (hovering)
                    dragging = true;
            }, MouseButton.Left);

            InputManager.BindMouse(() => { dragging = false; }, MouseButton.Left, false);

            InputManager.BindMouse(() =>
            {
                if (dragging)
                {
                    float charLength = input.getCharLength();
                    float xDist = InputManager.GetMousePos().X - input.BoundBox.Left;
                    int pos = (int)MathHelper.Clamp(xDist / charLength, 0, input.input.Length - input.offset);
                    int negablePos = (int)(xDist / charLength);
                    negablePos += input.offset;
                    if (negablePos < 0)
                    {
                        input.offset += negablePos;
                        if (input.offset < 0) input.offset = 0;
                    }
                    pos += input.offset;
                    input.selectionEnd = pos;
                    input.cursorPos = pos;
                }
            }, MouseButton.Movement, true, true);

        }

        public void setDefaultText(string text)
        {
            defaultText = text;
        }

        public int numCharsAllowed()
        {
            float length = input.tdI.font.MeasureString(" ").X;
            return (int)(width / length) - 1;
        }

        public void SetPosition(Vector2 pos)
        {
            this.topLeft = pos;
            this.bottomRight = new Vector2(topLeft.X + width, topLeft.Y + height);
            input.SetPosition(new Vector2(topLeft.X + 2, topLeft.Y));
        }

        public void SetWidth(float width2)
        {
            this.width = width2;
            this.bottomRight = new Vector2(topLeft.X + width, topLeft.Y + height);
        }

        public override void Update(GameTime time)
        {
            if (active)
            {
                Point mousePos = InputManager.GetMousePos();
                if (this.BoundBox.Contains(mousePos))
                {
                    hovering = true;
                }
                else
                {
                    hovering = false;
                }

                input.Update(time);
            }
            oldInput = input.input;
            base.Update(time);
        }

        public override void Draw(SpriteBatch sb)
        {
            if (active)
            {
                DrawManager.Draw_Box(topLeft, bottomRight, backgroundColor, sb, 0f, backgroundColor.A);
                DrawManager.Draw_Outline(topLeft, bottomRight, borderColor, sb, borderColor.A);
                bool defaulted = false;
                Color oldColor = input.tdI.color;
                if (!input.selected && input.input == "" && defaultText != "")
                {
                    input.input = defaultText;
                    defaulted = true;
                    input.tdI.color = Color.Gray;
                }
                input.Draw(sb);
                if (defaulted)
                {
                    input.input = "";
                    input.tdI.color = oldColor;
                }
            }

            base.Draw(sb);
        }

        private void TextEnter()
        {
            onTextEnter(GetText());
        }
        private void TextChanged()
        {
            if (onTextChanged != null)
                onTextChanged(GetText());
        }

        private bool textExtends()
        {
            return input.tdI.font.MeasureString(getOffsetString() + "|").X >= width;
        }

        private string getOffsetString()
        {
            string ret = "";
            for (int i = input.offset; i < input.input.Length; i++)
            {
                ret += input.input[i];
            }
            return ret;
        }

        public void SetText(string text)
        {
            string oldtext = input.input;
            input.input = text;
            input.cursorPos = text.Length;
        }

        public string GetText()
        {
            return input.input;
        }

        public void SetActive(bool active)
        {
            this.active = active;
            input.SetActive(active);
        }
        public void SetSelected(bool selected)
        {
            active = active;
            input.selected = selected;
        }
    }
}
