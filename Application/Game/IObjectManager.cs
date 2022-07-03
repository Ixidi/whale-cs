namespace Application.Game;
/*
 * ObjectManager is a red-black tree so to iterate through it u must first get the root node, read object from node, 3 next nodes and lastly create loop to scan everything.
 * 
 */
public interface IObjectManager
{
    public List<int> Champions { get; }
    public List<int> Minions { get; }
    public List<int> Turrets { get; }
    public List<int> JungleMonsters { get; }
    // may be more for example missiles or plants.

    public void ScanUnit(int address);
    public void ScanUnits(int objectManagerAddress);
    public void UpdateUnit(int netId, int address);
}