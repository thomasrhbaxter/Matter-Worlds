using BreakInfinity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatterWorlds.UserInterface;

namespace MatterWorlds.Control
{
    internal class CoreControl
    {

        public static bool canSacrifice;
        public static BigDouble antimatterCount = 10;
        public static BigDouble startingAntimatter = 10;
        public static BigDouble debugAntimatter = new BigDouble(1, 4000);

        #region worlds
        public static BigDouble aw1 = 0;
        public static BigDouble aw2 = 0;
        public static BigDouble aw3 = 0;
        public static BigDouble aw4 = 0;
        public static BigDouble aw5 = 0;
        public static BigDouble aw6 = 0;
        public static BigDouble aw7 = 0;
        public static BigDouble aw8 = 0;

        private static BigDouble aw1m = 1;
        private static BigDouble aw2m = 1;
        private static BigDouble aw3m = 1;
        private static BigDouble aw4m = 1;
        private static BigDouble aw5m = 1;
        private static BigDouble aw6m = 1;
        private static BigDouble aw7m = 1;
        private static BigDouble aw8m = 1;

        private static BigDouble aw1dbm = 1;
        private static BigDouble aw2dbm = 1;
        private static BigDouble aw3dbm = 1;
        private static BigDouble aw4dbm = 1;
        private static BigDouble aw5dbm = 1;
        private static BigDouble aw6dbm = 1;
        private static BigDouble aw7dbm = 1;
        private static BigDouble aw8dbm = 1;

        private static BigDouble aw1c = 10;
        private static BigDouble aw2c = 100;
        private static BigDouble aw3c = 1000;
        private static BigDouble aw4c = 10000;
        private static BigDouble aw5c = 100000;
        private static BigDouble aw6c = 1000000;
        private static BigDouble aw7c = 10000000;
        private static BigDouble aw8c = 100000000;

        private static double aw1Bought;
        private static double aw2Bought;
        private static double aw3Bought;
        private static double aw4Bought;
        private static double aw5Bought;
        private static double aw6Bought;
        private static double aw7Bought;
        private static double aw8Bought;
        #endregion

        public static BigDouble totalDim1;
        public static BigDouble previousTotalDim1;

        public static BigDouble totalSacrificeMultiply = 1;
        public static BigDouble sacrificeMultiply = 1;
        public static BigDouble sacrificeExponent = 2;

        public static int dimBoostsBought;
        public static BigDouble dimBoostC = 0;

        public static int dimGalaxy = 0;
        public static BigDouble dimGalaxyC = 80;

        public static string dimBoostsCostString = "20 4th worlds";
        public static string exponentFormat = "G3";

        public static BigDouble tickSpeedMult = 1;
        public static BigDouble tickSpeedC = 1000;
        public static BigDouble tickSpeedMultScale = 1.125;
        public static UI myGame;

        public static void OnRun()
        {
            myGame = new UI();
        }

        #region reset
        public static void InfiniteReset()
        {
            dimGalaxy = 0;
            dimGalaxyC = 80;
            tickSpeedMultScale = 1.125;
            GalaxyReset();
        }

        public static void GalaxyReset()
        {
            aw1dbm = 1;
            aw2dbm = 1;
            aw3dbm = 1;
            aw4dbm = 1;
            aw5dbm = 1;
            aw6dbm = 1;
            aw7dbm = 1;
            aw8dbm = 1;

            dimBoostC = 0;
            dimBoostsBought = 0;
            dimBoostsCostString = "";
            canSacrifice = false;

            myGame.ResetUI();

            totalDim1 = 0;
            previousTotalDim1 = 0;
            ResetVariables();
        }

        public static void ResetVariables()
        {

            tickSpeedC = 1000;
            tickSpeedMult = 1;
            //antimatterCount = startingAntimatter;
            antimatterCount = debugAntimatter;
            aw1 = 0;
            aw2 = 0;
            aw3 = 0;
            aw4 = 0;
            aw5 = 0;
            aw6 = 0;
            aw7 = 0;
            aw8 = 0;

            aw1Bought = 0;
            aw2Bought = 0;
            aw3Bought = 0;
            aw4Bought = 0;
            aw5Bought = 0;
            aw6Bought = 0;
            aw7Bought = 0;
            aw8Bought = 0;

            sacrificeMultiply = 1;
            totalSacrificeMultiply = 1;


            aw1m = 1;
            aw2m = 1;
            aw3m = 1;
            aw4m = 1;
            aw5m = 1;
            aw6m = 1;
            aw7m = 1;
            aw8m = 1;

            aw1c = 10;
            aw2c = 100;
            aw3c = 1000;
            aw4c = 10000;
            aw5c = 100000;
            aw6c = 1000000;
            aw7c = 10000000;
            aw8c = 100000000;
            #endregion
        }

    }
}
