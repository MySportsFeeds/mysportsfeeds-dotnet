using System.Threading.Tasks;
using Xunit;
using MySportsFeeds.NetCore.Enums;

namespace MySportsFeeds.NetCore.IntegrationTests
{
    public class MySportsFeedsClientTests : TestBase
    {
        private const string FOR_DATE = "20180520";
        private const string GAME_ID = "44050";


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

        [Fact]
        public async Task Can_Get_All_Game_Play_By_Plays()
        {
            // Arrange

            var requestOptions = new Helpers.RequestOptions()
            {
                GameId = GAME_ID
            };

            // Act

            var response = await mySportsFeedsClient.GamePlayByPlay.Get(League.MLB, 2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
            Assert.Equal(77, response.GamePlayByPlay.AtBats.AtBat.Count);
        }

        [Fact]
        public async Task Can_Get_Current_Season()
        {
            // Arrange

            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = FOR_DATE
            };

            // Act

            var response = await mySportsFeedsClient.CurrentSeason.Get(League.MLB, 2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
            Assert.Single(response.CurrentSeason.Season);
        }

        [Fact]
        public async Task Can_Get_Active_Players()
        {
            // Arrange
            // Act

            var response = await mySportsFeedsClient.ActivePlayers.Get(League.MLB, 2018, SeasonType.Regular);

            // Assert

            Assert.NotNull(response);
            
        }

    }
}
