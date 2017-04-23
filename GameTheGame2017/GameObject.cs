using GameTheGame2017.Utils;
using OpenTK.Graphics;

namespace GameTheGame2017
{
    class GameObject {
        public GameObject(Vector2 pos, char symbol) {
            Pos = pos;
            tile = new Tile(symbol, Color4.White, Tile.Types.Actor);
        }

        public GameObject(Vector2 pos, char symbol, Color4 color) {
            Pos = pos;
            tile = new Tile(symbol, color, Tile.Types.Actor);
        }

        public Vector2 Pos { get; set; }

        public Tile Tile => tile;

        public void Draw() => GameWindow.Window.Write(Pos.X, Pos.Y, Tile.Symbol, Tile.Color);


        protected Tile tile;
    }
}
