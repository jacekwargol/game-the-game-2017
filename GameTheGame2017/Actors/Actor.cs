using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Actor : GameObject {
        public Actor(int[] pos, char symbol) : base(pos, symbol) { }

        public Actor(int[] pos,  char symbol, Color4 color) : base(pos, symbol, color) { }


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


    }
}
