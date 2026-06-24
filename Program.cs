using System;

namespace practice_5
{
     class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of array : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i=0; i<n; i++)
            {
                Console.Write($"Enter the element No. {i + 1} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the element to search for : ");
            int s = int.Parse(Console.ReadLine());

            bool found = false;

            foreach (int t in arr)
            {
                if(t == s)
                {
                    found = true;
                    break;
                }
            }
            if(found)
            {
                Console.WriteLine("Item found ");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}
