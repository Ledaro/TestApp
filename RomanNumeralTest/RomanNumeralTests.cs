using NUnit.Framework;
using RomanNumeralProject;
using System;

namespace RomanNumeralTest
{

    [TestFixture]
    public class RomanNumeralTests
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(500, "D")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanNumeral.Parse(roman));

        }
        
    }
}
