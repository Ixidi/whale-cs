using Application.Math;

namespace Application.Game;

public interface IGameObject
{
     int Address { get; }
     float Health { get; }
     float MaxHealth { get; }
     int Team { get; }
     string Name { get; } // [(IntPtr)NamePtr] + 0x00 (50 length)
     bool IsAlive { get; }
     bool IsVisible { get; }
     float AttackRange { get; }
     float Armor { get; }
     float AttackDamage { get; } // base + bonus attack dmg (two addresses)
     float CriticalChance { get; }
     IVector3 Position { get; }
     float MovementSpeed { get; }
     bool IsMoving { get; }
     bool AttackSpeedMultiplier { get; } // multiplier (base_attack_speed * multiplier = attack speed)
     ISpellBook GetSpellBook { get; }
}