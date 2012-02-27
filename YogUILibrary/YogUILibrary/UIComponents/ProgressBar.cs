using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUILibrary.Managers;
namespace YogUILibrary.UIComponents
{
    public class ProgressBar : UIComponent
    {
        Vector2 position;
        public float width;
        public float height;
        private float progress;
        Vector2 tL;
        Vector2 bR;
        Color backgroundColor = Color.Green;
        Color unselectedColor = Color.Red;
        Color borderColor = Color.White;

        public override Rectangle BoundBox
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, (int)width, (int)height);
                //return base.BoundBox;
            }
        }

        public ProgressBar(Vector2 position, float width, float height, float progress = 0.0f)
        {
            this.position = position;
            this.width = width;
            this.height = height;
            this.progress = (progress <= 100) ? progress : 100;
            this.tL = position;
            this.bR = new Vector2(tL.X + width, tL.Y + height);
            base.UIC_Initialize();
        }

        public void setBackgroundColor(Color color)
        {
            this.backgroundColor = color;
        }

        public void setBorderColor(Color color)
        {
            this.borderColor = color;
        }

        public float getProgress()
        {
            return progress;
        }

        public void addProgress(float amount)
        {
            progress += amount;
            if (progress > 100)
                progress = 100;
            if (progress < 0)
                progress = 0;
        }
        public void setProgress(float progress)
        {
            this.progress = progress;
            if (progress > 100)
                progress = 100;
            if (progress < 0)
                progress = 0;
        }

        public override void Update(GameTime time)
        {
            base.Update(time);
        }

        public override void Draw(SpriteBatch sb)
        {
            if (progress > 100)
                progress = 100;
            if (progress < 0)
                progress = 0;
            Vector2 bRR = new Vector2(tL.X, bR.Y);
            bRR.X += (width * (progress / 100));
            Vector2 TLR = new Vector2(bRR.X, tL.Y);
            DrawManager.Draw_Box(tL, bRR, backgroundColor, sb);
            DrawManager.Draw_Box(TLR, bR, unselectedColor, sb);
            DrawManager.Draw_Outline(tL, bR, borderColor, sb);
            //base.Draw();
        }

    }
}
