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
using YogUILibrary;
using YogUILibrary.UIComponents;
using YogUILibrary.Managers;
using YogUILibrary.Structs;
using System.IO;
using System.Diagnostics;

namespace NinepatchEditor
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    /// 

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Texture2D curTexture = null;
        public NinePatch curNinepatch = new NinePatch();

        public TextField xStart;
        public TextField xEnd;
        public TextField yStart;
        public TextField yEnd;
        public Button refreshNinepatch;
        public SliderBar patchScale;

        public Button loadNinepatch;
        public Button saveNinepatchAs;

        public Rectangle fileOpDraw = new Rectangle(1, 1, 200, 50);
        public Rectangle patchInfoDraw = new Rectangle(201, 1, 800 - 201, 50);
        public Rectangle patchDisplayDraw = new Rectangle(201, 51, 800 - 201, 480 - 51);
        public Rectangle patchTextureDraw = new Rectangle(1, 51, 200, 480 - 51);

        public Rectangle testDrawing = new Rectangle(0, 0, 1, 1);

        public RadioButtonGroup scaleGroup = new RadioButtonGroup();
        public RadioButton scaleX;
        public RadioButton scaleY;
        public RadioButton scaleXY;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
            Window.Title = "YoGUI Ninepatch editor";
            graphics.PreferMultiSampling = true;
            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {


            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            YogUI.YogUI_LoadContent(this);

            SpriteFont buttonFont = Content.Load<SpriteFont>("buttonFont");

            loadNinepatch = new Button(new Vector2(46, 23), "Open", buttonFont, loadExisting);
            saveNinepatchAs = new Button(new Vector2(150, 23), "Save", buttonFont);

            xStart = new TextField(new Vector2(225, 3), 70, 15, Color.Black, buttonFont, (string s) => { });
            xEnd = new TextField(new Vector2(225, 28), 70, 15, Color.Black, buttonFont, (string s) => { });
            xStart.stringPattern = xEnd.stringPattern = "^\\d+?$";
            xStart.placeHolderText = "X start";
            xEnd.placeHolderText = "X end";

            yStart = new TextField(new Vector2(305, 3), 70, 15, Color.Black, buttonFont, (string s) => { });
            yEnd = new TextField(new Vector2(305, 28), 70, 15, Color.Black, buttonFont, (string s) => { });
            yStart.stringPattern = yEnd.stringPattern = "^\\d+?$";
            yStart.placeHolderText = "Y start";
            yEnd.placeHolderText = "Y end";

            refreshNinepatch = new Button(new Vector2(420, 23), "Refresh", buttonFont);

            patchScale = new SliderBar(new Vector2(465, 9), 225, 30, 0, 100, buttonFont);

            scaleX = new RadioButton(new Vector2(700, 9), buttonFont, "Scale X");
            scaleY = new RadioButton(new Vector2(700, 23), buttonFont, "Scale Y");
            scaleXY = new RadioButton(new Vector2(700, 37), buttonFont, "Scale X+Y");

            scaleGroup.addButton(scaleX);
            scaleGroup.addButton(scaleY);
            scaleGroup.addButton(scaleXY);

            scaleX.selected = true;

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            YogUI.YogUI_Update(gameTime);

            loadNinepatch.Update(gameTime);
            saveNinepatchAs.Update(gameTime);

            xStart.Update(gameTime);
            xEnd.Update(gameTime);
            yStart.Update(gameTime);
            yEnd.Update(gameTime);
            refreshNinepatch.Update(gameTime);
            patchScale.Update(gameTime);
            scaleX.Update(gameTime);
            scaleY.Update(gameTime);
            scaleXY.Update(gameTime);
            computeScale();

            base.Update(gameTime);
        }

        public void loadExisting()
        {
            var open = new System.Windows.Forms.OpenFileDialog();
            open.SupportMultiDottedExtensions = true;
            open.DefaultExt = ".9.png";
            open.Filter = "Image files|*.png|Ninepatch files|*.9.png|All files|*";
            open.ShowDialog();
            String fileName = open.FileName;
            if (File.Exists(fileName))
            {
                loadImage(fileName);
            }
        }

        public void loadImage(string path)
        {
            Texture2D texture = Texture2D.FromStream(GraphicsDevice, new FileStream(path, FileMode.Open));
            if (NinePatch.isAlreadyNinepatch(texture))
            {
                loadImageExisting(texture);
            }
            else
            {
                loadImageNew(texture);
            }
            computeScale();
        }

        public void loadImageExisting(Texture2D texture)
        {
            //We have to remove the 1-pixel padding on each side first.
            Color[] textureData = new Color[(texture.Width - 2) * (texture.Height - 2)];
            Color[] textureDataHolder = new Color[texture.Width * texture.Height];
            texture.GetData<Color>(textureDataHolder);

            int totalMinus = 0;

            for (int i = texture.Width + 1; i < (texture.Width * texture.Height); i++)
            {
                bool isNotToLeft = ((float)i / (float)texture.Width) != (i / texture.Width);
                bool isNotToRight = ((float)(i + 1) / (float)texture.Width) != ((i + 1) / texture.Width);
                totalMinus += (!isNotToLeft || !isNotToRight) ? 1 : 0;
                // if (!isNotToLeft) System.Diagnostics.Debugger.Break();
                if (isNotToLeft && isNotToRight && i >= texture.Width && i < (texture.Width - 1) * texture.Height)
                {
                    //Is within the bounds.
                    int test = i - (texture.Width + 1 + totalMinus);
                    textureData[test] = textureDataHolder[i];
                }
            }

            Texture2D ret = new Texture2D(GraphicsDevice, texture.Width - 2, texture.Height - 2);
            ret.SetData<Color>(textureData);
            curTexture = ret;
            curNinepatch.LoadFromTexture(texture);
            xStart.SetText(curNinepatch.leftMostPatch.ToString());
            xEnd.SetText(curNinepatch.rightWidth.ToString());
            yStart.SetText(curNinepatch.topMostPatch.ToString());
            yEnd.SetText(curNinepatch.bottomMostPatch.ToString());
        }

        public void loadImageNew(Texture2D texture)
        {
            curTexture = texture;
            xStart.SetText("1");
            xEnd.SetText("3");
            yStart.SetText("1");
            yEnd.SetText("3");
            curTexture = createImageNinepatch();
            curNinepatch.LoadFromTexture(curTexture);
        }

        public void computeScale()
        {
            if (curNinepatch == null) return;
            int midWidth = (curNinepatch.rightMostPatch - curNinepatch.leftMostPatch);
            int midHeight = (curNinepatch.bottomMostPatch - curNinepatch.topMostPatch);
            int extraWidth = curNinepatch.leftWidth + curNinepatch.rightWidth;
            int extraHeight = curNinepatch.bottomHeight + curNinepatch.topHeight;

            if (scaleX.selected)
            {
                int totalMinimum = midWidth + extraWidth + 10;
                int available = patchDisplayDraw.Width - totalMinimum;
                patchScale.min = 0;
                patchScale.max = available;
            }
            else if (scaleY.selected)
            {
                int totalMinimum = midHeight + extraHeight + 10;
                int available = patchDisplayDraw.Height - totalMinimum;
                patchScale.min = 0;
                patchScale.max = available;
            }
            else if (scaleXY.selected)
            {
                int totalMinimumW = midWidth + extraWidth + 10;
                int totalMinimumH = midHeight + extraHeight + 10;
                int availableW = patchDisplayDraw.Width - totalMinimumW;
                int availableH = patchDisplayDraw.Height - totalMinimumH;
                patchScale.min = 0;
                //set it to the lower of the two.
                patchScale.max = (availableH < availableW) ? availableH : availableW;
            }
        }

        public Texture2D createImageNinepatch()
        {
            int leftMost = xStart.textValid ? Convert.ToInt32(xStart.GetText()) : 0;
            int rightMost = xEnd.textValid ? Convert.ToInt32(xEnd.GetText()) : 1;
            int topMost = yStart.textValid ? Convert.ToInt32(yStart.GetText()) : 0;
            int bottomMost = yEnd.textValid ? Convert.ToInt32(yEnd.GetText()) : 1;

            Color[] newData = new Color[(curTexture.Width + 2) * (curTexture.Height + 2)];
            Color[] curData = new Color[curTexture.Width * curTexture.Height];
            curTexture.GetData<Color>(curData);

            int curRealPos = -1;
            for (int i = 0; i < newData.Length; i++)
            {
                Color curColor = Color.Transparent;
                int y = (i / (curTexture.Width + 2));
                int x = i - (y * (curTexture.Width + 2));
                int curPos = (x - 1) + ((y - 1) * curTexture.Width);
                if (y == 0)
                {
                    if (x >= leftMost && x <= rightMost)
                    {
                        curColor = Color.Black;
                    }
                }
                if (x == 0)
                {
                    if (y >= topMost && y <= bottomMost)
                    {
                        curColor = Color.Black;
                    }
                }
                if (x > 0 && y > 0 && x < (curTexture.Width + 1) && y < (curTexture.Height + 1))
                {
                    curRealPos += 1;
                    curColor = curData[curRealPos];
                }
                newData[i] = curColor;
            }

            Texture2D ret = new Texture2D(GraphicsDevice, curTexture.Width + 2, curTexture.Height + 2);
            ret.SetData<Color>(newData);
            return ret;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            GraphicsDevice.PresentationParameters.MultiSampleCount = 12;
            spriteBatch.Begin();

            DrawManager.Draw_Box(new Vector2(fileOpDraw.Left, fileOpDraw.Top), new Vector2(fileOpDraw.Right, fileOpDraw.Bottom), Color.Black, spriteBatch, 0f, 200);
            DrawManager.Draw_Outline(new Vector2(fileOpDraw.Left, fileOpDraw.Top), new Vector2(fileOpDraw.Right, fileOpDraw.Bottom), Color.White, spriteBatch);

            DrawManager.Draw_Box(new Vector2(patchInfoDraw.Left, patchInfoDraw.Top), new Vector2(patchInfoDraw.Right, patchInfoDraw.Bottom), Color.Black, spriteBatch, 0f, 200);
            DrawManager.Draw_Outline(new Vector2(patchInfoDraw.Left, patchInfoDraw.Top), new Vector2(patchInfoDraw.Right, patchInfoDraw.Bottom), Color.White, spriteBatch);

            DrawManager.Draw_Box(new Vector2(patchDisplayDraw.Left, patchDisplayDraw.Top), new Vector2(patchDisplayDraw.Right, patchDisplayDraw.Bottom), Color.Black, spriteBatch, 0f, 200);
            DrawManager.Draw_Outline(new Vector2(patchDisplayDraw.Left, patchDisplayDraw.Top), new Vector2(patchDisplayDraw.Right, patchDisplayDraw.Bottom), Color.White, spriteBatch);

            DrawManager.Draw_Box(new Vector2(patchTextureDraw.Left, patchTextureDraw.Top), new Vector2(patchTextureDraw.Right, patchTextureDraw.Bottom), Color.Black, spriteBatch, 0f, 200);
            DrawManager.Draw_Outline(new Vector2(patchTextureDraw.Left, patchTextureDraw.Top), new Vector2(patchTextureDraw.Right, patchTextureDraw.Bottom), Color.White, spriteBatch);

            DrawManager.Draw_Box(new Vector2(testDrawing.Left, testDrawing.Top), new Vector2(testDrawing.Right, testDrawing.Bottom), Color.Black, spriteBatch, 0f, 200);
            DrawManager.Draw_Outline(new Vector2(testDrawing.Left, testDrawing.Top), new Vector2(testDrawing.Right, testDrawing.Bottom), Color.White, spriteBatch);

            loadNinepatch.Draw(spriteBatch);
            saveNinepatchAs.Draw(spriteBatch);

            xStart.Draw(spriteBatch);
            xEnd.Draw(spriteBatch);
            yStart.Draw(spriteBatch);
            yEnd.Draw(spriteBatch);
            refreshNinepatch.Draw(spriteBatch);
            patchScale.Draw(spriteBatch);
            scaleX.Draw(spriteBatch);
            scaleY.Draw(spriteBatch);
            scaleXY.Draw(spriteBatch);

            if (curTexture != null)
            {
                spriteBatch.Draw(curTexture, ConversionManager.PToV(patchTextureDraw.Center), null, Color.White, 0f, new Vector2(curTexture.Width / 2, curTexture.Height / 2), 1f, SpriteEffects.None, 0f);
            }

            Vector2 drawPos = ConversionManager.PToV(patchDisplayDraw.Center);

            if (curNinepatch.texture != null)
            {
                int height = curNinepatch.bottomMostPatch - curNinepatch.topMostPatch;
                int width = curNinepatch.rightMostPatch - curNinepatch.leftMostPatch;
                if (scaleX.selected)
                {
                    curNinepatch.Draw(spriteBatch, drawPos - curNinepatch.getCenter(width + patchScale.getNumber() + 5, height), width + (patchScale.getNumber() - 5), height);
                }
                else if (scaleY.selected)
                {
                    curNinepatch.Draw(spriteBatch, drawPos - curNinepatch.getCenter(width, height + patchScale.getNumber() + 5), width, height + (patchScale.getNumber() - 5));
                }
                else if (scaleXY.selected)
                {
                    curNinepatch.Draw(spriteBatch, drawPos - curNinepatch.getCenter(width + patchScale.getNumber() + 5, height + patchScale.getNumber() + 5), width + (patchScale.getNumber() - 5), height + (patchScale.getNumber() - 5));
                }
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
