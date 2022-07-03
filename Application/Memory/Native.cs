using System.Runtime.InteropServices;

namespace Application.Memory;

public static class Native
{

    [DllImport("kernel32.dll")]
    public static extern bool ReadProcessMemory(IntPtr hProcess,
        IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

}