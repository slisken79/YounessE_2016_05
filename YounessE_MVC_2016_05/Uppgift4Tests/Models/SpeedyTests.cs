using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uppgift4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4.Models.Tests
{
    [TestClass]
    public class MovingBallTests
    {
        [TestMethod]
        public void GetCurrentSpeed_CorrectCalculation()
        {
            //Arrange
            var grej = new Speedy();
            //Act
            var actual = grej.GetCurrentSpeed(distanceC: 20.4, tid: 2);
            double expected = 10.2;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void GetCurrentSpeed_ZeroTime()
        {
            var grej = new Speedy();
            grej.GetCurrentSpeed(distanceC: 2, tid: 0);
        }

        [TestMethod]
        public void GetCurrentSpeed_ZeroDistance()
        {
            var grej = new Speedy();
            var actual = grej.GetCurrentSpeed(distanceC: 0, tid: 8);
            double expected = 0;
            Assert.AreEqual(expected, actual);
        }

       
    }
}