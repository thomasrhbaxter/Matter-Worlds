using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatterWorlds.Control
{
    internal class InfinityPurchaseControls
    {
        private void sacrifice()
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
    }
}
