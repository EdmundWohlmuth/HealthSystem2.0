using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem2._0
{
    class Program
    {    
        static void Main(string[] args)
        {
            PlayerCharacter playerCharacter = new PlayerCharacter();
            DrawHUD playerHUD = new DrawHUD();

            playerHUD.DRAWHUD();

            Console.ReadKey();

        }


    }
}
