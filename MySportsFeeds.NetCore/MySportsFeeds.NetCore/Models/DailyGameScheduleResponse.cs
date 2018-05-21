using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models
{
    public class DailyGameScheduleResponse
    {
        [JsonProperty("dailygameschedule")]
        public DailyGameSchedule DailyGameSchedule { get; set; }
    }

    public class DailyGameSchedule
    {
        [JsonProperty("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [JsonProperty("gameentry")]
        public List<GameEntry> GameEntry { get; set; }
    }

   
    public class GameEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("scheduleStatus")]
        public string ScheduleStatus { get; set; }

        [JsonProperty("originalDate")]
        public string OriginalDate { get; set; }

        [JsonProperty("originalTime")]
        public string OriginalTime { get; set; }

        [JsonProperty("delayedOrPostponedReason")]
        public string DelayedOrPostponedReason { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("awayTeam")]
        public Team AwayTeam { get; set; }

        [JsonProperty("homeTeam")]
        public HomeTeam HomeTeam { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}