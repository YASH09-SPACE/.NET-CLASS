using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_BHUMI_MA_M
{
    internal class Q2_UserDetails
    {
        static void Main(String[] args)
        {
            Console.Write("Enter your name : ");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter like this DOB: 15 / 10 / 1991");
            Console.Write("Enter your DOB : ");
            String dob = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter your address : ");
            String address = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter your city : ");
            String city = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter your pincode : ");
            String pincode = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter your state : ");
            String state = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter your country : ");
            String country = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter your gmail : ");
            String gmail = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Your Details are : ");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"DOB : {dob}");
            Console.WriteLine($"Address : {address}");
            Console.WriteLine($"City : {city}");
            Console.WriteLine($"Pincode : {pincode}");
            Console.WriteLine($"State : {state}");
            Console.WriteLine($"Country : {country}");
            Console.WriteLine($"Gmail : {gmail}");
            Console.WriteLine();

        }
    }
}
