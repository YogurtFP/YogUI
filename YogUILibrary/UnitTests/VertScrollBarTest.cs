using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for VertScrollBarTest and is intended
    ///to contain all VertScrollBarTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VertScrollBarTest
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
        ///A test for VertScrollBar Constructor
        ///</summary>
        [TestMethod()]
        public void VertScrollBarConstructorTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
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
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
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
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
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
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetHeight
        ///</summary>
        [TestMethod()]
        public void SetHeightTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
            float h = 0F; // TODO: Initialize to an appropriate value
            target.SetHeight(h);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetMax
        ///</summary>
        [TestMethod()]
        public void SetMaxTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
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
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
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
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
            float m = 0F; // TODO: Initialize to an appropriate value
            target.SetValue(m);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for computePosition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void computePositionTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            VertScrollBar_Accessor target = new VertScrollBar_Accessor(param0); // TODO: Initialize to an appropriate value
            target.computePosition();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setPosition
        ///</summary>
        [TestMethod()]
        public void setPositionTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
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
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
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
            float height = 0F; // TODO: Initialize to an appropriate value
            VertScrollBar target = new VertScrollBar(topLeft, height); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBoxPart;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _height
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void _heightTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            VertScrollBar_Accessor target = new VertScrollBar_Accessor(param0); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            target._height = expected;
            actual = target._height;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for height
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void heightTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            VertScrollBar_Accessor target = new VertScrollBar_Accessor(param0); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            target.height = expected;
            actual = target.height;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
