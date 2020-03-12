using System;
namespace Exceptions
{
    public class BaseballStats
    {
        // Constructor
        public BaseballStats()
        {
        }

        public decimal CalculateBattingAverage(int hits, int atBats)
        {
            #region Checks
                // Potential Exceptions
                // atBats does not equal zero

                // Potential invalid results
                // hits > atBats
                // hits and/or atBats are negative
            #endregion

            // Batting average is hits divided by at-bats
            decimal battingAverage = 0.000m;

            battingAverage = hits / atBats;

            return battingAverage;
        }

        public decimal CalculateSluggingPercentage(int singles, int doubles, int triples, int homeRuns, int atBats)
        {

            #region Checks
            // Potential Exceptions
            // atBats does not equal zero

            // Potential invalid results
            // singles + doubles + triples + home runs > atBats
            // any input is negative
            #endregion

            // Slugging percentage is total bases divided by at bats
            decimal sluggingPercentage = 0.000m;
            int totalBases;

            totalBases = singles + (2 * doubles) + (3 * triples) + (4 * homeRuns);

            sluggingPercentage = totalBases / atBats;

            return sluggingPercentage;
        }

        public decimal CalculateFieldingPercentage(int chances, int errors)
        {
            #region Checks
            // Potential Exceptions
            // chances does not equal zero

            // Potential invalid results
            // errors > chances
            // any input is negative
            #endregion

            // Fielding percentage is total plays (chances minus errors) divided by the number of total chances
            decimal fieldingPercentage = 0.000m;

            fieldingPercentage = (chances - errors) / chances;

            return fieldingPercentage;
        }
    }
}
