namespace Application.Game;

public interface SpellSlot
{
    public float ReadyTime { get; }
    public float ReadyAt { get; }

    public float Damage { get; }

    public string Name { get; }

    public float Level { get; }

    
}

public interface SpellBook
{
    
    public SpellSlot SpellQ { get; set; }
    public SpellSlot SpellW { get; set; }
    public SpellSlot SpellE { get; set; }
    public SpellSlot SpellR { get; set; }
    public SpellSlot SpellD { get; set; }
    public SpellSlot SpellF { get; set; }

    SpellBook Load();

}