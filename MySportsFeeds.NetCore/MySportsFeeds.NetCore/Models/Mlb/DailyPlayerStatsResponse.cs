using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class DailyPlayerStatsResponse
    {
        [JsonProperty("dailyplayerstats")]
        public Dailyplayerstats DailyPlayerStats { get; set; }
    }
  
    public class PlayerStats
    {
        public AtBatStats AtBats { get; set; }
        public Runs Runs { get; set; }
        public Hits Hits { get; set; }
        public Homeruns Homeruns { get; set; }
        public EarnedRuns EarnedRuns { get; set; }
        public HitsAllowed HitsAllowed { get; set; }
        public RunsAllowed RunsAllowed { get; set; }
        public EarnedRunsAllowed EarnedRunsAllowed { get; set; }
        public HomerunsAllowed HomerunsAllowed { get; set; }
    }

    public class Playerstatsentry
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("stats")]
        public PlayerStats Stats { get; set; }
    }

    public class Dailyplayerstats
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("playerstatsentry")]
        public List<Playerstatsentry> PlayerStatsEntry { get; set; }
    }
}
