using System.Threading.Tasks;
using Xunit;
using MySportsFeeds.NetCore.Enums;

namespace MySportsFeeds.NetCore.IntegrationTests.Mlb
{
    public class MySportsFeedsMlbTests : TestBase
    {
        private const string FOR_DATE = "20180527";
        private const string GAME_ID = "44218";
       
        [Fact]
        public async Task Can_Get_All_Daily_Game_Schedules()
        {
            // Arrange

            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = FOR_DATE
            };

            // Act

            var response = await mySportsFeedsClient.DailyGameSchedule.Get(2018, SeasonType.Regular, requestOptions);

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

            var response = await mySportsFeedsClient.DailyGameSchedule.Get(2018, SeasonType.Regular, requestOptions);

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

            var response = await mySportsFeedsClient.Scoreboard.Get(2018, SeasonType.Regular, requestOptions);

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

            var response = await mySportsFeedsClient.GamePlayByPlay.Get(2018, SeasonType.Regular, requestOptions);

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

            var response = await mySportsFeedsClient.CurrentSeason.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
            Assert.Single(response.CurrentSeason.Season);
        }

        [Fact]
        public async Task Can_Get_Active_Players()
        {
            // Arrange
            // Act

            var response = await mySportsFeedsClient.ActivePlayers.Get(2018, SeasonType.Regular);

            // Assert

            Assert.NotNull(response);   
        }

        [Fact]
        public async Task Can_Get_Player_Game_Logs()
        {
            // Arrange
            string[] teams = new string[2];
            teams[0] = "bos";
            teams[1] = "mil";

            var requestOptions = new Helpers.RequestOptions()
            {
                Teams = teams
            };

            // Act

            var response = await mySportsFeedsClient.PlayerGameLogs.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Roster_Players()
        {
            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = FOR_DATE
            };

            // Act

            var response = await mySportsFeedsClient.RosterPlayers.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }
        
        [Fact]
        public async Task Can_Get_Cumulative_Player_Stats()
        {
            // Arrange
            string[] filterOptions = new string[4];
            filterOptions[0] = "AB";
            filterOptions[1] = "H";
            filterOptions[2] = "HR";
            filterOptions[3] = "ER";
            
            var requestOptions = new Helpers.RequestOptions()
            {
                PlayerStatsMlb = filterOptions
            };

            // Act

            var response = await mySportsFeedsClient.CumulativePlayerStats.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Conference_Team_Standings()
        {
            // Arrange
            string[] filterOptions = new string[4];
            filterOptions[0] = "W";
            filterOptions[1] = "L";
            filterOptions[2] = "RF";
            filterOptions[3] = "RA";

            var requestOptions = new Helpers.RequestOptions()
            {
                PlayerStatsMlb = filterOptions
            };

            // Act

            var response = await mySportsFeedsClient.ConferenceTeamStandings.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Full_Game_Schedule()
        {
            // Arrange
            // Act

            var response = await mySportsFeedsClient.FullGameSchedule.Get(2018, SeasonType.Regular);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Daily_Player_Stats()
        {
            // Arrange
            
            string[] filterOptions = new string[5];
            filterOptions[0] = "AB";
            filterOptions[1] = "H";
            filterOptions[2] = "HR";
            filterOptions[3] = "ER";
            filterOptions[4] = "R";

            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = FOR_DATE,
                PlayerStatsMlb = filterOptions
            };

            // Act

            var response = await mySportsFeedsClient.DailyPlayerStats.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Division_Team_Standings()
        {
            // Arrange

            string[] filterOptions = new string[4];
            filterOptions[0] = "W";
            filterOptions[1] = "L";
            filterOptions[2] = "RF";
            filterOptions[3] = "RA";

            var requestOptions = new Helpers.RequestOptions()
            {
                TeamStatsMlb = filterOptions
            };

            // Act

            var response = await mySportsFeedsClient.DivisionTeamStandings.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Latest_Updates()
        {
            // Arrange
            // Act

            var response = await mySportsFeedsClient.LatestUpdates.Get(2018, SeasonType.Regular);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Overall_Team_Standings()
        {
            // Arrange

            string[] filterOptions = new string[4];
            filterOptions[0] = "W";
            filterOptions[1] = "L";
            filterOptions[2] = "RF";
            filterOptions[3] = "RA";

            var requestOptions = new Helpers.RequestOptions()
            {
                TeamStatsMlb = filterOptions
            };

            // Act

            var response = await mySportsFeedsClient.OverallTeamStandings.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Team_Game_Logs()
        {
            // Arrange
            string[] teams = new string[1];
            teams[0] = "bos";

            var requestOptions = new Helpers.RequestOptions()
            {
                Teams = teams
            };

            // Act

            var response = await mySportsFeedsClient.TeamGameLogs.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Player_Injuries()
        {
            // Arrange
            // Act

            var response = await mySportsFeedsClient.PlayerInjuries.Get(2018, SeasonType.Regular);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Playoff_Team_Standings()
        {
            // Arrange

            string[] filterOptions = new string[4];
            filterOptions[0] = "W";
            filterOptions[1] = "L";
            filterOptions[2] = "RF";
            filterOptions[3] = "RA";

            var requestOptions = new Helpers.RequestOptions()
            {
                TeamStatsMlb = filterOptions
            };

            // Act

            var response = await mySportsFeedsClient.PlayoffTeamStandings.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Game_Box_Score()
        {
            // Arrange

            string[] teamStatsOptions = new string[4];
            teamStatsOptions[0] = "W";
            teamStatsOptions[1] = "L";
            teamStatsOptions[2] = "RF";
            teamStatsOptions[3] = "RA";
            
            string[] playerStatsOptions = new string[4];
            playerStatsOptions[0] = "AB";
            playerStatsOptions[1] = "H";
            playerStatsOptions[2] = "HR";
            playerStatsOptions[3] = "ER";
            
            var requestOptions = new Helpers.RequestOptions()
            {
                GameId = GAME_ID,
                TeamStatsMlb = teamStatsOptions,
                PlayerStatsMlb = playerStatsOptions
            };

            // Act

            var response = await mySportsFeedsClient.GameBoxScore.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }

        [Fact]
        public async Task Can_Get_Game_Starting_Lineup()
        {
            // Arrange

            var requestOptions = new Helpers.RequestOptions()
            {
                GameId = GAME_ID
            };

            // Act

            var response = await mySportsFeedsClient.GameStartingLineup.Get(2018, SeasonType.Regular, requestOptions);

            // Assert

            Assert.NotNull(response);
        }
    }
}
