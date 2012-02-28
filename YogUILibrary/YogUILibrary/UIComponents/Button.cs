using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUILibrary.Managers;
using YogUILibrary.Structs;
namespace YogUILibrary.UIComponents
{
    public class Button : UIComponent
    {

        private TextDrawer td;
        private Vector2 position;
        private Action lambdaOnClick = null;
        private Color textColor = Color.Black;

        public bool testing = false;

        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle(
                    td.BoundBox.Left - 5,
                    td.BoundBox.Top - 10,
                    td.BoundBox.Width + 10,
                    td.BoundBox.Height + 10);
            }
        }

        public Button(Vector2 Position, string text, SpriteFont font, Action lambdaOnClick = null)
        {
            position = Position;
            base.UIC_Initialize();
            this.lambdaOnClick = lambdaOnClick;
            td = new TextDrawer(font, text, Position, textColor, TextAlign.Center);
        }

        public override void Draw(SpriteBatch sb)
        {
            if (testing)
            {

            }
            else
            {
                NinePatch patch = base.mouseOver ? YogUI.btn_hover : YogUI.btn_normal;
                Vector2 center = ConversionManager.PToV(BoundBox.Center);
                patch.Draw(sb, center - patch.getCenter(td.BoundBox.Width, td.BoundBox.Height), td.BoundBox.Width, td.BoundBox.Height);
                td.Draw(sb);
                //base.Draw();
            }
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

            base.OnMouseOver();
        }

        public override void OnMouseOff()
        {
            base.OnMouseOff();
        }

        public void SetText(string text)
        {
            td.text = text;
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
