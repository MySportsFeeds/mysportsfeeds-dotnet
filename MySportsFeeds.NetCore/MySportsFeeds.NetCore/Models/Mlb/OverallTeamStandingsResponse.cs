using System.Collections.Generic;
using Newtonsoft.Json;
using MySportsFeeds.NetCore.Models;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class OverallTeamStandingsResponse
    {

        /// <summary>
        /// Gets or sets the overallteamstandings.
        /// </summary>
        /// <value>
        /// The overallteamstandings.
        /// </value>
        public Overallteamstandings overallteamstandings { get; set; }
    }

    public class OverallTeamStandingsStats
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

    public class Teamstandingsentry
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
        public OverallTeamStandingsStats Stats { get; set; }
    }

    public class Overallteamstandings
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
        /// Gets or sets the team standings entry.
        /// </summary>
        /// <value>
        /// The team standings entry.
        /// </value>
        [JsonProperty("teamstandingsentry")]
        public List<Teamstandingsentry> TeamStandingsEntry { get; set; }
    }
}
