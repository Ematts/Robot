using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{ class Catbot : Robot
{
    public int scratch;
    Random rnd = new Random();
        public int catDamage;

    public Catbot(string Name)
    {
        name = Name;
        design = "Cat";
        hitPoints = 10;
        scratch = rnd.Next(0, 9);

    }

    public int scratchDamage()
    {
        int y = rnd.Next(0, 9);
        int catDamage = y;

        return catDamage;
    }
}

    }
