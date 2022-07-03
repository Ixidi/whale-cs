namespace Application.Types;

public interface IRiotString
{
    /*
     * NamePointer = read<int>(address);
     * (String)Name = read_string(NamePointer, length); for object names 50 for buffs 150
     */
    String Read(int address, int length=50);
}