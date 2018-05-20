using MySportsFeeds.NetCore.Enums;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MySportsFeeds.NetCore.IntegrationTests
{
    public class MySportsFeedsClientTests : TestBase
    {
        [Fact]
        public async Task Can_Get_Daily_Game_Schedules()
        {

            string[] teams = new string[2];
            teams[0] = "bos";
            teams[1] = "mil";
         
            var requestOptions = new Helpers.RequestOptions()
            {
                ForDate = "20180520",
                Force = true,
                Teams = teams
            };

            var response = await mySportsFeedsClient.DailyGameSchedule.Get(League.MLB, 2018, SeasonType.Regular, requestOptions);
        
            Assert.NotNull(response);
        }
    }
}
