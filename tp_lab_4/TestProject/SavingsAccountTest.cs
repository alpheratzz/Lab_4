using tp_lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for SavingsAccountTest and is intended
    ///to contain all SavingsAccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SavingsAccountTest
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
            SavingsAccount target = new SavingsAccount(1000.0, new DateTime(2010, 8, 21), 0.2); // TODO: Initialize to an appropriate value
            double expected = 1728F; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.CheckBalance();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Withdraw
        ///</summary>
        [TestMethod()]
        public void WithdrawTest()
        {
            SavingsAccount target = new SavingsAccount(1000.0, new DateTime(2011, 10, 6), 0.16); // TODO: Initialize to an appropriate value
            double amount = 1300; // TODO: Initialize to an appropriate value
            DateTime paydate = new DateTime(); // TODO: Initialize to an appropriate value
            double expected = 1300; // TODO: Initialize to an appropriate value
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
            SavingsAccount target = new SavingsAccount(1000.0, new DateTime(2011, 10, 6), 0.16); // TODO: Initialize to an appropriate value
            double amount = 1350; // TODO: Initialize to an appropriate value
            DateTime paydate = new DateTime(); // TODO: Initialize to an appropriate value
            double expected = 0; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Withdraw(amount, paydate);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SavingsAccount Constructor
        ///</summary>
        [TestMethod()]
        public void SavingsAccountConstructorTest()
        {
            double bal = 0F; // TODO: Initialize to an appropriate value
            DateTime date = DateTime.Now; // TODO: Initialize to an appropriate value
            double int_rate = 0.1; // TODO: Initialize to an appropriate value
            SavingsAccount target = new SavingsAccount(bal, date, int_rate);
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for SavingsAccount Constructor
        ///</summary>
        [TestMethod()]
        public void SavingsAccountConstructorTest1()
        {
            SavingsAccount target = new SavingsAccount();
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
