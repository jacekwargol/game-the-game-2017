using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTheGame2017.Components {
    class LivingComponent : BaseComponent {
        public LivingComponent(int health) {
            MaxHealth = health;
            Health = health;
        }

        public int Health {
            get => health;
            set {
                health = value;
                if (health <= 0) {
                    IsAlive = false;
                }
            }
        }

        public int MaxHealth { get; set; }
        public bool IsAlive { get; set; } = true;


        private int health;
    }


}
