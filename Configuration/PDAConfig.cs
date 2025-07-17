using Terraria.GameContent.UI.ResourceSets;
using Terraria.ModLoader.Config;
using TerraUtil.Configuration;

namespace AccessoriesPlus.Configuration;

// ReSharper disable ConvertToConstant.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

public class PDAConfig : SubConfiguration
{
    public static PDAConfig Instance => Config.Instance.ImprovedPDA;
    public static int ArrowCategoryMask { get; private set; }

    public override void OnChanged()
    {

    }

    [Header("Radar")]
    public bool RadarHighlightEnemies = true;
    public bool RadarHighlightDanger = true;

    [Header("MetalDetector")]
    public bool MetalDetectorDistanceInfo = true;
    public bool MetalDetectorHighlight = true;
    //i decided to split setting into categories,
    //categories:
    //Blocked, Ores, gems, misc, containers, userChoise
    //in THIS EXACT order. It is needed for bitmapping
    [ReloadRequired]
    public bool TrackGems = true;
    [ReloadRequired]
    public bool TrackHellstone = true; //Technically an ore
    [ReloadRequired]
    public List<TileDefinition> TileAllowlist = [];
    [ReloadRequired]
    public List<TileDefinition> TileBlocklist = [];

    //public bool ProgressiveGemArrows = false; gems aren't exactly progression based
    //no progression based arrows for AllowList
    public bool ProgressiveMiscArrows = false;
    public bool ProgressiveOreArrows = false;


    public bool MetalDetectorGemArrows = true;  
    public bool MetalDetectorOreArrows = true;
    public bool MetalDetectorMiscArrows = true;
    public bool MetalDetectorContainerArrows = true;
    public bool MetalDetectorUserChoiceArrows = true;


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
