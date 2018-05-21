using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models
{
    public class Game
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("awayTeam")]
        public AwayTeam AwayTeam { get; set; }

        [JsonProperty("homeTeam")]
        public HomeTeam HomeTeam { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
