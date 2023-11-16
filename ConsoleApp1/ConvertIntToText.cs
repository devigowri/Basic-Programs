using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConvertIntToText
    {
        public static void Converttostring()
        {
            Console.WriteLine("Enter a number that retuns as text");
            int num= Convert.ToInt32(Console.ReadLine());
           switch (num)
            {
                case 0: Console.WriteLine("Zero");
                break;
                case 1: Console.WriteLine("one");
                break;
                case 2:
                Console.WriteLine("Two");
                break;
                case 3:
                Console.WriteLine("Three");
                break;
                case 4:
                 Console.WriteLine("Four");
                 break;
                case 5:
                 Console.WriteLine("Five");
                 break;
            }

              
           
        }
    }
}
