using System;
using System.Threading.Tasks;
using MySportsFeeds.NetCore.Enums;
using MySportsFeeds.NetCore.Helpers;
using MySportsFeeds.NetCore.Models;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore.Api
{
    public class ConferenceTeamStandings
    {
        /// <summary>
        /// The URL
        /// </summary>
        private const string Url = "/pull/{0}/{1}/conference_team_standings.json";

        /// <summary>
        /// The HTTP worker
        /// </summary>
        private HttpCommunicationWorker _httpWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceTeamStandings"/> class.
        /// </summary>
        /// <param name="httpWorker">The HTTP worker.</param>
        internal ConferenceTeamStandings(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        /// <summary>
        /// Gets the Conference Team Standings.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <param name="year">The year.</param>
        /// <param name="seasonType">Type of the season.</param>
        /// <param name="requestOptions">The request options.</param>
        /// <returns></returns>
        public async Task<ConferenceTeamStandingsResponse> Get(League league, int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            var url = string.Concat(_httpWorker.Version, Url);
            string requestUrl = UrlBuilder.FormatRestApiUrl(url, league, year, seasonType, requestOptions);

            return await _httpWorker.GetAsync<ConferenceTeamStandingsResponse>(requestUrl).ConfigureAwait(false);
        }
    }
}