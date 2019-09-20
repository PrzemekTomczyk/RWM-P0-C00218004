using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DecrementIfLessThanFirstTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void DecrementIfLessThanFirstTestBiggerThanFirst()
        {
            float[] inputArr = { 5.0f, 2.0f, 5.0f, 9.0f };
            float[] expectedArr = { 5.0f, 1.0f, 5.0f, 9.0f };            

            CollectionAssert.AreEqual(expectedArr, DecrementIfLessThanFirstFilter.DecrementIfLess(inputArr));
        }
    }
}