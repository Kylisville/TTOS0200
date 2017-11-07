﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vko44;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko44.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        double expected, actual;
        [TestMethod()]
        public void SumTest()
        {
            expected = 25.60;
                actual = ArrayCalcs.Sum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double summa = 0;
            foreach(double i in array)
            {
                summa += i;
            }
            expected = summa / array.Length;
            actual = ArrayCalcs.Average(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            expected = array.Min();
            actual = ArrayCalcs.Min(array);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MaxTest()
        {
            expected = array.Max();
            actual = ArrayCalcs.Max(array);
            Assert.AreEqual(expected, actual);
        }
    }
}