using YogUILibrary.UIComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for TextFieldTest and is intended
    ///to contain all TextFieldTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TextFieldTest
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
        ///A test for TextField Constructor
        ///</summary>
        [TestMethod()]
        public void TextFieldConstructorTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged);
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
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            SpriteBatch sb = null; // TODO: Initialize to an appropriate value
            target.Draw(sb);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetText
        ///</summary>
        [TestMethod()]
        public void GetTextTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetText();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetActive
        ///</summary>
        [TestMethod()]
        public void SetActiveTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            bool active = false; // TODO: Initialize to an appropriate value
            target.SetActive(active);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetSelected
        ///</summary>
        [TestMethod()]
        public void SetSelectedTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            bool selected = false; // TODO: Initialize to an appropriate value
            target.SetSelected(selected);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetText
        ///</summary>
        [TestMethod()]
        public void SetTextTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            target.SetText(text);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void TextChangedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextField_Accessor target = new TextField_Accessor(param0); // TODO: Initialize to an appropriate value
            target.TextChanged();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TextEnter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void TextEnterTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextField_Accessor target = new TextField_Accessor(param0); // TODO: Initialize to an appropriate value
            target.TextEnter();
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
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getOffsetString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void getOffsetStringTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextField_Accessor target = new TextField_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getOffsetString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isFilterText
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void isFilterTextTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextField_Accessor target = new TextField_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isFilterText();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for numCharsAllowed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void numCharsAllowedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextField_Accessor target = new TextField_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.numCharsAllowed();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for revalidate
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void revalidateTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextField_Accessor target = new TextField_Accessor(param0); // TODO: Initialize to an appropriate value
            target.revalidate();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for textExtends
        ///</summary>
        [TestMethod()]
        [DeploymentItem("YogUILibrary.dll")]
        public void textExtendsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TextField_Accessor target = new TextField_Accessor(param0); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.textExtends();
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
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.BoundBox;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for placeHolderText
        ///</summary>
        [TestMethod()]
        public void placeHolderTextTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.placeHolderText = expected;
            actual = target.placeHolderText;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for stringPattern
        ///</summary>
        [TestMethod()]
        public void stringPatternTest()
        {
            Vector2 position = new Vector2(); // TODO: Initialize to an appropriate value
            float width = 0F; // TODO: Initialize to an appropriate value
            float height = 0F; // TODO: Initialize to an appropriate value
            Color textColor = new Color(); // TODO: Initialize to an appropriate value
            SpriteFont font = null; // TODO: Initialize to an appropriate value
            Action<string> onTextEnter = null; // TODO: Initialize to an appropriate value
            Action<string> onTextChanged = null; // TODO: Initialize to an appropriate value
            TextField target = new TextField(position, width, height, textColor, font, onTextEnter, onTextChanged); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.stringPattern = expected;
            actual = target.stringPattern;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
