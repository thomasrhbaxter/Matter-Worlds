using System;
using System.Windows.Forms;
using BreakInfinity;
using MatterWorlds.Control;
namespace MatterWorlds.UserInterface
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            CoreControl.OnRun();
            CoreControl.InfiniteReset();
            
        }
        #region reset

        public  void ResetUI()
        {
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            sacrificeBuy.Enabled = false;
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
            if (antimatterCount >= tickSpeedC)
            {
                antimatterCount -= tickSpeedC;
                tickSpeedC *= 10;
                tickSpeedMult *= tickSpeedMultScale;
            }
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
                sacrifice();
            }
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
            aw7 += aw8 * aw8m * aw8dbm * totalSacrificeMultiply * tickSpeedMult;
            aw6 += aw7 * aw7m * aw7dbm * tickSpeedMult;
            aw5 += aw6 * aw6m * aw6dbm * tickSpeedMult;
            aw4 += aw5 * aw5m* aw5dbm * tickSpeedMult;
            aw3 += aw4 * aw4m* aw4dbm * tickSpeedMult;
            aw2 += aw3 * aw3m * aw3dbm * tickSpeedMult;
            aw1 += aw2 * aw2m* aw2dbm * tickSpeedMult;
            totalDim1 += aw1;
            antimatterCount += aw1 * aw1m * aw1dbm;

            sacrificeMultiply = BigDouble.Max(BigDouble.Pow(BigDouble.Log(totalDim1 - previousTotalDim1, 10) / 10, sacrificeExponent), 1);
            
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RefreshUI();
        }


    }
}
