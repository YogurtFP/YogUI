using YogUILibrary.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for NinePatchTest and is intended
    ///to contain all NinePatchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NinePatchTest
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
        ///A test for NinePatch Constructor
        ///</summary>
        [TestMethod()]
        public void NinePatchConstructorTest()
        {
            NinePatch target = new NinePatch();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            NinePatch target = new NinePatch(); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            int contentWidth = 0; // TODO: Initialize to an appropriate value
            int contentHeight = 0; // TODO: Initialize to an appropriate value
            target.Draw(sb, position, contentWidth, contentHeight);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LoadFromTexture
        ///</summary>
        [TestMethod()]
        public void LoadFromTextureTest()
        {
            NinePatch target = new NinePatch(); // TODO: Initialize to an appropriate value
            Texture2D texture = null; // TODO: Initialize to an appropriate value
            target.LoadFromTexture(texture);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getCenter
        ///</summary>
        [TestMethod()]
        public void getCenterTest()
        {
            NinePatch target = new NinePatch(); // TODO: Initialize to an appropriate value
            int contentWidth = 0; // TODO: Initialize to an appropriate value
            int contentHeight = 0; // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = target.getCenter(contentWidth, contentHeight);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for bottomHeight
        ///</summary>
        [TestMethod()]
        public void bottomHeightTest()
        {
            NinePatch target = new NinePatch(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.bottomHeight;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for leftWidth
        ///</summary>
        [TestMethod()]
        public void leftWidthTest()
        {
            NinePatch target = new NinePatch(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.leftWidth;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for rightWidth
        ///</summary>
        [TestMethod()]
        public void rightWidthTest()
        {
            NinePatch target = new NinePatch(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.rightWidth;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for topHeight
        ///</summary>
        [TestMethod()]
        public void topHeightTest()
        {
            NinePatch target = new NinePatch(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.topHeight;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
