namespace Engine.ConsoleEngine
{
    public struct Vector2
    {

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public int X;
        public int Y;
        
        public Vector2(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        
        public static Vector2 operator *(Vector2 a, int b)
            => new Vector2(a.X * b, a.Y * b);
        
        public static Vector2 operator +(Vector2 a, Vector2 b)
            => new Vector2(a.X + b.X, a.Y + b.Y);

        public static bool operator ==(Vector2 a, Vector2 b)
            => a.X == b.X && a.Y == b.Y;

        public static bool operator !=(Vector2 a, Vector2 b)
            => !(a == b);
        public bool Equals(Vector2 other)
        {
            return X == other.X && Y == other.Y;
        }
        public override bool Equals(object? obj)
        {
            return obj is Vector2 other && Equals(other);
        }
    }
}