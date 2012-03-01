using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for HorizontalScrollBarTest and is intended
    ///to contain all HorizontalScrollBarTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HorizontalScrollBarTest
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
        ///A test for HorizontalScrollBar Constructor
        ///</summary>
        [TestMethod()]
        public void HorizontalScrollBarConstructorTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            target.Draw(sb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetMax
        ///</summary>
        [TestMethod()]
        public void GetMaxTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = target.GetMax();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMin
        ///</summary>
        [TestMethod()]
        public void GetMinTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = target.GetMin();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        public void GetValueTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetMax
        ///</summary>
        [TestMethod()]
        public void SetMaxTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            float m = 0F; // TODO: Initialize to an appropriate value
            target.SetMax(m);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetMin
        ///</summary>
        [TestMethod()]
        public void SetMinTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            float m = 0F; // TODO: Initialize to an appropriate value
            target.SetMin(m);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetValue
        ///</summary>
        [TestMethod()]
        public void SetValueTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            float m = 0F; // TODO: Initialize to an appropriate value
            target.SetValue(m);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetWidth
        ///</summary>
        [TestMethod()]
        public void SetWidthTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            float w = 0F; // TODO: Initialize to an appropriate value
            target.SetWidth(w);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setPosition
        ///</summary>
        [TestMethod()]
        public void setPositionTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            Vector2 pos = new Vector2(); // TODO: Initialize to an appropriate value
            target.setPosition(pos);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoundBox
        ///</summary>
        [TestMethod()]
        public void BoundBoxTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BoundBoxPart
        ///</summary>
        [TestMethod()]
        public void BoundBoxPartTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            HorizontalScrollBar target = new HorizontalScrollBar(topLeft, width); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBoxPart;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _width
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void _widthTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            HorizontalScrollBar_Accessor target = new HorizontalScrollBar_Accessor(param0); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            target._width = expected;
            actual = target._width;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for width
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void widthTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            HorizontalScrollBar_Accessor target = new HorizontalScrollBar_Accessor(param0); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            target.width = expected;
            actual = target.width;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
