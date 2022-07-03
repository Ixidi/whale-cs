using System.Runtime.Intrinsics;
using Application.Math;

namespace Application;

public static class Program
{

    public static void xx(double x)
    {
        
    }
    
    public static void Main()
    {
        Console.WriteLine("test+");
        IVector2 vec = new Vector2(1, 5);
        var x = vec - vec;
        Console.WriteLine(x);
        xx(0.5);
    }
}