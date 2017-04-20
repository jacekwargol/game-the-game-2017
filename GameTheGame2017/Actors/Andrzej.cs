using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Andrzej : Actor, IMovable {
        public Andrzej(int[] pos, char symbol) : base(pos, symbol) { }

        public Andrzej(int[] pos, char symbol, Color4 color) : base(pos, symbol, color) { }

        public void Move() {
            int[] newPos = new int[2];
            Random rng = new Random();
            newPos[0] = pos[0] + rng.Next(-1, 2);
            newPos[1] = pos[1] + rng.Next(-1, 2);
            while(Game.Map.GetTile(newPos).IsBLocking) {
                newPos[0] = pos[0] + rng.Next(-1, 2);
                newPos[1] = pos[1] + rng.Next(-1, 2);
            }

            pos = newPos;
        }
    }
}
