using Terraria.GameContent.UI.ResourceSets;
using Terraria.ModLoader.Config;
using TerraUtil.Configuration;

namespace AccessoriesPlus.Configuration;

// ReSharper disable ConvertToConstant.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

public class PDAConfig : SubConfiguration
{
    public static PDAConfig Instance => Config.Instance.ImprovedPDA;

    [Header("Radar")]
    public bool RadarHighlightEnemies = true;
    public bool RadarHighlightDanger = true;

    [Header("MetalDetector")]
    public bool MetalDetectorDistanceInfo = true;
    public bool MetalDetectorArrows = true;
    public bool MetalDetectorHighlight = true;

    //i decided to split setting into categories,
    //categories:
    //Ores, gems, misc, containers, userChoise
    [ReloadRequired]
    public bool TrackGems = true;
    [ReloadRequired]
    public bool TrackHellstone = true; //Technically an ore
    [ReloadRequired]
    public List<TileDefinition> TileAllowlist = [];
    [ReloadRequired]
    public List<TileDefinition> TileBlocklist = [];

    public bool UseProgressionBasedHintsForOres = false;
    public bool UseProgressionBasedHintsForGems = false;

    [Header("LifeformAnalyzer")]
    public bool LifeformAnalyzerDistanceInfo = true;
    public bool LifeformAnalyzerArrows = true;
    public bool LifeformAnalyzerHighlight = true;

    public bool UseNPCWhitelist = true;
    public bool UseNPCBlacklist = true;
    //public Dictionary<NPCDefinition, int> NPCWhitelist = new();
    // TODO: add rarities to NPC whitelist
    public List<NPCDefinition> NPCWhitelist = [];
    public List<NPCDefinition> NPCBlacklist = [];
}
