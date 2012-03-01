using YogUILibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Resources;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for Resource1Test and is intended
    ///to contain all Resource1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Resource1Test
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
        ///A test for Resource1 Constructor
        ///</summary>
        [TestMethod()]
        public void Resource1ConstructorTest()
        {
            Resource1 target = new Resource1();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CircleShader
        ///</summary>
        [TestMethod()]
        public void CircleShaderTest()
        {
            byte[] actual;
            actual = Resource1.CircleShader;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Culture
        ///</summary>
        [TestMethod()]
        public void CultureTest()
        {
            CultureInfo expected = null; // TODO: Initialize to an appropriate value
            CultureInfo actual;
            Resource1.Culture = expected;
            actual = Resource1.Culture;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResourceManager
        ///</summary>
        [TestMethod()]
        public void ResourceManagerTest()
        {
            ResourceManager actual;
            actual = Resource1.ResourceManager;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn_default_focused_holo_9
        ///</summary>
        [TestMethod()]
        public void btn_default_focused_holo_9Test()
        {
            byte[] actual;
            actual = Resource1.btn_default_focused_holo_9;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for btn_default_normal_holo_9
        ///</summary>
        [TestMethod()]
        public void btn_default_normal_holo_9Test()
        {
            byte[] actual;
            actual = Resource1.btn_default_normal_holo_9;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for textfield_default_9
        ///</summary>
        [TestMethod()]
        public void textfield_default_9Test()
        {
            byte[] actual;
            actual = Resource1.textfield_default_9;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for textfield_selected_9
        ///</summary>
        [TestMethod()]
        public void textfield_selected_9Test()
        {
            byte[] actual;
            actual = Resource1.textfield_selected_9;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for textfield_selected_right_9
        ///</summary>
        [TestMethod()]
        public void textfield_selected_right_9Test()
        {
            byte[] actual;
            actual = Resource1.textfield_selected_right_9;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for textfield_selected_wrong_9
        ///</summary>
        [TestMethod()]
        public void textfield_selected_wrong_9Test()
        {
            byte[] actual;
            actual = Resource1.textfield_selected_wrong_9;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
