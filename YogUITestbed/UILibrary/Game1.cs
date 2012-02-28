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
using YogUILibrary.Structs;
namespace YogUITestBed
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public TextField textField = null;
        public FilterTextField filterTextField = null;
        public ListBox listBox = null;
        public ProgressBar progressBar = null;
        public SliderBar sliderBar = null;
        public RadioButton radioButton1 = null;
        public RadioButton radioButton2 = null;
        public RadioButtonGroup radioButtonGroup = new RadioButtonGroup();
        public CheckBox checkBox = null;
        public ComboBox comboBox = null;
        public Button button = null;
        public SpriteFont font = null;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            base.IsMouseVisible = true;
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
            YogUILibrary.YogUI.YogUI_LoadContent(this);
            font = Content.Load<SpriteFont>("Console");

            //Create a new Text Field with position (top-left) at 0, 10. Width 100, height 20 (don't change this to anything else yet),
            //White text, Black background, White border, SpriteFont font, doing nothing on text enter, and nothing on text changed.
            textField = new TextField(new Vector2(0, 10), 200, 20, Color.Black, font, (string s) => { /*Pressed Enter*/ }, (string s) => { /*Text changed*/});
            textField.SetText("TextField");
            textField.setPlaceHolderText("Default text");

            filterTextField = new FilterTextField(new Vector2(330, 10), "^\\d+?\\.\\d+?\\.\\d+?\\.\\d+?$", 150, 20, Color.Black, font, (string s) => { });

            //Create a new ListBox at (0, 150), 90 width, 100 height, and doing nothing on Selected Index Changed.
            listBox = new ListBox(new Vector2(0, 150), 90, 100, font, () => { /*Selected Index Changed*/});
            listBox.dataSource = new string[] { "Index 1", "Index 2", "Index 3" }.ToList<string>();

            //Create a new ProgressBar at (150, 100), 100 width, 30 height, 50% progress.
            progressBar = new ProgressBar(new Vector2(150, 100), 100, 30, 50f);

            //Create a new sliderbar at (150, 150), 100 width, 30 height, 0 minimum value, 200 maximum value, SpriteFont font, 25% progress.
            sliderBar = new SliderBar(new Vector2(150, 150), 100, 30, 0, 200, font, 25);

            //Create two new radiobuttons
            radioButton1 = new RadioButton(new Vector2(200, 50), font, "RadioButton 1");
            radioButton2 = new RadioButton(new Vector2(200, 65), font, "Radiobutton 2");

            //Add the radiobuttons to a RadioButtonGroup that controls only one being "checked" at a time.
            radioButtonGroup.addButton(radioButton1);
            radioButtonGroup.addButton(radioButton2);

            //Create a new CheckBox at (200, 90), SpriteFont font.
            checkBox = new CheckBox(new Vector2(200, 90), font);

            //Create a new ComboBox at (500, 200), SpriteFont font.
            comboBox = new ComboBox(new Vector2(500, 200), font, "Combo box option 1", "Combo box option 2", "Combo box option 3");

            //Create a new button at (500, 100), with the text "Button", Adding a new item to the listbox when it is clicked, the text being from the TextField.
            button = new Button(new Vector2(500, 100), "Button", font, () => { listBox.dataSource.Add(textField.GetText()); });
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            //Update all of our UIComponents.
            YogUI.YogUI_Update(gameTime);
            textField.Update(gameTime);
            filterTextField.Update(gameTime);
            listBox.Update(gameTime);
            progressBar.Update(gameTime);
            sliderBar.Update(gameTime);
            radioButton1.Update(gameTime);
            radioButton2.Update(gameTime);
            checkBox.Update(gameTime);
            comboBox.Update(gameTime);
            button.Update(gameTime);
            button.SetText(textField.GetText());
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SaddleBrown);
            //Draw all of our UIComponents.
            spriteBatch.Begin();

            textField.Draw(spriteBatch);
            filterTextField.Draw(spriteBatch);
            listBox.Draw(spriteBatch);
            progressBar.Draw(spriteBatch);
            sliderBar.Draw(spriteBatch);
            radioButton1.Draw(spriteBatch);
            radioButton2.Draw(spriteBatch);
            checkBox.Draw(spriteBatch);
            comboBox.Draw(spriteBatch);
            button.Draw(spriteBatch);
           // spriteBatch.Draw(testLol, YogUILibrary.Managers.InputManager.GetMousePosV() - new Vector2(20, 20), Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
