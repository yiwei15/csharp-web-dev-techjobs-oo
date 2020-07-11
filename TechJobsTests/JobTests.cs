using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
   

    [TestClass]
    public class JobTests
    {
        Job testJob1 = new Job();
        Job testJob2 = new Job();
        Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job testJob5 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));


        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestSettingJobID()
        {
            Assert.IsFalse(testJob1.Id == testJob2.Id);
            Assert.AreEqual(testJob1.Id + 1, testJob2.Id);
            Assert.IsTrue(testJob1.Id == testJob2.Id -1);
        }




        [TestMethod]    
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", testJob3.Name);
            Assert.AreEqual("ACME", testJob3.EmployerName.Value);
            Assert.AreEqual("Desert", testJob3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testJob3.JobType.Value);
            Assert.AreEqual("Persistence", testJob3.JobCoreCompetency.Value);
        }

        [TestMethod]    
        public void TestJobsForEquality()
        {
            //Assert.AreEqual(testJob3.Id, testJob4.Id); // fail, 11, 12
            Assert.IsFalse(testJob3.Equals(testJob4));
        }

        [TestMethod]
        public void TestJobToStringStartAndEndWithBlankLine()
        {
            Assert.IsTrue(testJob3.ToString().StartsWith("\n"));
            Assert.IsTrue(testJob3.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobToStringContainAllField()
        {
            //string strVal = testJob3.ToString();
            //int index1 = strVal.IndexOf("ID");
            //int index2 = strVal.IndexOf("\n", index1);
            //String testValue = strVal.Substring(index1 + 3, index2 - index1 - 3).Trim();

            //Assert.IsTrue(index1 > -1);
            //Assert.AreEqual(testValue, testJob3.Id.ToString());
            TestSingleJobFieldToString(testJob3, "ID:", testJob3.Id.ToString());
            TestSingleJobFieldToString(testJob3, "Name:", testJob3.Name);
            TestSingleJobFieldToString(testJob3, "Employer:", testJob3.EmployerName.ToString());
            TestSingleJobFieldToString(testJob3, "Location:", testJob3.EmployerLocation.ToString());
            TestSingleJobFieldToString(testJob3, "Position Type:", testJob3.JobType.ToString());
            TestSingleJobFieldToString(testJob3, "Core Competency:", testJob3.JobCoreCompetency.ToString());
        }


        public void TestSingleJobFieldToString(Job testJob, String labelName, String expectedValue)
        {
            string strVal = testJob.ToString();
            int index1 = strVal.IndexOf(labelName);
            int index2 = strVal.IndexOf("\n", index1);
            String testValue = strVal.Substring(index1 + labelName.Length, index2 - index1 - labelName.Length).Trim();

            Assert.IsTrue(index1 > -1);
            Assert.AreEqual(expectedValue, testValue);
        }   
        [TestMethod]
        public void TestJobToStringWithEmptyField()
        {
            Assert.AreEqual(testJob5.EmployerName.ToString(), "Data not available");
        }

        //bonus
        [TestMethod]
        public void TestJobToStringOnlyID()
        {
            Assert.AreEqual(testJob1.ToString(), "OOPS! This job does not seem to exist.");
        }

    }
}
