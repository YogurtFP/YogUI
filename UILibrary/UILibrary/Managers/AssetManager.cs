using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace YogUI.Code.Managers
{
    public static class AssetManager
    {
        public static Dictionary<string, Texture2D> Textures = new Dictionary<string, Texture2D>();
        public static Dictionary<string, SpriteFont> Fonts = new Dictionary<string, SpriteFont>();
        public static Dictionary<string, Effect> Effects = new Dictionary<string, Effect>();

        public static bool LoadAsset<T>(string key, string assetName, ContentManager content, GraphicsDevice graphics)
        {
            try
            {
                if (typeof(T) == typeof(Texture2D))
                {
                    if (GetTexture(key, false) != null) return false;
                    string path = assetName;
                    FileStream fs = new FileStream(path, FileMode.Open);
                    Texture2D texture = Texture2D.FromStream(graphics, fs);

                    Textures.Add(key, texture);
                    fs.Close();
                }

                if (typeof(T) == typeof(SpriteFont))
                {
                    if (GetFont(key, false) != null) return false;
                    SpriteFont font = content.Load<SpriteFont>(assetName);
                    Fonts.Add(key, font);
                }

                if (typeof(T) == typeof(Effect))
                {
                    if (GetEffect(key, false) != null) return false;
                    Effect e = content.Load<Effect>(assetName);
                    Effects.Add(key, e);
                }

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }



        public static Texture2D GetTexture(string key, bool error = true)
        {
            if (Textures.ContainsKey(key))
            {
                Texture2D texture;
                Textures.TryGetValue(key, out texture);
                return texture;
            }
            else
            {
                if (error)
                    return GetTexture("error", false);
                return null;
            }
        }


        public static Effect GetEffect(string key, bool error = true)
        {
            if (Effects.ContainsKey(key))
            {
                Effect e;
                Effects.TryGetValue(key, out e);
                return e;
            }
            if (error)
                return GetEffect("error");
            return null;
        }


        public static SpriteFont GetFont(string key, bool error = true)
        {
            if (Fonts.ContainsKey(key))
            {
                SpriteFont font = null;
                Fonts.TryGetValue(key, out font);
                return font;
            }

            else
            {
                if (error)
                    return GetFont("default");
                return null;
            }
        }
    }
}
