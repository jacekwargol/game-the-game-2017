﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Actor {
        public Actor(int[] pos, char symbol) {
            Pos = pos;
            tile = new Tile(symbol, Color4.White);
        }

        public Actor(int[] pos, char symbol, Color4 color) {
            Pos = pos;
            tile = new Tile(symbol, color);
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

        public void Kill() {
            isDead = true;
        }

        public bool IsDead { get; }

        public bool Move(int[] newPos) {
            if(Game.Map.GetTile(newPos).IsBLocking) {
                return false;
            }

            pos = newPos;
            return true;
        }



        private int[] pos;
        private Tile tile;
        private int health;
        private bool isDead = false;
    }
}
