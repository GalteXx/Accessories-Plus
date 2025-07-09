namespace AccessoriesPlus.Core.PlayerProgression;

internal static class MetalDetectorTileCategories
{
    private static readonly Dictionary<int, ProgressionStage> oreTier = new()
    {
        [TileID.Copper] = ProgressionStage.PreEvilBoss,
        [TileID.Tin] = ProgressionStage.PreEvilBoss,
        [TileID.Iron] = ProgressionStage.PreEvilBoss,
        [TileID.Lead] = ProgressionStage.PreEvilBoss,
        [TileID.Silver] = ProgressionStage.PreEvilBoss,
        [TileID.Tungsten] = ProgressionStage.PreEvilBoss,
        [TileID.Gold] = ProgressionStage.PreEvilBoss,
        [TileID.Platinum] = ProgressionStage.PreEvilBoss,

        [TileID.Demonite] = ProgressionStage.PostEvilBoss,
        [TileID.Crimtane] = ProgressionStage.PostEvilBoss,

        [TileID.Hellstone] = ProgressionStage.PostEvilBoss,

        [TileID.Cobalt] = ProgressionStage.PostHardMode,
        [TileID.Palladium] = ProgressionStage.PostHardMode,
        [TileID.Mythril] = ProgressionStage.PostHardMode,
        [TileID.Orichalcum] = ProgressionStage.PostHardMode,
        [TileID.Adamantite] = ProgressionStage.PostHardMode,
        [TileID.Titanium] = ProgressionStage.PostHardMode,

        [TileID.Chlorophyte] = ProgressionStage.PostMechBosses,

    };
    //I will mark every gem as postEvilBoss, as I think they are most relevant on this stage of the game
    //Maybe add a PreSkeletron stage?
    private static readonly Dictionary<int, ProgressionStage> gemTier = new()
    {
        [TileID.ExposedGems] = ProgressionStage.PostEvilBoss,

        [TileID.Amethyst] = ProgressionStage.PostEvilBoss,
        [TileID.Topaz] = ProgressionStage.PostEvilBoss,
        [TileID.Sapphire] = ProgressionStage.PostEvilBoss,
        [TileID.Emerald] = ProgressionStage.PostEvilBoss,
        [TileID.Ruby] = ProgressionStage.PostEvilBoss,
        [TileID.Diamond] = ProgressionStage.PostEvilBoss,
        [TileID.AmberStoneBlock] = ProgressionStage.PostEvilBoss,

        [TileID.TreeAmethyst] = ProgressionStage.PostEvilBoss,
        [TileID.TreeTopaz] = ProgressionStage.PostEvilBoss,
        [TileID.TreeSapphire] = ProgressionStage.PostEvilBoss,
        [TileID.TreeEmerald] = ProgressionStage.PostEvilBoss,
        [TileID.TreeRuby] = ProgressionStage.PostEvilBoss,
        [TileID.TreeDiamond] = ProgressionStage.PostEvilBoss,
        [TileID.TreeAmber] = ProgressionStage.PostEvilBoss,
    };
    private static readonly Dictionary<int, ProgressionStage> containerTier = new()
    {
        [TileID.Containers] = ProgressionStage.PostEvilBoss,
        [TileID.Containers2] = ProgressionStage.PostEvilBoss
    };
    private static readonly Dictionary<int, ProgressionStage> miscTier = new()
    {
        [TileID.Pots] = ProgressionStage.PreEvilBoss,
        [TileID.ManaCrystal] = ProgressionStage.PreEvilBoss,
        [TileID.FossilOre] = ProgressionStage.PreEvilBoss,
        [TileID.DesertFossil] = ProgressionStage.PreEvilBoss,

        [TileID.Heart] = ProgressionStage.PostEvilBoss,
        [TileID.LifeCrystalBoulder] = ProgressionStage.PostEvilBoss,

        [TileID.LifeFruit] = ProgressionStage.PostMechBosses,        // Jungle post-mech HP upgrade
    };
    //user choise will be stored in Config and is not subject to tier grading
    public static IReadOnlyDictionary<int, ProgressionStage> OreTier => oreTier;
    public static IReadOnlyDictionary<int, ProgressionStage> GemTier => gemTier;
    public static IReadOnlyDictionary<int, ProgressionStage> ContainerTier => containerTier;
    public static IReadOnlyDictionary<int, ProgressionStage> MiscellaneousTier => miscTier;

    public static ProgressionStage GetStage(int itemId) => OreTier.TryGetValue(itemId, out ProgressionStage stage) ? stage : ProgressionStage.PreEvilBoss;
}
