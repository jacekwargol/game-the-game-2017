using System;
using System.Collections.Generic;
using GameTheGame2017.Utils;
using OpenTK.Graphics;
using OpenTK.Input;

namespace GameTheGame2017 {
    class Game {
        public static void Main() {

            var rng = new Random();
            
            for(int i = 0; i < 1; i++) {
                GameObjects.Add(new Andrzej(new Vector2(rng.Next(1, 49), rng.Next(1, 49)), '%', Color4.Red));
            }

            while((GameWindow.Window.GetKey() != Key.Escape) && GameWindow.Window.WindowUpdate()) {
                Map.PrintMap();

                Player.Draw();
                KeyboardMovement();

                foreach(var gameObject in GameObjects) {
                    gameObject.Draw();
                    if(Player.DidMove) {
                        (gameObject as IMovable)?.Move(Player);
                    }
                }

                Player.DidMove = false;
            }
        }

        public static Map Map { get; } = new Map(GameWindow.Height, GameWindow.Width, 30);
        public static List<GameObject> GameObjects { get; } = new List<GameObject>();
        public static Player Player { get; } = new Player(new Vector2(1, 1), '@', Color4.Yellow);


        private static void KeyboardMovement() {
            switch(GameWindow.Window.GetKey()) {
                case Key.Up:
                    Player.Move(new Vector2(Player.Pos.X - 1, Player.Pos.Y));
                    break;
                case Key.Down:
                    Player.Move(new Vector2(Player.Pos.X + 1, Player.Pos.Y));
                    break;
                case Key.Left:
                    Player.Move(new Vector2(Player.Pos.X, Player.Pos.Y - 1));
                    break;
                case Key.Right:
                    Player.Move(new Vector2(Player.Pos.X, Player.Pos.Y + 1));
                    break;
            }
        }
    }
}
