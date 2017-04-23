using GameTheGame2017.Utils;
using OpenTK.Graphics;

namespace GameTheGame2017 {
    class Player : Actor {
        public Player(Vector2 pos, char symbol) : base(pos, symbol) { DidMove = false; }

        public Player(Vector2 pos, char symbol, Color4 color) : base(pos, symbol, color) { DidMove = false; }

        public bool DidMove { get; set; }

        public bool Move(Vector2 newPos) {
            DidMove = true;
            Tile target = Game.Map.GetTile(newPos);

            if(target.IsBLocking) {
                return false;
            }

            foreach (var gameObject in Game.GameObjects) {
                if (gameObject.Tile.IsBLocking && gameObject.Pos == newPos) {
                    return false;
                }
            }

            Pos = newPos;
            return true;
        }
    }
}
