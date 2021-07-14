using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CalculatePriceTest()
        {
            double expected =236;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(1, 100, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest2()
        {
            double expected = 214;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(3, 100, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest1()
        {
            double expected = 208;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(2, 100, 2);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void CalculatePriceTest3()
        {
            double expected = 236;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(4, 100, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculateCGST()
        {
            double expected = 100;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalculateCGST(1,100);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculateCGST1()
        {
            double expected = 103.5;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalculateCGST(2, 100);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculateSGST()
        {
            double expected = 100;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalculateCGST(1, 100);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculateSGST1()
        {
            double expected = 103.5;
            var PaymentObj = new Payment();
            double actual = PaymentObj.CalculateCGST(2, 100);
            Assert.AreEqual(expected, actual);
        }
    }
}