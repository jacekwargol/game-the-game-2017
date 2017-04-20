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

            Random rng = new Random();
            
            for(int i = 0; i < 10; i++) {
                actors.Push(new Andrzej(new int[] { rng.Next(1, 49), rng.Next(1, 49) }, '%', Color4.Red));
            }

            while((GameWindow.window.GetKey() != Key.Escape) && GameWindow.window.WindowUpdate()) {
                map.PrintMap();

                player.Draw();
                KeyboardMovement();

                foreach(var actor in actors) {
                    actor.Draw();
                    if(player.DidMove) {
                        if(actor is IMovable) {
                            ((IMovable)actor).Move();
                        }

                    }
                }

                player.DidMove = false;
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

        private static Player player = new Player(new int[] { 1, 1 }, '@', Color4.Yellow);
        private static Map map = new Map(50, 50, 30);
        private static Stack<Actor> actors = new Stack<Actor>();
    }
}
