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
    
    public double Length()
    {
        return _length.Value;
    }

    public IVector2 Normalize()
    {
        throw new NotImplementedException();
    }

    public IVector2 Scale(double length)
    {
        throw new NotImplementedException();
    }

    public IVector2 Add(IVector2 vec)
    {
        throw new NotImplementedException();
    }

    public IVector2 Add(double x = 0, double y = 0)
    {
        throw new NotImplementedException();
    }

    public IVector2 Subtract(IVector2 vec)
    {
        throw new NotImplementedException();
    }

    public IVector2 Subtract(double x = 0, double y = 0)
    {
        throw new NotImplementedException();
    }

    public IVector2 Multiply(double multiplier)
    {
        throw new NotImplementedException();
    }

    public IVector2 Divide(double divisor)
    {
        throw new NotImplementedException();
    }

    public IVector2 Rotate(double angle)
    {
        throw new NotImplementedException();
    }

    public IVector2 CrossProduct(IVector2 vec)
    {
        throw new NotImplementedException();
    }

    public IVector2 DotProduct(IVector2 vec)
    {
        throw new NotImplementedException();
    }
}