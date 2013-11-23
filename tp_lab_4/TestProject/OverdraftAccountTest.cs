using tp_lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for OverdraftAccountTest and is intended
    ///to contain all OverdraftAccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OverdraftAccountTest
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
        ///A test for CheckBalance
        ///</summary>
        [TestMethod()]
        public void CheckBalanceTest()
        {
            OverdraftAccount target = new OverdraftAccount(1000.0, new DateTime(2012, 7, 10), 0.05, 
                DateTime.Now.AddDays(-30)); // TODO: Initialize to an appropriate value
            double expected = -1050; // TODO: Initialize to an appropriate value
            double actual;
            target.Withdraw(2000, DateTime.Now);
            actual = target.CheckBalance();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Withdraw
        ///</summary>
        [TestMethod()]
        public void CheckBalanceTest1()
        {
            OverdraftAccount target = new OverdraftAccount(1000.0, new DateTime(2012, 7, 10), 0.05,
                DateTime.Now.AddDays(-30)); // TODO: Initialize to an appropriate value
            double expected = 0; // TODO: Initialize to an appropriate value
            double actual;
            target.Withdraw(1000, DateTime.Now);
            actual = target.CheckBalance();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Withdraw
        ///</summary>
        [TestMethod()]
        public void CheckBalanceTest2()
        {
            OverdraftAccount target = new OverdraftAccount(1000.0, new DateTime(2012, 7, 10), 0.05,
                DateTime.Now.AddDays(-30)); // TODO: Initialize to an appropriate value
            double expected = 1; // TODO: Initialize to an appropriate value
            double actual;
            target.Withdraw(999, DateTime.Now);
            actual = target.CheckBalance();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OverdraftAccount Constructor
        ///</summary>
        [TestMethod()]
        public void OverdraftAccountConstructorTest()
        {
            OverdraftAccount target = new OverdraftAccount();
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for OverdraftAccount Constructor
        ///</summary>
        [TestMethod()]
        public void OverdraftAccountConstructorTest1()
        {
            double bal = 0F; // TODO: Initialize to an appropriate value
            DateTime date = DateTime.Now; // TODO: Initialize to an appropriate value
            double int_rate = 0.05; // TODO: Initialize to an appropriate value
            DateTime last_acc_date = date; // TODO: Initialize to an appropriate value
            OverdraftAccount target = new OverdraftAccount(bal, date, int_rate, last_acc_date);
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
