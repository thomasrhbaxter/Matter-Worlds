using System;
using System.Windows.Forms;
using BreakInfinity;

namespace MatterWorlds.Control
{
    public partial class CoreControl : Form
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

        public static BigDouble aw1m = 1;
        public static BigDouble aw2m = 1;
        public static BigDouble aw3m = 1;
        public static BigDouble aw4m = 1;
        public static BigDouble aw5m = 1;
        public static BigDouble aw6m = 1;
        public static BigDouble aw7m = 1;
        public static BigDouble aw8m = 1;

        public static BigDouble aw1dbm = 1;
        public static BigDouble aw2dbm = 1;
        public static BigDouble aw3dbm = 1;
        public static BigDouble aw4dbm = 1;
        public static BigDouble aw5dbm = 1;
        public static BigDouble aw6dbm = 1;
        public static BigDouble aw7dbm = 1;
        public static BigDouble aw8dbm = 1;

        public static BigDouble aw1c = 10;
        public static BigDouble aw2c = 100;
        public static BigDouble aw3c = 1e4;
        public static BigDouble aw4c = 1e6;
        public static BigDouble aw5c = 1e9;
        public static BigDouble aw6c = 1e13;
        public static BigDouble aw7c = 1e18;
        public static BigDouble aw8c = 1e24;

        public static double aw1Bought;
        public static double aw2Bought;
        public static double aw3Bought;
        public static double aw4Bought;
        public static double aw5Bought;
        public static double aw6Bought;
        public static double aw7Bought;
        public static double aw8Bought;
        #endregion

        public static BigDouble galaxystrength = 1;

        public static BigDouble totalDim1;
        public static BigDouble previousTotalDim1;

        public static BigDouble totalSacrificeMultiply = 1;
        public static BigDouble sacrificeMultiply = 1;
        public static BigDouble sacrificeExponent = 2;

        public static int dimBoostsBought;
        public static BigDouble dimBoostC = 0;

        public static BigDouble dimGalaxy = 0;
        public static BigDouble dimGalaxyC = 80;

        public static string dimBoostsCostString = "20 4th worlds";


        public static BigDouble tickSpeedMult = 1;
        public static BigDouble tickSpeedC = 1000;
        public static BigDouble tickSpeedMultScale = 1.125;

        private static string exponentFormat = "G3";

        public CoreControl()
        {
            InitializeComponent();
            Init();
            timer1.Enabled = true;
            timer2.Enabled = true;
            EternalReset();
            
        }

        #region buttons

        #region purchases

        private void boostBuy_Click(object sender, EventArgs e)
        {
            switch (dimBoostsBought)
            {
                case 0:
                    if (aw4 >= 20)
                    {
                        aw1dbm *= 2;
                        dimBoostsBought++;
                        label5.Visible = true;
                        label5.Enabled = true;
                        button5.Enabled = true;
                        button5.Visible = true;
                        dimBoostsCostString = "20 5th worlds";
                        ResetVariables();
                    }
                    break;
                case 1:
                    if (aw5 >= 20)
                    {
                        aw1dbm *= 2;
                        aw2dbm *= 2;
                        dimBoostsBought++;
                        label6.Visible = true;
                        label6.Enabled = true;
                        button6.Enabled = true;
                        button6.Visible = true;
                        dimBoostsCostString = "20 6th worlds";
                        ResetVariables();
                    }
                    break;
                case 2:
                    if (aw6 >= 20)
                    {
                        aw1dbm *= 2;
                        aw2dbm *= 2;
                        aw3dbm *= 2;
                        dimBoostsBought++;
                        label7.Visible = true;
                        label7.Enabled = true;
                        button7.Enabled = true;
                        button7.Visible = true;
                        dimBoostsCostString = "20 7th worlds";
                        ResetVariables();
                    }
                    break;
                case 3:
                    if (aw7 >= 20)
                    {
                        aw1dbm *= 2;
                        aw2dbm *= 2;
                        aw3dbm *= 2;
                        aw4dbm *= 2;
                        label8.Visible = true;
                        label8.Enabled = true;
                        button8.Enabled = true;
                        button8.Visible = true;
                        dimBoostsBought++;
                        dimBoostsCostString = "20 8th worlds";
                        ResetVariables();
                    }
                    break;
                case 4:
                    if (aw8 >= 20)
                    {
                        aw1dbm *= 2;
                        aw2dbm *= 2;
                        aw3dbm *= 2;
                        aw4dbm *= 2;
                        aw5dbm *= 2;
                        dimBoostC = 35;
                        dimBoostsBought++;
                        dimBoostsCostString = "";
                        canSacrifice = true;
                        sacrificeBuy.Enabled = true;
                        sacrificeBuy.Visible = true;
                        ResetVariables();
                    }
                    break;
                case 5:
                    if (aw8 >= dimBoostC)
                    {
                        aw1dbm *= 2;
                        aw2dbm *= 2;
                        aw3dbm *= 2;
                        aw4dbm *= 2;
                        aw5dbm *= 2;
                        aw6dbm *= 2;
                        dimBoostC += 15;
                        dimBoostsBought++;
                        ResetVariables();
                    }
                    break;
                case 6:
                    if (aw8 >= dimBoostC)
                    {
                        aw1dbm *= 2;
                        aw2dbm *= 2;
                        aw3dbm *= 2;
                        aw4dbm *= 2;
                        aw5dbm *= 2;
                        aw6dbm *= 2;
                        aw7dbm *= 2;
                        dimBoostC += 15;
                        dimBoostsBought++;
                        ResetVariables();
                    }
                    break;
                case 7:
                    if (aw8 >= dimBoostC)
                    {
                        aw1dbm *= 2;
                        aw2dbm *= 2;
                        aw3dbm *= 2;
                        aw4dbm *= 2;
                        aw5dbm *= 2;
                        aw6dbm *= 2;
                        aw7dbm *= 2;
                        aw8dbm *= 2;
                        dimBoostC += 15;
                        ResetVariables();
                    }
                    break;
                default:
                    throw new Exception("UNIDENTIFIED DIMBOOST VALUE, THIS SHOULDN'T HAPPEN");             
            }
        }

