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
                GameWindow.window.Write(player.Pos[0], player.Pos[1], player.Tile.Symbol, player.Tile.Color);
                KeyboardMovement();
            }
        }

        public static Map Map { get => map; }


        private static void KeyboardMovement() {
            switch(GameWindow.window.GetKey()) {
                case Key.Up:
                    player.Move(new int[] { player.Pos[0] - 1, player.Pos[1] });
                    break;
                case Key.Down:
                    player.Move(new int[] { player.Pos[0] + 1, player.Pos[1] });
                    break;
                case Key.Left:
                    player.Move(new int[] { player.Pos[0], player.Pos[1] - 1 });
                    break;
                case Key.Right:
                    player.Move(new int[] { player.Pos[0], player.Pos[1] + 1 });
                    break;
            }
        }

        private static Actor player = new Actor(new int[] { 1, 1 }, 10, '@', Color4.Yellow);
        private static Map map = new Map(50, 50, 30);
    }
}
