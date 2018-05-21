using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models
{
    public class BattingPlayer : Player
    {
    }

    public class BattingPlayer2 : Player
    {  
    }

    public class BattingPlayer3 : Player
    {
    }

    public class PitchingPlayer : Player
    {
    }
    
    public class PitchingPlayer2 : Player
    {  
    }

    public class PitchingPlayer3 : Player
    {
    }

    public class RetrievedByPlayer : Player
    {  
    }
    
    public class RunningPlayer : Player
    {   
    }
    
    public class RunningPlayer2 : Player
    {  
    }

    public class RunningPlayer3 : Player
    {
    }

    public class CatchingPlayer : Player
    {  
    }

    public class FromPlayer : Player
    {
    }

    public class ToPlayer : Player
    {
    }
    
    public class OutgoingPlayer : Player
    {
    }

    public class IncomingPlayer : Player
    {
    }

    public class Player
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("JerseyNumber")]
        public string JerseyNumber { get; set; }

        [JsonProperty("Position")]
        public string Position { get; set; }
    }
}
