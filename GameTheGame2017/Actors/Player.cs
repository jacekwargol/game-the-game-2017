using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    // While Player is of course Movable Actor, due to keyboard control it handles moves differently
    // (i.e. Move method takes a newPos parameter, while in other Actors newPos will be calculated inside
    // Move() itself), so it won't implement IMovable Interface

    class Player : Actor {
        public Player(int[] pos, char symbol) : base(pos, symbol) { DidMove = false; }

        public Player(int[] pos, char symbol, Color4 color) : base(pos, symbol, color) { DidMove = false; }

        public bool DidMove { get; set; }

        public bool Move(int[] newPos) {
            Tile target = Game.Map.GetTile(newPos);

            if(target.IsBLocking) {
                return false;
            }

            pos = newPos;
            DidMove = true;
            return true;
        }
    }
}
