using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models
{
    public class CurrentSeasonResponse
    {
        [JsonProperty("currentseason")]
        public CurrentSeason CurrentSeason { get; set; }
    }
    
    public class Details
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("intervalType")]
        public string IntervalType { get; set; }
    }

    public class TeamStat
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class SupportedTeamStats
    {
        [JsonProperty("teamStat")]
        public List<TeamStat> TeamStat { get; set; }
    }

    public class PlayerStat
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class SupportedPlayerStats
    {
        [JsonProperty("playerStat")]
        public List<PlayerStat> PlayerStat { get; set; }
    }

    public class Season
    {
        [JsonProperty("details")]
        public Details Details { get; set; }

        [JsonProperty("supportedTeamStats")]
        public SupportedTeamStats SupportedTeamStats { get; set; }

        [JsonProperty("supportedPlayerStats")]
        public SupportedPlayerStats SupportedPlayerStats { get; set; }
    }

    public class CurrentSeason
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("season")]
        public List<Season> Season { get; set; }
    }
}