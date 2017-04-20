using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Actor {
        public Actor(int[] pos, char symbol) {
            Pos = pos;
            tile = new Tile(symbol, Color4.White, Tile.Types.ACTOR);
        }

        public Actor(int[] pos,  char symbol, Color4 color) {
            Pos = pos;
            tile = new Tile(symbol, color, Tile.Types.ACTOR);
        }

        public int[] Pos { get => pos; set => pos = value; }
        public Tile Tile { get => tile; }

        public void Draw() {
            GameWindow.window.Write(pos[0], pos[1], Tile.Symbol, Tile.Color);
        }

        //public int Health {
        //    get => health;
        //    set {
        //        health = value;
        //        if(health <= 0) {
        //            Kill();
        //        }
        //    }
        //}

        //public int Damage { get; set; }


        //public void Kill() {
        //    isDead = true;
        //}

        //public bool IsDead { get; }

        //public void TakeDamage(int amount) {
        //    Health -= amount;
        //}

        //public void DealDamage(Actor actor) {
        //    actor.TakeDamage(Damage);
        //}


        protected int[] pos;
        protected Tile tile;
    }
}
