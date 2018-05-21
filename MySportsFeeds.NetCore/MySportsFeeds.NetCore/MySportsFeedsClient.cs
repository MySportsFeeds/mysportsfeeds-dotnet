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
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public MySportsFeedsClient(string baseUrl, string username, string password)
        {
            _httpWorker = new HttpCommunicationWorker(baseUrl, username, password);
            InjectDependencies();
        }

        /// <summary>
        /// Injects the dependencies.
        /// </summary>
        private void InjectDependencies()
        {
            DailyGameSchedule = new DailyGameSchedule(_httpWorker);
        }

        /// <summary>
        /// Gets the daily game schedule.
        /// </summary>
        /// <value>
        /// The daily game schedule.
        /// </value>
        public DailyGameSchedule DailyGameSchedule { get; private set; }
    }
}
