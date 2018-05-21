using Newtonsoft.Json;
using System.Collections.Generic;

namespace MySportsFeeds.NetCore.Models
{
    public class GamePlayByPlayResponse
    {
        [JsonProperty("gameplaybyplay")]
        public Gameplaybyplay GamePlayByPlay { get; set; }
    }

    public class Gameplaybyplay
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("atBats")]
        public AtBats AtBats { get; set; }
    }

    public class BattingTeam
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Abbreviation")]
        public string Abbreviation { get; set; }
    }
    
    public class BatterUp
    {
        [JsonProperty("battingPlayer")]
        public BattingPlayer BattingPlayer { get; set; }

        [JsonProperty("standingLeftOrRight")]
        public string StandingLeftOrRight { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }
    
    public class Pitch
    {
        [JsonProperty("battingPlayer")]
        public BattingPlayer2 BattingPlayer { get; set; }

        [JsonProperty("pitchingPlayer")]
        public PitchingPlayer PitchingPlayer { get; set; }

        [JsonProperty("throwingLeftOrRight")]
        public string ThrowingLeftOrRight { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("ballStartSpeed")]
        public string BallStartSpeed { get; set; }

        [JsonProperty("ballEndSpeed")]
        public string BallEndSpeed { get; set; }

        [JsonProperty("pitchedLocationX")]
        public string PitchedLocationX { get; set; }

        [JsonProperty("pitchedLocationY")]
        public string PitchedLocationY { get; set; }
    }
    
    public class Hit
    {
        [JsonProperty("battingPlayer")]
        public BattingPlayer3 BattingPlayer { get; set; }

        [JsonProperty("pitchingPlayer")]
        public PitchingPlayer2 PitchingPlayer { get; set; }

        [JsonProperty("hitType")]
        public string HitType { get; set; }

        [JsonProperty("isOut")]
        public string IsOut { get; set; }

        [JsonProperty("isCaughtOut")]
        public string IsCaughtOut { get; set; }

        [JsonProperty("isError")]
        public string IsError { get; set; }

        [JsonProperty("retrievedByPlayer")]
        public RetrievedByPlayer RetrievedByPlayer { get; set; }

        [JsonProperty("retrievedAtLocationX")]
        public string RetrievedAtLocationX { get; set; }

        [JsonProperty("retrievedAtLocationY")]
        public string RetrievedAtLocationY { get; set; }
    }
    
    public class BaseRunAttempt
    {
        [JsonProperty("runningPlayer")]
        public RunningPlayer RunningPlayer { get; set; }

        [JsonProperty("fromBase")]
        public string FromBase { get; set; }

        [JsonProperty("toBase")]
        public string ToBase { get; set; }

        [JsonProperty("isSafe")]
        public string IsSafe { get; set; }

        [JsonProperty("isRunScored")]
        public string IsRunScored { get; set; }

        [JsonProperty("isForcedOut")]
        public string IsForcedOut { get; set; }

        [JsonProperty("isWalk")]
        public string IsWalk { get; set; }

        [JsonProperty("isWalkIntentional")]
        public string IsWalkIntentional { get; set; }

        [JsonProperty("isPassedBall")]
        public string IsPassedBall { get; set; }

        [JsonProperty("isWildPitch")]
        public string IsWildPitch { get; set; }

        [JsonProperty("isEarnedRun")]
        public string IsEarnedRun { get; set; }
    }
    
    public class PickoffAttempt
    {
        [JsonProperty("pitchingPlayer")]
        public PitchingPlayer3 PitchingPlayer { get; set; }

        [JsonProperty("runningPlayer")]
        public RunningPlayer2 RunningPlayer { get; set; }

        [JsonProperty("catchingPlayer")]
        public CatchingPlayer CatchingPlayer { get; set; }

        [JsonProperty("toBase")]
        public string ToBase { get; set; }

        [JsonProperty("isSuccessful")]
        public string IsSuccessful { get; set; }
    }
    
    public class BallThrow
    {
        [JsonProperty("fromPlayer")]
        public FromPlayer FromPlayer { get; set; }

        [JsonProperty("toPlayer")]
        public ToPlayer ToPlayer { get; set; }

        [JsonProperty("fromBase")]
        public string FromBase { get; set; }

        [JsonProperty("toBase")]
        public string ToBase { get; set; }

        [JsonProperty("isCaught")]
        public string IsCaught { get; set; }

        [JsonProperty("isRunningPlayerOut")]
        public string IsRunningPlayerOut { get; set; }

        [JsonProperty("isTagOut")]
        public string IsTagOut { get; set; }

        [JsonProperty("isForceOut")]
        public string IsForceOut { get; set; }

        [JsonProperty("isThrowingError")]
        public string IsThrowingError { get; set; }

        [JsonProperty("isCatchingError")]
        public string IsCatchingError { get; set; }

        [JsonProperty("runningPlayer")]
        public RunningPlayer3 RunningPlayer { get; set; }
    }
    
    public class PlayerSubstitution
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("outgoingPlayer")]
        public OutgoingPlayer OutgoingPlayer { get; set; }

        [JsonProperty("incomingPlayer")]
        public IncomingPlayer IncomingPlayer { get; set; }
    }

    public class AtBatPlay
    {
        [JsonProperty("batterUp")]
        public BatterUp BatterUp { get; set; }

        [JsonProperty("pitch")]
        public Pitch Pitch { get; set; }

        [JsonProperty("hit")]
        public Hit Hit { get; set; }

        [JsonProperty("baseRunAttempt")]
        public BaseRunAttempt BaseRunAttempt { get; set; }

        [JsonProperty("pickoffAttempt")]
        public PickoffAttempt PickoffAttempt { get; set; }

        [JsonProperty("ballThrow")]
        public BallThrow BallThrow { get; set; }

        [JsonProperty("playerSubstitution")]
        public PlayerSubstitution PlayerSubstitution { get; set; }
    }

    public class AtBat
    {
        [JsonProperty("inning")]
        public string Inning { get; set; }

        [JsonProperty("inningHalf")]
        public string InningHalf { get; set; }

        [JsonProperty("battingTeam")]
        public BattingTeam BattingTeam { get; set; }

        [JsonProperty("atBatPlay")]
        public List<AtBatPlay> AtBatPlay { get; set; }
    }

    public class AtBats
    {
        [JsonProperty("atBat")]
        public List<AtBat> AtBat { get; set; }
    }
}
