﻿using Tyuiu.PasechnikPA1.Sprint0.Task5.V0.Lib;
namespace Tyuiu.PasechnikPA1.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));

        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));

        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));

        }
        [TestMethod]
        public void CheckeDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));

        }

    }
}
