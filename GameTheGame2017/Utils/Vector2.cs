using System;
using System.Runtime.InteropServices;

namespace GameTheGame2017.Utils {
    class Vector2 : IEquatable<Vector2> {
        public Vector2(int x = 0, int y = 0) {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static Vector2 Zero => new Vector2();
        public static Vector2 One => new Vector2(1, 1);

        public static Vector2 Left => new Vector2(-1);
        public static Vector2 Right => new Vector2(1);
        public static Vector2 Up => new Vector2(0, -1);
        public static Vector2 Down => new Vector2(0, 1);

        public static Vector2[] Directions => new[] {Left, Right, Up, Down};

        public bool Equals(Vector2 other) {
            if(ReferenceEquals(null, other)) return false;
            if(ReferenceEquals(this, other)) return true;
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj) {
            if(ReferenceEquals(null, obj)) return false;
            if(ReferenceEquals(this, obj)) return true;
            if(obj.GetType() != this.GetType()) return false;
            return Equals((Vector2)obj);
        }

        public override int GetHashCode() {
            unchecked {
                return (X * 397) ^ Y;
            }
        }

        public static bool operator ==(Vector2 a, Vector2 b) => a.X == b.X && a.Y == b.Y;

        public static bool operator !=(Vector2 a, Vector2 b) => a.X != b.X || a.Y != b.Y;

        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.X + b.X, a.Y + b.Y);

        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.X - b.X, a.Y - b.Y);

        public static double DistanceBetween(Vector2 a, Vector2 b) => a.DistanceTo(b);
          
        public double DistanceTo(Vector2 other)
            => Math.Sqrt((X + other.X) * (X + other.Y) + (Y + other.Y) * (Y + other.Y));

        public static int DistanceTaxiBetween(Vector2 a, Vector2 b) => a.DistanceTaxiTo(b);

        public int DistanceTaxiTo(Vector2 other)
            => Math.Abs(X - other.X) + Math.Abs(Y - other.Y);
    }
}
