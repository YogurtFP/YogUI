﻿using YogUILibrary.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YogUILibrary.UIComponents;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for RadioButtonGroupTest and is intended
    ///to contain all RadioButtonGroupTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RadioButtonGroupTest
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
        ///A test for RadioButtonGroup Constructor
        ///</summary>
        [TestMethod()]
        public void RadioButtonGroupConstructorTest()
        {
            RadioButtonGroup target = new RadioButtonGroup();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for addButton
        ///</summary>
        [TestMethod()]
        public void addButtonTest()
        {
            RadioButtonGroup target = new RadioButtonGroup(); // TODO: Initialize to an appropriate value
            RadioButton b = null; // TODO: Initialize to an appropriate value
            target.addButton(b);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for buttonPressed
        ///</summary>
        [TestMethod()]
        public void buttonPressedTest()
        {
            RadioButtonGroup target = new RadioButtonGroup(); // TODO: Initialize to an appropriate value
            RadioButton b = null; // TODO: Initialize to an appropriate value
            target.buttonPressed(b);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
