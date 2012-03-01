using YogUILibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for InputManagerTest and is intended
    ///to contain all InputManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InputManagerTest
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
        ///A test for InputManager Constructor
        ///</summary>
        [TestMethod()]
        public void InputManagerConstructorTest()
        {
            InputManager target = new InputManager();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for BindKey
        ///</summary>
        [TestMethod()]
        public void BindKeyTest()
        {
            Action lambda = null; // TODO: Initialize to an appropriate value
            Keys key = new Keys(); // TODO: Initialize to an appropriate value
            bool constant = false; // TODO: Initialize to an appropriate value
            bool press = false; // TODO: Initialize to an appropriate value
            string identifier = string.Empty; // TODO: Initialize to an appropriate value
            InputManager.BindKey(lambda, key, constant, press, identifier);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BindMouse
        ///</summary>
        [TestMethod()]
        public void BindMouseTest()
        {
            Action a = null; // TODO: Initialize to an appropriate value
            MouseButton button = new MouseButton(); // TODO: Initialize to an appropriate value
            bool press = false; // TODO: Initialize to an appropriate value
            bool constant = false; // TODO: Initialize to an appropriate value
            string identifier = string.Empty; // TODO: Initialize to an appropriate value
            InputManager.BindMouse(a, button, press, constant, identifier);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetMousePos
        ///</summary>
        [TestMethod()]
        public void GetMousePosTest()
        {
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = InputManager.GetMousePos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetMousePosV
        ///</summary>
        [TestMethod()]
        public void GetMousePosVTest()
        {
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = InputManager.GetMousePosV();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            InputManager target = new InputManager(); // TODO: Initialize to an appropriate value
            GameTime time = null; // TODO: Initialize to an appropriate value
            target.Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for isKeyPressed
        ///</summary>
        [TestMethod()]
        public void isKeyPressedTest()
        {
            Keys k = new Keys(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = InputManager.isKeyPressed(k);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
