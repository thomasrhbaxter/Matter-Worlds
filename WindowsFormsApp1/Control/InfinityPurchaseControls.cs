using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatterWorlds.Control
{
    internal class InfinityPurchaseControls
    {
        public static void sacrifice()
        {
            CoreControl.aw1 = 0;
            CoreControl.aw2 = 0;
            CoreControl.aw3 = 0;
            CoreControl.aw4 = 0;
            CoreControl.aw5 = 0;
            CoreControl.aw6 = 0;
            CoreControl.aw7 = 0;
            CoreControl.previousTotalDim1 = CoreControl.totalDim1;
            CoreControl.totalSacrificeMultiply *= CoreControl.sacrificeMultiply;
        }

        public static void TickSpeedUp()
        {
            if (CoreControl.antimatterCount >= CoreControl.tickSpeedC)
            {
                CoreControl.antimatterCount -= CoreControl.tickSpeedC;
                CoreControl.tickSpeedC *= 10;
                CoreControl.tickSpeedMult *= CoreControl.tickSpeedMultScale;
            }
        }

        public static void BuyWorld1()
        {

                CoreControl.antimatterCount -= CoreControl.aw1c;

                CoreControl.aw1++;
                CoreControl.aw1Bought++;
                if (CoreControl.aw1Bought % 10 == 0)
                {
                    CoreControl.aw1c *= 1000;
                    CoreControl.aw1m *= 2;
                }
        }

        public static void BuyWorld2()
        {
            CoreControl.antimatterCount -= CoreControl.aw2c;

            CoreControl.aw2++;
            CoreControl.aw2Bought++;
            if (CoreControl.aw2Bought % 10 == 0)
            {
                CoreControl.aw2c *= 10000;
                CoreControl.aw2m *= 2;
            }
        }

        public static void BuyWorld3()
        {
            CoreControl.antimatterCount -= CoreControl.aw3c;

            CoreControl.aw3++;
            CoreControl.aw3Bought++;
            if (CoreControl.aw3Bought % 10 == 0)
            {
                CoreControl.aw3c *= 100000;
                CoreControl.aw3m *= 2;
            }
        }

        public static void BuyWorld4()
        {
            CoreControl.antimatterCount -= CoreControl.aw4c;

            CoreControl.aw4++;
            CoreControl.aw4Bought++;
            if (CoreControl.aw4Bought % 10 == 0)
            {
                CoreControl.aw4c *= 1e6;
                CoreControl.aw4m *= 2;
            }
        }

        public static void BuyWorld5()
        {
            CoreControl.antimatterCount -= CoreControl.aw5c;

            CoreControl.aw5++;
            CoreControl.aw5Bought++;
            if (CoreControl.aw5Bought % 10 == 0)
            {
                CoreControl.aw5c *= 1e8;
                CoreControl.aw5m *= 2;
            }
        }

        public static void BuyWorld6()
        {
            CoreControl.antimatterCount -= CoreControl.aw6c;

            CoreControl.aw6++;
            CoreControl.aw6Bought++;
            if (CoreControl.aw6Bought % 10 == 0)
            {
                CoreControl.aw6c *= 1e10;
                CoreControl.aw6m *= 2;
            }
        }

        public static void BuyWorld7()
        {
            CoreControl.antimatterCount -= CoreControl.aw7c;

            CoreControl.aw7++;
            CoreControl.aw7Bought++;
            if (CoreControl.aw7Bought % 10 == 0)
            {
                CoreControl.aw7c *= 1e12;
                CoreControl.aw7m *= 2;
            }
        }

        public static void BuyWorld8()
        {
            CoreControl.antimatterCount -= CoreControl.aw8c;

            CoreControl.aw8++;
            CoreControl.aw8Bought++;
            if (CoreControl.aw8Bought % 10 == 0)
            {
                CoreControl.aw8c *= 1e15;
                CoreControl.aw8m *= 2;
            }
        }
    }
}
