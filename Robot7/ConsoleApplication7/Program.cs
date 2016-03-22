using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogbot rex = new Dogbot("Rex");
            rex.biteDamage();
            
      
            Thread.Sleep(123);

            Catbot spot = new Catbot("Spot");

            spot.scratchDamage();




            Console.WriteLine("Rex did " + dogDamage + " damage!");
            Console.WriteLine("Spot did " + spot.scratchDamage() + " damage!");

            if (rex.biteDamage() > spot.scratchDamage())
                {
                Console.WriteLine("Dogbot wins");
                }

            else if (rex.biteDamage() < spot.scratchDamage())
                {
                Console.WriteLine("Catbot wins");
                }
            else
                {
                Console.WriteLine("It's a tie");
                }
        
            Console.Read();
           

        }
    }
}
