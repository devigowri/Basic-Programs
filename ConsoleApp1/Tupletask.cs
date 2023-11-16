using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tupletask
{
    
   interface Ituple
    {
       
        public void Numbers();
        public void personsdictionary();

    }
    public class Tuplees : Ituple
    {
        
        public void Numbers()
        {
            //List<Tuple<int, string, string>> person = new List<Tuple<int, string, string>>();
            Tuple<int, string, string> persons = Tuple.Create(1, "vasu","gowri");
            
            
            Console.WriteLine(persons); 

        }

        public void personsdictionary()
        {
            Console.WriteLine("Enter a number:");
            int num= Convert.ToInt32(Console.ReadLine());        
            Dictionary<int, string> persons = new Dictionary<int, string>();
            persons.Add(1, "xxxxx");
            persons.Add(2, "yyyy");
            persons.Add(3, "zzzz");
            var person = persons.Where(x => x.Key ==num);
            
            foreach(var obj in person)
            {
                Console.WriteLine("Hey"+obj.Value);
            }
           
        }


    }

       

    
}
