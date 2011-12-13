using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUI.Code.Structs;
using YogUI.Code.Managers;
namespace YogUI.Code.UIComponents
{
    public class DropDownList : UIComponent
    {
        public List<DropDownItem> items = new List<DropDownItem>();
        public int selectedItem = -1;
        private int width = 0;
        private int height = 0;
        private int itemHeight = 20;
        private SpriteFont font;

        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, width, height);
            }
        }

        public DropDownList(Vector2 position)
        {
            InputManager.BindMouse(() => { if (active) { Hide(); } }, MouseButton.Right, true);
            Position = position;
            font = AssetManager.GetFont("Console");
            base.UIC_Initialize();
        }

        public override void OnMouseOff()
        {
            Hide();
            base.OnMouseOff();
        }

        public override void OnMouseClick()
        {
            CalculateSelected();
            DropDownItem d = items[selectedItem];
            if (d.onClick != null)
            {
                d.onClick();
            }
            Hide();
            base.OnMouseClick();
        }

        public override void Update(GameTime time)
        {
            base.Update(time);
        }

        public override void Draw(SpriteBatch sb)
        {
            CalculateSelected();
            Vector2 drawPos = new Vector2(Position.X + 2, Position.Y);
            Vector2 topLeftPos = Position;
            Vector2 bottomRightPos = new Vector2(Position.X + width, Position.Y + itemHeight);
            Vector2 center = ConversionManager.PToV(BoundBox.Center);
            int i = 0;
            foreach (DropDownItem d in items)
            {
                Color backColor = Color.Black;
                Color borderColor = Color.White;
                byte alpha = 200;
                if (i == selectedItem)
                    backColor = Color.Gray;
                else if (i % 2 == 0)
                    alpha = 255;
                DrawManager.Draw_Box(topLeftPos, bottomRightPos, backColor, sb, 0f, alpha);
                DrawManager.Draw_Outline(center, width, height, borderColor, sb);
                sb.DrawString(font, d.text, drawPos, Color.White);
                drawPos.Y += itemHeight;
                topLeftPos.Y += itemHeight;
                bottomRightPos.Y += itemHeight;
                i++;
            }
            //base.Draw();
        }

        public void Destroy()
        {
            items.Clear();
            font = null;
            base.active = false;
        }

        public void Hide()
        {
            active = false;
        }

        public void Show()
        {
            active = true;
        }

        public void AddItem(DropDownItem item)
        {
            items.Add(item);
            CalculateDimensions();
        }

        public void CalculateDimensions()
        {
            int width = 0;
            int height = 0;
            foreach (DropDownItem d in items)
            {
                Vector2 dim = font.MeasureString(d.text);
                if (dim.X > width)
                    width = (int)dim.X + 2;
                height += itemHeight;
            }
            this.width = width;
            this.height = height;
        }

        public void CalculateSelected()
        {
            Point mousePos = InputManager.GetMousePos();
            Vector2 topLeftPos = Position;
            int i = 0;
            foreach (DropDownItem d in items)
            {
                Rectangle r = new Rectangle((int)topLeftPos.X, (int)topLeftPos.Y, width, itemHeight);
                if (r.Contains(mousePos))
                {
                    selectedItem = i;
                    break;
                }
                topLeftPos.Y += itemHeight;
                i++;
            }
        }
    }
}
