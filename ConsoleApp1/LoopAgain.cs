using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LoopAgain
    {
        public static void ConfirmYesNo(string confirmagain)
        {
            string cnfm = confirmagain;
            if (cnfm == "yes")
            {
                Console.WriteLine(cnfm.ToUpper());
                Console.WriteLine("Enter a num:");
                int num = Convert.ToInt32(Console.ReadLine());
                HelloWorld.Firstcall(num);
            }

        }
    }
}
