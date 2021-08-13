using Exercise01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestNumbersToWords()
        {
            Numbers numbers = new Numbers();
            var words = numbers.NumWords(18000000);
            Assert.AreEqual("eighteen million", words);
        }
    }
}
