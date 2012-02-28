using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YogUILibrary.Managers;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Text.RegularExpressions;
using YogUILibrary.Structs;
namespace YogUILibrary.UIComponents
{
    public class FilterTextField : UIComponent
    {
        private TextField textField;

        private Regex pattern = new Regex(".*?");

        public NinePatch patchNormal;
        public NinePatch patchSelectedRight;
        public NinePatch patchSelectedWrong;

        public string stringPattern
        {
            get
            {
                return pattern.ToString();
            }
            set
            {
                pattern = new Regex(value);
            }
        }

        public FilterTextField(Vector2 position, string pattern, float width, float height, Color textColor, SpriteFont font, Action<string> onTextEnter, Action<string> onTextChanged = null)
        {
            patchNormal = YogUI.textField_normal;
            patchSelectedRight = YogUI.textField_selected_right;
            patchSelectedWrong = YogUI.textField_selected_wrong;
            stringPattern = pattern;
            textField = new TextField(position, width, height, textColor, font, onTextEnter, (string text) =>
            {
                if (onTextChanged != null) onTextChanged(text);
                revalidate();
            });

            revalidate();
        }

        public override void Update(GameTime theTime)
        {
            textField.Update(theTime);
        }

        public override void Draw(SpriteBatch sb)
        {
            textField.Draw(sb);
        }

        private void revalidate()
        {
            if (pattern == null)
                return;

            String text = GetText();
            if (isValid())
            {
                textField.patchSelected = patchSelectedRight;
            }
            else
                textField.patchSelected = patchSelectedWrong;
        }

        public bool isValid()
        {
            return pattern.IsMatch(textField.GetText());
        }

        public void SetText(String text)
        {
            textField.SetText(text);
            revalidate();
        }

        public String GetText()
        {
            return textField.GetText();
        }
    }
}
