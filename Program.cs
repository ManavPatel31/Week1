using System;

namespace exam
{
    class MainClass
    {
        public static int OddCounts(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1)
                {
                    count += 1;
                }
                else
                {
                    count += 0;
                }

            }
            Console.WriteLine("The Count is:- " + count);
            return count;
        }
        public static void Main(string[] args)
        {

            int[] numbers = { 4, 3, 6, 7, 5, 6 };
            OddCounts(numbers);


        }
    }
}
