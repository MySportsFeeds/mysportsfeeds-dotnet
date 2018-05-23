using MySportsFeeds.NetCore.Api;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore
{
    /// <summary>
    /// 
    /// </summary>
    public class MySportsFeedsClient
    {
        /// <summary>
        /// The HTTP worker
        /// </summary>
        private HttpCommunicationWorker _httpWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="MySportsFeedsClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="version">The version.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public MySportsFeedsClient(string baseUrl, string version, string username, string password)
        {
            _httpWorker = new HttpCommunicationWorker(baseUrl, version, username, password);
            InjectDependencies();
        }

        /// <summary>
        /// Injects the dependencies.
        /// </summary>
        private void InjectDependencies()
        {
            ActivePlayers = new ActivePlayers(_httpWorker);
            ConferenceTeamStandings = new ConferenceTeamStandings(_httpWorker);
            CumulativePlayerStats = new CumulativePlayerStats(_httpWorker);
            CurrentSeason = new CurrentSeason(_httpWorker);
            DailyDfs = new DailyDfs(_httpWorker);
            DailyGameSchedule = new DailyGameSchedule(_httpWorker);
            DailyPlayerStats = new DailyPlayerStats(_httpWorker);
            DivisionTeamStandings = new DivisionTeamStandings(_httpWorker);
            FullGameSchedule = new FullGameSchedule(_httpWorker);
            GameBoxScore = new GameBoxScore(_httpWorker);
            GamePlayByPlay = new GamePlayByPlay(_httpWorker);
            GameStartingLineup = new GameStartingLineup(_httpWorker);
            LatestUpdates = new LatestUpdates(_httpWorker);
            OverallTeamStandings = new OverallTeamStandings(_httpWorker);
            PlayerGameLogs = new PlayerGameLogs(_httpWorker);
            PlayerInjuries = new PlayerInjuries(_httpWorker);
            PlayoffTeamStandings = new PlayoffTeamStandings(_httpWorker);
            RosterPlayers = new RosterPlayers(_httpWorker);
            Scoreboard = new Scoreboard(_httpWorker);
            TeamGameLogs = new TeamGameLogs(_httpWorker);
        }

        /// <summary>
        /// Gets the active players.
        /// </summary>
        /// <value>
        /// The active players.
        /// </value>
        public ActivePlayers ActivePlayers { get; private set; }

        /// <summary>
        /// Gets the conference team standings.
        /// </summary>
        /// <value>
        /// The conference team standings.
        /// </value>
        public ConferenceTeamStandings ConferenceTeamStandings { get; private set; }

        /// <summary>
        /// Gets the cumulative player stats.
        /// </summary>
        /// <value>
        /// The cumulative player stats.
        /// </value>
        public CumulativePlayerStats CumulativePlayerStats { get; private set; }

        /// <summary>
        /// Gets the current season.
        /// </summary>
        /// <value>
        /// The current season.
        /// </value>
        public CurrentSeason CurrentSeason { get; private set; }

        /// <summary>
        /// Gets the daily DFS.
        /// </summary>
        /// <value>
        /// The daily DFS.
        /// </value>
        public DailyDfs DailyDfs { get; private set; }

        /// <summary>
        /// Gets the daily game schedule.
        /// </summary>
        /// <value>
        /// The daily game schedule.
        /// </value>
        public DailyGameSchedule DailyGameSchedule { get; private set; }

        /// <summary>
        /// Gets the daily player stats.
        /// </summary>
        /// <value>
        /// The daily player stats.
        /// </value>
        public DailyPlayerStats DailyPlayerStats { get; private set; }
        /// <summary>
        /// Gets the division team standings.
        /// </summary>
        /// <value>
        /// The division team standings.
        /// </value>
        public DivisionTeamStandings DivisionTeamStandings { get; private set; }

        /// <summary>
        /// Gets the full game schedule.
        /// </summary>
        /// <value>
        /// The full game schedule.
        /// </value>
        public FullGameSchedule FullGameSchedule { get; private set; }

        /// <summary>
        /// Gets the game box score.
        /// </summary>
        /// <value>
        /// The game box score.
        /// </value>
        public GameBoxScore GameBoxScore { get; private set; }

        /// <summary>
        /// Gets the game play by play.
        /// </summary>
        /// <value>
        /// The game play by play.
        /// </value>
        public GamePlayByPlay GamePlayByPlay { get; private set; }

        /// <summary>
        /// Gets the game starting lineup.
        /// </summary>
        /// <value>
        /// The game starting lineup.
        /// </value>
        public GameStartingLineup GameStartingLineup { get; private set; }

        /// <summary>
        /// Gets the latest updates.
        /// </summary>
        /// <value>
        /// The latest updates.
        /// </value>
        public LatestUpdates LatestUpdates { get; private set; }

        /// <summary>
        /// Gets the overall team standings.
        /// </summary>
        /// <value>
        /// The overall team standings.
        /// </value>
        public OverallTeamStandings OverallTeamStandings { get; private set; }

        /// <summary>
        /// Gets the player game logs.
        /// </summary>
        /// <value>
        /// The player game logs.
        /// </value>
        public PlayerGameLogs PlayerGameLogs { get; private set; }

        /// <summary>
        /// Gets the player injuries.
        /// </summary>
        /// <value>
        /// The player injuries.
        /// </value>
        public PlayerInjuries PlayerInjuries { get; private set; }

        /// <summary>
        /// Gets the playoff team standings.
        /// </summary>
        /// <value>
        /// The playoff team standings.
        /// </value>
        public PlayoffTeamStandings PlayoffTeamStandings { get; private set; }

        /// <summary>
        /// Gets the roster players.
        /// </summary>
        /// <value>
        /// The roster players.
        /// </value>
        public RosterPlayers RosterPlayers { get; private set; }

        /// <summary>
        /// Gets the scoreboard.
        /// </summary>
        /// <value>
        /// The scoreboard.
        /// </value>
        public Scoreboard Scoreboard { get; private set; }

        /// <summary>
        /// Gets the team game logs.
        /// </summary>
        /// <value>
        /// The team game logs.
        /// </value>
        public TeamGameLogs TeamGameLogs { get; private set; }
    }
}