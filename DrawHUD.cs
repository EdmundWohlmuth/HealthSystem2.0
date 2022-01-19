using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem2._0
{
    class DrawHUD
    {
        PlayerCharacter playerCharacter = new PlayerCharacter();

        public void DRAWHUD()
        {
            Console.WriteLine("===============");
            Console.WriteLine("Health: " + playerCharacter.currentHealth + "/" + playerCharacter.maxHealth);
            Console.WriteLine("Shield: " + playerCharacter.currentShield + "/" + playerCharacter.maxShield);
            Console.WriteLine("Lives: " + playerCharacter.currentLives + "/" + playerCharacter.maxLives);
            Console.WriteLine("===============");
        }

    }



}
