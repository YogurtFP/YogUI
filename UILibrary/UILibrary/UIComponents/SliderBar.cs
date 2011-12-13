using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUI.Code.Managers;
namespace YogUI.Code.UIComponents
{
    public class SliderBar : UIComponent
    {
        ProgressBar progressBar;
        TextDrawer progressText;
        float width;
        float height;
        int min;
        int num;
        int max;
        bool selected = false;
        bool selectedOutside = false;
        public SliderBar(Vector2 position, float width, float height, int min, int max, float progress = 0.0f)
        {
            this.width = width;
            this.height = height;
            this.min = min;
            this.max = max;
            progressBar = new ProgressBar(position, width, height, progress);
            Vector2 center = new Vector2(position.X + (width / 2), position.Y + (height / 2));
            progressText = new TextDrawer(AssetManager.GetFont("Console"), "", center, Color.White, TextAlign.Center);
            InputManager.BindMouse(() => {
                Point mousePoint = InputManager.GetMousePos();
                Vector2 mouseVector = new Vector2(mousePoint.X, mousePoint.Y);
                if ((progressBar.BoundBox.Contains(mousePoint) || selected) && !selectedOutside)
                {
                    int dist = (int)(mousePoint.X - progressBar.BoundBox.Left);
                    float p = (dist / progressBar.width) * 100;
                    p = (p > 0) ? (p < 100) ? p : 100 : 0;
                    progressBar.setProgress(p);
                    selected = true;
                }
                else
                {
                    selectedOutside = true;
                }
            }, MouseButton.Left, true, true);
            InputManager.BindMouse(() =>
            {
                selected = false;
                selectedOutside = false;
            }, MouseButton.Left, false);
        }

        public override void Draw(SpriteBatch sb)
        {
            progressBar.Draw(sb);
            progressText.Draw(sb);
            //base.Draw();
        }

        public override void Update(GameTime time)
        {
            num = (int)(max * (progressBar.getProgress() / 100));
            progressText.text = num.ToString();
            base.Update(time);
        }

        public void setBackgroundColor(Color c)
        {
            progressBar.setBackgroundColor(c);
        }

        public void setBorderColor(Color c)
        {
            progressBar.setBorderColor(c);
        }

        public int getNumber()
        {
            return num;
        }

        public void setNumber(int number)
        {
            num = number;
        }

        public void setTextColor(Color c)
        {
            progressText.color = c;
        }

    }
}
