using System;
using GameTheGame2017.Utils;
using OpenTK.Graphics;

namespace GameTheGame2017 {
    class Andrzej : Actor, IMovable {
        public Andrzej(Vector2 pos, char symbol) : base(pos, symbol) { }

        public Andrzej(Vector2 pos, char symbol, Color4 color) : base(pos, symbol, color) { }

        public void Move(GameObject target) {
            var newPos = Pos;
            var minDist = newPos.DistanceTaxiTo(target.Pos);

            for (int i = 0; i < 4; i++) {
                var currDist = Vector2.DistanceTaxiBetween(Pos + Vector2.Directions[i], target.Pos);
                if (!(currDist < minDist) || IsCollision(Pos + Vector2.Directions[i])) {
                    continue;
                }

                minDist = currDist;
                newPos = Pos + Vector2.Directions[i];
            }

            Pos = newPos;
        }


        private static bool IsCollision(Vector2 pos) {
            if (Game.Map.GetTile(pos).IsBLocking || Game.Player.Pos == pos) {
                return true;
            }

            foreach (var gameObject in Game.GameObjects) {
                if (gameObject.Pos == pos) {
                    return true;
                }
            }

            return false;
        }
    }
}
