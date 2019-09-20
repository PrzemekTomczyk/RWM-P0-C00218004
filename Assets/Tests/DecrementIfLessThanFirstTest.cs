using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DecrementIfLessThanFirstTest
    {
        [Test]
        public void DecrementSecondNumPass()
        {
            float[] inputArr = { 5.0f, 2.0f, 5.0f, 9.0f };
            float[] expectedArr = { 5.0f, 1.0f, 5.0f, 9.0f };

            CollectionAssert.AreEqual(expectedArr, DecrementIfLessThanFirstFilter.DecrementIfLess(inputArr));
        }
        [Test]
        public void DecrementThirdNumPass()
        {
            float[] inputArr = { 5.0f, 6.0f, 4.0f, 9.0f };
            float[] expectedArr = { 5.0f, 6.0f, 3.0f, 9.0f };

            CollectionAssert.AreEqual(expectedArr, DecrementIfLessThanFirstFilter.DecrementIfLess(inputArr));
        }
        [Test]
        public void DecrementFourthNumPass()
        {
            float[] inputArr = { 5.0f, 6.0f, 7.0f, 3.0f };
            float[] expectedArr = { 5.0f, 6.0f, 7.0f, 2.0f };

            CollectionAssert.AreEqual(expectedArr, DecrementIfLessThanFirstFilter.DecrementIfLess(inputArr));
        }
        [Test]
        public void DecrementNone()
        {
            float[] inputArr = { 1.0f, 2.0f, 3.0f, 4.0f };
            float[] expectedArr = { 1.0f, 2.0f, 3.0f, 4.0f };

            CollectionAssert.AreEqual(expectedArr, DecrementIfLessThanFirstFilter.DecrementIfLess(inputArr));
        }

    }
}