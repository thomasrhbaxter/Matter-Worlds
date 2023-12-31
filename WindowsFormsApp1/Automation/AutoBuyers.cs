﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreakInfinity;
using MatterWorlds.Control;

namespace MatterWorlds.Control
{
    public partial class CoreControl
    {

        private void AutoDim1(object sender, EventArgs e)
        {          
            BuyWorld1(10);   
        }

        private void AutoDim2(object sender, EventArgs e)
        {
            BuyWorld2(10);
        }

        private void AutoDim3(object sender, EventArgs e)
        {
            BuyWorld3(10);
        }

        private void AutoDim4(object sender, EventArgs e)
        {
            BuyWorld4(10);
        }

        private void AutoDim5(object sender, EventArgs e)
        {
            BuyWorld5(10);
        }

        private void AutoDim6(object sender, EventArgs e)
        {
            BuyWorld6(10);
        }

        private void AutoDim7(object sender, EventArgs e)
        {
            BuyWorld7(10);
        }

        private void AutoDim8(object sender, EventArgs e)
        {
            BuyWorld8(10);
        }

        private void AutoBoost(object sender, EventArgs e)
        {
            if (CanDimboost())
            {
                boostBuy_Click(sender, e);
            }
        }

        private void AutoGalaxy(object sender, EventArgs e)
        {
            if (aw8 >= dimGalaxyC)
            {
                    dimGalaxy++;
                    if (dimGalaxy >= 100)
                    {
                        dimGalaxyC = (80 + (dimGalaxyC * 60) + BigDouble.Pow(dimGalaxy - 99, 2)) * 2;
                    }
                    else
                    {
                        dimGalaxyC = 80 + (dimGalaxy * 60);
                    }
                    tickSpeedMultScale *= 1.02;
                    GalaxyReset();
            }
        }

        private void AutoTickspeed(object sender, EventArgs e)
        {
            if (antimatterCount >= tickSpeedC)
            {
                antimatterCount-=tickSpeedC;
                TickSpeedUp();
            }
        }
    }
}
