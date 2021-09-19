using System;

namespace ex1
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Enter a comma-separate numbers to find the smalles positive not present: ");
            Solution(Array.ConvertAll(Console.ReadLine().Split(", "), int.Parse));
            return 0;
        }

        private static void Solution(int[] vs)
        {
            Array.Sort(vs);

            int higher = vs.Length, min = Math.Max(vs[0], 1), max = Math.Max(vs[higher -1], 1);

            if (min - 1 >= 1)
            {
                Console.WriteLine($"It's {min - 1}");
                return;
            }

            for (int i = 1; i < max; i++)
            {
                if(i > min && !Array.Exists(vs, el => el == i))
                {
                    Console.WriteLine($"It's {i}");
                    return;
                }
            }
            
            Console.WriteLine($"It's {(max == 1 ? 1 : max + 1)}");
        }
    }
}
