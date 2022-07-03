namespace Application.Game;
/*
 * ObjectManager is a red-black tree so to iterate through it u must first get the root node, read object from node, 3 next nodes and lastly create loop to scan everything.
 * 
 */
public interface IObjectManager
{
    List<int> Champions { get; }
    List<int> Minions { get; }
    List<int> Turrets { get; }
    List<int> JungleMonsters { get; }
    // may be more for example missiles or plants.

    void ScanUnit(int address);
    void ScanUnits(int objectManagerAddress);
    void UpdateUnit(int netId, int address);
}