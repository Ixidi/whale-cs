namespace Application.Math;

public interface IVector2
{

    double X { get; }
    double Y { get; }

    double Length();

    IVector2 Normalize();

    IVector2 Scale(double length);

    IVector2 Add(IVector2 vec);
    IVector2 Add(double x = 0.0, double y = 0.0);
    
    IVector2 Subtract(IVector2 vec);
    IVector2 Subtract(double x = 0.0, double y = 0.0);

    IVector2 Multiply(double multiplier);

    IVector2 Divide(double divisor);

    IVector2 Rotate(double angle);
    
    IVector2 CrossProduct(IVector2 vec);
    IVector2 DotProduct(IVector2 vec);

    public static IVector2 operator +(IVector2 a, IVector2 b) => a.Add(b);
    public static IVector2 operator -(IVector2 a, IVector2 b) => a.Subtract(b);
    public static IVector2 operator *(IVector2 a, double multiplier) => a.Multiply(multiplier);
    public static IVector2 operator *(double multiplier, IVector2 a) => a.Multiply(multiplier);
    public static IVector2 operator /(IVector2 a, double divisor) => a.Divide(divisor);
    
}