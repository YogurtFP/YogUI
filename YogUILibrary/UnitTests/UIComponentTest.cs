using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for UIComponentTest and is intended
    ///to contain all UIComponentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UIComponentTest
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
        ///A test for UIComponent Constructor
        ///</summary>
        [TestMethod()]
        public void UIComponentConstructorTest()
        {
            UIComponent target = new UIComponent();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Draw
        ///</summary>
        [TestMethod()]
        public void DrawTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
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
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            target.OnMouseClick();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnMouseDrag
        ///</summary>
        [TestMethod()]
        public void OnMouseDragTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            target.OnMouseDrag();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnMouseOff
        ///</summary>
        [TestMethod()]
        public void OnMouseOffTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            target.OnMouseOff();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnMouseOver
        ///</summary>
        [TestMethod()]
        public void OnMouseOverTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            target.OnMouseOver();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetOnMouseClick
        ///</summary>
        [TestMethod()]
        public void SetOnMouseClickTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            Action a = null; // TODO: Initialize to an appropriate value
            target.SetOnMouseClick(a);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetOnMouseDrag
        ///</summary>
        [TestMethod()]
        public void SetOnMouseDragTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            Action a = null; // TODO: Initialize to an appropriate value
            target.SetOnMouseDrag(a);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetOnMouseOff
        ///</summary>
        [TestMethod()]
        public void SetOnMouseOffTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            Action a = null; // TODO: Initialize to an appropriate value
            target.SetOnMouseOff(a);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetOnMouseOver
        ///</summary>
        [TestMethod()]
        public void SetOnMouseOverTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            Action a = null; // TODO: Initialize to an appropriate value
            target.SetOnMouseOver(a);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UIC_Initialize
        ///</summary>
        [TestMethod()]
        public void UIC_InitializeTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            bool bind = false; // TODO: Initialize to an appropriate value
            target.UIC_Initialize(bind);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            GameTime theTime = null; // TODO: Initialize to an appropriate value
            target.Update(theTime);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoundBox
        ///</summary>
        [TestMethod()]
        public void BoundBoxTest()
        {
            UIComponent target = new UIComponent(); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
