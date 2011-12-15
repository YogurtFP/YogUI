using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using YogUILibrary.Code.Managers;
namespace YogUILibrary.Code.UIComponents
{
    public class TextClickable : UIComponent
    {

        public Action onClick;
        public Color color;
        public Color cHover;
        public string text;
        public TextDrawer tdI;
        public bool enabled = true;

        public override Rectangle BoundBox
        {
            get
            {
                Vector2 size = tdI.font.MeasureString(tdI.text);
                return new Rectangle(
                    (int)tdI.Position.X,
                    (int)tdI.Position.Y,
                    (int)(size.X * tdI.scale),
                    (int)(size.Y * tdI.scale));
            }
        }

        public TextClickable(Vector2 position, string text, SpriteFont font, Color c, Color cHover, Action onClick)
        {
            tdI = new TextDrawer(font, text, position, c, TextAlign.Left);
            this.color = c;
            this.cHover = cHover;
            this.onClick = onClick;
            base.UIC_Initialize();
        }

        public override void Update(GameTime time)
        {
            tdI.Update(time);
            base.Update(time);
        }

        public override void Draw(SpriteBatch sb)
        {
            tdI.Draw(sb);
            //base.Draw();
        }

        public override void OnMouseClick()
        {
            base.OnMouseClick();
        }

        public override void OnMouseOver()
        {
            if (enabled)
            {
                tdI.color = cHover;
                //Main.SoundManager.PlaySound("shoot");
                base.OnMouseOver();
            }
        }
        public override void OnMouseOff()
        {
            if (enabled)
            {
                tdI.color = color;
                base.OnMouseOver();
            }
        }

    }
}
