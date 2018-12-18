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
            int[] res = Algorithms.Fibonnaci(0);
            Assert.AreEqual(res.Length, 0);
        }

        [TestMethod]
        public void Fibonnaci_WithXEqual4_ThenLastValueIs2()
        {
            int[] res = Algorithms.Fibonnaci(4);
            Assert.AreEqual(res[3], 2);
        }
    }
}
