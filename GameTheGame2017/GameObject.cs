using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017
{
    class GameObject {
        public GameObject(int[] pos, char symbol) {
            Pos = pos;
            tile = new Tile(symbol, Color4.White, Tile.Types.ACTOR);
        }

        public GameObject(int[] pos, char symbol, Color4 color) {
            Pos = pos;
            tile = new Tile(symbol, color, Tile.Types.ACTOR);
        }

        public int[] Pos { get; set; }

        public Tile Tile => tile;

        public void Draw() => GameWindow.window.Write(Pos[0], Pos[1], Tile.Symbol, Tile.Color);


        protected Tile tile;
    }
}
