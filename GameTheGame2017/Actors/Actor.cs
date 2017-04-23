using GameTheGame2017.Utils;
using OpenTK.Graphics;

namespace GameTheGame2017 {
    class Actor : GameObject {
        public Actor(Vector2 pos, char symbol) : base(pos, symbol) { }

        public Actor(Vector2 pos,  char symbol, Color4 color) : base(pos, symbol, color) { }
    }
}
