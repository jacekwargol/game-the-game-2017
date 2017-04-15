using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Tile {
        public Tile(char symbol, Color4 color, bool isBlocking = true) {
            Symbol = symbol;
            Color = color;
            IsBLocking = isBlocking;
        }

        public char Symbol { get; set; }
        public Color4 Color { get; set; }
        public bool IsBLocking { get;  }
    }
}
