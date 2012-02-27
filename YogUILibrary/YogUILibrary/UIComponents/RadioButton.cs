using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using YogUILibrary.Managers;
using YogUILibrary.Structs;
using Microsoft.Xna.Framework.Graphics;

namespace YogUILibrary.UIComponents
{
    public class RadioButton : UIComponent
    {
        Color selectedColor = Color.Green;
        Color backColorNoHover = Color.Gray;
        Color backColorHover = Color.Wheat;
        Color backColor = Color.Gray;
        Color borderColor = Color.Gray;

        public bool selected = false;

        public TextDrawer label;
        public string labelText;

        private float radius = 5;

        public RadioButtonGroup group = new RadioButtonGroup();

        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)Position.X - (int)radius, (int)Position.Y - (int)radius, (int)(radius * 2), (int)radius * 2);
                //return base.BoundBox;
            }
        }

        public RadioButton(Vector2 position, SpriteFont font, string text = "RadioButton")
        {
            labelText = text;
            label = new TextDrawer(font, labelText, position + new Vector2(radius + 5,  -radius * 1.9f), Color.White);
            Position = position;
            base.UIC_Initialize();
        }

        public override void OnMouseOver()
        {
            backColor = backColorHover;
            base.OnMouseOver();
        }

        public override void OnMouseOff()
        {
            backColor = backColorNoHover;
            //base.OnMouseOff();
        }

        public override void OnMouseClick()
        {
            if (!selected)
            {
                group.buttonPressed(this);
                selected = true;
            }
            base.OnMouseClick();
        }

        public override void Update(GameTime time)
        {
            label.Update(time);
            base.Update(time);
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            label.Draw(sb);
            DrawManager.Draw_Circle(Position, radius, backColor, borderColor, sb);
            if (selected)
                DrawManager.Draw_Circle(Position, radius / 1.5f, selectedColor, selectedColor, sb, 255, 1);
            //base.Draw(sb);
        }
    }
}
