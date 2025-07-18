using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_BHUMI_MA_M
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your mobile number: ");
            string mobileNumber = Console.ReadLine();
            if (mobileNumber.Length == 10)
            {
                string Number = mobileNumber.Substring(0, mobileNumber.Length - 5) + "XXXXX";
                Console.WriteLine($"Mobile Number: {Number}");
            }
            else
            {
                Console.WriteLine("Mobile number is too short.");
            }
        }
    }
}
