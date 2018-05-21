using System.Threading.Tasks;
using Xunit;
using MySportsFeeds.NetCore.Enums;

namespace MySportsFeeds.NetCore.IntegrationTests
{
    public class MySportsFeedsClientTests : TestBase
    {
        private const string FOR_DATE = "20180520";
        
        [Fact]
        public async Task Can_Get_All_Daily_Game_Schedules()
        {
            // Arrange

            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = FOR_DATE
            };

            // Act

            var response = await mySportsFeedsClient.DailyGameSchedule.Get(League.MLB, 2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
            Assert.Equal(15, response.DailyGameSchedule.GameEntry.Count);
        }

        [Fact]
        public async Task Can_Get_Daily_Game_Schedules_Filtered_By_Teams()
        {
            // Arrange

            string[] teams = new string[2];
            teams[0] = "bos";
            teams[1] = "mil";
         
            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = FOR_DATE,
                Teams = teams
            };

            // Act

            var response = await mySportsFeedsClient.DailyGameSchedule.Get(League.MLB, 2018, SeasonType.Regular, requestOptions);

            // Assert
    
            Assert.NotNull(response);
            Assert.Equal(2, response.DailyGameSchedule.GameEntry.Count);
        }

        [Fact]
        public async Task Can_Get_All_Scoreboards()
        {
            // Arrange

            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = FOR_DATE
            };

            // Act

            var response = await mySportsFeedsClient.Scoreboard.Get(League.MLB, 2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
            Assert.Equal(15, response.Scoreboard.GameScore.Count);
        }
    }
}
