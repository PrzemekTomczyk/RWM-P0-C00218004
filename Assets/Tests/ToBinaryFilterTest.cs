using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ToBinary
    {
        [Test]
        public void ToBinarySimplePasses()
        {
            List<int> input = new List<int> { 2, 4, 10 };
            List<int> output = ToBinaryFilter.ToBinary(input);
            List<int> expected = new List<int> { 10, 100, 1010};

            CollectionAssert.AreEqual(expected, output);
        }
        [Test]
        public void ToBinaryBoundaryCases()
        {
            List<int> input = new List<int> { 0, 1, 1023 };
            List<int> output = ToBinaryFilter.ToBinary(input);
            List<int> expected = new List<int> { 0, 1, 1111111111 };

            CollectionAssert.AreEqual(expected, output);
        }
        [Test]
        public void ToBinaryFail()
        {
            List<int> input = new List<int> { 0, 10, 100 };
            List<int> output = ToBinaryFilter.ToBinary(input);
            List<int> wrongValues = new List<int> { 2, 4, 6 };

            CollectionAssert.AreNotEqual(output, wrongValues);
        }
    }
}
