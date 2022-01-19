using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem2._0
{  
    class PlayerCharacter
    {

        public int maxHealth;
        public int currentHealth;

        public int maxShield;
        public int currentShield;

        public int damage;

        public PlayerCharacter()
        {
            maxHealth = 100;
            currentHealth = 100;

            maxShield = 50;
            currentShield = 50;
        }

    }
}
