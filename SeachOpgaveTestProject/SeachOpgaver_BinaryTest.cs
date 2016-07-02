using SeachOpgaveClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace SeachOpgaveTestProject
{
    
    
    /// <summary>
    ///This is a test class for SeachOpgaverTest and is intended
    ///to contain all SeachOpgaverTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SeachOpgaverTest_Binary
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


        /*------------------------------------------------------------------------*/
        /* Diverse test af FindPositionInList_Sorted_Binary
        /*------------------------------------------------------------------------*/

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_01()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 31;
            int expectedPosition = 7;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_02()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 30;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_03()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 7;
            int expectedPosition = 1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_04()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 4;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_05()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 40;
            int expectedPosition = data.Length - 1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_06()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 1;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_07()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 50;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_08()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40, 50 };
            int value = 40;
            int expectedPosition = data.Length-2;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_09()
        {
            int[] data = {2, 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 4;
            int expectedPosition = 1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_10()
        {
            int[] data = { 22 };
            int value = 22;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_11()
        {
            int[] data = { 22 };
            int value = 2;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_12()
        {
            int[] data = { 22 };
            int value = 25;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_13()
        {
            // ingen data
//            int[] data = { };
            int value = 25;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
//            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_BinaryTest_14()
        {
            int[] data = { 4, 7, 10, 11, 15, 24, 18, 31, 32, 40, 50 };
            int value = 18;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }





        /*------------------------------------------------------------------------*/
        /* Diverse test af FindPositionInList_Sorted_Binary_Recursive
        /*------------------------------------------------------------------------*/

        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_01()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 31;
            int firstPosition = 0;
            int lastPosition = data.Length-1;
            int expectedPosition = 7;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_02()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 8;
            int firstPosition = 0;
            int lastPosition = data.Length - 1;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_03()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 18;
            int firstPosition = 3;
            int lastPosition = data.Length - 1;
            int expectedPosition = 5;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_04()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 18;
            int firstPosition = 3;
            int lastPosition = data.Length - 2;
            int expectedPosition = 5;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_05()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 32;
            int firstPosition = 3;
            int lastPosition = data.Length - 3;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_06()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 10;
            int firstPosition = 2;
            int lastPosition = 2;
            int expectedPosition = 2;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_07()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 10;
            int firstPosition = 2;
            int lastPosition = 1;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveTest_08()
        {
            // ingen data
//            int[] data = {  };
            int value = 10;
            int firstPosition = 0;
            int lastPosition = -1;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
//            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_Recursive(firstPosition, lastPosition, value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        /*------------------------------------------------------------------------*/
        /* Diverse test af FindPositionInList_Sorted_Binary_RecursiveStart
        /*------------------------------------------------------------------------*/

        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveStartTest_01()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 31;
            int expectedPosition = 7;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_RecursiveStart(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveStartTest_02()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 30;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_RecursiveStart(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_Binary_RecursiveStartTest_03()
        {
            // ingen data
            int[] data = {  };
            int value = 31;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
//            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Binary_RecursiveStart(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }


    }
}