        private void TickSpeedBuy_Click(object sender, EventArgs e)
        {
            InfinityPurchaseControls.TickSpeedUp();
        }

        private void galaxyBuy_Click(object sender, EventArgs e)
        {
            if (aw8 >= dimGalaxyC)
            {
                dimGalaxy++;
                if (dimGalaxy >= 100)
                {
                    dimGalaxyC = (80 + (dimGalaxyC*60)+ BigDouble.Pow(dimGalaxy-99, 2))*2;
                }
                else
                {
                    dimGalaxyC = 80 + (dimGalaxy * 60);
                }
                if (dimGalaxy == 1)
                {
                    tickSpeedMultScale = 1 / (1 / 1.11888888 - (dimGalaxy * galaxystrength * 0.02));
                }
                else if (dimGalaxy == 2)
                {
                    tickSpeedMultScale = 1 / (1 / 1.11267177 - (dimGalaxy * galaxystrength * 0.02));
                }
                else
                {
                    tickSpeedMultScale = 1 / (BigDouble.Pow(0.965, (dimGalaxy - 2) * 0.8));
                }
                GalaxyReset();
            }
        }

        private void sacrificeBuy_Click(object sender, EventArgs e)
        {
            if (canSacrifice && sacrificeMultiply >= 1)
            { 
                InfinityPurchaseControls.sacrifice();
            }
        }

        #region dimensions

        private void buy1_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < 10; i++)
                {
                if (antimatterCount >= aw1c)
                {
                    InfinityPurchaseControls.BuyWorld1();
                }
                    
                }
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (antimatterCount >= aw2c)
                {
                    InfinityPurchaseControls.BuyWorld2();
                }

            }
        }
        

        private void buy3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (antimatterCount >= aw3c)
                {
                    InfinityPurchaseControls.BuyWorld3();
                }

            }
        }

        private void buy4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (antimatterCount >= aw4c)
                {
                    InfinityPurchaseControls.BuyWorld4();
                }

            }
        }

        private void buy5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (antimatterCount >= aw5c)
                {
                    InfinityPurchaseControls.BuyWorld5();
                }

            }
        }

        private void buy6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (antimatterCount >= aw6c)
                {
                    InfinityPurchaseControls.BuyWorld6();
                }

            }
        }

        private void buy7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (antimatterCount >= aw7c)
                {
                    InfinityPurchaseControls.BuyWorld7();
                }

            }
        }

        private void buy8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (antimatterCount >= aw8c)
                {
                    InfinityPurchaseControls.BuyWorld8();
                }

            }
        }



        #endregion

        #endregion

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            TickUpdate.ExecuteTickUpdate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveProcess();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            LoadProcess();
        }
    }
}
