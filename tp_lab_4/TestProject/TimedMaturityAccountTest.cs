using tp_lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for TimedMaturityAccountTest and is intended
    ///to contain all TimedMaturityAccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TimedMaturityAccountTest
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
        ///A test for Withdraw
        ///</summary>
        [TestMethod()]
        public void WithdrawTest()
        {
            TimedMaturityAccount target = new TimedMaturityAccount(1000.0, new DateTime(2010, 6, 14), 0.05, 0.05); // TODO: Initialize to an appropriate value
            double amount = 600; // TODO: Initialize to an appropriate value
            DateTime paydate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+1); // TODO: Initialize to an appropriate value
            double expected = 570; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Withdraw(amount, paydate);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Withdraw
        ///</summary>
        [TestMethod()]
        public void WithdrawTest1()
        {
            TimedMaturityAccount target = new TimedMaturityAccount(1000.0, new DateTime(2010, 6, 14), 0.05, 0.05); // TODO: Initialize to an appropriate value
            double amount = 600; // TODO: Initialize to an appropriate value
            DateTime paydate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1); // TODO: Initialize to an appropriate value
            double expected = 600; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Withdraw(amount, paydate);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CheckBalance
        ///</summary>
        [TestMethod()]
        public void CheckBalanceTest()
        {
            TimedMaturityAccount target = new TimedMaturityAccount(1000.0, new DateTime(2010, 6, 14), 0.05, 0.05); // TODO: Initialize to an appropriate value
            double expected = 1000.0; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.CheckBalance();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TimedMaturityAccount Constructor
        ///</summary>
        [TestMethod()]
        public void TimedMaturityAccountConstructorTest()
        {
            TimedMaturityAccount target = new TimedMaturityAccount();
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TimedMaturityAccount Constructor
        ///</summary>
        [TestMethod()]
        public void TimedMaturityAccountConstructorTest1()
        {
            double bal = 0F; // TODO: Initialize to an appropriate value
            DateTime date = DateTime.Now; // TODO: Initialize to an appropriate value
            double int_rate = 0.05; // TODO: Initialize to an appropriate value
            double pen_rate = 0.05; // TODO: Initialize to an appropriate value
            TimedMaturityAccount target = new TimedMaturityAccount(bal, date, int_rate, pen_rate);
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
