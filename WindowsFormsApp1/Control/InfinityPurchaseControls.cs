using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatterWorlds.Control
{
    public partial class CoreControl
    {
        public static void sacrifice()
        {
            aw1 = 0;
            aw2 = 0;
            aw3 = 0;
            aw4 = 0;
            aw5 = 0;
            aw6 = 0;
            aw7 = 0;
            previousTotalDim1 = totalDim1;
            totalSacrificeMultiply *= sacrificeMultiply;
        }

        public static void TickSpeedUp()
        {
            if (antimatterCount >= tickSpeedC)
            {
                antimatterCount -= tickSpeedC;
                tickSpeedC *= 10;
                tickSpeedMult *= tickSpeedMultScale;
            }
        }

        public static void BuyWorld1(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw1c)
                {
                    antimatterCount -= aw1c;

                    aw1++;
                    aw1Bought++;
                    if (aw1Bought % 10 == 0)
                    {
                        aw1c *= 1000;
                        aw1m *= 2;
                    }
                }
            }
        }

        public static void BuyWorld2(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw2c)
                {
                    antimatterCount -= aw2c;

                    aw2++;
                    aw2Bought++;
                    if (aw2Bought % 10 == 0)
                    {
                        aw2c *= 10000;
                        aw2m *= 2;
                    }
                }
            }
        }

        public static void BuyWorld3(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw3c)
                {
                    antimatterCount -= aw3c;

                    aw3++;
                    aw3Bought++;
                    if (aw3Bought % 10 == 0)
                    {
                        aw3c *= 100000;
                        aw3m *= 2;
                    }
                }
            }
        }

        public static void BuyWorld4(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw4c)
                {
                    antimatterCount -= aw4c;

                    aw4++;
                    aw4Bought++;
                    if (aw4Bought % 10 == 0)
                    {
                        aw4c *= 1e6;
                        aw4m *= 2;
                    }
                }
            }
        }

        public static void BuyWorld5(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw5c)
                {
                    antimatterCount -= aw5c;

                    aw5++;
                    aw5Bought++;
                    if (aw5Bought % 10 == 0)
                    {
                        aw5c *= 1e8;
                        aw5m *= 2;
                    }
                }
            }
        }

        public static void BuyWorld6(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw6c)
                {
                    antimatterCount -= aw6c;

                    aw6++;
                    aw6Bought++;
                    if (aw6Bought % 10 == 0)
                    {
                        aw6c *= 1e10;
                        aw6m *= 2;
                    }
                }
            }
        }

        public static void BuyWorld7(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw7c)
                {
                    antimatterCount -= aw7c;

                    aw7++;
                    aw7Bought++;
                    if (aw7Bought % 10 == 0)
                    {
                        aw7c *= 1e12;
                        aw7m *= 2;
                    }
                }
            }
        }

        public static void BuyWorld8(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (antimatterCount >= aw8c)
                {
                    antimatterCount -= aw8c;

                    aw8++;
                    aw8Bought++;
                    if (aw8Bought % 10 == 0)
                    {
                        aw8c *= 1e15;
                        aw8m *= 2;
                    }
                }
            }
        }
    }
}
