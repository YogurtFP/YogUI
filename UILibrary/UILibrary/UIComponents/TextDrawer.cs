using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using YogUI.Code.Managers;
namespace YogUI.Code.UIComponents
{
    public class TextDrawer : UIComponent
    {

        public SpriteFont font;
        public string text = "";
        public Color color = new Color();
        public TextAlign textAlign;
        public float scale = 1f;

        public override Rectangle BoundBox
        {
            get
            {
                Vector2 size = font.MeasureString(text);
                Rectangle ret = new Rectangle();
                switch (textAlign)
                {
                    case TextAlign.Left:
                        ret = new Rectangle(
                            (int)Position.X,
                            (int)Position.Y,
                            (int)(size.X * scale),
                            (int)(size.Y * scale));
                        break;

                    case TextAlign.Center:
                        ret = new Rectangle(
                            (int)Position.X - (int)(size.X / 2),
                            (int)Position.Y - (int)(size.Y / 4),
                            (int)(size.X * scale),
                            (int)(size.Y * scale)
                            );
                        break;
                }
                return ret;
                //return base.BoundBox;
            }
        }

        public Vector2 origin
        {
            get
            {
                switch (textAlign)
                {
                    case TextAlign.Center:
                        Vector2 size = font.MeasureString(text);
                        return new Vector2(size.X / 2, size.Y / 2);
                    case TextAlign.Left:
                        return Vector2.Zero;
                    case TextAlign.Right:
                        return font.MeasureString(text);
                    default:
                        return Vector2.Zero;
                }

            }
        }

        public TextDrawer(SpriteFont font, string text, Vector2 position, Color color, TextAlign align = TextAlign.Left)
        {
            this.font = font;
            this.text = text;
            this.Position = position;
            this.color = color;
            this.textAlign = align;
        }

        public override void Draw(SpriteBatch sb)
        {
            if (active)
                sb.DrawString(font, text, Position, color, 0f, origin, scale, SpriteEffects.None, 0);
        }

        internal void SetActive(bool active)
        {
            this.active = active;
        }
    }
}
