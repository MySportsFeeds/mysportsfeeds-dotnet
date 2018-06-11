using Newtonsoft.Json;
using System.Collections.Generic;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class ConferenceTeamStandingsResponse
    {
        [JsonProperty("conferenceteamstandings")]
        public ConferenceTeamStandings Conferenceteamstandings { get; set; }
    }
    
    public class RunsFor : Stat
    {  
    }

    public class RunsAgainst : Stat
    {
    }

    public class ConferenceTeamStats
    {
        public GamesPlayed GamesPlayed { get; set; }
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public RunsFor RunsFor { get; set; }
        public RunsAgainst RunsAgainst { get; set; }
    }

    public class TeamEntry
    {
        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("stats")]
        public ConferenceTeamStats Stats { get; set; }
    }

    public class Conference
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("teamentry")]
        public List<TeamEntry> TeamEntry { get; set; }
    }

    public class ConferenceTeamStandings
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("conference")]
        public List<Conference> Conference { get; set; }
    }
}
