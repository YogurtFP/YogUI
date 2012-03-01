using YogUILibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for YogUITest and is intended
    ///to contain all YogUITest Unit Tests
    ///</summary>
    [TestClass()]
    public class YogUITest
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
        ///A test for YogUI Constructor
        ///</summary>
        [TestMethod()]
        public void YogUIConstructorTest()
        {
            YogUI target = new YogUI();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for YogUI_LoadContent
        ///</summary>
        [TestMethod()]
        public void YogUI_LoadContentTest()
        {
            Game game = null; // TODO: Initialize to an appropriate value
            YogUI.YogUI_LoadContent(game);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for YogUI_Update
        ///</summary>
        [TestMethod()]
        public void YogUI_UpdateTest()
        {
            GameTime time = null; // TODO: Initialize to an appropriate value
            YogUI.YogUI_Update(time);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
