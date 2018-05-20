using System;
using Xunit;

namespace MySportsFeeds.NetCore.IntegrationTests
{
    public abstract class TestBase
    {
        // data required to run this tests, please check App.config and modify the values to mapping to your local stash instance
        protected readonly string BASE_URL = "https://api.mysportsfeeds.com/";
        protected readonly string USERNAME = "";
        protected readonly string PASSWORD = "";

        protected MySportsFeedsClient mySportsFeedsClient;
        
        public TestBase()
        {
            mySportsFeedsClient = new MySportsFeedsClient(BASE_URL, USERNAME, PASSWORD);
        }
    }
}
