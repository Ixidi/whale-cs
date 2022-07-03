namespace Application.Math;

public class Vector3 : IVector3
{
    public double X { get; }
    public double Y { get; }

    public double Z { get; }

    private readonly Lazy<double> _length;

    public Vector3(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
        _length = new Lazy<double>(() => System.Math.Sqrt((X * X) + (Y * Y) + (Z * Z)));
    }

    public double Length() => _length.Value;

    public IVector3 Normalize() => this / Length();

    public IVector3 Scale(double length) => Normalize() * length;

    public IVector3 Add(IVector3 vec) => new Vector3(X + vec.X, Y + vec.Y, Z + vec.Z);

    public IVector3 Add(double x = 0, double y = 0, double z = 0) => new Vector3(X + x, Y + y, Z + z);

    public IVector3 Subtract(IVector3 vec) => new Vector3(X - vec.X, Y - vec.Y, Z - vec.Z);

    public IVector3 Subtract(double x = 0, double y = 0, double z = 0) => new Vector3(X - x, Y - y, Z - z);

    public IVector3 Multiply(double multiplier) => new Vector3(X * multiplier, Y * multiplier, Z * multiplier);

    public IVector3 Divide(double divisor) => new Vector3(X / divisor, Y / divisor, Z / divisor);

    protected bool Equals(Vector3 other)
    {
        return X.IsCloseEnough(other.X, 0.000000001) && Y.IsCloseEnough(other.Y, 0.000000001) &&
               Z.IsCloseEnough(other.Z, 0.000000001);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Vector3)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public static IVector3 operator +(Vector3 a, IVector3 b) => a.Add(b);
    public static IVector3 operator -(Vector3 a, IVector3 b) => a.Subtract(b);
    public static IVector3 operator *(Vector3 a, double multiplier) => a.Multiply(multiplier);
    public static IVector3 operator *(double multiplier, Vector3 a) => a.Multiply(multiplier);
    public static IVector3 operator /(Vector3 a, double divisor) => a.Divide(divisor);
}