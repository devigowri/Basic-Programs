using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operations
    {
        public static void operationadd()
        {
            Console.WriteLine("---Arithmatic Operations----");
            Console.WriteLine("Enter 1st Num:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Num:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("operation name:");
            string userinput = Convert.ToString(Console.ReadLine()); 
            switch(userinput)
            {
                case "add":
                    Console.WriteLine(num1 + num2);
                    break;

                case "Sub":
                    Console.WriteLine(num1 - num2);
                    break;

                case "mul":
                    Console.WriteLine(num1 * num2);
                    break;

                case "Div":
                    Console.WriteLine(num1/num2);
                    break;
                    
                default:
                    Console.WriteLine("thankyou");
                    break;
                        
            }
           
            
        }

        public static void commasepration()
        {
            Console.WriteLine("---Comma Separation----");
            Console.WriteLine("How many numbers you want to add?");
            string numbers =Console.ReadLine();
            Console.WriteLine("Enter" + numbers + "number");
            string[] seprate = numbers.Split(',');
            
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num} ");
            }
           


        }

      


    }
}
