namespace Application.Game;

public interface ISpellSlot
{
    public float ReadyTime { get; }
    public float ReadyAt { get; }
    public float Damage { get; }
    public string Name { get; }
    public float Level { get; }

    
}

public interface ISpellBook
{
    
    public ISpellSlot SpellQ { get; set; }
    public ISpellSlot SpellW { get; set; }
    public ISpellSlot SpellE { get; set; }
    public ISpellSlot SpellR { get; set; }
    public ISpellSlot SpellD { get; set; }
    public ISpellSlot SpellF { get; set; }

    ISpellBook Load();

}