using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TextInputTest and is intended
    ///to contain all TextInputTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TextInputTest
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
        ///A test for TextInput Constructor
        ///</summary>
        [TestMethod()]
        public void TextInputConstructorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Copy
        ///</summary>
        [TestMethod()]
        public void CopyTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            target.Copy();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Cut
        ///</summary>
        [TestMethod()]
        public void CutTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            target.Cut();
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
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
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
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
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
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
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
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            target.OnMouseOver();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Paste
        ///</summary>
        [TestMethod()]
        public void PasteTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            target.Paste();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetActive
        ///</summary>
        [TestMethod()]
        public void SetActiveTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            bool active = false; // TODO: Initialize to an appropriate value
            target.SetActive(active);
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
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            Vector2 position1 = new Vector2(); // TODO: Initialize to an appropriate value
            target.SetPosition(position1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShiftHeld
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void ShiftHeldTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextInput_Accessor target = new TextInput_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShiftHeld();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for backSpace
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void backSpaceTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextInput_Accessor target = new TextInput_Accessor(param0); // TODO: Initialize to an appropriate value
            target.backSpace();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for bindKeys
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void bindKeysTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextInput_Accessor target = new TextInput_Accessor(param0); // TODO: Initialize to an appropriate value
            target.bindKeys();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getCharLength
        ///</summary>
        [TestMethod()]
        public void getCharLengthTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = target.getCharLength();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getFixedSelection
        ///</summary>
        [TestMethod()]
        public void getFixedSelectionTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = target.getFixedSelection();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for keyPressed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void keyPressedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextInput_Accessor target = new TextInput_Accessor(param0); // TODO: Initialize to an appropriate value
            string key = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.keyPressed(key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for BoundBox
        ///</summary>
        [TestMethod()]
        public void BoundBoxTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for offsetText
        ///</summary>
        [TestMethod()]
        public void offsetTextTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.offsetText;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for selectedText
        ///</summary>
        [TestMethod()]
        public void selectedTextTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Color color = new Color(); // TODO: Initialize to an appropriate value
            Action lambdaTextEnter = null; // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            Action lambdaTextChanged = null; // TODO: Initialize to an appropriate value
            TextInput target = new TextInput(position, font, color, lambdaTextEnter, input, lambdaTextChanged); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.selectedText;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
