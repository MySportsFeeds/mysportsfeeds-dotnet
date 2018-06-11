using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class GameStartingLineupResponse
    {
        [JsonProperty("gamestartinglineup")]
        public GameStartingLineup GameStartingLineup { get; set; }
    }
    
    public class Starter
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }
    }

    public class Expected
    {
        [JsonProperty("starter")]
        public List<Starter> Starter { get; set; }
    }
    
    public class Starter2
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("player")]
        public Player2 Player { get; set; }
    }

    public class Actual
    {
        [JsonProperty("starter")]
        public List<Starter2> Starter { get; set; }
    }

    public class TeamLineup
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("expected")]
        public Expected Expected { get; set; }

        [JsonProperty("actual")]
        public Actual Actual { get; set; }
    }

    public class GameStartingLineup
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("teamLineup")]
        public List<TeamLineup> TeamLineup { get; set; }
    }
    
}
