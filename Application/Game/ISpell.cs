namespace Application.Game;

public interface ISpellSlot
{
     float ReadyTime { get; }
     float ReadyAt { get; }
     float Damage { get; }
     string Name { get; }
     float Level { get; }

    
}

public interface ISpellBook
{
    
     ISpellSlot SpellQ { get; set; }
     ISpellSlot SpellW { get; set; }
     ISpellSlot SpellE { get; set; }
     ISpellSlot SpellR { get; set; }
     ISpellSlot SpellD { get; set; }
     ISpellSlot SpellF { get; set; }

    ISpellBook Load();

}