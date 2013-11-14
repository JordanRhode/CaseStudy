//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using CaseStudy.Business;

//namespace CaseStudyTest
//{
//    [TestClass]
//    public class DataObject_Person_Tests
//    {
//        [TestMethod]
//        public void Test_DataObject_Person_Equals()
//        {
//            Person person1 = new Person();
//            Person person2 = new Person();
//            person1.FirstName = person2.FirstName = "Joe";
//            person1.LastName = person2.LastName = "Smith";
//            person1.DateOfBirth = person2.DateOfBirth = DateTime.Now;
//            person1.AddressID = person2.AddressID = 123456;

//            Assert.IsTrue(person1.Equals(person2));
//        }

//        [TestMethod]
//        public void Test_DataObject_Person_NotEqual_NonPersonObject()
//        {
//            Person person1 = new Person();
//            Person person2 = new Person();
//            person1.FirstName = person2.FirstName = "Joe";
//            person1.LastName = person2.LastName = "Smith";
//            person1.DateOfBirth = person2.DateOfBirth = DateTime.Now;
//            person1.AddressID = person2.AddressID = 123456;
//            Object obj = new Object();
//            Assert.IsFalse(person1.Equals(obj));
//        }

//        [TestMethod]
//        public void Test_DataObject_Person_NotEqual_DifferentProperties()
//        {
//            Person person1 = new Person();
//            person1.FirstName = "Joe";
//            person1.LastName = "Smith";
//            person1.DateOfBirth = DateTime.Now;
//            person1.AddressID = 123456;
//            Person person2 = new Person();
//            person2.FirstName = "Jane";
//            person2.LastName = "Smith";
//            person2.DateOfBirth = DateTime.Now;
//            person2.AddressID = 123456;
//            Assert.IsFalse(person1.Equals(person2));
//        }

//        [TestMethod]
//        public void Test_DataObject_Person_ToString()
//        {
//            Person person1 = new Person();
//            person1.FirstName = "Joe";
//            person1.LastName = "Smith";
//            person1.DateOfBirth = DateTime.Today;
//            person1.AddressID = 123456;
//            string expectedResult = string.Format("Name: Joe Smith, DOB: {0}", DateTime.Today);
//            Assert.IsTrue(person1.ToString() == expectedResult);
//        }
//    }
//}
