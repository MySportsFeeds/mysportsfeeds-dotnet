using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models
{
    public class CumulativePlayerStatsResponse
    {
        /// <summary>
        /// Gets or sets the cumulativeplayerstats.
        /// </summary>
        /// <value>
        /// The cumulativeplayerstats.
        /// </value>
        [JsonProperty("cumulativeplayerstats")]
        public Cumulativeplayerstats Cumulativeplayerstats { get; set; }
    }

    public class CumulativeStats : StatsBase
    {
        /// <summary>
        /// Gets or sets the games played.
        /// </summary>
        /// <value>
        /// The games played.
        /// </value>
        public GamesPlayed GamesPlayed { get; set; }
    }

    public class PlayerStatsEntry
    {
        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        [JsonProperty("player")]
        public Player Player { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        [JsonProperty("team")]
        public Team Team { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        [JsonProperty("stats")]
        public CumulativeStats Stats { get; set; }
    }
    
    public class Cumulativeplayerstats
    {
        /// <summary>
        /// Gets or sets the last updated on date.
        /// </summary>
        /// <value>
        /// The last updated on.
        /// </value>
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the player stats entry.
        /// </summary>
        /// <value>
        /// The player stats entry.
        /// </value>
        [JsonProperty("playerstatsentry")]
        public List<PlayerStatsEntry> PlayerStatsEntry { get; set; }
    }        
}
