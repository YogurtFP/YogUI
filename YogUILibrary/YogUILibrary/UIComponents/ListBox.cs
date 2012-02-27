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
    public class ListBox : UIComponent
    {
        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)width, (int)height);
                //return base.BoundBox;
            }
        }

        SpriteFont textFont;

        VertScrollBar vScroll;
        HorizontalScrollBar hScroll;


        private int vertOffset = 0;
        private int horizontalOffset = 0;

        List<string> objects = new List<string>();

        public List<string> dataSource
        {
            get
            {
                return objects;
            }
            set
            {
                objects = value;
                if (selectedIndex >= value.Count)
                    selectedIndex = -1;
            }
        }

        public int selectedIndex = -1;

        public bool VertScrollBar = true;
        public bool HorizontalScrollBar = true;
        public bool autoAdjust = true;

        public float width = 50;
        public float height = 250;

        public Action selectedIndexChanged = () => { };

        public ListBox(Vector2 position, float width, float height, SpriteFont font, Action selectedIndexChanged = null)
        {
            this.Position = position;
            this.height = height;
            this.width = width;
            this.textFont = font;
            vScroll = new VertScrollBar(position, height - 4);
            vScroll.SetHeight(height);
            hScroll = new HorizontalScrollBar(position, width);
            hScroll.SetWidth(width);
            if (selectedIndexChanged != null) this.selectedIndexChanged = selectedIndexChanged;
            base.UIC_Initialize();
        }

        public void computeSelected()
        {
            Point mousePos = InputManager.GetMousePos();
            if (BoundBox.Contains(mousePos))
            {
                if (mousePos.X - Position.X <= width)
                {
                    float off = mousePos.Y - Position.Y;
                    float which = off / 15;
                    which = (float)Math.Floor(which);
                    int oldSel = selectedIndex;
                    selectedIndex = (int)(which + vertOffset);
                    if (selectedIndex >= dataSource.Count) selectedIndex = -1;
                }
            }
            else
            {
                selectedIndex = -1;
            }
        }

        public override void OnMouseClick()
        {
            computeSelected();
            //base.OnMouseClick();
        }

        public int textOverflows()
        {
            int ret = 0;
            //Find the length of a single monospace character
            float length = textFont.MeasureString("a").X;
            //Now we can use this length to find out just HOW many characters we've gone over. Quite quite.
            int numCharsAllowed = (int)(width / length) - 1;
            for (int i = vertOffset; i < objects.Count; i++)
            {
                object o = objects[i];
                float oLength = textFont.MeasureString(o.ToString()).X;
                int numChars = (int)(oLength / length);
                if (numChars > numCharsAllowed)
                {
                    int numOver = numChars - numCharsAllowed;
                    ret = (numOver > ret) ? numOver : ret;
                }
            }
            return ret;
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            float perEntryHeight = 15;
            int maxCanHold = (int)(height / perEntryHeight);

            //Take the width divided by the width of a monospace character in the current font, minus 1 (for spacing)
            int maxCharsCanHold = (int)(width / textFont.MeasureString("a").X) - 1;

            Vector2 startBoxPos = Position + new Vector2(2, 2);
            Vector2 drawTextPos = startBoxPos + new Vector2(0, -2);
            Vector2 bottomRightBoxPos = new Vector2(startBoxPos.X + (width - 4), startBoxPos.Y + perEntryHeight);
            bool vertScrollBars = false;
            bool horiScrollBars = false;

            if (objects.Count > maxCanHold && VertScrollBar)
                vertScrollBars = true;

            int textOverflow = textOverflows();

            if (textOverflow > 0 && HorizontalScrollBar)
                horiScrollBars = true;

            DrawManager.Draw_Box(Position + new Vector2(width / 2, height / 2), width, height, Color.Black, sb, 0, 200);
            DrawManager.Draw_Outline(Position + new Vector2(width / 2, height / 2), width, height, Color.Black, sb);
            if (vertScrollBars)
            {
                Vector2 spos = new Vector2(BoundBox.Right - 3, Position.Y + 2);
                vScroll.setPosition(spos);
                vScroll.SetMax(objects.Count);
                vScroll.SetMin(maxCanHold);
                vScroll.Draw(sb);
                vertOffset = objects.Count - vScroll.GetValue();
            }

            if (horiScrollBars)
            {
                Vector2 hSPos = new Vector2(BoundBox.Left, BoundBox.Bottom + 3);
                hScroll.setPosition(hSPos);
                hScroll.SetMax(textOverflow + 1);
                hScroll.SetMin(1);
                hScroll.Draw(sb);
                horizontalOffset = hScroll.GetValue() - 1;
            }
            else
                horizontalOffset = 0;

            for (int i = 0; i < maxCanHold && i + vertOffset < objects.Count; i++)
            {
                string o2 = objects[i + vertOffset];
                string o = "";
                for (int a = horizontalOffset; a < o2.Length && a < maxCharsCanHold + horizontalOffset; a++)
                {
                    o += o2[a];
                }
                Color textColor = Color.White;
                Color backColor = Color.Black;
                Color selectedColor = Color.Brown;

                byte alpha = 200;
                if (i % 2 == 0)
                    alpha = 255;
                if (i + vertOffset == selectedIndex)
                    backColor = selectedColor;

                DrawManager.Draw_Box(startBoxPos, bottomRightBoxPos, backColor, sb, 0f, alpha);
                DrawManager.Draw_Outline(startBoxPos, bottomRightBoxPos, Color.White, sb);

                sb.DrawString(textFont, o, drawTextPos, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0);

                startBoxPos.Y += perEntryHeight;
                drawTextPos.Y += perEntryHeight;
                bottomRightBoxPos.Y += perEntryHeight;
            }
            //base.Draw(sb);
        }
        int oldSel = 1000;
        public override void Update(GameTime time)
        {
            if (VertScrollBar)
                vScroll.Update(time);
            if (autoAdjust)
            {
                float maxWidth = 0;
                foreach (object o in objects)
                {
                    string r = o.ToString();
                    Vector2 size = textFont.MeasureString(r);
                    float w = size.X;
                    if (w > maxWidth)
                        maxWidth = w;
                }
                maxWidth += 5;
                if (maxWidth > 5)
                {

                }
            }
            if (oldSel != selectedIndex)
                selectedIndexChanged();
            oldSel = selectedIndex;
            base.Update(time);
        }
    }
}
