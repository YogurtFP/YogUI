using YogUILibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DrawManagerTest and is intended
    ///to contain all DrawManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DrawManagerTest
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
        ///A test for Draw_Bezier
        ///</summary>
        [TestMethod()]
        public void Draw_BezierTest()
        {
            Vector2 point1 = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 point2 = new Vector2(); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            SpriteBatch b = null; // TODO: Initialize to an appropriate value
            byte alpha = 0; // TODO: Initialize to an appropriate value
            DrawManager.Draw_Bezier(point1, point2, c, b, alpha);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Draw_Box
        ///</summary>
        [TestMethod()]
        public void Draw_BoxTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            SpriteBatch b = null; // TODO: Initialize to an appropriate value
            float rotation = 0F; // TODO: Initialize to an appropriate value
            byte alpha = 0; // TODO: Initialize to an appropriate value
            Effect e = null; // TODO: Initialize to an appropriate value
            bool wrong = false; // TODO: Initialize to an appropriate value
            DrawManager.Draw_Box(position, width, height, c, b, rotation, alpha, e, wrong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Draw_Box
        ///</summary>
        [TestMethod()]
        public void Draw_BoxTest1()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 bottomRight = new Vector2(); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            SpriteBatch b = null; // TODO: Initialize to an appropriate value
            float rotation = 0F; // TODO: Initialize to an appropriate value
            byte alpha = 0; // TODO: Initialize to an appropriate value
            Effect e = null; // TODO: Initialize to an appropriate value
            bool wrong = false; // TODO: Initialize to an appropriate value
            DrawManager.Draw_Box(topLeft, bottomRight, c, b, rotation, alpha, e, wrong);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Draw_Circle
        ///</summary>
        [TestMethod()]
        public void Draw_CircleTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float radius = 0F; // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            Color cOutline = new Color(); // TODO: Initialize to an appropriate value
            SpriteBatch b = null; // TODO: Initialize to an appropriate value
            byte alpha = 0; // TODO: Initialize to an appropriate value
            byte cutoff = 0; // TODO: Initialize to an appropriate value
            DrawManager.Draw_Circle(position, radius, c, cOutline, b, alpha, cutoff);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Draw_Line
        ///</summary>
        [TestMethod()]
        public void Draw_LineTest()
        {
            Vector2 point1 = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 point2 = new Vector2(); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            SpriteBatch b = null; // TODO: Initialize to an appropriate value
            byte alpha = 0; // TODO: Initialize to an appropriate value
            DrawManager.Draw_Line(point1, point2, c, b, alpha);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Draw_Outline
        ///</summary>
        [TestMethod()]
        public void Draw_OutlineTest()
        {
            Vector2 topLeft = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 bottomRight = new Vector2(); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            SpriteBatch b = null; // TODO: Initialize to an appropriate value
            byte alpha = 0; // TODO: Initialize to an appropriate value
            bool up = false; // TODO: Initialize to an appropriate value
            bool down = false; // TODO: Initialize to an appropriate value
            bool left = false; // TODO: Initialize to an appropriate value
            bool right = false; // TODO: Initialize to an appropriate value
            DrawManager.Draw_Outline(topLeft, bottomRight, c, b, alpha, up, down, left, right);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Draw_Outline
        ///</summary>
        [TestMethod()]
        public void Draw_OutlineTest1()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            SpriteBatch b = null; // TODO: Initialize to an appropriate value
            byte alpha = 0; // TODO: Initialize to an appropriate value
            bool up = false; // TODO: Initialize to an appropriate value
            bool down = false; // TODO: Initialize to an appropriate value
            bool left = false; // TODO: Initialize to an appropriate value
            bool right = false; // TODO: Initialize to an appropriate value
            DrawManager.Draw_Outline(position, width, height, c, b, alpha, up, down, left, right);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MidPoint
        ///</summary>
        [TestMethod()]
        public void MidPointTest()
        {
            Vector2 point1 = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 point2 = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = DrawManager.MidPoint(point1, point2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PointInCircle
        ///</summary>
        [TestMethod()]
        public void PointInCircleTest()
        {
            Vector2 origin = new Vector2(); // TODO: Initialize to an appropriate value
            float radius = 0F; // TODO: Initialize to an appropriate value
            Vector2 point = new Vector2(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = DrawManager.PointInCircle(origin, radius, point);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PointOnLine
        ///</summary>
        [TestMethod()]
        public void PointOnLineTest()
        {
            Vector2 linePoint1 = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 linePoint2 = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 point = new Vector2(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = DrawManager.PointOnLine(linePoint1, linePoint2, point);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
