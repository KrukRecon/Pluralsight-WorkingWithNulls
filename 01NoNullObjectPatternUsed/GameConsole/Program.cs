using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter sarah = new(new DiamondSkinDefence())
            {
                Name = "Sarah"            
            };

            PlayerCharacter amrit = new(new IronBonesDefence())
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new(new NullDefence())
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);


            Console.ReadLine();
        }
    }
}
