using System;
using System.Collections.Generic;
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

        public Tile GetTile(int[] pos) => tiles[pos[0], pos[1]];
        public void SetTile(char ch, int[] pos) => tiles[pos[0], pos[1]] = new Tile(ch, Color4.White);
        public void SetTile(char ch, int[] pos, Color4 color, bool isBlocking)
            => tiles[pos[0], pos[1]] = new Tile(ch, color, true);

        public int FillPercentage { get; set; }

        public void PrintMap() {
            for(int x = 0; x < width; x++) {
                for(int y = 0; y < height; y++) {
                    GameWindow.window.Write(x, y, tiles[x, y].Symbol, tiles[x, y].Color);
                }
            }
        }


        private void GenerateMap() {
            Random rng = new Random();
            int minRoomLength = 10;
            int maxRoomLength = 20;

            int noRooms = rng.Next(5, 10);

            int roomWidth = rng.Next(minRoomLength, maxRoomLength);
            int roomHeight = rng.Next(minRoomLength, maxRoomLength);

            GenerateRoom(0, 0, width, height);
        }

        private void GenerateRoom(int posX, int posY, int width, int height) {
            Tile[,] room = new Tile[width, height];
            for(int x = 0; x < width; x++) {
                for(int y = 0; y < width; y++) {
                    if(x == 0 || x == width - 1 || y == 0 || y == height - 1) {
                        tiles[x, y] = new Tile(tilesType["wall"].Symbol,
                            tilesType["wall"].Color, true);
                    }
                    else {
                        tiles[x, y] = new Tile(tilesType["floor"].Symbol,
                            tilesType["floor"].Color, false);
                    }
                }
            }
        }


        private Tile[,] tiles;
        private int width;
        private int height;
        private int wallsPercentage;

        private Dictionary<string, Tile> tilesType = new Dictionary<string, Tile>() {
            { "wall", new Tile('#', Color4.DarkBlue) },
            { "floor", new Tile('.', Color4.White) },
        };

        private enum blockingTiles { wall } 
    }
}
