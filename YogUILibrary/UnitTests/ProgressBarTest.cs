using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for ProgressBarTest and is intended
    ///to contain all ProgressBarTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgressBarTest
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
        ///A test for ProgressBar Constructor
        ///</summary>
        [TestMethod()]
        public void ProgressBarConstructorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress);
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
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
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
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for addProgress
        ///</summary>
        [TestMethod()]
        public void addProgressTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
            float amount = 0F; // TODO: Initialize to an appropriate value
            target.addProgress(amount);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getProgress
        ///</summary>
        [TestMethod()]
        public void getProgressTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = target.getProgress();
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
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            target.setBackgroundColor(color);
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
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            target.setBorderColor(color);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setProgress
        ///</summary>
        [TestMethod()]
        public void setProgressTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
            float progress1 = 0F; // TODO: Initialize to an appropriate value
            target.setProgress(progress1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoundBox
        ///</summary>
        [TestMethod()]
        public void BoundBoxTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            float progress = 0F; // TODO: Initialize to an appropriate value
            ProgressBar target = new ProgressBar(position, width, height, progress); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
