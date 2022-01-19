using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem2._0
{
    class Program
    {
        static bool isAlive;

        static void Main(string[] args)
        {         
            PlayerCharacter playerCharacter = new PlayerCharacter();
            DrawHUD playerHUD = new DrawHUD();

            while (isAlive = true)
            {            
                playerCharacter.TEMPHUD();
                playerCharacter.TakeDamage(45);
                playerCharacter.RegenerateShield(10);

                if (playerCharacter.currentLives == 0)
                {
                    isAlive = false;
                }

                Console.ReadKey(true);
            }       

            Console.ReadKey();

        }

    }
}
