using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using YogUILibrary.Managers;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TextDrawerTest and is intended
    ///to contain all TextDrawerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TextDrawerTest
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
        ///A test for TextDrawer Constructor
        ///</summary>
        [TestMethod()]
        public void TextDrawerConstructorTest()
        {
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            TextAlign align = new TextAlign(); // TODO: Initialize to an appropriate value
            TextDrawer target = new TextDrawer(font, text, position, color, align);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            TextAlign align = new TextAlign(); // TODO: Initialize to an appropriate value
            TextDrawer target = new TextDrawer(font, text, position, color, align); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            target.Draw(sb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetActive
        ///</summary>
        [TestMethod()]
        public void SetActiveTest()
        {
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            TextAlign align = new TextAlign(); // TODO: Initialize to an appropriate value
            TextDrawer target = new TextDrawer(font, text, position, color, align); // TODO: Initialize to an appropriate value
            bool active = false; // TODO: Initialize to an appropriate value
            target.SetActive(active);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoundBox
        ///</summary>
        [TestMethod()]
        public void BoundBoxTest()
        {
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            TextAlign align = new TextAlign(); // TODO: Initialize to an appropriate value
            TextDrawer target = new TextDrawer(font, text, position, color, align); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for origin
        ///</summary>
        [TestMethod()]
        public void originTest()
        {
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            TextAlign align = new TextAlign(); // TODO: Initialize to an appropriate value
            TextDrawer target = new TextDrawer(font, text, position, color, align); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = target.origin;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
