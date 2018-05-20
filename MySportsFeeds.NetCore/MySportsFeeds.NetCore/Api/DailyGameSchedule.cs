using MySportsFeeds.NetCore.Enums;
using MySportsFeeds.NetCore.Helpers;
using MySportsFeeds.NetCore.Models;
using MySportsFeeds.NetCore.Workers;
using System.Threading.Tasks;

namespace MySportsFeeds.NetCore.Api
{
    public class DailyGameSchedule
    {
        private const string Url = "v1.2/pull/{0}/{1}/daily_game_schedule.json";
       
        private HttpCommunicationWorker _httpWorker;

        internal DailyGameSchedule(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        public async Task<DailyGameScheduleResponse> Get(League league, int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            string requestUrl = UrlBuilder.FormatRestApiUrl(Url, league, year, seasonType, requestOptions);

            return await _httpWorker.GetAsync<DailyGameScheduleResponse>(requestUrl).ConfigureAwait(false);
        }
    }
}
