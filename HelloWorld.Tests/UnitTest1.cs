using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class AlgorithmsTester
    {
        [TestMethod]
        public void Fibonnaci_WithXEqualZero_ThenResultLengthIsZero()
        {
            int[] res = Algorithms.Fibonnaci("0");
            Assert.AreEqual(res.Length, 0);
        }

        [TestMethod]
        public void Fibonnaci_WithXEqual4_ThenLastValueIs2()
        {
            int[] res = Algorithms.Fibonnaci("4");
            Assert.AreEqual(res[3], 2);
        }

        [TestMethod]
        public void IsPalindrome_WithPalindrome_ThenTrue()
        {
            string palindrome = "maoam";
            Assert.IsTrue(Algorithms.IsPalindrome(palindrome));
        }

        [TestMethod]
        public void IsPalindrome_WithRandomString_ThenFalse()
        {
            string rndString = "ok";
            Assert.IsFalse(Algorithms.IsPalindrome(rndString));
        }

        [TestMethod]
        public void TriTableauEntier_TriCroissant()
        {
            int[] tabEntier = new int[] { 1, 6, 2, 3, 5, 4 };
            int[] tabAttendu = new int[] { 1, 2, 3, 4, 5, 6 };
            var expectedString = String.Join(",", tabAttendu);
            var sortedString = String.Join(",", tabEntier);
            Algorithms.TriTableauEntier(tabEntier, true);
            Assert.Equals(sortedString, expectedString);
        }

        [TestMethod]
        public void TriTableauEntier_TriDeroissant()
        {
            int[] tabEntier = new int[] { 1, 6, 2, 3, 5, 4 };
            Assert.IsNotNull(Algorithms.TriTableauEntier(tabEntier, false));
        }
    }
}
