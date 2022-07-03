namespace Application.Math;

public interface IVector3
{

    double X { get; }
    double Y { get; }
    double Z { get; }

    double Length();

    IVector3 Normalize();

    IVector3 Scale(double length);

    IVector3 Add(IVector3 vec);
    IVector3 Add(double x = 0.0, double y = 0.0, double z = 0.0);
    
    IVector3 Subtract(IVector3 vec);
    IVector3 Subtract(double x = 0.0, double y = 0.0, double z = 0.0);

    IVector3 Multiply(double multiplier);
    IVector3 Divide(double divisor);

    public static IVector3 operator +(IVector3 a, IVector3 b) => a.Add(b);
    public static IVector3 operator -(IVector3 a, IVector3 b) => a.Subtract(b);
    public static IVector3 operator *(IVector3 a, double multiplier) => a.Multiply(multiplier);
    public static IVector3 operator *(double multiplier, IVector3 a) => a.Multiply(multiplier);
    public static IVector3 operator /(IVector3 a, double divisor) => a.Divide(divisor);
    
}