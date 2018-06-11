using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.Models.Mlb
{
    public class GameBoxScoreResponse
    {
        /// <summary>
        /// Gets or sets the game box score.
        /// </summary>
        /// <value>
        /// The game box score.
        /// </value>
        [JsonProperty("gameboxscore")]
        public Gameboxscore GameBoxScore { get; set; }
    }

    public class ScoringPlay
    {
        /// <summary>
        /// Gets or sets the team abbreviation.
        /// </summary>
        /// <value>
        /// The team abbreviation.
        /// </value>
        [JsonProperty("teamAbbreviation")]
        public string TeamAbbreviation { get; set; }
        
        /// <summary>
        /// Gets or sets the play description.
        /// </summary>
        /// <value>
        /// The play description.
        /// </value>
        [JsonProperty("playDescription")]
        public string PlayDescription { get; set; }
    }
    
    public class Scoring
    {
        /// <summary>
        /// Gets or sets the scoring play.
        /// </summary>
        /// <value>
        /// The scoring play.
        /// </value>
        [JsonProperty("scoringPlay")]
        public List<ScoringPlay> ScoringPlay { get; set; }
    }
    
    public class GameBoxScoreInning : Inning
    {
        /// <summary>
        /// Gets or sets the scoring.
        /// </summary>
        /// <value>
        /// The scoring.
        /// </value>
        [JsonProperty("scoring")]
        public Scoring Scoring { get; set; }
    }
    
    public class InningTotals
    {
        /// <summary>
        /// Gets or sets the away score.
        /// </summary>
        /// <value>
        /// The away score.
        /// </value>
        [JsonProperty("awayScore")]
        public string AwayScore { get; set; }

        /// <summary>
        /// Gets or sets the home score.
        /// </summary>
        /// <value>
        /// The home score.
        /// </value>
        [JsonProperty("homeScore")]
        public string HomeScore { get; set; }
    }
    
    public class BoxScoreInningSummary
    {
        /// <summary>
        /// Gets or sets the inning.
        /// </summary>
        /// <value>
        /// The inning.
        /// </value>
        [JsonProperty("inning")]
        public List<GameBoxScoreInning> Inning { get; set; }

        /// <summary>
        /// Gets or sets the inning totals.
        /// </summary>
        /// <value>
        /// The inning totals.
        /// </value>
        [JsonProperty("inningTotals")]
        public InningTotals InningTotals { get; set; }
    }
    
    public class AwayTeamStats
    {
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
    
    public class GameBoxScoreStats
    {
        /// <summary>
        /// Gets or sets at bats.
        /// </summary>
        /// <value>
        /// At bats.
        /// </value>
        public AtBatStats AtBats { get; set; }
        
        /// <summary>
        /// Gets or sets the runs.
        /// </summary>
        /// <value>
        /// The runs.
        /// </value>
        public Runs Runs { get; set; }
        
        /// <summary>
        /// Gets or sets the hits.
        /// </summary>
        /// <value>
        /// The hits.
        /// </value>
        public Hits Hits { get; set; }
        
        /// <summary>
        /// Gets or sets the homeruns.
        /// </summary>
        /// <value>
        /// The homeruns.
        /// </value>
        public Homeruns Homeruns { get; set; }
        
        /// <summary>
        /// Gets or sets the earned runs.
        /// </summary>
        /// <value>
        /// The earned runs.
        /// </value>
        public EarnedRuns EarnedRuns { get; set; }
        
        /// <summary>
        /// Gets or sets the hits allowed.
        /// </summary>
        /// <value>
        /// The hits allowed.
        /// </value>
        public HitsAllowed HitsAllowed { get; set; }
        
        /// <summary>
        /// Gets or sets the runs allowed.
        /// </summary>
        /// <value>
        /// The runs allowed.
        /// </value>
        public RunsAllowed RunsAllowed { get; set; }
        
        /// <summary>
        /// Gets or sets the earned runs allowed.
        /// </summary>
        /// <value>
        /// The earned runs allowed.
        /// </value>
        public EarnedRunsAllowed EarnedRunsAllowed { get; set; }
        
        /// <summary>
        /// Gets or sets the homeruns allowed.
        /// </summary>
        /// <value>
        /// The homeruns allowed.
        /// </value>
        public HomerunsAllowed HomerunsAllowed { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class GameBoxScorePlayerEntry
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
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        [JsonProperty("stats")]
        public GameBoxScoreStats Stats { get; set; }
    }

    public class AwayPlayers
    {

        /// <summary>
        /// Gets or sets the player entry.
        /// </summary>
        /// <value>
        /// The player entry.
        /// </value>
        [JsonProperty("playerEntry")]
        public List<GameBoxScorePlayerEntry> PlayerEntry { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AwayTeam2
    {
        /// <summary>
        /// Gets or sets the away team stats.
        /// </summary>
        /// <value>
        /// The away team stats.
        /// </value>
        [JsonProperty("awayTeamStats")]
        public AwayTeamStats AwayTeamStats { get; set; }

        /// <summary>
        /// Gets or sets the away players.
        /// </summary>
        /// <value>
        /// The away players.
        /// </value>
        [JsonProperty("awayPlayers")]
        public AwayPlayers AwayPlayers { get; set; }
    }

    public class Wins2 : Stat
    {
    }

    public class Losses2 : Stat
    {
    }

    public class RunsFor2 : Stat
    {
    }

    public class RunsAgainst2 : Stat
    {
    }

    public class HomeTeamStats
    {
        /// <summary>
        /// Gets or sets the wins.
        /// </summary>
        /// <value>
        /// The wins.
        /// </value>
        public Wins2 Wins { get; set; }

        /// <summary>
        /// Gets or sets the losses.
        /// </summary>
        /// <value>
        /// The losses.
        /// </value>
        public Losses2 Losses { get; set; }
        
        /// <summary>
        /// Gets or sets the runs for.
        /// </summary>
        /// <value>
        /// The runs for.
        /// </value>
        public RunsFor2 RunsFor { get; set; }
        
        /// <summary>
        /// Gets or sets the runs against.
        /// </summary>
        /// <value>
        /// The runs against.
        /// </value>
        public RunsAgainst2 RunsAgainst { get; set; }
    }

    public class Player2 : Player
    {
    }
    
    public class AtBats2 : Stat
    {  
    }

   
    public class Runs2 : Stat
    {
    }

    public class Hits2 : Stat
    {
    }

    public class Homeruns2 : Stat
    {
    }

    public class EarnedRuns2 : Stat
    {
    }

    public class HitsAllowed2 : Stat
    {
    }

    public class RunsAllowed2 : Stat
    {
    }

    public class EarnedRunsAllowed2 : Stat
    {
    }

    public class HomerunsAllowed2 : Stat
    {
    }
    
    public class Stats2
    {
        /// <summary>
        /// Gets or sets at bats.
        /// </summary>
        /// <value>
        /// At bats.
        /// </value>
        public AtBats2 AtBats { get; set; }

        /// <summary>
        /// Gets or sets the runs.
        /// </summary>
        /// <value>
        /// The runs.
        /// </value>
        public Runs2 Runs { get; set; }

        /// <summary>
        /// Gets or sets the hits.
        /// </summary>
        /// <value>
        /// The hits.
        /// </value>
        public Hits2 Hits { get; set; }

        /// <summary>
        /// Gets or sets the homeruns.
        /// </summary>
        /// <value>
        /// The homeruns.
        /// </value>
        public Homeruns2 Homeruns { get; set; }

        /// <summary>
        /// Gets or sets the earned runs.
        /// </summary>
        /// <value>
        /// The earned runs.
        /// </value>
        public EarnedRuns2 EarnedRuns { get; set; }

        /// <summary>
        /// Gets or sets the hits allowed.
        /// </summary>
        /// <value>
        /// The hits allowed.
        /// </value>
        public HitsAllowed2 HitsAllowed { get; set; }

        /// <summary>
        /// Gets or sets the runs allowed.
        /// </summary>
        /// <value>
        /// The runs allowed.
        /// </value>
        public RunsAllowed2 RunsAllowed { get; set; }

        /// <summary>
        /// Gets or sets the earned runs allowed.
        /// </summary>
        /// <value>
        /// The earned runs allowed.
        /// </value>
        public EarnedRunsAllowed2 EarnedRunsAllowed { get; set; }

        /// <summary>
        /// Gets or sets the homeruns allowed.
        /// </summary>
        /// <value>
        /// The homeruns allowed.
        /// </value>
        public HomerunsAllowed2 HomerunsAllowed { get; set; }
    }
    
    public class PlayerEntry2
    {
        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        [JsonProperty("player")]
        public Player2 Player { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        [JsonProperty("stats")]
        public Stats2 Stats { get; set; }
    }
    
    public class HomePlayers
    {
        /// <summary>
        /// Gets or sets the player entry.
        /// </summary>
        /// <value>
        /// The player entry.
        /// </value>
        [JsonProperty("playerEntry")]
        public List<PlayerEntry2> PlayerEntry { get; set; }
    }
    
    public class HomeTeam2
    {
        /// <summary>
        /// Gets or sets the home team stats.
        /// </summary>
        /// <value>
        /// The home team stats.
        /// </value>
        [JsonProperty("homeTeamStats")]
        public HomeTeamStats HomeTeamStats { get; set; }

        /// <summary>
        /// Gets or sets the home players.
        /// </summary>
        /// <value>
        /// The home players.
        /// </value>
        [JsonProperty("homePlayers")]
        public HomePlayers HomePlayers { get; set; }
    }
    
    public class Gameboxscore
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
        /// Gets or sets the game.
        /// </summary>
        /// <value>
        /// The game.
        /// </value>
        [JsonProperty("game")]
        public Game Game { get; set; }

        /// <summary>
        /// Gets or sets the inning summary.
        /// </summary>
        /// <value>
        /// The inning summary.
        /// </value>
        [JsonProperty("inningSummary")]
        public BoxScoreInningSummary InningSummary { get; set; }

        /// <summary>
        /// Gets or sets the away team.
        /// </summary>
        /// <value>
        /// The away team.
        /// </value>
        [JsonProperty("awayTeam")]
        public AwayTeam2 AwayTeam { get; set; }

        /// <summary>
        /// Gets or sets the home team.
        /// </summary>
        /// <value>
        /// The home team.
        /// </value>
        [JsonProperty("homeTeam")]
        public HomeTeam2 HomeTeam { get; set; }
    }
}