using System.Threading.Tasks;

using MySportsFeeds.NetCore.Enums;
using MySportsFeeds.NetCore.Helpers;
using MySportsFeeds.NetCore.Models;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore.Api
{
    public class Scoreboard
    {
        /// <summary>
        /// The URL
        /// </summary>
        private const string Url = "v1.2/pull/{0}/{1}/scoreboard.json";

        /// <summary>
        /// The HTTP worker
        /// </summary>
        private HttpCommunicationWorker _httpWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="Scoreboard"/> class.
        /// </summary>
        /// <param name="httpWorker">The HTTP worker.</param>
        internal Scoreboard(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }
        
        public async Task<ScoreboardResponse> Get(League league, int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            string requestUrl = UrlBuilder.FormatRestApiUrl(Url, league, year, seasonType, requestOptions);

            return await _httpWorker.GetAsync<ScoreboardResponse>(requestUrl).ConfigureAwait(false);
        }
    }
}
