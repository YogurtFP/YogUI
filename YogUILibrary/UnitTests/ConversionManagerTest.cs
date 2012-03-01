using YogUILibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Xna.Framework;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for ConversionManagerTest and is intended
    ///to contain all ConversionManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConversionManagerTest
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
        ///A test for DegreeToRadians
        ///</summary>
        [TestMethod()]
        public void DegreeToRadiansTest()
        {
            double degree = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = ConversionManager.DegreeToRadians(degree);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FloatToTime
        ///</summary>
        [TestMethod()]
        public void FloatToTimeTest()
        {
            float minutes = 0F; // TODO: Initialize to an appropriate value
            TimeSpan expected = new TimeSpan(); // TODO: Initialize to an appropriate value
            TimeSpan actual;
            actual = ConversionManager.FloatToTime(minutes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSafeName
        ///</summary>
        [TestMethod()]
        public void GetSafeNameTest()
        {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = ConversionManager.GetSafeName(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PToV
        ///</summary>
        [TestMethod()]
        public void PToVTest()
        {
            Point p = new Point(); // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = ConversionManager.PToV(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RadianToDegrees
        ///</summary>
        [TestMethod()]
        public void RadianToDegreesTest()
        {
            double radian = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = ConversionManager.RadianToDegrees(radian);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetDisplayUnitToSimUnitRatio
        ///</summary>
        [TestMethod()]
        public void SetDisplayUnitToSimUnitRatioTest()
        {
            float displayUnitsPerSimUnit = 0F; // TODO: Initialize to an appropriate value
            ConversionManager.SetDisplayUnitToSimUnitRatio(displayUnitsPerSimUnit);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToDisplayUnits
        ///</summary>
        [TestMethod()]
        public void ToDisplayUnitsTest()
        {
            Vector2 simUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = ConversionManager.ToDisplayUnits(simUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDisplayUnits
        ///</summary>
        [TestMethod()]
        public void ToDisplayUnitsTest1()
        {
            Vector2 simUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 simUnitsExpected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 displayUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 displayUnitsExpected = new Vector2(); // TODO: Initialize to an appropriate value
            ConversionManager.ToDisplayUnits(ref simUnits, out displayUnits);
            Assert.AreEqual(simUnitsExpected, simUnits);
            Assert.AreEqual(displayUnitsExpected, displayUnits);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToDisplayUnits
        ///</summary>
        [TestMethod()]
        public void ToDisplayUnitsTest2()
        {
            float x = 0F; // TODO: Initialize to an appropriate value
            float y = 0F; // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = ConversionManager.ToDisplayUnits(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDisplayUnits
        ///</summary>
        [TestMethod()]
        public void ToDisplayUnitsTest3()
        {
            float x = 0F; // TODO: Initialize to an appropriate value
            float y = 0F; // TODO: Initialize to an appropriate value
            Vector2 displayUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 displayUnitsExpected = new Vector2(); // TODO: Initialize to an appropriate value
            ConversionManager.ToDisplayUnits(x, y, out displayUnits);
            Assert.AreEqual(displayUnitsExpected, displayUnits);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToDisplayUnits
        ///</summary>
        [TestMethod()]
        public void ToDisplayUnitsTest4()
        {
            Vector3 simUnits = new Vector3(); // TODO: Initialize to an appropriate value
            Vector3 expected = new Vector3(); // TODO: Initialize to an appropriate value
            Vector3 actual;
            actual = ConversionManager.ToDisplayUnits(simUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDisplayUnits
        ///</summary>
        [TestMethod()]
        public void ToDisplayUnitsTest5()
        {
            float simUnits = 0F; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = ConversionManager.ToDisplayUnits(simUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDisplayUnits
        ///</summary>
        [TestMethod()]
        public void ToDisplayUnitsTest6()
        {
            int simUnits = 0; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = ConversionManager.ToDisplayUnits(simUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest()
        {
            Vector2 displayUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 displayUnitsExpected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 simUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 simUnitsExpected = new Vector2(); // TODO: Initialize to an appropriate value
            ConversionManager.ToSimUnits(ref displayUnits, out simUnits);
            Assert.AreEqual(displayUnitsExpected, displayUnits);
            Assert.AreEqual(simUnitsExpected, simUnits);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest1()
        {
            Vector3 displayUnits = new Vector3(); // TODO: Initialize to an appropriate value
            Vector3 expected = new Vector3(); // TODO: Initialize to an appropriate value
            Vector3 actual;
            actual = ConversionManager.ToSimUnits(displayUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest2()
        {
            Vector2 displayUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = ConversionManager.ToSimUnits(displayUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest3()
        {
            float x = 0F; // TODO: Initialize to an appropriate value
            float y = 0F; // TODO: Initialize to an appropriate value
            Vector2 simUnits = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 simUnitsExpected = new Vector2(); // TODO: Initialize to an appropriate value
            ConversionManager.ToSimUnits(x, y, out simUnits);
            Assert.AreEqual(simUnitsExpected, simUnits);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest4()
        {
            double x = 0F; // TODO: Initialize to an appropriate value
            double y = 0F; // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = ConversionManager.ToSimUnits(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest5()
        {
            float x = 0F; // TODO: Initialize to an appropriate value
            float y = 0F; // TODO: Initialize to an appropriate value
            Vector2 expected = new Vector2(); // TODO: Initialize to an appropriate value
            Vector2 actual;
            actual = ConversionManager.ToSimUnits(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest6()
        {
            float displayUnits = 0F; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = ConversionManager.ToSimUnits(displayUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest7()
        {
            double displayUnits = 0F; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = ConversionManager.ToSimUnits(displayUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSimUnits
        ///</summary>
        [TestMethod()]
        public void ToSimUnitsTest8()
        {
            int displayUnits = 0; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = ConversionManager.ToSimUnits(displayUnits);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VToP
        ///</summary>
        [TestMethod()]
        public void VToPTest()
        {
            Vector2 v = new Vector2(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = ConversionManager.VToP(v);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for circleTo180
        ///</summary>
        [TestMethod()]
        public void circleTo180Test()
        {
            double degrees = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = ConversionManager.circleTo180(degrees);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for circleTo360
        ///</summary>
        [TestMethod()]
        public void circleTo360Test()
        {
            double degrees = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = ConversionManager.circleTo360(degrees);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
