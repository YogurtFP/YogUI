using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for SliderBarTest and is intended
    ///to contain all SliderBarTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SliderBarTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SliderBar Constructor
        ///</summary>
        [TestMethod()]
        public void SliderBarConstructorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            target.Draw(sb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getNumber
        ///</summary>
        [TestMethod()]
        public void getNumberTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getNumber();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setBackgroundColor
        ///</summary>
        [TestMethod()]
        public void setBackgroundColorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            target.setBackgroundColor(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setBorderColor
        ///</summary>
        [TestMethod()]
        public void setBorderColorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            target.setBorderColor(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setNumber
        ///</summary>
        [TestMethod()]
        public void setNumberTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress); // TODO: Initialize to an appropriate value
            int number = 0; // TODO: Initialize to an appropriate value
            target.setNumber(number);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setTextColor
        ///</summary>
        [TestMethod()]
        public void setTextColorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            int min = 0; // TODO: Initialize to an appropriate value
            int max = 0; // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            SliderBar target = new SliderBar(position, width, height, min, max, font, progress); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            target.setTextColor(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
