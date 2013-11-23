using tp_lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for CheckingAccountTest and is intended
    ///to contain all CheckingAccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CheckingAccountTest
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
        public void CheckBalanceTest()
        {
            CheckingAccount target = new CheckingAccount(1000.0, new DateTime(2011, 9, 27), 5, 7.5, 7, DateTime.Now.AddDays(-1)); // TODO: Initialize to an appropriate value
            double amount = 500; // TODO: Initialize to an appropriate value
            DateTime paydate = new DateTime(); // TODO: Initialize to an appropriate value
            double expected = 492.5; // TODO: Initialize to an appropriate value
            target.Withdraw(amount, paydate);
            double actual;
            actual = target.CheckBalance();
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Withdraw
        ///</summary>
        [TestMethod()]
        public void CheckBalanceTest1()
        {
            CheckingAccount target = new CheckingAccount(1000.0, new DateTime(2011, 9, 27), 5, 7.5, 4, DateTime.Now.AddDays(-1)); // TODO: Initialize to an appropriate value
            double amount = 500; // TODO: Initialize to an appropriate value
            DateTime paydate = new DateTime(); // TODO: Initialize to an appropriate value
            double expected = 500; // TODO: Initialize to an appropriate value
            target.Withdraw(amount, paydate);
            double actual;
            actual = target.CheckBalance();
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CheckingAccount Constructor
        ///</summary>
        [TestMethod()]
        public void CheckingAccountConstructorTest()
        {
            double bal = 1000; // TODO: Initialize to an appropriate value
            DateTime date = DateTime.Now; // TODO: Initialize to an appropriate value
            int m_quota = 5; // TODO: Initialize to an appropriate value
            double ptf = 7.5; // TODO: Initialize to an appropriate value
            int total = 0; // TODO: Initialize to an appropriate value
            DateTime lvd = date; // TODO: Initialize to an appropriate value
            CheckingAccount target = new CheckingAccount(bal, date, m_quota, ptf, total, lvd);
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CheckingAccount Constructor
        ///</summary>
        [TestMethod()]
        public void CheckingAccountConstructorTest1()
        {
            CheckingAccount target = new CheckingAccount();
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ValidateTransactionNumber
        ///</summary>
        [TestMethod()]
        [DeploymentItem("tp_lab_4.exe")]
        public void ValidateTransactionNumberTest()
        {
            CheckingAccount_Accessor target = new CheckingAccount_Accessor(
                1000, new DateTime(2013, 8, 23), 5, 10, 5, new DateTime(2013, 11, 22)); // TODO: Initialize to an appropriate value
            int expected = 0;
            target.ValidateTransactionNumber();
            int actual = target.total_transactions;
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
