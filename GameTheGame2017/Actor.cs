using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Actor {
        public Actor(int[] pos, int damage, char symbol) {
            Pos = pos;
            Damage = damage;
            tile = new Tile(symbol, Color4.White, Tile.Types.ACTOR);
        }

        public Actor(int[] pos, int damage, char symbol, Color4 color) {
            Pos = pos;
            Damage = damage;
            tile = new Tile(symbol, color, Tile.Types.ACTOR);
        }

        public int[] Pos { get => pos; set => pos = value; }

        public Tile Tile { get => tile; }

        public int Health {
            get => health;
            set {
                health = value;
                if(health <= 0) {
                    Kill();
                }
            }
        }

        public int Damage { get; set; }


        public void Kill() {
            isDead = true;
        }

        public bool IsDead { get; }

        public bool Move(int[] newPos) {
            Tile target = Game.Map.GetTile(newPos);

            if(target.IsBLocking) {
                return false;
            }

            pos = newPos;
            return true;
        }

        public void TakeDamage(int amount) {
            Health -= amount;
        }

        public void DealDamage(Actor actor) {
            actor.TakeDamage(Damage);
        }


        private int[] pos;
        private Tile tile;
        private int health;
        private bool isDead = false;
    }
}
