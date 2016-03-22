using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Dogbot : Robot
    {
        public int bite;
        Random rnd = new Random();
        public int dogDamage;

        public Dogbot(string Name)
        {
            name = Name;
            design = "Dog";
            hitPoints = 10;
            bite = rnd.Next(0, 9);

        }

        public int biteDamage()
        {
            int x = rnd.Next(0, 9);
            int dogDamage = x;

            return dogDamage;
        }

    }
}
