using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class LastUpdatesReponse
    {
        /// <summary>
        /// Gets or sets the latest updates.
        /// </summary>
        /// <value>
        /// The latest updates.
        /// </value>
        [JsonProperty("latestupdates")]
        public Latestupdates LatestUpdates { get; set; }
    }

    public class Feed
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the abbreviation.
        /// </summary>
        /// <value>
        /// The abbreviation.
        /// </value>
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ForGame
    {
        /// <summary>
        /// Gets or sets the game.
        /// </summary>
        /// <value>
        /// The game.
        /// </value>
        [JsonProperty("game")]
        public List<Game> Game { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>
        /// The last updated on.
        /// </value>
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }
    }

    public class Feedentry
    {
        /// <summary>
        /// Gets or sets the feed.
        /// </summary>
        /// <value>
        /// The feed.
        /// </value>
        [JsonProperty("feed")]
        public Feed Feed { get; set; }

        /// <summary>
        /// Gets or sets the last updated on.
        /// </summary>
        /// <value>
        /// The last updated on.
        /// </value>
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets for date.
        /// </summary>
        /// <value>
        /// For date.
        /// </value>
        [JsonProperty("forDate")]
        public object ForDate { get; set; }

        /// <summary>
        /// Gets or sets for game.
        /// </summary>
        /// <value>
        /// For game.
        /// </value>
        [JsonProperty("forGame")]
        public List<ForGame> ForGame { get; set; }
    }

    public class Latestupdates
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
        /// Gets or sets the feed entry.
        /// </summary>
        /// <value>
        /// The feed entry.
        /// </value>
        [JsonProperty("feedentry")]
        public List<Feedentry> FeedEntry { get; set; }
    }
}
