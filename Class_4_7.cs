using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_BHUMI_MA_M
{
    internal class Class_4_7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int a = int.Parse(Console.ReadLine());  
            Console.Write("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum of {a} and {b} is : {a + b}");

        }
    }
}
