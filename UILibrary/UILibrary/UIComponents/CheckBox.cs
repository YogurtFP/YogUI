using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUI.Code.Managers;
namespace YogUI.Code.UIComponents
{
    public class CheckBox : UIComponent
    {
        private const int width = 10;
        private const int height = 10;
        private bool state = false;
        private string label = "CheckBox";
        private Action onChanged = null;
        private Color backColor = Color.Black;
        private Color borderColor = Color.LightGray;
        private Color defaultBorderColor = Color.LightGray;
        private Color checkColor = Color.Green;
        private Color labelColor = Color.White;
        private TextDrawer labelDrawer;
        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)Position.X - (width / 2), (int)Position.Y - (height / 2), width, height);
                //return base.BoundBox;
            }
        }

        public CheckBox(Vector2 position)
        {
            Position = position;
            Vector2 textPosition = new Vector2(position.X + 10, position.Y - (height));
            labelDrawer = new TextDrawer(AssetManager.GetFont("Console"), label, textPosition, labelColor);
            base.UIC_Initialize();
        }


        public override void Update(GameTime time)
        {
            labelDrawer.text = label;
            labelDrawer.color = labelColor;

            base.Update(time);
        }

        public override void Draw(SpriteBatch sb)
        {

            labelDrawer.Draw(sb);

            DrawManager.Draw_Box(Position, width, height, backColor, sb, 0f, 200);
            DrawManager.Draw_Outline(Position, width, height, borderColor, sb, 255);

            Vector2 checkLower = new Vector2(Position.X - 2, Position.Y - 2);
            Vector2 checkCenter = new Vector2(Position.X, Position.Y + (height / 2) - 1);
            Vector2 checkHigher = new Vector2(Position.X + (width / 2), Position.Y - (height / 2));

            if (state)
            {
                DrawManager.Draw_Line(checkLower, checkCenter, checkColor, sb);
                DrawManager.Draw_Line(checkHigher, checkCenter, checkColor, sb);
            }

           // base.Draw();
        }

        public override void OnMouseClick()
        {
            if (active)
            {
                state = !state;
                if (onChanged != null)
                {
                    onChanged();
                }
            }
            //base.OnMouseClick();
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
                borderColor = defaultBorderColor;
            }
            base.OnMouseOff();
        }


        public void SetOnChanged(Action a)
        {
            this.onChanged = a;
        }

        public void SetLabel(string label)
        {
            this.label = label;
        }

        public string GetLabel()
        {
            return label;
        }

        public void SetChecked(bool state)
        {
            this.state = state;
        }

        public bool GetChecked()
        {
            return state;
        }

        public void SetBackColor(Color c)
        {
            this.backColor = c;
        }

        public void SetBorderColor(Color c)
        {
            this.borderColor = c;
            this.defaultBorderColor = c;
        }

        public void SetCheckColor(Color c)
        {
            this.checkColor = c;
        }

        public void SetLabelColor(Color c)
        {
            labelColor = c;
        }

        public void SetPosition(Vector2 position)
        {
            this.Position = position;
        }

        public Vector2 GetPosition()
        {
            return Position;
        }

    }
}
