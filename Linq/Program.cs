using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{                              // Using linq we can write queries on  a wide variety of data sources
                               // like  Array collections  Database ,Dataset,XmlData
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 34, 56, 55, 45, 67, 41, 30, 45, 23, 35, 60, 80, 90, 100, 5, 45, 78, 22, 34, 11 };


            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                    count += 1;
            }
            int[] brr = new int[count];
            int Index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                {
                    brr[Index] = arr[i];
                    Index++; // Increment Index here
                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);

            foreach (int i in brr)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
