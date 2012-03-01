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
        private Action lambdaOnClick = null;
        private Color textColor = Color.Black;

        public NinePatch patchNormal = YogUI.btn_normal;
        public NinePatch patchHover = YogUI.btn_hover;
        public NinePatch patchClick = YogUI.btn_hover;

        private int paddingWidth = 0;
        public int paddingHeight = 0;

        public override Rectangle BoundBox
        {
            get
            {
                NinePatch patch = base.mouseOver ? patchHover : patchNormal;
                return new Rectangle(
                   (td.BoundBox.Left - (patch.leftWidth / 2)) - (paddingWidth / 2),
                    (td.BoundBox.Top - patch.topHeight) - (paddingHeight / 2),
                    td.BoundBox.Width + patch.rightWidth + (paddingWidth / 2),
                    td.BoundBox.Height + patch.bottomHeight + (paddingHeight / 2));
            }
        }

        public Button(Vector2 Position, string text, SpriteFont font, Action lambdaOnClick = null)
        {
            this.Position = Position;
            base.UIC_Initialize();
            this.lambdaOnClick = lambdaOnClick;
            td = new TextDrawer(font, text, Position, textColor, TextAlign.Center);
            patchNormal = YogUI.btn_normal;
            patchHover = YogUI.btn_hover;
            patchClick = YogUI.btn_hover;
        }

        public override void Draw(SpriteBatch sb)
        {
            td.Position = Position;
            if (!active) return;
            NinePatch patch = base.mouseOver ? patchHover : patchNormal;
            Vector2 center = ConversionManager.PToV(BoundBox.Center);
            patch.Draw(sb, center - patch.getCenter(td.BoundBox.Width + paddingWidth, td.BoundBox.Height), td.BoundBox.Width + paddingWidth, td.BoundBox.Height + paddingHeight);
            td.Draw(sb);
            //YogUILibrary.Managers.DrawManager.Draw_Circle(Position, 5f, Color.Red, Color.Black, sb);
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
