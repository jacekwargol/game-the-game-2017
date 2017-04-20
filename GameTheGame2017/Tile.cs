using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public bool IsBLocking {
            get => (Enum.GetNames(typeof(BlockingTypes)).Contains(Type.ToString()));
        }
        
        public Types Type { get; }

        public enum Types {
            WALL,
            FLOOR,
            ACTOR
        }


        private enum BlockingTypes {
            WALL,
            ACTOR,
        }
    }
}
