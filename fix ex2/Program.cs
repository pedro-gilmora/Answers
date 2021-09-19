using System;

namespace ex1
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Enter a comma-separate numbers to find the smallest number: ");
            Smallest(Array.ConvertAll(Console.ReadLine().Trim().Split(", "), int.Parse));
            return 0;
        }

        private static void Smallest(int[] numbers)
        {
            int small = 0;
            //for (int i = 1; i < numbers.Length; i++) <-- It must start at zero
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] < small)
                    small = numbers[i];
            Console.WriteLine(numbers.Length > 0 ? $"Smallest is: {small}" : "There's no elements");
        }
    }
}
