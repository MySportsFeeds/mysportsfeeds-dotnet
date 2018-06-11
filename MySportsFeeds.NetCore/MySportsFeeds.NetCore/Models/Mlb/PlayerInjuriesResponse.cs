using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class PlayerInjuriesResponse
    {
        /// <summary>
        /// Gets or sets the player injuries.
        /// </summary>
        /// <value>
        /// The player injuries.
        /// </value>
        [JsonProperty("playerinjuries")]
        public PlayerInjuries PlayerInjuries { get; set; }
    }

    public class InjuredPlayer : Player
    {

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public string Height { get; set; }
        
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public string Weight { get; set; }
        
        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        public string BirthDate { get; set; }
        
        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public string Age { get; set; }
        
        /// <summary>
        /// Gets or sets the birth city.
        /// </summary>
        /// <value>
        /// The birth city.
        /// </value>
        public string BirthCity { get; set; }
        
        /// <summary>
        /// Gets or sets the birth country.
        /// </summary>
        /// <value>
        /// The birth country.
        /// </value>
        public string BirthCountry { get; set; }
        
        /// <summary>
        /// Gets or sets the is rookie.
        /// </summary>
        /// <value>
        /// The is rookie.
        /// </value>
        public string IsRookie { get; set; }
    }

    public class PlayerEntry
    {
        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        [JsonProperty("player")]
        public InjuredPlayer Player { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        [JsonProperty("team")]
        public Team Team { get; set; }

        /// <summary>
        /// Gets or sets the injury.
        /// </summary>
        /// <value>
        /// The injury.
        /// </value>
        [JsonProperty("injury")]
        public string Injury { get; set; }
    }

    public class PlayerInjuries
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
        /// Gets or sets the player entry.
        /// </summary>
        /// <value>
        /// The player entry.
        /// </value>
        [JsonProperty("playerentry")]
        public List<PlayerEntry> PlayerEntry { get; set; }
    }
}
