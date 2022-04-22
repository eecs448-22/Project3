using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSuite
{
    [TestClass]
    public class TestSuite
    {
        [TestMethod]
        public void Admin_Create_New_User()
        {
            //Steps needed:
            //Make a new user profile to enter in database
            //Enter that user into the database
            //Check the database to verify the user is there
            //If yes, return test passed, if no, return pass failed.

            //Below is a dummy test so you can see how the test explorer will work
            //Go to Test->TestExplorer->Run All Tests, and you'll see the test run and the outcome (pass)
            
            double num1 = 4.5;
            double num2 = 4.5;
            Assert.AreEqual(num1, num2);

        }
    }
}