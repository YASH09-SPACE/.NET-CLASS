using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_BHUMI_MA_M
{
    internal class FirstProgram
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("This is my first program in C#.");
            //Console.ReadLine(); // Wait for user input before closing the console window
            Console.Write("enter the num : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0;i <= n;i++)
            //{
            //    for(int j = 0;j < 3;j++)
            //    {
            //        if(j == 1 && i != 0)
            //        {
            //            Console.Write(i+" ");
            //        }
            //        else
            //        {
            //            Console.Write(n+" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            /*
              
             *
             # *
             * # *
             # * # *

             */

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("* ");
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("# ");
                        }
                    }
                }
                else
                {
                    Console.Write("# ");
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("# ");
                        }
                        else
                        {
                            Console.Write("* ");
                        }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
