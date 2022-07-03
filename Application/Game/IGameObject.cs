using Application.Math;

namespace Application.Game;

public interface IGameObject
{
    public int Address { get; }
    public float Health { get; }
    public float MaxHealth { get; }
    public int Team { get; }
    public string Name { get; } // [(IntPtr)NamePtr] + 0x00 (50 length)
    public bool IsAlive { get; }
    public bool IsVisible { get; }
    public float AttackRange { get; }
    public float Armor { get; }
    public float AttackDamage { get; } // base + bonus attack dmg (two addresses)
    public float CriticalChance { get; }
    public IVector3 Position { get; }
    public float MovementSpeed { get; }
    public bool IsMoving { get; }
    public bool AttackSpeedMultiplier { get; } // multiplier (base_attack_speed * multiplier = attack speed)
    public ISpellBook GetSpellBook { get; }
}