using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySportsFeeds.NetCore.Models
{
    public class ScoreboardResponse
    {
        [JsonProperty("scoreboard")]
        public Scoreboard Scoreboard { get; set; }
    }
    
    public class ScoreboardGame : Game
    {
        [JsonProperty("scheduleStatus")]
        public string ScheduleStatus { get; set; }

        [JsonProperty("originalDate")]
        public object OriginalDate { get; set; }

        [JsonProperty("originalTime")]
        public object OriginalTime { get; set; }

        [JsonProperty("delayedOrPostponedReason")]
        public object DelayedOrPostponedReason { get; set; }
    }

    public class Inning
    {
        [JsonProperty("@number")]
        public string Number { get; set; }

        [JsonProperty("awayScore")]
        public string AwayScore { get; set; }

        [JsonProperty("homeScore")]
        public string HomeScore { get; set; }
    }

    public class InningSummary
    {
        [JsonProperty("inning")]
        public List<Inning> Inning { get; set; }
    }

    public class GameScore
    {
        [JsonProperty("game")]
        public ScoreboardGame Game { get; set; }

        [JsonProperty("isUnplayed")]
        public string IsUnplayed { get; set; }

        [JsonProperty("isInProgress")]
        public string IsInProgress { get; set; }

        [JsonProperty("isCompleted")]
        public string IsCompleted { get; set; }

        [JsonProperty("playStatus")]
        public object PlayStatus { get; set; }

        [JsonProperty("awayScore")]
        public string AwayScore { get; set; }

        [JsonProperty("homeScore")]
        public string HomeScore { get; set; }

        [JsonProperty("inningSummary")]
        public InningSummary InningSummary { get; set; }
    }

    public class Scoreboard
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("gameScore")]
        public List<GameScore> GameScore { get; set; }
    }
}
