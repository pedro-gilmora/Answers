using System;

namespace ex1
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Enter a comma-separate numbers to find the smallest positive not present: ");
            Console.WriteLine($"Answer: {Solution(Array.ConvertAll(Console.ReadLine().Split(", "), int.Parse))} is the smallest not listed");
            return 0;
        }

        private static int Solution(params int[] arr)
        {
            int len = arr.Length, max = 0;
            //sort the array and find the minimum positive and maximum
            for (int i = 0, temp; i < len; max = Math.Max(max, arr[i]), i++
            )
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

            for (int j = 0; j < len; j++) //i => current | j => next								  
                if (j + 1 < len && arr[j + 1] > 1 && arr[j + 1] - arr[j] > 1)//if next is positive and next - current > 1
                    return arr[j] < 0 ? arr[j + 1] - 1 : arr[j] + 1;//if current is negative then next - 1, else current + 1

            return max > -1 ? max + 1 : 1;//if minimum positive > 1 then 1 else if max is not negative then max + 1 else 1 
        }
    }
}
