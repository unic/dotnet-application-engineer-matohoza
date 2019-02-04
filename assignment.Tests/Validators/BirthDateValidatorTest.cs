using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using assignment.Validators;

namespace assignment.Tests.Validators
{
    public class BirthDateValidatorTest
    {
        [Test]
        public void TestInputNotDateTime()
        {
            var instance = new BirthDateValidator();
            var param = new object();

            Assert.Throws<InvalidOperationException>(() => instance.IsValid(param));
        }

        [Test]
        public void TestNearFutureInput_False()
        {
            var instance = new BirthDateValidator();

            var param = DateTime.Now.AddSeconds(1);
            Assert.IsFalse(instance.IsValid(param));
        }
        
        [Test]
        public void TestNearPastInput_True()
        {
            var instance = new BirthDateValidator();

            var param = DateTime.Now.AddSeconds(-1);
            Assert.IsTrue(instance.IsValid(param));
        }
    }
}
