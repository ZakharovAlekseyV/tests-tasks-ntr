using System;

namespace TestTasks
{
    //supposed that 0 is like positive, so it does not disturb a positive sequence
    static class Calculator
    {
        public static int Calculate(int[] numbers)
        {
            if ( numbers==null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }
            var summ = 0;
            var max = 0;

            foreach (var n in numbers)
            {
                if (n < 0)
                {
                    if (summ > 0)
                    {
                        max = Math.Max(max, summ);
                    }
                    summ = 0;
                }
                else
                {
                    summ += n;
                }
            }
            return Math.Max(max, summ);
        }
    }
}
