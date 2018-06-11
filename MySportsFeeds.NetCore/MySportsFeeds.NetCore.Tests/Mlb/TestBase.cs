namespace MySportsFeeds.NetCore.IntegrationTests.Mlb
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class TestBase
    {
        /// <summary>
        /// The base URL
        /// </summary>
        protected readonly string BASE_URL = "https://api.mysportsfeeds.com/";

        /// <summary>
        /// The version
        /// </summary>
        protected readonly string VERSION = "v1.2";

        /// <summary>
        /// The username
        /// </summary>
        protected readonly string USERNAME = "jarnone";

        /// <summary>
        /// The password
        /// </summary>
        protected readonly string PASSWORD = "thanky0u";
        

        /// <summary>
        /// My sports feeds client
        /// </summary>
        protected MySportsFeedsClient mySportsFeedsClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestBase"/> class.
        /// </summary>
        public TestBase()
        {
            mySportsFeedsClient = new MySportsFeedsClient(BASE_URL, Enums.League.MLB, VERSION, USERNAME, PASSWORD);
        }
    }
}
