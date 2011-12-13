using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUI.Code.Managers;
namespace YogUI.Code.UIComponents
{
    public class Button : UIComponent
    {

        private TextDrawer td;
        private Vector2 position;
        private Action lambdaOnClick = null;
        private Color backColor = Color.Black;
        private Color borderColor = Color.Gray;
        private Color textColor = Color.Black;
        private byte backAlpha = 200;
        private byte borderAlpha = 255;
        private float width = 5;
        private float height = 5f;

        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle(
                    td.BoundBox.Left - (int)(width / 2),
                    td.BoundBox.Top - (int)(height/2) - 4,
                    td.BoundBox.Width + (int)width,
                    td.BoundBox.Height + (int)height);
            }
        }

        public Button(Vector2 Position, string text, Action lambdaOnClick = null)
        {
            position = Position;
            base.UIC_Initialize();
            this.lambdaOnClick = lambdaOnClick;
            td = new TextDrawer(AssetManager.GetFont("Console"), text, Position, textColor, TextAlign.Center);
        }

        public override void Draw(SpriteBatch sb)
        {
            Vector2 center = ConversionManager.PToV(BoundBox.Center);
            DrawManager.Draw_Box(center, BoundBox.Width, BoundBox.Height, backColor, sb, 0f, backAlpha);
            DrawManager.Draw_Outline(center, BoundBox.Width, BoundBox.Height, borderColor, sb, borderAlpha);
            td.Draw(sb);
            //base.Draw();
        }

        public override void OnMouseClick()
        {
            if (active)
            {
                if (lambdaOnClick != null)
                    lambdaOnClick();
            }
            base.OnMouseClick();
        }

        public override void OnMouseOver()
        {
            if (active)
            {
                borderColor = Color.White;
            }
            base.OnMouseOver();
        }

        public override void OnMouseOff()
        {
            if (active)
            {
                borderColor = Color.Gray;
            }
            base.OnMouseOff();
        }

        public void SetBackgroundAlpha(byte alpha)
        {
            backAlpha = alpha;
        }

        public void SetBackgroundColor(Color c)
        {
            backColor = c;
        }

        public void SetBorderAlpha(byte alpha)
        {
            borderAlpha = alpha;
        }

        public void SetBorderColor(Color c)
        {
            borderColor = c;
        }

        public void SetWidth(float w)
        {
            width = w;
        }

        public void SetHeight(float h)
        {
            height = h;
        }

        public void SetWidthTotal(float w)
        {
            width = w - td.BoundBox.Width;
        }

        public void SetHeightTotal(float h)
        {
            height = h - td.BoundBox.Height;
        }

        public float GetWidth()
        {
            return width;
        }

        public float GetHeight()
        {
            return height;
        }

        public float GetTotalWidth()
        {
            return BoundBox.Width;
        }

        public float GetTotalHeight()
        {
            return BoundBox.Height;
        }

    }
}
