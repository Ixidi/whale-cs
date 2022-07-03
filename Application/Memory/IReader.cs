using Application.Math;

namespace Application.Memory;

public interface IReader
{

    string ReadString(int address);
    float ReadFloat(int address);
    int ReadInt(int address);
    short ReadShort(int address);
    byte ReadByte(int address);
    IVector3 ReadVector3(int address);

    T Read<T>(int address);

}