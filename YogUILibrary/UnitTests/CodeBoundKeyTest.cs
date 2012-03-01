using YogUILibrary.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework.Input;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for CodeBoundKeyTest and is intended
    ///to contain all CodeBoundKeyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CodeBoundKeyTest
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
        ///A test for CodeBoundKey Constructor
        ///</summary>
        [TestMethod()]
        public void CodeBoundKeyConstructorTest()
        {
            Action a = null; // TODO: Initialize to an appropriate value
            Keys key = new Keys(); // TODO: Initialize to an appropriate value
            bool constant = false; // TODO: Initialize to an appropriate value
            bool pressing = false; // TODO: Initialize to an appropriate value
            string identifier = string.Empty; // TODO: Initialize to an appropriate value
            CodeBoundKey target = new CodeBoundKey(a, key, constant, pressing, identifier);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
