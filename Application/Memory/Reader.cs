using System.Diagnostics;
using System.Text;
using Application.Math;

namespace Application.Memory;

public class Reader : IReader
{

    private IntPtr _handle;
    
    public Reader(Process process)
    {
        _handle = process.Handle;
    }

    private byte[] ReadBytes(int address, int length)
    {
        var bytesRead = 0;
        var buff = new byte[length];
        Native.ReadProcessMemory(_handle, new IntPtr(address), buff, length, ref bytesRead);
        return buff;
    }
    
    public string ReadString(int address)
    {
        var stringAddress = ReadInt(address);
        var l = ReadInt(address + 4);
        var bytes = ReadBytes(stringAddress, l);
        return Encoding.UTF8.GetString(bytes);
    }

    public float ReadFloat(int address)
    {
        var bytes = ReadBytes(address, 4);
        return BitConverter.ToSingle(bytes);
    }

    public int ReadInt(int address)
    {
        var bytes = ReadBytes(address, 4);
        return BitConverter.ToInt32(bytes);
    }

    public short ReadShort(int address)
    {
        var bytes = ReadBytes(address, 2);
        return BitConverter.ToInt16(bytes);
    }

    public byte ReadByte(int address)
    {
        var bytes = ReadBytes(address, 1);
        return bytes.First();
    }

    public IVector3 ReadVector3(int address)
    {
        return new Vector3(ReadFloat(address), ReadFloat(address + 0x04), ReadFloat(address + 0x08));
    }

    public T Read<T>(int address)
    {
        var type = typeof(T);
        
        object obj;
        if (type == typeof(string))
        {
            obj = ReadString(address);
        }
        else if (type == typeof(float))
        {
            obj = ReadFloat(address);
        }
        else if (type == typeof(byte))
        {
            obj = ReadByte(address);
        }
        else if (type == typeof(Vector3))
        {
            obj = ReadVector3(address);
        }
        else if (type == typeof(int))
        {
            obj = ReadInt(address);
        }
        else
        {
            throw new Exception("unsupported type");
        }

        return (T) obj;
    }
}