using System.Numerics;
using System.Runtime.Intrinsics;

namespace Application;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("test+");
        var vec = new Vector2(6, 7);
        vec += vec;
    }
}