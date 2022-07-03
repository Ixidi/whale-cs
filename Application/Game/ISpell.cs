namespace Application.Game;

public struct SpellSlot
{
    public SpellSlot(float readyTime, float level, String name, float damage, float readyAt)
    {
        ReadyTime = readyTime;
        Level = level;
        Name = name;
        Damage = damage;
        ReadyAt = readyAt;
    }
    
    public float ReadyTime { get; }
    public float ReadyAt { get; }

    public float Damage { get; }

    public string Name { get; }

    public float Level { get; }

    
}

public struct SpellBook
{
    public SpellBook(int objectSpellBookAddress)
    {
        objectSpellBookAddress = objectSpellBookAddress;
        SpellQ = default;
        SpellW = default;
        SpellE = default;
        SpellR = default;
        SpellD = default;
        SpellF = default;
    }
    
    public SpellSlot SpellQ { get; set; }
    public SpellSlot SpellW { get; set; }
    public SpellSlot SpellE { get; set; }
    public SpellSlot SpellR { get; set; }
    public SpellSlot SpellD { get; set; }
    public SpellSlot SpellF { get; set; }

    SpellBook Load()
    {
        // ladowanie spell booka i slotow z pamieci
        // [[<league of legends.exe> + ObjectPointer] + SPELL_BOOK_ADDRESS + 0x488 + (0x4*0)] // 0x488 = spell slot (0x4*i) i= index
        return this;
    }
    
}