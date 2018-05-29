using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models
{
    public class Handedness
    {
        /// <summary>
        /// Gets or sets the bats.
        /// </summary>
        /// <value>
        /// The bats.
        /// </value>
        public string Bats { get; set; }

        /// <summary>
        /// Gets or sets the throws.
        /// </summary>
        /// <value>
        /// The throws.
        /// </value>
        public string Throws { get; set; }
    }
    
    public class Draft
    {
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public string Year { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        [JsonProperty("team")]
        public Team Team { get; set; }

        /// <summary>
        /// Gets or sets the round.
        /// </summary>
        /// <value>
        /// The round.
        /// </value>
        public string Round { get; set; }

        /// <summary>
        /// Gets or sets the round pick.
        /// </summary>
        /// <value>
        /// The round pick.
        /// </value>
        public string RoundPick { get; set; }

        /// <summary>
        /// Gets or sets the overall pick.
        /// </summary>
        /// <value>
        /// The overall pick.
        /// </value>
        public string OverallPick { get; set; }
    }
    
    public class ExternalMapping
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public string Source { get; set; }
        
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ID { get; set; }
    }
    
    public class ActivePlayer
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public string Position { get; set; }

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

        /// <summary>
        /// Gets or sets the high school.
        /// </summary>
        /// <value>
        /// The high school.
        /// </value>
        public object HighSchool { get; set; }

        /// <summary>
        /// Gets or sets the college.
        /// </summary>
        /// <value>
        /// The college.
        /// </value>
        public string College { get; set; }

        /// <summary>
        /// Gets or sets the twitter.
        /// </summary>
        /// <value>
        /// The twitter.
        /// </value>
        public object Twitter { get; set; }

        /// <summary>
        /// Gets or sets the roster status.
        /// </summary>
        /// <value>
        /// The roster status.
        /// </value>
        public string RosterStatus { get; set; }


        /// <summary>
        /// Gets or sets the handedness.
        /// </summary>
        /// <value>
        /// The handedness.
        /// </value>
        [JsonProperty("handedness")]
        public Handedness Handedness { get; set; }

        /// <summary>
        /// Gets or sets the draft.
        /// </summary>
        /// <value>
        /// The draft.
        /// </value>
        [JsonProperty("draft")]
        public Draft Draft { get; set; }

        /// <summary>
        /// Gets or sets the current contract year.
        /// </summary>
        /// <value>
        /// The current contract year.
        /// </value>
        [JsonProperty("currentContractYear")]
        public object CurrentContractYear { get; set; }

        /// <summary>
        /// Gets or sets the official image source.
        /// </summary>
        /// <value>
        /// The official image source.
        /// </value>
        [JsonProperty("officialImageSrc")]
        public string OfficialImageSrc { get; set; }

        /// <summary>
        /// Gets or sets the external mapping.
        /// </summary>
        /// <value>
        /// The external mapping.
        /// </value>
        [JsonProperty("externalMapping")]
        public ExternalMapping ExternalMapping { get; set; }

        /// <summary>
        /// Gets or sets the jersey number.
        /// </summary>
        /// <value>
        /// The jersey number.
        /// </value>
        public string JerseyNumber { get; set; }
    }
    
    public class ActivePlayerEntry
    {
        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        [JsonProperty("player")]
        public ActivePlayer Player { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        [JsonProperty("team")]
        public Team2 Team { get; set; }
    }
    
    public class Activeplayers
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
        /// Gets or sets the playerentry.
        /// </summary>
        /// <value>
        /// The playerentry.
        /// </value>
        [JsonProperty("playerentry")]
        public List<ActivePlayerEntry> PlayerEntry { get; set; }
    }
    
    public class ActivePlayersResponse
    {
        /// <summary>
        /// Gets or sets the activeplayers.
        /// </summary>
        /// <value>
        /// The activeplayers.
        /// </value>
        [JsonProperty("activeplayers")]
        public Activeplayers Activeplayers { get; set; }
    }
}