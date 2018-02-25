using System;

namespace TestTasks
{
    static class IndexSearcher
    {
        public static int Search(int[] input, int value)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Length == 0)
            {
                throw new ArgumentException("void array is not supported", nameof(input));
            }

            int startIndex = 0;
            int finishIndex = input.Length - 1;

            if (input[finishIndex] < value)
            {
                return finishIndex;
            }

            if (input[startIndex] >= value)
            {
                return startIndex;
            }

            while (startIndex <= finishIndex)
            {
                var middleIndex = (startIndex+finishIndex) / 2;

                if (input[middleIndex] < value)
                {
                    startIndex = middleIndex;

                    if (input[middleIndex + 1] >= value)
                    {
                        return middleIndex + 1;
                    }
                }
                else 
                {
                    finishIndex = middleIndex;
                }
            }

            return startIndex;
        }
    }
}
