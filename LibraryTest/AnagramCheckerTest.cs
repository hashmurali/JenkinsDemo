using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace LibraryTest
{
    [TestClass]
    public class AnagramCheckerTest
    {
        [TestMethod]
        public void IsAnagramTest_InputsAreAnagram_ReturnTrue()
        {
            Assert.AreEqual(true, AnagramChecker.IsAnagram("Elvis", "Lives"));
        }

        [TestMethod]
        public void IsAnagramTest_InputsAreNotAnagram_ReturnFalse()
        {
            Assert.AreEqual(false, AnagramChecker.IsAnagram("Elvis", "Legend"));
        }
    }
}
