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

            button1.Text = "Buy world 1: " + aw1c.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " " + aw1Bought % 10;
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

            galaxyCost.Text = "Universe boost cost: " + dimGalaxyC.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " 8th worlds";

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
                dimBoostCost.Text = "World boost cost: " + dimBoostC.ToString(exponentFormat).Replace("+", "").Replace("E0", "E") + " 8th worlds";
            }
            ColourButtons();
        }

        private bool CanDimboost()
        {
            switch (dimBoostsBought)
            {
                case 0:
                    if (aw4 >= 20)
                    {
                        return true;
                    }
                    return false;
                case 1:
                    if (aw5 >= 20)
                    {
                        return true;
                    }
                    return false;
                case 2:
                    if (aw6 >= 20)
                    {
                        return true;
                    }
                    return false;
                case 3:
                    if (aw7 >= 20)
                    {
                        return true;
                    }
                    return false;
                case 4:
                    if (aw8 >= 20)
                    {
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }

        private void ColourButtons()
        {
            #region pre-Infinity
            #region antimatter worlds
            if (antimatterCount >= aw1c)
            {
                button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }
            if (antimatterCount >= aw2c)
            {
                button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (antimatterCount >= aw3c)
            {
                button3.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (antimatterCount >= aw4c)
            {
                button4.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (antimatterCount >= aw5c)
            {
                button5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (antimatterCount >= aw6c)
            {
                button6.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (antimatterCount >= aw7c)
            {
                button7.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (antimatterCount >= aw8c)
            {
                button8.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                button8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }
            #endregion
            #region other
            if (CanDimboost())
            {
                boostBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                boostBuy.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if(aw8 >=dimGalaxyC)
            {
                galaxyBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                galaxyBuy.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (antimatterCount >= tickSpeedC)
            {
                TickSpeedBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                TickSpeedBuy.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            if (sacrificeMultiply > 1)
            {
                sacrificeBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                sacrificeBuy.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            }

            #endregion
            #endregion


        }
    }
}
