using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
using OpenTK.Graphics;

namespace GameTheGame2017 {
    class Game {
        public static void Main() {
            while((GameWindow.window.GetKey() != Key.Escape) && GameWindow.window.WindowUpdate()) {
                map.PrintMap();
                GameWindow.window.Write(player.PosY, player.PosX, player.Tile.Symbol, player.Tile.Color);
                KeyboardMovement();
            }
        }


        private static void KeyboardMovement() {
            switch(GameWindow.window.GetKey()) {
                case Key.Up:
                    player.PosY -= 1;
                    break;
                case Key.Down:
                    player.PosY += 1;
                    break;
                case Key.Left:
                    player.PosX -= 1;
                    break;
                case Key.Right:
                    player.PosX += 1;
                    break;
            }
        }

        private static Actor player = new Actor(1, 1, '@', Color4.YellowGreen);
        private static Map map = new Map(50, 50, 30);
    }
}
