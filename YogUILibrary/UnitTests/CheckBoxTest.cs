using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for CheckBoxTest and is intended
    ///to contain all CheckBoxTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CheckBoxTest
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
        ///A test for CheckBox Constructor
        ///</summary>
        [TestMethod()]
        public void CheckBoxConstructorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font);
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
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            target.Draw(sb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetChecked
        ///</summary>
        [TestMethod()]
        public void GetCheckedTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.GetChecked();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLabel
        ///</summary>
        [TestMethod()]
        public void GetLabelTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetLabel();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetPosition
        ///</summary>
        [TestMethod()]
        public void GetPositionTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = target.GetPosition();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OnMouseClick
        ///</summary>
        [TestMethod()]
        public void OnMouseClickTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
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
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
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
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            target.OnMouseOver();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetBackColor
        ///</summary>
        [TestMethod()]
        public void SetBackColorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            target.SetBackColor(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetBorderColor
        ///</summary>
        [TestMethod()]
        public void SetBorderColorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            target.SetBorderColor(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetCheckColor
        ///</summary>
        [TestMethod()]
        public void SetCheckColorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            target.SetCheckColor(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetChecked
        ///</summary>
        [TestMethod()]
        public void SetCheckedTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            bool state = false; // TODO: Initialize to an appropriate value
            target.SetChecked(state);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetLabel
        ///</summary>
        [TestMethod()]
        public void SetLabelTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            string label = string.Empty; // TODO: Initialize to an appropriate value
            target.SetLabel(label);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetLabelColor
        ///</summary>
        [TestMethod()]
        public void SetLabelColorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Color c = new Color(); // TODO: Initialize to an appropriate value
            target.SetLabelColor(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetOnChanged
        ///</summary>
        [TestMethod()]
        public void SetOnChangedTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Action a = null; // TODO: Initialize to an appropriate value
            target.SetOnChanged(a);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetPosition
        ///</summary>
        [TestMethod()]
        public void SetPositionTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Vector2 position1 = new Vector2(); // TODO: Initialize to an appropriate value
            target.SetPosition(position1);
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
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
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
            CheckBox target = new CheckBox(position, font); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
