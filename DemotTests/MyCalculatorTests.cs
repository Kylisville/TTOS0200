using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //testataan MyCalculator-luokan Add-metodia, AAA-malli
            //Arrange
            int i = 10;
            int j = 12;
            int tulos = 22;
            MyCalculator laskin = new MyCalculator();
            //Act
            int summa = laskin.Add(i, j);
            //Assert
            Assert.AreEqual(tulos, summa);
            //Assert.Fail();
            // Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //testataan MyCalculator-luokan Add-metodia, AAA-malli
            //Arrange
            int i = 10;
            int j = 12;
            int tulos = 120;
            MyCalculator laskin = new MyCalculator();
            //Act
            int summa = laskin.Multiply(i, j);
            //Assert
            Assert.AreEqual(tulos, summa);

        }

        [TestMethod()]
        public void DivideTest()
        {
            //tehdään kahden luvun jakamisen testaus
            int i = 24;
            int j = 4;
            int odotettu = 6;
            MyCalculator laskin = new MyCalculator();
            //Act
            int jako = laskin.Divide(i, j);
            //Assert
            DivideByZeroException dbze = new DivideByZeroException();
            Assert.ThrowsException<>
            Assert.AreEqual(odotettu, jako);
        }
    }
}