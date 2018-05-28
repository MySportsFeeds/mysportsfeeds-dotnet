using System;
using System.Threading.Tasks;
using MySportsFeeds.NetCore.Enums;
using MySportsFeeds.NetCore.Helpers;
using MySportsFeeds.NetCore.Models;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore.Api
{
    public class ActivePlayers
    {
        /// <summary>
        /// The URL
        /// </summary>
        private const string Url = "/pull/{0}/{1}/active_players.json";

        /// <summary>
        /// The HTTP worker
        /// </summary>
        private HttpCommunicationWorker _httpWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivePlayers"/> class.
        /// </summary>
        /// <param name="httpWorker">The HTTP worker.</param>
        internal ActivePlayers(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        /// <summary>
        /// Gets the Active Players.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <param name="year">The year.</param>
        /// <param name="seasonType">Type of the season.</param>
        /// <param name="requestOptions">The request options.</param>
        /// <returns></returns>
        public async Task<ActivePlayersResponse> Get(League league, int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            var url = string.Concat(_httpWorker.Version, Url);
            string requestUrl = UrlBuilder.FormatRestApiUrl(url, league, year, seasonType, requestOptions);

            return await _httpWorker.GetAsync<ActivePlayersResponse>(requestUrl).ConfigureAwait(false);
        }
    }
}
