using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class ConfirmFromUser
    {
        public static void confirm(string ok)
        {
            var x = ok == "yes" ? "yes" : "no";
           LoopAgain.ConfirmYesNo(x);
        }
    }
}
