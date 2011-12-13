using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YogUI.Code.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace YogUI.Code.UIComponents
{
    public class VertScrollBar : UIComponent
    {
        private const float width = 10;
        private float maxValue = 0;
        private float curValue = 0;
        private float minValue = 0;
        private float _height
        {
            get;
            set;
        }
        private float height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = (bottomRight.Y - topLeft.Y);
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
                return new Rectangle((int)topLeft.X + ((int)width / 2), (int)topLeft.Y, (int)width, ((int)bottomRight.Y - (int)topLeft.Y));
            }
        }
        public Rectangle BoundBoxPart
        {
            get
            {
                float percent = (float)(curValue / maxValue);
                float dist = bottomRight.Y - topLeft.Y;
                float height = (minValue / maxValue) * dist;
                float y = bottomRight.Y - (dist * percent);
                return new Rectangle((int)topLeft.X + ((int)width / 2), (int)y, (int)width, (int)height);
            }
        }

        public VertScrollBar(Vector2 topLeft, float height)
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
                        float dist = ((m.Y - (BoundBoxPart.Bottom - BoundBoxPart.Top) / 2) - BoundBox.Top);
                        dist = height - dist;
                        float percent = dist / height;
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
            float XM = topLeft.X + (bottomRight.X - topLeft.X);
            Vector2 BBPC = ConversionManager.PToV(BoundBoxPart.Center);
            Vector2 BBC = ConversionManager.PToV(BoundBox.Center);

            DrawManager.Draw_Outline(BBPC, BoundBoxPart.Width, BoundBoxPart.Height, Color.Black, sb, 200);
            DrawManager.Draw_Line(new Vector2(XM, topLeft.Y), new Vector2(XM, bottomRight.Y), Color.White, sb, 150);
            DrawManager.Draw_Box(BBPC, BoundBoxPart.Width, BoundBoxPart.Height, Color.Black, sb, 0, 150);
            //base.Draw();
        }

        public void SetHeight(float h)
        {
            this.height = h;
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

        private void computePosition()
        {

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
            return (int)Math.Round(curValue);
        }

        public void setPosition(Vector2 pos)
        {
            this.topLeft = pos;
            this.bottomRight = new Vector2(pos.X + width, pos.Y + height);
        }
    }
}
