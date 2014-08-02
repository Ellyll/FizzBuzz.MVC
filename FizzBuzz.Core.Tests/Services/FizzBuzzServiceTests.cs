using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzz.Core.Services;

namespace FizzBuzz.Core.Tests.Services
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService GetService()
        {
            return new FizzBuzzService();
        }

        [Test]
        public void CanCreateService()
        {
            Assert.IsNotNull(GetService());
        }

        [Test]
        public void CheckReturnsTheNumberForNonMulipleOf3Or5()
        {
            Assert.AreEqual("7", GetService().Check(7));
        }

        [Test]
        public void CheckReturnsFizzForMultipleOf3()
        {
            Assert.AreEqual("Fizz", GetService().Check(6));
        }

        [Test]
        public void CheckReturnsBuzzForMultipleOf5()
        {
            Assert.AreEqual("Buzz", GetService().Check(10));
        }

        [Test]
        public void CheckReturnsFizzBuzzForMultipleOf3And5()
        {
            Assert.AreEqual("FizzBuzz", GetService().Check(30));
        }

        [Test]
        public void CheckReturns1For1()
        {
            Assert.AreEqual("1", GetService().Check(1));
        }

        [Test]
        public void CheckReturns2For2()
        {
            Assert.AreEqual("2", GetService().Check(2));
        }

        [Test]
        public void CheckReturnsFizzFor3()
        {
            Assert.AreEqual("Fizz", GetService().Check(3));
        }

        [Test]
        public void CheckReturnsBuzzFor5()
        {
            Assert.AreEqual("Buzz", GetService().Check(5));
        }

        [Test, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckThrowsArgumentOfRangeExceptionFor0()
        {
            var result = GetService().Check(0);
        }

        [Test, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckThrowsArgumentOfRangeExceptionForValueLessThan1()
        {
            var result = GetService().Check(-1);
        }

        [Test, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckThrowsArgumentOfRangeExceptionForValueGreaterThan100()
        {
            var result = GetService().Check(101);
        }
    }
}
