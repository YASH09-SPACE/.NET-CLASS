using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_BHUMI_MA_M
{
    internal class BuiltInFunctions
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 5, 8, 86, 21, 7, 1, 26 };

            Console.WriteLine("Max Num : "+a.Max());
            Console.WriteLine("Min Num : " + a.Min());

            var reverse = a.Reverse();
            Console.Write("Reverse : ");
            foreach (var item in reverse)
            {
                Console.Write(item + " ");
            }
            Array.Sort(a);
            Console.WriteLine("\nSorted Array : ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

            int[] b = { 365, 15, 56, 656, 10, 58, 58, 51, 53, 45, 56 };
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (var item in b)
            {
                if(item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine("\nMin : " + min);
            Console.WriteLine("Max : " + max);
        }
    }
}
