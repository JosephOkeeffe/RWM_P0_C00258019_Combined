using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 }; // conors output
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 24, 1, 40320, 2, 362880, 24, 3628800, 120, 39916800, 720, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
