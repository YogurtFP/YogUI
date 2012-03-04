using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUILibrary.Managers;
using YogUILibrary.Structs;
using System.Text.RegularExpressions;
namespace YogUILibrary.UIComponents
{
    public class TextField : UIComponent
    {
        TextInput input;
        Color textColor = Color.White;
        Action<string> onTextEnter, onTextChanged;
        private bool dragging = false, hovering = false;
        public float width, height;

        private string _placeHolderText = "";
        public string placeHolderText
        {
            get
            {
                return _placeHolderText;
            }
            set
            {
                if (value.Length > allowedWidth())
                    _placeHolderText = value.Remove(allowedWidth());
                else
                    _placeHolderText = value;
            }
        }

        DropDownList contextMenu;

        public NinePatch patchNormal;
        public NinePatch patchSelected;
        public NinePatch patchSelectedRight;
        public NinePatch patchSelectedWrong;

        private Regex pattern = null;


        public bool textValid = true;
        public bool scaleToText
        {
            get
            {
                return input.allowedWidth == -1;
            }
            set
            {
                input.allowedWidth = value ? -1 : allowedWidth();
            }
        }

        public string stringPattern
        {
            get
            {
                return pattern.ToString();
            }
            set
            {
                pattern = new Regex(value);
                revalidate();
            }
        }

        public override Rectangle BoundBox
        {
            get
            {
                NinePatch patch = input.selected ? patchSelected : patchNormal;
                return new Rectangle((int)(Position.X),
                    (int)(Position.Y),
                    (int)(patch.rightWidth + width),
                    (int)(patch.bottomHeight + height + patch.topHeight));
            }
        }

        public TextField(Vector2 position, float width, float height, Color textColor, SpriteFont font, Action<string> onTextEnter, Action<string> onTextChanged = null)
        {
            patchSelected = YogUI.textField_selected;
            patchSelectedRight = YogUI.textField_selected_right;
            patchSelectedWrong = YogUI.textField_selected_wrong;
            patchNormal = YogUI.textField_normal;
            this.Position = position;
            this.width = width;
            this.height = height;
            input = new TextInput(new Vector2(position.X + 2, position.Y), font, textColor, () => { TextEnter(); }, "", () => { TextChanged(); });
            this.textColor = textColor;
            this.onTextEnter = onTextEnter;
            this.onTextChanged = onTextChanged;
            contextMenu = new DropDownList(Vector2.Zero, font);
            contextMenu.AddItem(new DropDownItem("Copy", input.Copy));
            contextMenu.AddItem(new DropDownItem("Paste", input.Paste));
            contextMenu.AddItem(new DropDownItem("Cut", input.Cut));
            base.UIC_Initialize();
            input.allowedWidth = allowedWidth();

            InputManager.BindMouse(() =>
            {
                input.selected = hovering;
                if (!hovering) return;
                float xDist = InputManager.GetMousePos().X - input.BoundBox.Left;
                string offset = input.offsetText;
                int maxBelow = offset.Length;
                string cur = "";
                for (int i = 0; i < offset.Length; i++)
                {
                    cur += offset[i];
                    float xWidth = input.tdI.font.MeasureString(cur).X;
                    if (xWidth < xDist)
                    {
                        maxBelow = i + 1;
                    }
                    if (xDist < xWidth && i == 0)
                    {
                        maxBelow = 0;
                        break;
                    }
                    if (xWidth >= xDist)
                        break;
                }
                int pos = maxBelow;
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
                    float xDist = InputManager.GetMousePos().X - input.BoundBox.Left;
                    string offset = input.offsetText;
                    int maxBelow = offset.Length;
                    string cur = "";
                    for (int i = 0; i < offset.Length; i++)
                    {
                        cur += offset[i];
                        float xWidth = input.tdI.font.MeasureString(cur).X;
                        if (xWidth < xDist)
                        {
                            maxBelow = i + 1;
                        }
                        if (xDist < xWidth && i == 0)
                        {
                            maxBelow = 0;
                            break;
                        }
                        if(xWidth >= xDist)
                            break;
                    }
                    if (xDist < 0)
                    {
                        input.offset += -1;
                        if (input.offset < 0) input.offset = 0;
                    }
                    if (xDist > input.BoundBox.Width)
                    {
                        input.offset += 1;
                        if (input.offset > input.input.Length - offset.Length) input.offset = input.input.Length - offset.Length;
                    }
                    int pos = maxBelow;
                    pos += input.offset;
                    input.selectionEnd = pos;
                    input.cursorPos = pos;
                }
            }, MouseButton.Movement, true, true);

            InputManager.BindMouse(() =>
                {
                    input.selected = hovering;
                    if (hovering)
                    {
                        contextMenu.Position = InputManager.GetMousePosV() - new Vector2(3);
                        contextMenu.Show();
                    }
                }, MouseButton.Right);

        }

        private int allowedWidth()
        {
            return (int)width;
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

        private void revalidate()
        {
            if (pattern == null)
            {
                textValid = true;
                return;
            }
            textValid = pattern.IsMatch(input.input);
        }

        private bool isFilterText()
        {
            return pattern != null;
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
                contextMenu.Update(time);
            }
            base.Update(time);
        }

        public override void Draw(SpriteBatch sb)
        {
            if (active)
            {
                bool defaulted = false;
                Color oldColor = input.tdI.color;
                if (!input.selected && input.input == "" && placeHolderText != "")
                {
                    input.tdI.text = placeHolderText;
                    defaulted = true;
                    input.tdI.color = Color.Gray;
                }

                NinePatch patch = patchNormal;
                if (input.selected)
                {
                    if (isFilterText())
                    {
                        patch = textValid ? patchSelectedRight : patchSelectedWrong;
                    }
                    else
                    {
                        patch = patchSelected;
                    }
                }

                int patchWidth = scaleToText && input.BoundBox.Width >= (int)width ? input.BoundBox.Width : (int)width;

                patch.Draw(sb, Position, (int)patchWidth, (int)height);
                input.Position = Position + new Vector2(patch.leftWidth, patch.topHeight);
                input.Draw(sb);
                if (defaulted)
                {
                    input.tdI.text = "";
                    input.tdI.color = oldColor;
                }

                contextMenu.Draw(sb);
            }
            base.Draw(sb);
        }

        private void TextEnter()
        {
            revalidate();
            onTextEnter(GetText());
        }

        private void TextChanged()
        {
            revalidate();
            if (onTextChanged != null)
                onTextChanged(GetText());
        }

        public void SetText(string text)
        {
            string oldtext = input.input;
            input.input = text;
            input.cursorPos = text.Length;
            revalidate();
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
