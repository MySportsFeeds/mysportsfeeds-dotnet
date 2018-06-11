using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class PlayoffTeamStandingsResponse
    {
        /// <summary>
        /// Gets or sets the playoff team standings.
        /// </summary>
        /// <value>
        /// The playoff team standings.
        /// </value>
        [JsonProperty("playoffteamstandings")]
        public Playoffteamstandings PlayoffTeamStandings { get; set; }
    }
    
    public class PlayoffTeamStandingsStats
    {
        /// <summary>
        /// Gets or sets the games played.
        /// </summary>
        /// <value>
        /// The games played.
        /// </value>
        public GamesPlayed GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets the wins.
        /// </summary>
        /// <value>
        /// The wins.
        /// </value>
        public Wins Wins { get; set; }
        
        /// <summary>
        /// Gets or sets the losses.
        /// </summary>
        /// <value>
        /// The losses.
        /// </value>
        public Losses Losses { get; set; }
        
        /// <summary>
        /// Gets or sets the runs for.
        /// </summary>
        /// <value>
        /// The runs for.
        /// </value>
        public RunsFor RunsFor { get; set; }
    
        /// <summary>
        /// Gets or sets the runs against.
        /// </summary>
        /// <value>
        /// The runs against.
        /// </value>
        public RunsAgainst RunsAgainst { get; set; }
    }

    public class PlayoffTeamStandingsTeamEntry
    {
        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        [JsonProperty("team")]
        public Team Team { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>
        /// The rank.
        /// </value>
        [JsonProperty("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        [JsonProperty("stats")]
        public PlayoffTeamStandingsStats Stats { get; set; }
    }

    public class PlayoffTeamStandingsConference
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("@name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the team entry.
        /// </summary>
        /// <value>
        /// The team entry.
        /// </value>
        [JsonProperty("teamentry")]
        public List<PlayoffTeamStandingsTeamEntry> TeamEntry { get; set; }
    }

    public class Playoffteamstandings
    {
        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>
        /// The last updated on.
        /// </value>
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the conference.
        /// </summary>
        /// <value>
        /// The conference.
        /// </value>
        [JsonProperty("conference")]
        public List<PlayoffTeamStandingsConference> Conference { get; set; }
    }
}