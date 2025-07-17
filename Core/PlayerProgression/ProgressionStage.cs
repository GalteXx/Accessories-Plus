namespace AccessoriesPlus.Core.PlayerProgression;
internal enum ProgressionStage
{
   PreEvilBoss,
   PostEvilBoss,
   PostHardMode,
   PostMechBosses, 
}

[Flags]
public enum TileCategory
{
    BlockedCategory = 0,
    Ore = 1,
    Gem = 1 << 1,
    Miscellanious = 1 << 2,
    Container = 1 << 3,
    UserChoice = 1 << 4
}
