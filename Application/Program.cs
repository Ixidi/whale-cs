using System.Diagnostics;
using System.Runtime.Intrinsics;
using Application.Math;

namespace Application;

public static class Program
{

    public static void Print(string x)
    {
        Console.WriteLine(x);
    }
    
    public static void Main()
    {
        var process = Process.GetProcessesByName("League of Legends").First();
        var memory = new Memory.Reader(process);
        var localPlayer = memory.ReadInt(process.MainModule.BaseAddress.ToInt32() + 0x3107314);
        var health = memory.ReadFloat(localPlayer + 0xE74);
        Print(memory.Read<string>(localPlayer + 0x2BA4));
        
        while (true)
        {
            var vec = memory.Read<Vector3>(localPlayer + 0x1DC);
            Console.WriteLine($"{vec.X}, {vec.Y}, {vec.Z}");
        }
    }
}