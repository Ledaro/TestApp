using DegreeConverterProject;
using NUnit.Framework;
using System;

namespace DegreeConverterTest
{

    [TestFixture]
    public class DegreeConverterTests
    {


        [Test]
        public void ToFahrenheit_ZeroCelsius_Returns32()
        {
            var converter = new DegreeConverter();
            double result = converter.ToFahrenheit(0);

            Assert.That(result, Is.EqualTo(32));

        }

        [Test]
        public void ToCelsius_1Fahrenheit_Resturns0()
        {
            var converter = new DegreeConverter();
            double result = converter.ToCelsius(1);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
