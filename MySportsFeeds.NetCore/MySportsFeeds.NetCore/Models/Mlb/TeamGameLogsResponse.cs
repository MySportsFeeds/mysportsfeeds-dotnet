using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class TeamGameLogsResponse
    {
        public Teamgamelogs teamgamelogs { get; set; }
    }

    public class OpponentsLeftOnBase : Stat
    {
    }

    public class OpponentAtBats : Stat
    {
    }

    public class RunDifferential : Stat
    {
    }

    public class DefenceEfficiencyRatio : Stat
    {
    }

    public class GamesBack : Stat
    {    
    }

    public class TeamGameLogStats
    {
        public AtBats AtBats { get; set; }
        public Runs Runs { get; set; }
        public Hits Hits { get; set; }
        public SecondBaseHits SecondBaseHits { get; set; }
        public ThirdBaseHits ThirdBaseHits { get; set; }
        public Homeruns Homeruns { get; set; }
        public EarnedRuns EarnedRuns { get; set; }
        public UnearnedRuns UnearnedRuns { get; set; }
        public RunsBattedIn RunsBattedIn { get; set; }
        public BatterWalks BatterWalks { get; set; }
        public BatterSwings BatterSwings { get; set; }
        public BatterStrikes BatterStrikes { get; set; }
        public BatterStrikesFoul BatterStrikesFoul { get; set; }
        public BatterStrikesMiss BatterStrikesMiss { get; set; }
        public BatterStrikesLooking BatterStrikesLooking { get; set; }
        public BatterTagOuts BatterTagOuts { get; set; }
        public BatterForceOuts BatterForceOuts { get; set; }
        public BatterPutOuts BatterPutOuts { get; set; }
        public BatterGroundBalls BatterGroundBalls { get; set; }
        public BatterFlyBalls BatterFlyBalls { get; set; }
        public BatterLineDrives BatterLineDrives { get; set; }
        public Batter2SeamFastballs Batter2SeamFastballs { get; set; }
        public Batter4SeamFastballs Batter4SeamFastballs { get; set; }
        public BatterCurveballs BatterCurveballs { get; set; }
        public BatterChangeups BatterChangeups { get; set; }
        public BatterCutters BatterCutters { get; set; }
        public BatterSliders BatterSliders { get; set; }
        public BatterSinkers BatterSinkers { get; set; }
        public BatterSplitters BatterSplitters { get; set; }
        public BatterStrikeouts BatterStrikeouts { get; set; }
        public StolenBases StolenBases { get; set; }
        public CaughtBaseSteals CaughtBaseSteals { get; set; }
        public BatterStolenBasePct BatterStolenBasePct { get; set; }
        public BattingAvg BattingAvg { get; set; }
        public BatterOnBasePct BatterOnBasePct { get; set; }
        public BatterSluggingPct BatterSluggingPct { get; set; }
        public BatterOnBasePlusSluggingPct BatterOnBasePlusSluggingPct { get; set; }
        public BatterIntentionalWalks BatterIntentionalWalks { get; set; }
        public HitByPitch HitByPitch { get; set; }
        public BatterSacrificeBunts BatterSacrificeBunts { get; set; }
        public BatterSacrificeFlies BatterSacrificeFlies { get; set; }
        public TotalBases TotalBases { get; set; }
        public ExtraBaseHits ExtraBaseHits { get; set; }
        public BatterDoublePlays BatterDoublePlays { get; set; }
        public BatterTriplePlays BatterTriplePlays { get; set; }
        public BatterGroundOuts BatterGroundOuts { get; set; }
        public BatterFlyOuts BatterFlyOuts { get; set; }
        public BatterGroundOutToFlyOutRatio BatterGroundOutToFlyOutRatio { get; set; }
        public PitchesFaced PitchesFaced { get; set; }
        public PlateAppearances PlateAppearances { get; set; }
        public LeftOnBase LeftOnBase { get; set; }
        public OpponentsLeftOnBase OpponentsLeftOnBase { get; set; }
        public OpponentAtBats OpponentAtBats { get; set; }
        public SecondBaseHitsAllowed SecondBaseHitsAllowed { get; set; }
        public ThirdBaseHitsAllowed ThirdBaseHitsAllowed { get; set; }
        public PitcherSwings PitcherSwings { get; set; }
        public PitcherStrikes PitcherStrikes { get; set; }
        public PitcherStrikesFoul PitcherStrikesFoul { get; set; }
        public PitcherStrikesMiss PitcherStrikesMiss { get; set; }
        public PitcherStrikesLooking PitcherStrikesLooking { get; set; }
        public PitcherGroundBalls PitcherGroundBalls { get; set; }
        public PitcherFlyBalls PitcherFlyBalls { get; set; }
        public PitcherLineDrives PitcherLineDrives { get; set; }
        public Pitcher2SeamFastballs Pitcher2SeamFastballs { get; set; }
        public Pitcher4SeamFastballs Pitcher4SeamFastballs { get; set; }
        public PitcherCurveballs PitcherCurveballs { get; set; }
        public PitcherChangeups PitcherChangeups { get; set; }
        public PitcherCutters PitcherCutters { get; set; }
        public PitcherSliders PitcherSliders { get; set; }
        public PitcherSinkers PitcherSinkers { get; set; }
        public PitcherSplitters PitcherSplitters { get; set; }
        public PitcherSacrificeBunts PitcherSacrificeBunts { get; set; }
        public PitcherSacrificeFlies PitcherSacrificeFlies { get; set; }
        public EarnedRunAvg EarnedRunAvg { get; set; }
        public InningsPitched InningsPitched { get; set; }
        public HitsAllowed HitsAllowed { get; set; }
        public RunsAllowed RunsAllowed { get; set; }
        public EarnedRunsAllowed EarnedRunsAllowed { get; set; }
        public HomerunsAllowed HomerunsAllowed { get; set; }
        public PitcherWalks PitcherWalks { get; set; }
        public PitcherStrikeouts PitcherStrikeouts { get; set; }
        public PitchingAvg PitchingAvg { get; set; }
        public WalksAndHitsPerInningPitched WalksAndHitsPerInningPitched { get; set; }
        public Shutouts Shutouts { get; set; }
        public BattersHit BattersHit { get; set; }
        public PitcherIntentionalWalks PitcherIntentionalWalks { get; set; }
        public PitcherGroundOuts PitcherGroundOuts { get; set; }
        public PitcherFlyOuts PitcherFlyOuts { get; set; }
        public PitcherWildPitches PitcherWildPitches { get; set; }
        public Balks Balks { get; set; }
        public PitcherStolenBasesAllowed PitcherStolenBasesAllowed { get; set; }
        public PitcherCaughtStealing PitcherCaughtStealing { get; set; }
        public PickoffAttempts PickoffAttempts { get; set; }
        public Pickoffs Pickoffs { get; set; }
        public TotalBattersFaced TotalBattersFaced { get; set; }
        public PitchesThrown PitchesThrown { get; set; }
        public PitcherGroundOutToFlyOutRatio PitcherGroundOutToFlyOutRatio { get; set; }
        public PitcherOnBasePct PitcherOnBasePct { get; set; }
        public PitcherSluggingPct PitcherSluggingPct { get; set; }
        public PitcherOnBasePlusSluggingPct PitcherOnBasePlusSluggingPct { get; set; }
        public StrikeoutsPer9Innings StrikeoutsPer9Innings { get; set; }
        public WalksAllowedPer9Innings WalksAllowedPer9Innings { get; set; }
        public HitsAllowedPer9Innings HitsAllowedPer9Innings { get; set; }
        public StrikeoutsToWalksRatio StrikeoutsToWalksRatio { get; set; }
        public PitchesPerInning PitchesPerInning { get; set; }
        public InningsPlayed InningsPlayed { get; set; }
        public TotalChances TotalChances { get; set; }
        public FielderTagOuts FielderTagOuts { get; set; }
        public FielderForceOuts FielderForceOuts { get; set; }
        public FielderPutOuts FielderPutOuts { get; set; }
        public Assists Assists { get; set; }
        public Errors Errors { get; set; }
        public FielderDoublePlays FielderDoublePlays { get; set; }
        public FielderTriplePlays FielderTriplePlays { get; set; }
        public FielderStolenBasesAllowed FielderStolenBasesAllowed { get; set; }
        public FielderCaughtStealing FielderCaughtStealing { get; set; }
        public FielderStolenBasePct FielderStolenBasePct { get; set; }
        public PassedBalls PassedBalls { get; set; }
        public FielderWildPitches FielderWildPitches { get; set; }
        public FieldingPct FieldingPct { get; set; }
        public DefenceEfficiencyRatio DefenceEfficiencyRatio { get; set; }
        public OutsFaced OutsFaced { get; set; }
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public WinPct WinPct { get; set; }
        public GamesBack GamesBack { get; set; }
        public RunsFor RunsFor { get; set; }
        public RunsAgainst RunsAgainst { get; set; }
        public RunDifferential RunDifferential { get; set; }
    }

    public class TeamGamelog
    {
        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("stats")]
        public TeamGameLogStats Stats { get; set; }
    }

    public class Teamgamelogs
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }
        
        [JsonProperty("gamelogs")]
        public List<TeamGamelog> TeamGameLogs { get; set; }
    }

}
