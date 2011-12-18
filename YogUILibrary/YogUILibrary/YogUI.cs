using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using YogUILibrary.Code.Managers;
using YogUILibrary.Structs;
namespace YogUILibrary
{
    public class YogUI
    {
        public static ContentManager content;
        public static Texture2D white;
        public static Effect circleShader;
        public static InputManager inputManager;
        public static Game theGame;

        public static void YogUI_LoadContent(Game game)
        {
            content = new ResourceContentManager(game.Services, Resource1.ResourceManager);
            white = new Texture2D(game.GraphicsDevice, 1, 1);
            white.SetData<Color>(new Color[] { Color.White });
            circleShader = content.Load<Effect>("CircleShader");
            inputManager = new InputManager();
            theGame = game;
        }

        public static void YogUI_Update(GameTime time)
        {
            inputManager.Update(time);
        }
        /*Placeholder
        private static NinePatch LoadNinepatch(string name, ContentManager content, Game game)
        {
        }*/
    }
}
