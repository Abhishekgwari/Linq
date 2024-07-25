using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Linq1
    {
        static void Main(string[] args)
        {
            int[] arr = { 34, 56, 55, 45, 67, 41, 30, 45, 23, 35, 60, 80, 90, 100, 5, 45, 78, 22, 34, 11 };

            //  var brr = from i in arr select i;
            //  var brr = from i in arr where i > 40 select i;

            //  var brr = from i in arr where i > 40 orderby i select i;

            var brr = from i in arr where i > 40 orderby i descending select i;

            foreach (int x in brr)
                Console.WriteLine(x + " ");

        }
    }
}