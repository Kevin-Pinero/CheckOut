using System;
using NUnit.Framework;

namespace CheckOutKata.UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("", 0)]
        [TestCase("A", 50)]
        [TestCase("AB", 80)]
        [TestCase("CDBA",115)]
        [TestCase("AA", 100)]
        [TestCase("AAA",130)]
        [TestCase("AAAA", 180)]
        [TestCase("AAAAAA", 260)]
        public void Should_return_correct_price(string items, int totalPrice)
        {
            Assert.AreEqual(totalPrice, new CheckOut().GetTotal(items));
        }
    }
}
