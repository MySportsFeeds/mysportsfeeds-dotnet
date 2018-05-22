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
            DailyGameSchedule = new DailyGameSchedule(_httpWorker);
            Scoreboard = new Scoreboard(_httpWorker);
            GamePlayByPlay = new GamePlayByPlay(_httpWorker);
            CurrentSeason = new CurrentSeason(_httpWorker);
        }

        /// <summary>
        /// Gets the daily game schedule.
        /// </summary>
        /// <value>
        /// The daily game schedule.
        /// </value>
        public DailyGameSchedule DailyGameSchedule { get; private set; }

        /// <summary>
        /// Gets the scoreboard.
        /// </summary>
        /// <value>
        /// The scoreboard.
        /// </value>
        public Scoreboard Scoreboard { get; private set; }
        
        /// <summary>
        /// Gets the game play by play.
        /// </summary>
        /// <value>
        /// The game play by play.
        /// </value>
        public GamePlayByPlay GamePlayByPlay { get; private set; }

        /// <summary>
        /// Gets the current season.
        /// </summary>
        /// <value>
        /// The current season.
        /// </value>
        public CurrentSeason CurrentSeason { get; private set; }
    }
}
