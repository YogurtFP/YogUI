using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for ComboBoxTest and is intended
    ///to contain all ComboBoxTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ComboBoxTest
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
        ///A test for ComboBox Constructor
        ///</summary>
        [TestMethod()]
        public void ComboBoxConstructorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string[] items = null; // TODO: Initialize to an appropriate value
            ComboBox target = new ComboBox(position, font, items);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string[] items = null; // TODO: Initialize to an appropriate value
            ComboBox target = new ComboBox(position, font, items); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            target.Draw(sb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnMouseClick
        ///</summary>
        [TestMethod()]
        public void OnMouseClickTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string[] items = null; // TODO: Initialize to an appropriate value
            ComboBox target = new ComboBox(position, font, items); // TODO: Initialize to an appropriate value
            target.OnMouseClick();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnMouseOff
        ///</summary>
        [TestMethod()]
        public void OnMouseOffTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string[] items = null; // TODO: Initialize to an appropriate value
            ComboBox target = new ComboBox(position, font, items); // TODO: Initialize to an appropriate value
            target.OnMouseOff();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnMouseOver
        ///</summary>
        [TestMethod()]
        public void OnMouseOverTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string[] items = null; // TODO: Initialize to an appropriate value
            ComboBox target = new ComboBox(position, font, items); // TODO: Initialize to an appropriate value
            target.OnMouseOver();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for updateSelected
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void updateSelectedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ComboBox_Accessor target = new ComboBox_Accessor(param0); // TODO: Initialize to an appropriate value
            target.updateSelected();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoundBox
        ///</summary>
        [TestMethod()]
        public void BoundBoxTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            string[] items = null; // TODO: Initialize to an appropriate value
            ComboBox target = new ComboBox(position, font, items); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
