using System.Collections.Generic;
using GameTheGame2017.Components;
using GameTheGame2017.Utils;
using OpenTK.Graphics;

namespace GameTheGame2017 {
    class Player : Actor {
        public LivingComponent LivingComponent { get; set; }

        public Player(Vector2 pos, char symbol, int health = 10) : base(pos, symbol) {
            LivingComponent = new LivingComponent(health);
        }

        public Player(Vector2 pos, char symbol, Color4 color, int health = 10) : base(pos, symbol, color) {
            LivingComponent = new LivingComponent(health);
        }

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
