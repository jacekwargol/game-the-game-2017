using System.Collections.Generic;
using GameTheGame2017.Utils;
using OpenTK.Graphics;

namespace GameTheGame2017 {
    class Map {
        public Map(int width, int height, int wallsPercentage = 50) {
            this.width = width;
            this.height = height;
            this.wallsPercentage = wallsPercentage;

            tiles = new Tile[width, height];
            GenerateMap();
        }

        public Tile GetTile(Vector2 pos) => tiles[pos.X, pos.Y];
        public void SetTile(char ch, Vector2 pos, Tile.Types type)
            => tiles[pos.X, pos.Y] = new Tile(ch, Color4.White, type);

        public void SetTile(char ch, int[] pos, Color4 color, Tile.Types type)
            => tiles[pos[0], pos[1]] = new Tile(ch, color, type);

        public int FillPercentage { get; set; }

        public void PrintMap() {
            for(int x = 0; x < width; x++) {
                for(int y = 0; y < height; y++) {
                    GameWindow.Window.Write(x, y, tiles[x, y].Symbol, tiles[x, y].Color);
                }
            }
        }


        private void GenerateMap() {
            GenerateRoom(new Vector2(), width, height);
        }

        private void GenerateRoom(Vector2 pos, int width, int height) {
            Tile[,] room = new Tile[width, height];
            for(int x = 0; x < width; x++) {
                for(int y = 0; y < height; y++) {
                    if(x == 0 || x == width - 1 || y == 0 || y == height - 1) {
                        tiles[x, y] = tilesType["wall"];
                    }
                    else {
                        tiles[x, y] = tilesType["floor"];
                    }
                }
            }
        }


        private Tile[,] tiles;
        private int width;
        private int height;
        private int wallsPercentage;

        private Dictionary<string, Tile> tilesType = new Dictionary<string, Tile> {
            { "wall", new Tile('#', Color4.DarkBlue, Tile.Types.Wall) },
            { "floor", new Tile('.', Color4.White, Tile.Types.Floor) }
        };

        private enum BlockingTiles { Wall } 
    }
}
