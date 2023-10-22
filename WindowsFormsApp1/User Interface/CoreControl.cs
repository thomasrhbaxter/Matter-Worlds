using System;
using System.Windows.Forms;
using BreakInfinity;
using MatterWorlds.Automation;
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
        public static BigDouble aw3c = 1000;
        public static BigDouble aw4c = 10000;
        public static BigDouble aw5c = 100000;
        public static BigDouble aw6c = 1000000;
        public static BigDouble aw7c = 10000000;
        public static BigDouble aw8c = 100000000;

        public static double aw1Bought;
        public static double aw2Bought;
        public static double aw3Bought;
        public static double aw4Bought;
        public static double aw5Bought;
        public static double aw6Bought;
        public static double aw7Bought;
        public static double aw8Bought;
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
            InfiniteReset();
            
        }
        #region reset
        public void InfiniteReset()
        {
            dimGalaxy = 0;
            dimGalaxyC = 80;
            tickSpeedMultScale = 1.125;
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

            dimBoostC = 0;
            dimBoostsBought = 0;
            dimBoostsCostString = "";
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
        }
        public void ResetUI()
        {

            
        }

        #endregion

        private void RefreshUI()
        {
            label1.Text = "World 1 count: " + aw1.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw1m * aw1dbm * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label2.Text = "World 2 count: " + aw2.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw2m * aw2dbm * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label3.Text = "World 3 count: " + aw3.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw3m * aw3dbm * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label4.Text = "World 4 count: " + aw4.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw4m * aw4dbm * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label5.Text = "World 5 count: " + aw5.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw5m * aw5dbm * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label6.Text = "World 6 count: " + aw6.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw6m * aw6dbm * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label7.Text = "World 7 count: " + aw7.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw7m * aw7dbm * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label8.Text = "World 8 count: " + aw8.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " Multiplier: " + (aw8m * aw8dbm * totalSacrificeMultiply * tickSpeedMult).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            label10.Text = "Antimatter: " + antimatterCount.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + "\nAntimatter per second: " + (aw1 * aw1m * aw1dbm).ToString(exponentFormat).Replace("+", "").Replace("E0", "E");

            button1.Text = "Buy world 1: " + aw1c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw1Bought %10;
            button2.Text = "Buy world 2: " + aw2c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw2Bought % 10;
            button3.Text = "Buy world 3: " + aw3c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw3Bought % 10;
            button4.Text = "Buy world 4: " + aw4c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw4Bought % 10;
            button5.Text = "Buy world 5: " + aw5c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw5Bought % 10;
            button6.Text = "Buy world 6: " + aw6c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw6Bought % 10;
            button7.Text = "Buy world 7: " + aw7c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw7Bought % 10;
            button8.Text = "Buy world 8: " + aw8c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw8Bought % 10;

            label9.Text = "Tickspeed multiplier:" + tickSpeedMult;
            TickSpeedBuy.Text = "Get a " + tickSpeedMultScale.ToString("G4").Replace("+", "").Replace("E0", "E") + " modifier to all worlds\nCost: " + tickSpeedC.ToString(exponentFormat).Replace("+", "").Replace("E0", "E");

            sacrificeBuy.Text = "Reset  world 1-7 for a " + sacrificeMultiply.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + "x multiplier";

            galaxyCost.Text = "Universe boost cost: " + dimGalaxyC.ToString(exponentFormat).Replace("+", "").Replace("E0", "E");
            
            if (dimBoostsBought >= 7)
            {
                boostBuy.Text = "Boost world: " + dimBoostsBought + "\n reset worlds for a 2x multiplier to all worlds";
            }
            else
            {
                boostBuy.Text = "Boost world: " + dimBoostsBought + "\n reset worlds for a new world";
            }
            if (dimBoostsCostString != "")
            {
                dimBoostCost.Text = "World boost cost: " + dimBoostsCostString;
            }
            else
            {
                dimBoostCost.Text = "World boost cost: " + dimBoostC.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " 8th dimensions";
            }
        }


        #region buttons

        #region navmenu


        #endregion


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
            if (aw8 > dimGalaxyC)
            {
                tickSpeedMultScale *= 1.02;
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
            if (antimatterCount >= aw1c)
            {
                InfinityPurchaseControls.BuyWorld2();
            }
        }

        private void buy2_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw2c)
            {
                InfinityPurchaseControls.BuyWorld2();
            }
        }
        

        private void buy3_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw3c)
            {
                InfinityPurchaseControls.BuyWorld3();
            }
        
        }

        private void buy4_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw4c)
            {
                InfinityPurchaseControls.BuyWorld4();
            }
        }

        private void buy5_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw5c)
            {
                InfinityPurchaseControls.BuyWorld5();
            }
        }

        private void buy6_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw6c)
            {
                InfinityPurchaseControls.BuyWorld6();
            }
        }

        private void buy7_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw7c)
            {
                InfinityPurchaseControls.BuyWorld7();
            }
        }

        private void buy8_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw8c)
            {
                InfinityPurchaseControls.BuyWorld8();
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

        private void Automator_Tick(object sender, EventArgs e)
        {
            AutoBuyers.OnAutobuyerTick();
        }

        private void UpgradeAutobuyerTickrate()
        {
            Dim1Automator.Interval /= 2;
        }


    }
}
