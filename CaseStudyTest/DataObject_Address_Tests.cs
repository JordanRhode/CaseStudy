//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using CaseStudy.Business;

//namespace CaseStudyTest
//{
//    [TestClass]
//    public class DataObject_Address_Tests
//    {
//        [TestMethod]
//        public void Test_DataObject_Address_Equals()
//        {
//            Address add1 = new Address();
//            Address add2 = new Address();
//            add1.Street = add2.Street = "1234 Main St.";
//            add1.City = add2.City = "Stevens Point";
//            add1.StateCode = add2.StateCode = "WI";
//            add1.Zip = add2.Zip = 54481;

//            Assert.IsTrue(add1.Equals(add2));
//        }

//        [TestMethod]
//        public void Test_DataObject_Address_NotEqual_NonAddressObject()
//        {
//            Address add1 = new Address();
//            add1.Street = "1234 Main St.";
//            add1.City = "Stevens Point";
//            add1.StateCode = "WI";
//            add1.Zip = 54481;
//            Object obj = new Object();
//            Assert.IsFalse(add1.Equals(obj));
//        }

//        [TestMethod]
//        public void Test_DataObject_Address_NotEqual_DifferentProperties()
//        {
//            Address add1 = new Address();
//            add1.Street = "1234 Main St.";
//            add1.City = "Stevens Point";
//            add1.StateCode = "WI";
//            add1.Zip = 54481;
//            Address add2 = new Address();
//            add2.Street = "ABCDE";
//            add2.City = "City";
//            add2.StateCode = "NY";
//            add2.Zip = 12345;
//            Assert.IsFalse(add1.Equals(add2));
//        }

//        [TestMethod]
//        public void Test_DataObject_Address_ToString()
//        {
//            Address add1 = new Address();
//            add1.Street = "1234 Main St.";
//            add1.City = "Stevens Point";
//            add1.StateCode = "WI";
//            add1.Zip = 54481;
//            string expectedResult = "Street: 1234 Main St., City: Stevens Point, State: WI, Zip: 54481";
//            Assert.IsTrue(add1.ToString() == expectedResult);
//        }
//    }
//}
