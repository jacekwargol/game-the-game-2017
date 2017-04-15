using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;


namespace GameTheGame2017 {
    class Tile {
        public Tile(char symbol) {
            Symbol = symbol;
            Color = Color4.White;
        }

        public Tile(char symbol, Color4 color) {
            Symbol = symbol;
            Color = color;
        }

        public char Symbol { get; set; }
        public Color4 Color { get; set; }
    }
}
