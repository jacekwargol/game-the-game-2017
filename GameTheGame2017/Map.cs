using System;
using System.Collections.Generic;
using OpenTK.Graphics;



namespace GameTheGame2017 {
    class Map {
        public Map(int width, int height, int wallPercentage = 50) {
            this.width = width;
            this.height = height;
            this.wallsPercentage = wallPercentage;

            tiles = new Tile[width, height];
            GenerateMap();
        }

        public Tile GetTile(int x, int y) => tiles[x, y];
        public void SetTile(char ch, int x, int y) => tiles[x, y] = new Tile(ch);
        public void SetTile(char ch, Color4 color, int x, int y)
            => tiles[x, y] = new Tile(ch, color);

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
                            tilesType["wall"].Color);
                    }
                    else {
                        tiles[x, y] = new Tile(tilesType["floor"].Symbol,
                            tilesType["floor"].Color);
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
    }
}
