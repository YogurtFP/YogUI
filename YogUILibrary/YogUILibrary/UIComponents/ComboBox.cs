using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YogUILibrary.Code.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace YogUILibrary.Code.UIComponents
{
    public class ComboBox : UIComponent
    {
        DropDownList drop;
        TextDrawer label;
        Color backColor = Color.Black;
        public int selectedIndex = -1;
        float width = 40;
        float height = 15;

        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)Position.X - (int)(width / 2), (int)Position.Y - (int)(height / 2), (int)width + 15, (int)height);
            }
        }
        public ComboBox(Vector2 position, SpriteFont font, params string[] items)
        {
            Position = position;
            drop = new DropDownList(position + new Vector2((-width - 15), height / 2), font);
            label = new TextDrawer(font, "", position, Color.White, TextAlign.Center);
            drop.Hide();
            foreach (string item in items)
            {
                drop.AddItem(new Structs.DropDownItem(item, () => { updateSelected(); }));
            }
            if (items.Length > 0)
                selectedIndex = 0;

            base.UIC_Initialize();
        }

        public override void OnMouseClick()
        {
            if (!drop.active)
                drop.Show();
            else
                drop.Hide();
            base.OnMouseClick();
        }

        public override void OnMouseOver()
        {
            backColor = Color.Gray;
            base.OnMouseOver();
        }

        public override void OnMouseOff()
        {
            backColor = Color.Black;
            if (drop.active && !drop.BoundBox.Contains(InputManager.GetMousePos()))
                drop.Hide();
            base.OnMouseOff();
        }

        public override void Draw(SpriteBatch sb)
        {
            float extra = 15;
            width = drop.BoundBox.Width;
            drop.Position = new Vector2(Position.X - (width / 2), Position.Y + 5);
            string toDraw = "";
            Vector2 ArrowStartPos;
            if (selectedIndex >= 0)
                toDraw = drop.items[selectedIndex].text;

            label.text = toDraw;

            ArrowStartPos = new Vector2(BoundBox.Right - 12, Position.Y - 3);

            DrawManager.Draw_Box(Position + new Vector2(extra / 2, 0), width + extra, height, backColor, sb, 0f, 255);
            DrawManager.Draw_Outline(Position + new Vector2(extra / 2, 0), width + extra, height, Color.Black, sb);
            if (!drop.active)
            {
                DrawManager.Draw_Line(ArrowStartPos, ArrowStartPos + new Vector2(4, 6), Color.White, sb);
                DrawManager.Draw_Line(ArrowStartPos + new Vector2(4, 6), ArrowStartPos + new Vector2(8, 0), Color.White, sb);
            }
            else
            {
                DrawManager.Draw_Line(ArrowStartPos + new Vector2(0, 6), ArrowStartPos + new Vector2(4, 0), Color.White, sb);
                DrawManager.Draw_Line(ArrowStartPos + new Vector2(4, 0), ArrowStartPos + new Vector2(8, 6), Color.White, sb);
                drop.Draw(sb);
            }

            label.Draw(sb);

        }

        private void updateSelected()
        {
            selectedIndex = drop.selectedItem;
        }
    }
}
