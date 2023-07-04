using System;

namespace FindBalanceElementTask
{
    /// <summary>
    /// Class for operations with arrays.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds an index of element in an integer array for which the sum of the elements
        /// on the left and the sum of the elements on the right are equal.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>The index of the balance element, if it exists, and null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static int? FindBalanceElement(int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty", nameof(array));
            }

            int res = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                long lsum = 0;
                long rsum = 0;
                for (int j = i + 1;  j < array.Length; j++)
                {
                    rsum += array[j];
                }

                for (int j = 0; j < i; j++)
                {
                    lsum += array[j];
                }

                if (lsum == rsum)
                {
                    res = i;
                    return res;
                }
            }

            return null;
        }
    }
}
