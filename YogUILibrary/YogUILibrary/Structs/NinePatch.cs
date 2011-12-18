using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace YogUILibrary.Structs
{
    public struct NinePatch
    {
        public Texture2D topLeft;
        public Texture2D topMiddle;
        public Texture2D topRight;

        public Texture2D Left;
        public Texture2D Middle;
        public Texture2D Right;

        public Texture2D bottomLeft;
        public Texture2D bottomMiddle;
        public Texture2D bottomRight;

        public NinePatch(string a = "")
        {
            topLeft = null;
            topMiddle = null;
            topRight = null;

            Left = null;
            Middle = null;
            Right = null;

            
            bottomLeft = null;
            bottomMiddle = null;
            bottomRight = null;
        }
    }
}
