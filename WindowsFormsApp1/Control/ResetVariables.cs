using BreakInfinity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatterWorlds.Control
{
    public partial class CoreControl : Form
    {

        public void EternalReset()
        {

            InfiniteReset();
        }
        public void InfiniteReset()
        {
            dimGalaxy = 0;
            dimGalaxyC = 80;
            tickSpeedMultScale = 1 / (1 / 1.1245 - (dimGalaxy * galaxystrength * 0.02));
            GalaxyReset();
        }

        public void GalaxyReset()
        {
            aw1dbm = 1;
            aw2dbm = 1;
            aw3dbm = 1;
            aw4dbm = 1;
            aw5dbm = 1;
            aw6dbm = 1;
            aw7dbm = 1;
            aw8dbm = 1;

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            sacrificeBuy.Enabled = false;

            dimBoostsCostString = "20 4th worlds";

            dimBoostC = 0;
            dimBoostsBought = 0;
            canSacrifice = false;

            totalDim1 = 0;
            previousTotalDim1 = 0;
            ResetVariables();
        }

        public static void ResetVariables()
        {

            tickSpeedC = 1000;
            tickSpeedMult = 1;
            //antimatterCount = startingAntimatter;
            antimatterCount = startingAntimatter;
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
            aw3c = 1e4;
            aw4c = 1e6;
            aw5c = 1e9;
            aw6c = 1e13;
            aw7c = 1e18;
            aw8c = 1e24;
    }
    }
}
