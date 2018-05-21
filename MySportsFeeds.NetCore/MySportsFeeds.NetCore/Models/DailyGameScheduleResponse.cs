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
    
    public class GameEntry : Game
    {
        [JsonProperty("scheduleStatus")]
        public string ScheduleStatus { get; set; }

        [JsonProperty("originalDate")]
        public string OriginalDate { get; set; }

        [JsonProperty("originalTime")]
        public string OriginalTime { get; set; }

        [JsonProperty("delayedOrPostponedReason")]
        public string DelayedOrPostponedReason { get; set; }
    }
}