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
    public class SeachOpgaverTest_Linear
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
        /* Diverse test af FindPositionInList_Unsorted_Sequential
        /*------------------------------------------------------------------------*/

        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_01()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };
            int value = 21;
            int expectedPosition = 3;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition,"Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_02()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };
            int value = 4;
            int expectedPosition = 6;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_03()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };
            int value = 20;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_04()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };
            int value = 24;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_05()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };
            int value = 17;
            int expectedPosition = data.Length-1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_06()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17, 50 };
            int value = 50;
            int expectedPosition = data.Length - 1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_07()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17, 50 };
            int value = 24;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_08()
        {
            int[] data = { 5 };
            int value = 5;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_09()
        {
            int[] data = { 5 };
            int value = 6;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Unsorted_SequentialTest_10()
        {
            // Ingen data
//            int[] data = { };
            int value = 6;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
 //           opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Unsorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }


        /*------------------------------------------------------------------------*/
        /* Diverse test af FindPositionInList_Unsorted_Sequential
        /*------------------------------------------------------------------------*/
        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_01()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 18;
            int expectedPosition = 5;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_02()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40, 50 };
            int value = 18;
            int expectedPosition = 5;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_03()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 4;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }
        
        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_04()
        {
            int[] data = { 4, 7, 10, 11, 15, 18, 24, 31, 32, 40 };
            int value = 40;
            int expectedPosition = data.Length-1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_05()
        {
            int[] data = { 8 };
            int value = 8;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_06()
        {
            int[] data = { 8 };
            int value = 8;
            int expectedPosition = 0;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_07()
        {
            int[] data = { 8 };
            int value = 4;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_08()
        {
            int[] data = { 8 };
            int value = 10;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_09()
        {
            // ingen data
//            int[] data = { };
            int value = 4;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
//            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

        [TestMethod()]
        public void FindPositionInList_Sorted_SequentialTest_10()
        {
            int[] data = { 4, 7, 10, 11, 15, 24, 18, 31, 32, 40 };
            int value = 18;
            int expectedPosition = -1;

            SeachOpgaver opgaver = new SeachOpgaver();
            opgaver.FillList(data);
            int foundPosition = opgaver.FindPositionInList_Sorted_Sequential(value);
            Assert.AreEqual(expectedPosition, foundPosition, "Du finder ikke den rigtige position - (forbehold for fejl i unit test) ");
        }

    }
}
