using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YogUILibrary.Structs;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DropDownListTest and is intended
    ///to contain all DropDownListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DropDownListTest
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
        ///A test for DropDownList Constructor
        ///</summary>
        [TestMethod()]
        public void DropDownListConstructorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddItem
        ///</summary>
        [TestMethod()]
        public void AddItemTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            DropDownItem item = null; // TODO: Initialize to an appropriate value
            target.AddItem(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CalculateDimensions
        ///</summary>
        [TestMethod()]
        public void CalculateDimensionsTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            target.CalculateDimensions();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CalculateSelected
        ///</summary>
        [TestMethod()]
        public void CalculateSelectedTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            target.CalculateSelected();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Destroy
        ///</summary>
        [TestMethod()]
        public void DestroyTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            target.Destroy();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            target.Draw(sb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Hide
        ///</summary>
        [TestMethod()]
        public void HideTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            target.Hide();
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
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
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
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            target.OnMouseOff();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Show
        ///</summary>
        [TestMethod()]
        public void ShowTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            target.Show();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
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
            DropDownList target = new DropDownList(position, font); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
