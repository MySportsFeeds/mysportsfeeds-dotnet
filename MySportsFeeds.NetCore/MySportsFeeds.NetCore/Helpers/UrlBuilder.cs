using System;
using MySportsFeeds.NetCore.Enums;

namespace MySportsFeeds.NetCore.Helpers
{
    internal class UrlBuilder
    {
        /// <summary>
        /// Builds the season string.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="seasonType">Type of the season.</param>
        /// <returns></returns>
        private static string BuildSeasonString(int year, SeasonType seasonType)
        {
            string seasonTypeString = "regular";

            if (seasonType == SeasonType.Playoff)
            {
                seasonTypeString = "playoff";
            }

            return string.Concat(year.ToString(), "-", seasonTypeString);
        }

        /// <summary>
        /// Resolves the status parameter expected by the api 
        /// from the status enum.
        /// 
        /// unplayed (scheduled but not yet started)
        /// in-progress (currently underway)
        /// postgame-reviewing (game is over, but we're reviewing against official sources)
        /// final (game is final and reviewed)
        /// 
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns></returns>
        private static string BuildStatusString(Status? status)
        {
            string returnStatus = string.Empty;
           
            if (status == Status.Unplayed)
            {
                returnStatus = "unplayed";
            }
            else if (status == Status.Inprogress)
            {
                returnStatus = "in-progress";
            }
            else if (status == Status.PostGameReviewing)
            {
                returnStatus = "postgame-reviewing";
            }
            else if (status == Status.Final)
            {
                returnStatus = "final";
            }

            return returnStatus;
        }

        /// <summary>
        /// Builds the player stats options.
        /// </summary>
        /// <param name="playerStatsOptions">The player stats options.</param>
        /// <returns></returns>
        private static string BuildPlayerStatsOptions(string[] playerStatsOptions)
        {
            string playerStatsString = string.Empty;

            for (int i = 0; i < playerStatsOptions.Length; i++)
            {
                if (i == 0)
                {
                    playerStatsString += playerStatsOptions[i];
                }
                else
                {
                    playerStatsString += string.Concat(",", playerStatsOptions[i]);
                }
            }

            return playerStatsString;
        }

        /// <summary>
        /// Builds the team names.
        /// </summary>
        /// <param name="teams">The teams.</param>
        /// <returns></returns>
        private static string BuildTeamNames(string[] teams)
        {
            string teamNameString = string.Empty;

            for (int i = 0; i < teams.Length; i++)
            {
                if (i == 0)
                {
                    teamNameString += teams[i];
                }
                else
                {
                    teamNameString += string.Concat(",", teams[i]);
                }
            }

            return teamNameString;
        }

        /// <summary>
        /// Formats the rest API URL.
        /// </summary>
        /// <param name="restUrl">The rest URL.</param>
        /// <param name="league">The league.</param>
        /// <param name="year">The year.</param>
        /// <param name="seasonType">Type of the season.</param>
        /// <param name="requestOptions">The request options.</param>
        /// <returns></returns>
        public static string FormatRestApiUrl(string restUrl, League league, int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            string resultingUrl = String.Format(restUrl, league.ToString().ToLower(), BuildSeasonString(year, seasonType));

            if (requestOptions != null)
            {
                string partialUrl = "";
                bool urlHasQueryParams = restUrl.IndexOf('?') > -1;

                if (!String.IsNullOrEmpty(requestOptions.ForDate))
                {
                    partialUrl += string.IsNullOrWhiteSpace(partialUrl) && !urlHasQueryParams ? "?" : "&";
                    partialUrl += string.Format("fordate={0}", requestOptions.ForDate);
                }

                if (requestOptions.Status != null)
                {
                    partialUrl += string.IsNullOrWhiteSpace(partialUrl) && !urlHasQueryParams ? "?" : "&";
                    partialUrl += string.Format("status={0}", BuildStatusString(requestOptions.Status));
                }

                if (requestOptions.Force != null)
                {
                    partialUrl += string.IsNullOrWhiteSpace(partialUrl) && !urlHasQueryParams ? "?" : "&";
                    partialUrl += string.Format("force={0}",requestOptions.Force.ToString().ToLower());
                }

                if (requestOptions.Teams != null)
                {
                    partialUrl += string.IsNullOrWhiteSpace(partialUrl) && !urlHasQueryParams ? "?" : "&";
                    partialUrl += string.Format("team={0}", BuildTeamNames(requestOptions.Teams));
                }

                // TODO: Make the various filter options generic at the base. 
                if (requestOptions.PlayerStatsMlb != null)
                {
                    partialUrl += string.IsNullOrWhiteSpace(partialUrl) && !urlHasQueryParams ? "?" : "&";
                    partialUrl += string.Format("playerstats={0}", BuildTeamNames(requestOptions.PlayerStatsMlb));
                }

                if (requestOptions.TeamStatsMlb != null)
                {
                    partialUrl += string.IsNullOrWhiteSpace(partialUrl) && !urlHasQueryParams ? "?" : "&";
                    partialUrl += string.Format("teamstats={0}", BuildTeamNames(requestOptions.TeamStatsMlb));
                }

                if (!String.IsNullOrEmpty(requestOptions.GameId))
                {
                    partialUrl += string.IsNullOrWhiteSpace(partialUrl) && !urlHasQueryParams ? "?" : "&";
                    partialUrl += string.Format("gameid={0}", requestOptions.GameId);
                }
                
                resultingUrl += partialUrl;
            }

            return resultingUrl;
        }
    }
}
