using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using YogUILibrary.Managers;

namespace YogUILibrary.Structs
{
    public class NinePatch
    {
        public int leftMostPatch;
        public int rightMostPatch;
        public int topMostPatch;
        public int bottomMostPatch;

        public int leftWidth
        {
            get
            {
                return leftMostPatch - 1;
            }
        }
        public int rightWidth
        {
            get
            {
                if (texture != null)
                    return texture.Width - (rightMostPatch + 1);
                return 0;
            }
        }
        public int topHeight
        {
            get
            {
                return topMostPatch - 1;
            }
        }
        public int bottomHeight
        {
            get
            {
                if (texture != null)
                    return texture.Height - (bottomMostPatch + 1);
                return 0;
            }
        }

        private Texture2D texture;

        public NinePatch()
        {
            leftMostPatch = -1;
            rightMostPatch = -1;
            topMostPatch = -1;
            bottomMostPatch = -1;
            texture = null;
        }

        public void LoadFromTexture(Texture2D texture)
        {
            this.texture = texture;
            Microsoft.Xna.Framework.Color[] data = new Microsoft.Xna.Framework.Color[texture.Width * texture.Height];
            texture.GetData(data);
            for (int i = 0; i < texture.Width; i++)
            {
                Color curPixel = data[i];
                if (curPixel.A != 0)
                {
                    if (leftMostPatch == -1) leftMostPatch = i;
                }
                else if (curPixel.A == 0 && leftMostPatch != -1 && rightMostPatch == -1)
                {
                    rightMostPatch = i - 1;
                    break;
                }
            }
            for (int i = 0; i < data.Length; i += texture.Width)
            {
                Color curPixel = data[i];
                if (curPixel.A != 0)
                {
                    if (topMostPatch == -1) topMostPatch = i / texture.Width;
                }
                else if (curPixel.A == 0 && topMostPatch != -1 && bottomMostPatch == -1)
                {
                    bottomMostPatch = (i / texture.Width) - 1;
                    break;
                }
            }
        }

        public void Draw(SpriteBatch sb, Vector2 position, int contentWidth, int contentHeight)
        {
            Rectangle topLeft = new Rectangle(1, 1, leftMostPatch - 1, topMostPatch - 1);
            Rectangle topMiddle = new Rectangle(leftMostPatch, 1, (rightMostPatch - leftMostPatch), topMostPatch - 1);
            Rectangle topRight = new Rectangle(rightMostPatch + 1, 1, (texture.Width - 1) - rightMostPatch, topMostPatch - 1);

            Rectangle Left = new Rectangle(1, topMostPatch, leftMostPatch - 1, (bottomMostPatch - topMostPatch));
            Rectangle Middle = new Rectangle(leftMostPatch, topMostPatch, (rightMostPatch - leftMostPatch), (bottomMostPatch - topMostPatch));
            Rectangle Right = new Rectangle(rightMostPatch + 1, topMostPatch, (texture.Width - 1) - rightMostPatch, (bottomMostPatch - topMostPatch));

            Rectangle bottomLeft = new Rectangle(1, bottomMostPatch, leftMostPatch - 1, (texture.Height - 1) - bottomMostPatch);
            Rectangle bottomMiddle = new Rectangle(leftMostPatch, bottomMostPatch, (rightMostPatch - leftMostPatch), (texture.Height - 1) - bottomMostPatch);
            Rectangle bottomRight = new Rectangle(rightMostPatch + 1, bottomMostPatch, (texture.Width - 1) - rightMostPatch, (texture.Height - 1) - bottomMostPatch);

            int topMiddleWidth = topMiddle.Width;
            int leftMiddleHeight = Left.Height;
            float scaleMiddleByHorizontally = ((float)contentWidth / (float)topMiddleWidth);
            float scaleMiddleByVertically = ((float)contentHeight / (float)leftMiddleHeight);
           // if (scaleMiddleByVertically < 1) scaleMiddleByVertically = 1;
           // if (scaleMiddleByHorizontally < 1) scaleMiddleByHorizontally = 1;

            Vector2 drawTL = position;
            Vector2 drawT = drawTL + new Vector2(topLeft.Width, 0);
            Vector2 drawTR = drawT + new Vector2(topMiddle.Width * scaleMiddleByHorizontally, 0);

            Vector2 drawL = drawTL + new Vector2(0, topLeft.Height);
            Vector2 drawM = drawT + new Vector2(0, topMiddle.Height);
            Vector2 drawR = drawTR + new Vector2(0, topRight.Height);

            Vector2 drawBL = drawL + new Vector2(0, leftMiddleHeight * scaleMiddleByVertically);
            Vector2 drawBM = drawM + new Vector2(0, leftMiddleHeight * scaleMiddleByVertically);
            Vector2 drawBR = drawR + new Vector2(0, leftMiddleHeight * scaleMiddleByVertically);

            sb.Draw(texture, drawTL, topLeft, Color.White);
            sb.Draw(texture, drawT, topMiddle, Color.White, 0f, Vector2.Zero, new Vector2(scaleMiddleByHorizontally, 1), SpriteEffects.None, 0f);
            sb.Draw(texture, drawTR, topRight, Color.White);

            sb.Draw(texture, drawL, Left, Color.White, 0f, Vector2.Zero, new Vector2(1, scaleMiddleByVertically), SpriteEffects.None, 0f);
            sb.Draw(texture, drawM, Middle, Color.White, 0f, Vector2.Zero, new Vector2(scaleMiddleByHorizontally, scaleMiddleByVertically), SpriteEffects.None, 0f);
            sb.Draw(texture, drawR, Right, Color.White, 0f, Vector2.Zero, new Vector2(1, scaleMiddleByVertically), SpriteEffects.None, 0f);

            sb.Draw(texture, drawBL, bottomLeft, Color.White);
            sb.Draw(texture, drawBM, bottomMiddle, Color.White, 0f, Vector2.Zero, new Vector2(scaleMiddleByHorizontally, 1), SpriteEffects.None, 0f);
            sb.Draw(texture, drawBR, bottomRight, Color.White);
        }

        public Vector2 getCenter(int contentWidth, int contentHeight)
        {
            Rectangle topLeft = new Rectangle(1, 1, leftMostPatch - 1, topMostPatch - 1);
            Rectangle topRight = new Rectangle(rightMostPatch + 1, 1, (texture.Width - 1) - rightMostPatch, topMostPatch - 1);
            Rectangle topMiddle = new Rectangle(leftMostPatch, 1, (rightMostPatch - leftMostPatch), topMostPatch - 1);
            Rectangle Left = new Rectangle(1, topMostPatch, leftMostPatch - 1, (bottomMostPatch - topMostPatch));
            Rectangle Middle = new Rectangle(leftMostPatch, topMostPatch, (rightMostPatch - leftMostPatch), (bottomMostPatch - topMostPatch));


            int topMiddleWidth = topMiddle.Width;
            int leftMiddleHeight = Left.Height;
            float scaleMiddleByHorizontally = ((float)contentWidth / (float)topMiddleWidth);
            float scaleMiddleByVertically = ((float)contentHeight / (float)leftMiddleHeight);
            if (scaleMiddleByVertically < 1) scaleMiddleByVertically = 1;
            if (scaleMiddleByHorizontally < 1) scaleMiddleByHorizontally = 1;

            Vector2 drawMMiddle = new Vector2(topLeft.Width, topLeft.Height);
            drawMMiddle += new Vector2(topMiddleWidth * (scaleMiddleByHorizontally / 2), leftMiddleHeight * (scaleMiddleByVertically / 2));
            return drawMMiddle;
        }
    }
}
