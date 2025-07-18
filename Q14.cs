using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_BHUMI_MA_M
{
    internal class Q14
    {
        static void Main(string[] args)
        {
            string[] arr = { " ZERO ", " ONE "," TWO "," THREE "," FOUR "," FIVE "," SIX "," SEVEN "," EIGHT "," NINE "};
            Console.Write("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int newNum = 0;
            string output = "";
            //reverse the number
            while (num > 0)
            {
                int temp = num % 10;
                if(temp == 0)
                {
                    output += "0";
                }
                newNum = newNum * 10 + temp;
                output += newNum;
                num /= 10;
            }
            Console.Write(output);
            //printing from reverse number 
            /*
             num = 98732  -> newNum = 23789
            newNum % 10 = 9 NINE 23789/10 = 2378
            newNum % 10 = 8 EIGHT 2378/10 = 237
            newNum % 10 = 7 SEVEN 237/10 = 23
            newNum % 10 = 3 THREE 23/10 = 2
            newNum % 10 = 2 TWO  2/10 = 0
             */
            while (newNum > 0)
            {

                int temp = newNum % 10;
                //switch (temp)
                //{
                //    case 0: Console.Write(" ZERO "); break;
                //    case 1: Console.Write(" ONE "); break;
                //    case 2: Console.Write(" TWO "); break;
                //    case 3: Console.Write(" THERE "); break;
                //    case 4: Console.Write(" FOUR "); break;
                //    case 5: Console.Write(" FIVE "); break;
                //    case 6: Console.Write(" SIX "); break;
                //    case 7: Console.Write(" SEVEN "); break;
                //    case 8: Console.Write(" EIGHT "); break;
                //    case 9: Console.Write(" NINE "); break;
                //}
                Console.Write(arr[temp]);
                newNum /= 10;
            }
        }
    }
}
