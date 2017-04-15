using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Actor {
        public Actor(int posX, int posY, char symbol) {
            this.posX = posX;
            this.posY = posY;
            tile = new Tile(symbol, Color4.White);
        }

        public Actor(int posX, int posY, char symbol, Color4 color) {
            this.posX = posX;
            this.posY = posY;
            tile = new Tile(symbol, color);
        }

        public int PosX {
            get => posX;
            set => posX = value;
        }
        public int PosY {
            get => posY;
            set => posY = value;
        }

        public Tile Tile {
            get => tile;
        }


        private int posX;
        private int posY;
        private Tile tile;
    }
}
