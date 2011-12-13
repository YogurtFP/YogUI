using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YogUI.Code.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace YogUI.Code.UIComponents
{
    public class HorizontalScrollBar : UIComponent
    {
        private float maxValue = 0;
        private float curValue = 0;
        private float minValue = 0;
        public const float height = 10;
        private float _width
        {
            get;
            set;
        }
        private float width
        {
            get
            {
                return (bottomRight.X - topLeft.X);
            }
            set
            {
                _width = (bottomRight.X - topLeft.X);
            }
        }
        private Vector2 topLeft;
        private Vector2 bottomRight;
        private bool selected = false;
        private bool selectedOutside = false;
        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)topLeft.X, (int)topLeft.Y + (int)(height / 2), (int)width, ((int)bottomRight.Y - (int)topLeft.Y));
            }
        }
        public Rectangle BoundBoxPart
        {
            get
            {
                float percent = (float)(curValue / maxValue);
                float dist = bottomRight.X - topLeft.X;
                float width = (minValue / maxValue) * dist;
                float x = bottomRight.X - (dist * percent);
                return new Rectangle((int)x, (int)topLeft.Y + ((int)height/2), (int)width, (int)height);
            }
        }

        public HorizontalScrollBar(Vector2 topLeft, float width)
        {
            this.topLeft = topLeft;
            this.bottomRight = new Vector2(topLeft.X + width, topLeft.Y + height);
            base.UIC_Initialize();
            InputManager.BindMouse(() =>
            {
                if (active)
                {
                    Point m = InputManager.GetMousePos();
                    if ((BoundBox.Contains(m) || selected) && !selectedOutside)
                    {
                        float dist = ((m.X - (BoundBoxPart.Right - BoundBoxPart.Left) / 2) - BoundBox.Left);
                        dist = width - dist;
                        float percent = dist / width;
                        curValue = maxValue * percent;
                        if (curValue < minValue)
                            curValue = minValue;
                        if (curValue > maxValue)
                            curValue = maxValue;
                        selected = true;
                    }
                    else
                    {
                        selectedOutside = true;
                    }
                }
            }, MouseButton.Left, true, true);

            InputManager.BindMouse(() =>
            {
                selectedOutside = false;
                selected = false;
            }, MouseButton.Left, false, false);
        }

        public override void Update(GameTime time)
        {
        }

        public override void Draw(SpriteBatch sb)
        {
            float YM = topLeft.Y + (bottomRight.Y - topLeft.Y);
            Vector2 BBPC = ConversionManager.PToV(BoundBoxPart.Center);
            Vector2 BBC = ConversionManager.PToV(BoundBox.Center);

            DrawManager.Draw_Outline(BBPC, BoundBoxPart.Width, BoundBoxPart.Height, Color.Black, sb, 200);
            DrawManager.Draw_Line(new Vector2(topLeft.X, YM), new Vector2(bottomRight.X, YM), Color.White, sb, 150);
            DrawManager.Draw_Box(BBPC, BoundBoxPart.Width, BoundBoxPart.Height, Color.Black, sb, 0, 150);
            //base.Draw();
        }

        public void SetWidth(float w)
        {
            this.width = w;
        }

        public void SetMax(float m)
        {
            float oldMax = maxValue;
            maxValue = (m >= minValue) ? m : minValue;
            float adjust = oldMax - maxValue;
            curValue -= adjust;
        }

        public void SetMin(float m)
        {
            minValue = (m <= maxValue) ? m : maxValue;
        }

        public void SetValue(float m)
        {
            curValue = m;
        }

        public float GetMax()
        {
            return maxValue;
        }

        public float GetMin()
        {
            return minValue;
        }

        public int GetValue()
        {
            return (int)Math.Round(maxValue - curValue) + 1;
        }

        public void setPosition(Vector2 pos)
        {
            this.topLeft = pos;
            this.bottomRight = new Vector2(pos.X + width, pos.Y + height);
        }
    }
}
