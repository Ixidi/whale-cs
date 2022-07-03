namespace Application.Math;

public class Vector2 : IVector2
{
    
    public double X { get; }
    public double Y { get; }

    private readonly Lazy<double> _length;

    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
        _length = new Lazy<double>(() => System.Math.Sqrt((X * X) + (Y * Y)));
    }
    
    public double Length() => _length.Value;

    public IVector2 Normalize() => this / Length();

    public IVector2 Scale(double length) => Normalize() * length;

    public IVector2 Add(IVector2 vec) => new Vector2(X + vec.X, Y + vec.Y);

    public IVector2 Add(double x = 0, double y = 0) => new Vector2(X + x, Y + y);

    public IVector2 Subtract(IVector2 vec) => new Vector2(X - vec.X, Y - vec.Y);

    public IVector2 Subtract(double x = 0, double y = 0) => new Vector2(X - x, Y - y);

    public IVector2 Multiply(double multiplier) => new Vector2(X * multiplier, Y * multiplier);

    public IVector2 Divide(double divisor) => new Vector2(X / divisor, Y / divisor);

    public IVector2 Rotate(double angle)
    {
        var x = (System.Math.Cos(angle) * X) - (System.Math.Sin(angle) * Y) + X;
        var y = (System.Math.Sin(angle) * X) + (System.Math.Cos(angle) * Y) + Y;
        return new Vector2(x, y);
    }
    
    protected bool Equals(Vector2 other)
    {
        return X.IsCloseEnough(other.X, 0.000000001) && Y.IsCloseEnough(other.Y, 0.000000001);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Vector2)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public static IVector2 operator +(Vector2 a, IVector2 b) => a.Add(b);
    public static IVector2 operator -(Vector2 a, IVector2 b) => a.Subtract(b);
    public static IVector2 operator *(Vector2 a, double multiplier) => a.Multiply(multiplier);
    public static IVector2 operator *(double multiplier, Vector2 a) => a.Multiply(multiplier);
    public static IVector2 operator /(Vector2 a, double divisor) => a.Divide(divisor);
    
}