namespace GameLibraryRemastered.Model
{
    public readonly struct Vector3(float x, float y, float z)
    {
        public static Vector3 Zero => new(0, 0, 0);
        public static Vector3 One => new(1, 1, 1);
        public static Vector3 UnitX => new(1, 0, 0);
        public static Vector3 UnitY => new(0, 1, 0);
        public static Vector3 UnitZ => new(0, 0, 1);

        public float X { get; } = x;
        public float Y { get; } = y;
        public float Z { get; } = z;

        public readonly float Dot(Vector3 other) => X * other.X + Y * other.Y + Z * other.Z;
        public readonly float Magnitude() => MathF.Sqrt(X * X + Y * Y + Z * Z);
        public readonly Vector3 Normalize() => new(X / Magnitude(), Y / Magnitude(), Z / Magnitude());
    }
}