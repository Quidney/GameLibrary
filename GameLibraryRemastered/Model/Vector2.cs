namespace GameLibraryRemastered.Model
{
    public readonly struct Vector2(float _x, float _y)
    {
        public static Vector2 Zero => new(0, 0);
        public static Vector2 One => new(1, 1);
        public static Vector2 UnitX => new(1, 0);
        public static Vector2 UnitY => new(0, 1);

        public float X { get; } = _x;
        public float Y { get; } = _y;

        public readonly float Dot(Vector2 other) => X * other.X + Y * other.Y;
        public readonly float Magnitude() => MathF.Sqrt(X * X + Y * Y);
        public readonly Vector2 Normalize() => new(X / Magnitude(), Y / Magnitude());
    }
}