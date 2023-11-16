using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
 
    public class OddOrEven
    {

        public static void Findoddeven(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                var x = i % 2 == 0 ? "even" : "odd";
                Console.WriteLine(x);


            }


        }


    }
}
