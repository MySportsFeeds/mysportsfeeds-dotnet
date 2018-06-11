using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class DivisionTeamStandingsResponse
    {
        [JsonProperty("divisionteamstandings")]
        public Divisionteamstandings DivisionTeamStandings { get; set; }
    }
    
    public class DivisionTeamStandingStats
    {
        public GamesPlayed GamesPlayed { get; set; }
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public RunsFor RunsFor { get; set; }
        public RunsAgainst RunsAgainst { get; set; }
    }

    public class DivisonTeamEntry
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("stats")]
        public DivisionTeamStandingStats Stats { get; set; }
    }

    public class Division
    {
        [JsonProperty("@name")]
        public string Name { get; set; }

        [JsonProperty("teamentry")]
        public List<DivisonTeamEntry> TeamEntry { get; set; }
    }

    public class Divisionteamstandings
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("division")]
        public List<Division> Division { get; set; }
    }
}
