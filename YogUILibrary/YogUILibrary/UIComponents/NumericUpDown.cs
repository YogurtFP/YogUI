using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using YogUILibrary.Managers;
using YogUILibrary;
using YogUILibrary.Structs;
namespace YogUILibrary.UIComponents
{
    public class NumericUpDown : UIComponent
    {
        public TextField numericTextField;
        public Button numericUp;
        public Button numericDown;

        private int lastGoodInt = 0;

        public int value
        {
            get
            {
                if (numericTextField.textValid)
                {
                    return Convert.ToInt32(numericTextField.GetText());
                }
                else
                {
                    return lastGoodInt;
                }
            }
            set
            {
                numericTextField.SetText(value.ToString());
            }
        }

        private int _minimumValue = 0;
        public int minimumValue{
            get{
                return _minimumValue;
            }
            set{
                if(value <= maxValue) _minimumValue = value;
                else _minimumValue = maxValue;
            }
        }

        private int _maxValue = 0;
        public int maxValue{
            get{
                return _maxValue;
            }
            set{
                if(value >= minimumValue) _maxValue = value;
                else _maxValue = minimumValue;
            }
        }

        public override Rectangle BoundBox
        {
            get
            {
                int width = numericUp.BoundBox.Right - numericTextField.BoundBox.Left;
                int height = numericDown.BoundBox.Bottom - numericTextField.BoundBox.Top;
                return new Rectangle((int)Position.X, (int)Position.Y, width, height);
            }
        }

        public NumericUpDown(Vector2 position, SpriteFont textFieldFont, SpriteFont buttonsFont)
        {
            numericTextField = new TextField(position, 20, 20, Color.Black, textFieldFont, (string s) => { });
            numericTextField.stringPattern = "^\\d+?$";
            numericTextField.patchSelectedRight = numericTextField.patchNormal;
            numericTextField.scaleToText = true;

            numericUp = new Button(Vector2.Zero, "+", buttonsFont);
            numericUp.Position = new Vector2(numericTextField.BoundBox.Right + 12, numericTextField.BoundBox.Top + (numericUp.BoundBox.Height / 2));

            numericDown = new Button(Vector2.Zero, "-", buttonsFont);
            numericDown.Position = new Vector2(numericTextField.BoundBox.Left - (numericDown.BoundBox.Width / 2), numericTextField.BoundBox.Center.Y);

            numericDown.paddingHeight = -5;
            numericUp.paddingHeight = -5;

            numericTextField.height = numericUp.BoundBox.Height - numericTextField.patchNormal.bottomHeight - numericTextField.patchNormal.topHeight;
        }

        public override void Update(GameTime theTime)
        {
            numericTextField.Update(theTime);
            numericDown.Update(theTime);
            numericUp.Update(theTime);
            numericDown.Position = new Vector2(numericTextField.BoundBox.Left - (numericDown.BoundBox.Width / 2), numericTextField.BoundBox.Center.Y);
            numericTextField.height = numericDown.BoundBox.Height - numericTextField.patchNormal.bottomHeight - numericTextField.patchNormal.topHeight;
            numericUp.Position = new Vector2(numericTextField.BoundBox.Right + 12, numericTextField.BoundBox.Top + (numericUp.BoundBox.Height / 2));
            base.Update(theTime);
        }

        public override void Draw(SpriteBatch sb)
        {
            numericTextField.Draw(sb);
            numericDown.Draw(sb);
            numericUp.Draw(sb);
            
            //int diff = 
            base.Draw(sb);
        }

    }
}
