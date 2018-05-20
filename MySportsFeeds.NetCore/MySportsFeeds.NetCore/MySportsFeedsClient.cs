using MySportsFeeds.NetCore.Api;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore
{
    public class MySportsFeedsClient
    {
        private HttpCommunicationWorker _httpWorker;
        
        public MySportsFeedsClient(string baseUrl, string username, string password)
        {
            _httpWorker = new HttpCommunicationWorker(baseUrl, username, password);
            InjectDependencies();
        }

        private void InjectDependencies()
        {
            DailyGameSchedule = new DailyGameSchedule(_httpWorker);
        }

        public DailyGameSchedule DailyGameSchedule { get; private set; }
    }
}
