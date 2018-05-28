using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySportsFeeds.NetCore.Models
{
    public class PlayerGameLogsResponse
    {
        public Playergamelogs playergamelogs { get; set; }
    }


    public class AtBatStats : Stat
    {

    }

    public class Runs : Stat
    {

    }

    public class Hits : Stat
    {

    }

    public class SecondBaseHits : Stat
    {

    }

    public class ThirdBaseHits : Stat
    {

    }

    public class Homeruns : Stat
    {

    }

    public class EarnedRuns : Stat
    {

    }

    public class UnearnedRuns : Stat
    {

    }

    public class RunsBattedIn : Stat
    {

    }

    public class BatterWalks : Stat
    {

    }

    public class BatterSwings : Stat
    {

    }

    public class BatterStrikes : Stat
    {

    }

    public class BatterStrikesFoul : Stat
    {

    }

    public class BatterStrikesMiss : Stat
    {

    }

    public class Stat
    {
        [JsonProperty("@category")]
        public string Category { get; set; }

        [JsonProperty("@abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("#text")]
        public string Text { get; set; }
    }

    public class BatterStrikesLooking : Stat
    {

    }

    public class BatterTagOuts : Stat
    {

    }

    public class BatterForceOuts : Stat
    {

    }

    public class BatterPutOuts : Stat
    {

    }

    public class BatterGroundBalls : Stat
    {
    }

    public class BatterFlyBalls : Stat
    {
    }

    public class BatterLineDrives : Stat
    {
    }

    public class Batter2SeamFastballs
    {
    }

    public class Batter4SeamFastballs : Stat
    {
    }

    public class BatterCurveballs : Stat
    {
    }

    public class BatterChangeups : Stat
    {
    }

    public class BatterCutters : Stat
    {
    }

    public class BatterSliders : Stat
    {
    }

    public class BatterSinkers : Stat
    {
    }

    public class BatterSplitters : Stat
    {
    }

    public class BatterStrikeouts : Stat
    {
    }

    public class StolenBases : Stat
    {
    }

    public class CaughtBaseSteals : Stat
    {
    }

    public class BatterStolenBasePct : Stat
    {
    }

    public class BattingAvg : Stat
    {
    }

    public class BatterOnBasePct : Stat
    {
    }

    public class BatterSluggingPct : Stat
    {

    }

    public class BatterOnBasePlusSluggingPct : Stat
    {

    }

    public class BatterIntentionalWalks : Stat
    {

    }

    public class HitByPitch : Stat
    {

    }

    public class BatterSacrificeBunts : Stat
    {

    }

    public class BatterSacrificeFlies : Stat
    {

    }

    public class TotalBases : Stat
    {

    }

    public class ExtraBaseHits : Stat
    {
    }

    public class BatterDoublePlays : Stat
    {
    }

    public class BatterTriplePlays : Stat
    {
    }

    public class BatterGroundOuts : Stat
    {
    }

    public class BatterFlyOuts : Stat
    {
    }

    public class BatterGroundOutToFlyOutRatio : Stat
    {
    }

    public class PitchesFaced : Stat
    {
    }

    public class PlateAppearances : Stat
    {
    }

    public class LeftOnBase : Stat
    {
    }

    public class Wins : Stat
    {
    }

    public class Losses : Stat
    {
    }

    public class EarnedRunAvg : Stat
    {
    }

    public class Saves : Stat
    {
    }

    public class SaveOpportunities : Stat
    {
    }

    public class InningsPitched : Stat
    {
    }

    public class HitsAllowed : Stat
    {
    }

    public class SecondBaseHitsAllowed : Stat
    {
    }

    public class ThirdBaseHitsAllowed : Stat
    {
    }

    public class RunsAllowed : Stat
    {
    }

    public class EarnedRunsAllowed : Stat
    {
    }

    public class HomerunsAllowed : Stat
    {
    }

    public class PitcherWalks : Stat
    {
    }

    public class PitcherSwings : Stat
    {
    }

    public class PitcherStrikes : Stat
    {
    }

    public class PitcherStrikesFoul : Stat
    {
    }

    public class PitcherStrikesMiss : Stat
    {
    }

    public class PitcherStrikesLooking : Stat
    {
    }

    public class PitcherGroundBalls : Stat
    {
    }

    public class PitcherFlyBalls : Stat
    {
    }

    public class PitcherLineDrives : Stat
    {
    }

    public class Pitcher2SeamFastballs : Stat
    {
    }

    public class Pitcher4SeamFastballs : Stat
    {
    }

    public class PitcherCurveballs : Stat
    {
    }

    public class PitcherChangeups : Stat
    {
    }

    public class PitcherCutters : Stat
    {
    }

    public class PitcherSliders : Stat
    {
    }

    public class PitcherSinkers : Stat
    {
    }

    public class PitcherSplitters : Stat
    {
    }

    public class PitcherSacrificeBunts : Stat
    {
    }

    public class PitcherSacrificeFlies : Stat
    {
    }

    public class PitcherStrikeouts : Stat
    {
    }

    public class PitchingAvg : Stat
    {
    }

    public class WalksAndHitsPerInningPitched : Stat
    {
    }

    public class CompletedGames : Stat
    {
    }

    public class Shutouts : Stat
    {
    }

    public class BattersHit : Stat
    {
    }

    public class PitcherIntentionalWalks : Stat
    {
    }

    public class GamesFinished : Stat
    {
    }

    public class Holds : Stat
    {
    }

    public class PitcherDoublePlays : Stat
    {
    }

    public class PitcherTriplePlays : Stat
    {
    }

    public class PitcherGroundOuts : Stat
    {
    }

    public class PitcherFlyOuts : Stat
    {
    }

    public class PitcherWildPitches : Stat
    {
    }

    public class Balks : Stat
    {
    }

    public class PitcherStolenBasesAllowed : Stat
    {
    }

    public class PitcherCaughtStealing : Stat
    {
    }

    public class PickoffAttempts : Stat
    {
    }

    public class Pickoffs : Stat
    {
    }

    public class TotalBattersFaced : Stat
    {
    }

    public class PitchesThrown : Stat
    {
    }

    public class WinPct : Stat
    {
    }

    public class PitcherGroundOutToFlyOutRatio : Stat
    {
    }

    public class PitcherOnBasePct : Stat
    {
    }

    public class PitcherSluggingPct : Stat
    {
    }

    public class PitcherOnBasePlusSluggingPct : Stat
    {
    }

    public class StrikeoutsPer9Innings : Stat
    {
    }

    public class WalksAllowedPer9Innings : Stat
    {
    }

    public class HitsAllowedPer9Innings : Stat
    {
    }

    public class StrikeoutsToWalksRatio : Stat
    {
    }

    public class PitchesPerInning : Stat
    {
    }

    public class PitcherAtBats : Stat
    {
    }

    public class InningsPlayed : Stat
    {
    }

    public class TotalChances : Stat
    {
    }

    public class FielderTagOuts : Stat
    {
    }

    public class FielderForceOuts : Stat
    {
    }

    public class FielderPutOuts : Stat
    {
    }

    public class OutsFaced : Stat
    {
    }

    public class Assists : Stat
    {
    }

    public class Errors : Stat
    {
    }

    public class FielderDoublePlays : Stat
    {
    }

    public class FielderTriplePlays : Stat
    {
    }

    public class FielderStolenBasesAllowed : Stat
    {
    }

    public class FielderCaughtStealing : Stat
    {
    }

    public class FielderStolenBasePct : Stat
    {
    }

    public class PassedBalls : Stat
    {
    }

    public class FielderWildPitches : Stat
    {
    }

    public class FieldingPct : Stat
    {
    }

    public class RangeFactor : Stat
    {
    }

    public class GamesStarted : Stat
    {
    }

    public class Stats
    {
        public AtBatStats AtBats { get; set; }
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
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public EarnedRunAvg EarnedRunAvg { get; set; }
        public Saves Saves { get; set; }
        public SaveOpportunities SaveOpportunities { get; set; }
        public InningsPitched InningsPitched { get; set; }
        public HitsAllowed HitsAllowed { get; set; }
        public SecondBaseHitsAllowed SecondBaseHitsAllowed { get; set; }
        public ThirdBaseHitsAllowed ThirdBaseHitsAllowed { get; set; }
        public RunsAllowed RunsAllowed { get; set; }
        public EarnedRunsAllowed EarnedRunsAllowed { get; set; }
        public HomerunsAllowed HomerunsAllowed { get; set; }
        public PitcherWalks PitcherWalks { get; set; }
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
        public PitcherStrikeouts PitcherStrikeouts { get; set; }
        public PitchingAvg PitchingAvg { get; set; }
        public WalksAndHitsPerInningPitched WalksAndHitsPerInningPitched { get; set; }
        public CompletedGames CompletedGames { get; set; }
        public Shutouts Shutouts { get; set; }
        public BattersHit BattersHit { get; set; }
        public PitcherIntentionalWalks PitcherIntentionalWalks { get; set; }
        public GamesFinished GamesFinished { get; set; }
        public Holds Holds { get; set; }
        public PitcherDoublePlays PitcherDoublePlays { get; set; }
        public PitcherTriplePlays PitcherTriplePlays { get; set; }
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
        public WinPct WinPct { get; set; }
        public PitcherGroundOutToFlyOutRatio PitcherGroundOutToFlyOutRatio { get; set; }
        public PitcherOnBasePct PitcherOnBasePct { get; set; }
        public PitcherSluggingPct PitcherSluggingPct { get; set; }
        public PitcherOnBasePlusSluggingPct PitcherOnBasePlusSluggingPct { get; set; }
        public StrikeoutsPer9Innings StrikeoutsPer9Innings { get; set; }
        public WalksAllowedPer9Innings WalksAllowedPer9Innings { get; set; }
        public HitsAllowedPer9Innings HitsAllowedPer9Innings { get; set; }
        public StrikeoutsToWalksRatio StrikeoutsToWalksRatio { get; set; }
        public PitchesPerInning PitchesPerInning { get; set; }
        public PitcherAtBats PitcherAtBats { get; set; }
        public InningsPlayed InningsPlayed { get; set; }
        public TotalChances TotalChances { get; set; }
        public FielderTagOuts FielderTagOuts { get; set; }
        public FielderForceOuts FielderForceOuts { get; set; }
        public FielderPutOuts FielderPutOuts { get; set; }
        public OutsFaced OutsFaced { get; set; }
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
        public RangeFactor RangeFactor { get; set; }
        public GamesStarted GamesStarted { get; set; }
    }

    public class Gamelog
    {
        public Game game { get; set; }
        public Player player { get; set; }
        public Team team { get; set; }
        public Stats stats { get; set; }
    }

    public class Playergamelogs
    {
        public string lastUpdatedOn { get; set; }
        public List<Gamelog> gamelogs { get; set; }
    }
}
