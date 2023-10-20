using System;
using System.Windows.Forms;
using BreakInfinity;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        #region vars

        private static BigDouble antimatterCount = double.MaxValue/2;

        private static BigDouble aw1 = 0;
        private static BigDouble aw2 = 0;
        private static BigDouble aw3 = 0;
        private static BigDouble aw4 = 0;
        private static BigDouble aw5 = 0;
        private static BigDouble aw6 = 0;
        private static BigDouble aw7 = 0;
        private static BigDouble aw8 = 0;

        private static int dimBoostsBought;
        private static BigDouble dimBoostC = 0;

        private static int dimGalaxy = 0;
        private static BigDouble dimGalaxyC = 0;

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


        private string dimBoostsCostString;

        #endregion
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        #region reset

        private void InfiniteReset()
        {
            dimGalaxy = 0;
            dimGalaxyC = 0;
            GalaxyReset();
        }

        private void GalaxyReset()
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

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            ResetVariables();
    }

        private void ResetVariables()
        {
            antimatterCount = 10;
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
        #endregion

        private void RefreshUI()
        {
            label1.Text = "World 1 count: " + aw1 + " Multiplier: " + aw1m * aw1dbm;
            label2.Text = "World 2 count: " + aw2 + " Multiplier: " + aw2m * aw2dbm;
            label3.Text = "World 3 count: " + aw3 + " Multiplier: " + aw3m * aw3dbm;
            label4.Text = "World 4 count: " + aw4 + " Multiplier: " + aw4m * aw4dbm;
            label5.Text = "World 5 count: " + aw5 + " Multiplier: " + aw5m * aw5dbm;
            label6.Text = "World 6 count: " + aw6 + " Multiplier: " + aw6m * aw6dbm;
            label7.Text = "World 7 count: " + aw7 + " Multiplier: " + aw7m * aw7dbm;
            label8.Text = "World 8 count: " + aw8 + " Multiplier: " + aw8m * aw8dbm;
            label10.Text = "Antimatter: " + antimatterCount + "\nAntimatter per second: " + aw1 * aw1m * aw1dbm;

            button1.Text = "Buy world 1: " + aw1c;
            button2.Text = "Buy world 2: " + aw2c;
            button3.Text = "Buy world 3: " + aw3c;
            button4.Text = "Buy world 4: " + aw4c;
            button5.Text = "Buy world 5: " + aw5c;
            button6.Text = "Buy world 6: " + aw6c;
            button7.Text = "Buy world 7: " + aw7c;
            button8.Text = "Buy world 8: " + aw8c;

            dimBoostCost.Text = "World boost cost: " + dimBoostC;
            galaxyCost.Text = "Universe boost cost: " + dimGalaxyC;
            boostBuy.Text = " Boost world: " + dimBoostsBought; 
        }


        #region buttons

        #region navmenu
        private void infinityMenu_Click(object sender, EventArgs e)
        {
            if (panel2.Enabled)
            {
                panel2.Enabled = false;
                panel2.Visible = false;
            }
            else
            {
                panel2.Enabled = true;
                panel2.Visible = true;
            }
        }

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
                    }
                    break;
                default:
                    throw new Exception("UNIDENTIFIED DIMBOOST VALUE, THIS SHOULDN'T HAPPEN");             
            }
        }

        private void galaxyBuy_Click(object sender, EventArgs e)
        {

        }

        #region dimensions

        private void buy1_Click(object sender, EventArgs e)
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

        private void buy2_Click(object sender, EventArgs e)
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
        

        private void buy3_Click(object sender, EventArgs e)
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

        private void buy4_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw4c)
            {
                antimatterCount -= aw4c;

                aw4++;
                aw4Bought++;
                if (aw4Bought % 10 == 0)
                {
                    aw4c *= 1000000;
                    aw4m *= 2;
                }
            }
        }

        private void buy5_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw5c)
            {
                antimatterCount -= aw5c;

                aw5++;
                aw5Bought++;
                if (aw5Bought % 10 == 0)
                {
                    aw5c *= 1000000;
                    aw5m *= 2;
                }
            }
        }

        private void buy6_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw6c)
            {
                antimatterCount -= aw6c;

                aw6++;
                aw6Bought++;
                if (aw6Bought % 10 == 0)
                {
                    aw6c *= 100000000;
                    aw6m *= 2;
                }
            }
        }

        private void buy7_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw7c)
            {
                antimatterCount -= aw7c;

                aw7++;
                aw7Bought++;
                if (aw7Bought % 10 == 0)
                {
                    aw7c *= 1000000000;
                    aw7m *= 2;
                }
            }
        }

        private void buy8_Click(object sender, EventArgs e)
        {
            if (antimatterCount >= aw8c)
            {
                antimatterCount -= aw8c;

                aw8++;
                aw8Bought++;
                if (aw8Bought % 10 == 0)
                {
                    aw8c *= 10000000000;
                    aw8m *= 2;
                }
            }
        }

        #endregion

        #endregion

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            aw7 += aw8 * aw8m * aw8dbm;
            aw6 += aw7 * aw7m * aw7dbm;
            aw5 += aw6 * aw6m * aw6dbm;
            aw4 += aw5 * aw5m* aw5dbm;
            aw3 += aw4 * aw4m* aw4dbm;
            aw2 += aw3 * aw3m * aw3dbm;
            aw1 += aw2 * aw2m* aw2dbm;
            antimatterCount += aw1 * aw1m * aw1dbm;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RefreshUI();
        }


    }
}
