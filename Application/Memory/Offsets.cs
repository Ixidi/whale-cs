namespace Application.Game;

public static class Offsets
{
    // Game offsets
    public static int GTime = 0x31002F8;
    public static int GObjectManager = 0x1868CF8;
    public static int GLocalPlayer = 0x3107314;
    public static int GUnderMouseObject = 0x24B7D9C;
    public static int GRenderer = 0x3138FAC;
        
    // Object offsets
    public static int OIndex = 0x8;
    public static int OTeam = 0x34;
    public static int OHealth = 0xE74;
    public static int OMaxHealth = 0xE84;
    public static int OPosition = 0x1DC;
    public static int OIsVisible = 0x274;
    public static int OMana = 0x29C;
    public static int OName = 0x2BA4;
    public static int OSpawnCount = 0x288;
    public static int OAttackRange = 0x12B4;
    public static int OMagicResist = 0x1380; //might be wrong
    public static int OAttackDamage = 0x134C;
    public static int OBonusAttackDamage = 0x12C4;
    public static int OCritChance = 0x12C8;
    public static int OIsMoving = 0x32E7;
    public static int OAbilityPower = 0x11F4;
    public static int OAbilityPowerMultiplier = 0x11F8;
    public static int ONetworkId = 0xB4;
}