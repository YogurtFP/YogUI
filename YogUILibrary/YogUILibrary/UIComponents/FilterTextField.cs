using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YogUILibrary.Managers;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Text.RegularExpressions;
namespace YogUILibrary.UIComponents
{
    public class FilterTextField : UIComponent
    {
        private TextField textField;

        private Color successColor = Color.Green;
        private Color failColor = Color.Red;

        private Color curBorderColor = Color.Black;

        private Regex pattern = new Regex(".*?");

        public FilterTextField(Vector2 position, string pattern, float width, float height, Color textColor, Color backColor, Color successColor, Color failColor, SpriteFont font, Action<string> onTextEnter, Action<string> onTextChanged = null)
        {
            this.pattern = new Regex(pattern);
            this.successColor = successColor;
            this.failColor = failColor;
            textField = new TextField(position, width, height, textColor, backColor, failColor, font, onTextEnter, (string text) =>
            {
                if (onTextChanged != null) onTextChanged(text);
                revalidate();
            });

            revalidate();
        }

        public void Update(GameTime theTime)
        {
            textField.Update(theTime);
        }

        public void Draw(SpriteBatch sb)
        {
            textField.Draw(sb);
        }

        private void revalidate()
        {
            if (pattern == null)
            {
                curBorderColor = successColor;
                return;
            }

            String text = getText();
            curBorderColor = pattern.IsMatch(text) ? successColor : failColor;
            textField.setBorderColor(curBorderColor);
        }

        public bool isValid()
        {
            return curBorderColor == successColor;
        }

        public String getText()
        {
            return textField.GetText();
        }

        public Color getSuccessColor()
        {
            return successColor;
        }
        public Color getFailColor()
        {
            return failColor;
        }


        public void setPattern(string pattern)
        {
            this.pattern = new Regex(pattern);
        }

        public void setSuccessColor(Color success)
        {
            successColor = success;
        }
        public void setFailColor(Color fail)
        {
            failColor = fail;
        }
    }
}
