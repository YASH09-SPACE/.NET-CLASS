using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//yash vyas
namespace CLASS_BHUMI_MA_M
{
    internal class Lab_Tutorial_1
    {
        static void Main(string[] args)
        {
            Q18();
        }
        static void Q1()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the C# Programming Language");
            Console.WriteLine("This is my first program in C#");
        }
        static void Q2()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your DOB (format: DD/MM/YYYY): ");
            string dob = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your pincode: ");
            string pincode = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your state: ");
            string state = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your country: ");
            string country = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.WriteLine();
            // Display the collected user details
            Console.WriteLine("Your Details are:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"DOB: {dob}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Pincode: {pincode}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Email: {email}");
        }
        static void Q3()
        {
            Console.Write("Enter Number: ");
            int a = int.Parse(Console.ReadLine());
            
            if(a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even number.");
            }
            else
            {
                Console.WriteLine($"{a} is an odd number.");
            }
        }

        static void Q4()
        {
            int x;

            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            x = Convert.ToInt32(str);

            if (x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");


           Console.Read();      
        }

        static void Q5()
        {
            int n, fact = 1;//decalre variables

            Console.WriteLine("Enter Number : ");//prompt user for input

            string str = Console.ReadLine();//read input from user

            n = Convert.ToInt32(str);//convert input to integer

            for (int i = 1; i <= n; i++)//loop from 1 to n

            {

                fact = fact * i;//calculate factorial

            }

            Console.WriteLine("Factorial : {0}", fact);//display factorial



            Console.Read();//wait for user input before closing the console
        }

        static void Q6()
        {
            int a, b, c, result;

            Console.Write("Enter Number   1: ");

            //Missing statement
            string str = Console.ReadLine();

            a = Convert.ToInt32(str);



            Console.Write("Enter Number  2 : ");

            //Missing statement
            string str1 = Console.ReadLine();

            b = Convert.ToInt32(str1);



            Console.Write("Enter Number   3 : ");

            str = Console.ReadLine();

            c = Convert.ToInt32(str);
            //Missing statement



            result = Sum(a, b, c);

            //Missing statement
            Console.WriteLine($"Sum of {a}, {b}, and {c} is: {result}");



            Console.Read();

        }

        static int Sum(int x, int y, int z)

        {

            int res;

            res = x + y + z;

            return res;
        }

        static void Q7()
        {
            int num1, res, i;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());


            i = 1; //Initialization



            //Check whether condition matches or not
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);

                i++; //Increment by one
            }
            Console.ReadLine();
        }

        //Write a program to convert given name in upper characters.
        static void Q8()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string upperName = name.ToUpper(); // Convert to uppercase
            Console.WriteLine($"Your name in uppercase is: {upperName}");
        }

        // Write a Program to convert given name in toggle case.
        static void Q9()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            StringBuilder toggleName = new StringBuilder();
            foreach (char c in name)
            {
                if (char.IsUpper(c))
                {
                    toggleName.Append(char.ToLower(c));
                }
                else if (char.IsLower(c))
                {
                    toggleName.Append(char.ToUpper(c));
                }
                else
                {
                    toggleName.Append(c); // Keep non-alphabetic characters unchanged
                }
            }
            Console.WriteLine($"Your name in toggle case is: {toggleName}");
        }

        // Write a Program which accepts mobile no as a string from the user and converts the last 5 digits into X.
        static void Q10()
        {
            Console.WriteLine("Enter your mobile number: ");
            string mobileNumber = Console.ReadLine();
            if (mobileNumber.Length >= 5)
            {
                string HideNumber = mobileNumber.Substring(0, mobileNumber.Length - 5) + "XXXXX";
                Console.WriteLine($"Masked Mobile Number: {HideNumber}");
            }
            else
            {
                Console.WriteLine("Mobile number is too short to mask.");
            }
        }

        // Write a Program which accepts name and gender from the user. Here, gender may have only 1 character, M or F.
        //Based on the gender prefix the name Mr. & Ms.

        static void Q11()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            

            string prefix = name.Substring(0,3);
            if (prefix == "Mr.")
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Gender: M");
            }
            else if (prefix == "Ms.")
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Gender : F");
            }
            else
            {
                Console.WriteLine("Invalid prefix. Please use 'Mr.' or 'Ms.'");
            }
        }

        static void Q12()
        {   
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is: " + name);
        }

        static void Q13(int n)
        { 
            int a = 0, b = 1, c;
            Console.Write("Fibonacci Series: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        static void Q14()
        {
            Console.Write("Enter NUmber : ");
            int n = Int32.Parse(Console.ReadLine());
            int newNum = 0;
            while (n > 0)
            {
                int temp = n % 10;
                newNum = newNum*10 + temp;
                n /= 10;
            }
            
            while (newNum > 0)
            {
                int temp = newNum % 10;
                switch (temp)
                {
                    case 0: Console.Write(" ZERO "); break;
                    case 1: Console.Write(" ONE "); break;
                    case 2: Console.Write(" TWO "); break;
                    case 3: Console.Write(" THERE "); break;
                    case 4: Console.Write(" FOUR "); break;
                    case 5: Console.Write(" FIVE "); break;
                    case 6: Console.Write(" SIX "); break;
                    case 7: Console.Write(" SEVEN "); break;
                    case 8: Console.Write(" EIGHT "); break;
                    case 9: Console.Write(" NINE "); break;
                }
                newNum /= 10;
            }
        }

        //15  Write a Program to check whether the given no is Armstrong no or not.
        static void Q15()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
         

            //finding digits
            int temp = n;
            int digits = 0;
            while (temp > 0)
            {   
                digits++;
                temp /= 10;
            }

            // Calculating the sum of the pow of digit of each digit
            int sum = 0;
            temp = n;   
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }
            // Checking if the sum is equal to the original number
            if (sum == n)
            {
                Console.WriteLine($"{n} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{n} is not an Armstrong number.");
            }
        }

        /* 16  Write a program to display a pattern like a right angle triangle using an asterisk

 The pattern like :

 *

 **

 ***

 *****/
        static void Q16()
        {
            Console.Write("Enter the number of rows for the triangle : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write('*'+" ");
                }
                Console.WriteLine();
            }
        }
        /*17. Write a Program to generate following output.

1

1 2

1 2 3

1 2 3 4*/
        static void Q17()
        {
            Console.Write("Enter the number of rows for the triangle : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        /*18 Write a program to make such a pattern like a right angle triangle with the number increased by 1.

The pattern like :

1  

2 3  

4 5 6  

7 8 9 10*/
        static void Q18()
        {
            Console.Write("Enter the number of rows for the triangle : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int num = 1; // Initialize the number to start from
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++; // Increment the number after printing
                }
                Console.WriteLine();
            }
        }
        /*19. Write a program to make such a pattern as a pyramid with an asterisk. 

   *   

  * *  

 * * *

* * * **/
        public static void Q19()
        {
            Console.Write("Enter the number of rows for the pyramid: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                // Print asterisks
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
