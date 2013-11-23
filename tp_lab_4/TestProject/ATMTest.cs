using tp_lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for ATMTest and is intended
    ///to contain all ATMTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ATMTest
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
        ///A test for ATM Constructor
        ///</summary>
        [TestMethod()]
        public void ATMConstructorTest()
        {
            ATM target = new ATM();
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ATM Constructor
        ///</summary>
        [TestMethod()]
        public void ATMConstructorTest1()
        {
            List<UniversalAccount> acc_base = new List<UniversalAccount>(); // TODO: Initialize to an appropriate value
            List<int> pin_base = new List<int>(); // TODO: Initialize to an appropriate value
            acc_base.Add(new SavingsAccount());
            pin_base.Add( ( (new Random()).Next()%10000 ).GetHashCode() );
            ATM target = new ATM(acc_base, pin_base);
            Assert.IsNotNull(target);
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
