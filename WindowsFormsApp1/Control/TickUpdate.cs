using BreakInfinity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatterWorlds.Control
{
    internal class TickUpdate
    {

        public static void ExecuteTickUpdate()
        {
            CoreControl.aw7 += (CoreControl.aw8 * CoreControl.aw8m * CoreControl.aw8dbm * CoreControl.totalSacrificeMultiply * CoreControl.tickSpeedMult) * 0.1;
            CoreControl.aw6 += (CoreControl.aw7 * CoreControl.aw7m * CoreControl.aw7dbm * CoreControl.tickSpeedMult) * 0.1;
            CoreControl.aw5 += (CoreControl.aw6 * CoreControl.aw6m * CoreControl.aw6dbm * CoreControl.tickSpeedMult) * 0.1;
            CoreControl.aw4 += (CoreControl.aw5 * CoreControl.aw5m * CoreControl.aw5dbm * CoreControl.tickSpeedMult) * 0.1;
            CoreControl.aw3 += (CoreControl.aw4 * CoreControl.aw4m * CoreControl.aw4dbm * CoreControl.tickSpeedMult) * 0.1;
            CoreControl.aw2 += (CoreControl.aw3 * CoreControl.aw3m * CoreControl.aw3dbm * CoreControl.tickSpeedMult) * 0.1;
            CoreControl.aw1 += (CoreControl.aw2 * CoreControl.aw2m * CoreControl.aw2dbm * CoreControl.tickSpeedMult) * 0.1;
            CoreControl.totalDim1 += CoreControl.aw1;
            CoreControl.antimatterCount += CoreControl.aw1 * CoreControl.aw1m * CoreControl.aw1dbm;

            CoreControl.sacrificeMultiply = BigDouble.Max(BigDouble.Pow(BigDouble.Log(CoreControl.totalDim1 - CoreControl.previousTotalDim1, 10) / 10, CoreControl.sacrificeExponent), 1);

        }
    }
}
