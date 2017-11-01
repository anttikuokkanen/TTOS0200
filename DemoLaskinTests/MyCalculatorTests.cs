using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT.Laskin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Laskin.Tests
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
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //testataan MyCalculator-luokan Multiply-metodia, AAA-malli
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
            Assert.AreEqual(odotettu, jako);
        }

        [TestMethod()]
        public void DivideTestWithZero()
        {
            //tehdään kahden luvun jakamisen testaus
            int i = 24;
            int j = 0;
            int odotettu = 1;
            MyCalculator laskin = new MyCalculator();
            //Act
            try
            {
                int jako = laskin.Divide(i, j);
                Assert.Fail();
            }
            //Assert
            catch (DivideByZeroException)
            {
                //ok, tulee oikean tyyppinen poikkeus
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}