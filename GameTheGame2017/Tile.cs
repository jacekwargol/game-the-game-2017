using System;
using System.Linq;
using OpenTK.Graphics;

namespace GameTheGame2017 {
    struct Tile {
        public Tile(char symbol, Color4 color, Types type) {
            Symbol = symbol;
            Color = color;
            Type = type;
        }

        public char Symbol { get; set; }
        public Color4 Color { get; set; }
        public bool IsBLocking => (Enum.GetNames(typeof(BlockingTypes)).Contains(Type.ToString()));

        public Types Type { get; }

        public enum Types {
            Wall,
            Floor,
            Actor
        }


        private enum BlockingTypes {
            Wall,
            Actor
        }
    }
}
