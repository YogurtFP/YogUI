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
using YogUILibrary.Managers;
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

        public static NinePatch btn_hover = new NinePatch();
        public static NinePatch btn_normal = new NinePatch();

        public static NinePatch textField_normal = new NinePatch();
        public static NinePatch textField_selected = new NinePatch();
        public static NinePatch textField_selected_wrong = new NinePatch();
        public static NinePatch textField_selected_right = new NinePatch();
        
        public static void YogUI_LoadContent(Game game)
        {
            content = new ResourceContentManager(game.Services, Resource1.ResourceManager);
            white = new Texture2D(game.GraphicsDevice, 1, 1);
            white.SetData<Color>(new Color[] { Color.White });
            circleShader = content.Load<Effect>("CircleShader");
            btn_hover.LoadFromTexture(content.Load<Texture2D>("btn_default_focused_holo_9"));
            btn_normal.LoadFromTexture(content.Load<Texture2D>("btn_default_normal_holo_9"));

            textField_normal.LoadFromTexture(content.Load<Texture2D>("textfield_default_9"));
            textField_selected.LoadFromTexture(content.Load<Texture2D>("textfield_selected_9"));
            textField_selected_right.LoadFromTexture(content.Load<Texture2D>("textfield_selected_right_9"));
            textField_selected_wrong.LoadFromTexture(content.Load<Texture2D>("textfield_selected_wrong_9"));

            //Texture2D test = content.Load<Texture2D>("ninepatchtest");
           // bool isPatch = textField_normal.isAlreadyNinepatch(textField_normal.texture);

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
