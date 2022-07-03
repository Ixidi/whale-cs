namespace Application.Math;

public static class Extension
{

    public static bool IsCloseEnough(this double a, double b, double precision = 0.000001)
    {
        return System.Math.Abs(a - b) < precision;
    }
    
}