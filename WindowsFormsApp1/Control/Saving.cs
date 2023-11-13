using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BreakInfinity;

namespace MatterWorlds.Control
{
    public partial class CoreControl
    {

        private void SaveProcess()
        {
            TextWriter saver = new StreamWriter("Save.txt");
            saver.WriteLine(dimGalaxy);
            saver.WriteLine(dimGalaxyC);
            saver.WriteLine(tickSpeedMultScale);

            saver.WriteLine(aw1dbm);
            saver.WriteLine(aw2dbm);
            saver.WriteLine(aw3dbm);
            saver.WriteLine(aw4dbm);
            saver.WriteLine(aw5dbm);
            saver.WriteLine(aw6dbm);
            saver.WriteLine(aw7dbm);
            saver.WriteLine(aw8dbm);

            saver.WriteLine(button5.Enabled);
            saver.WriteLine(button6.Enabled);
            saver.WriteLine(button7.Enabled);
            saver.WriteLine(button8.Enabled);
            saver.WriteLine(sacrificeBuy.Enabled);

            saver.WriteLine(dimBoostsCostString);

            saver.WriteLine(dimBoostC);
            saver.WriteLine(dimBoostsBought);
            saver.WriteLine(canSacrifice);

            saver.WriteLine(totalDim1);
            saver.WriteLine(previousTotalDim1);

            saver.WriteLine(tickSpeedC);
            saver.WriteLine(tickSpeedMult);
            saver.WriteLine(antimatterCount);
            saver.WriteLine(aw1);
            saver.WriteLine(aw2);
            saver.WriteLine(aw3);
            saver.WriteLine(aw4);
            saver.WriteLine(aw5);
            saver.WriteLine(aw6);
            saver.WriteLine(aw7);
            saver.WriteLine(aw8);

            saver.WriteLine(aw1Bought);
            saver.WriteLine(aw2Bought);
            saver.WriteLine(aw3Bought);
            saver.WriteLine(aw4Bought);
            saver.WriteLine(aw5Bought);
            saver.WriteLine(aw6Bought);
            saver.WriteLine(aw7Bought);
            saver.WriteLine(aw8Bought);

            saver.WriteLine(sacrificeMultiply);
            saver.WriteLine(totalSacrificeMultiply);


            saver.WriteLine(aw1m);
            saver.WriteLine(aw2m);
            saver.WriteLine(aw3m);
            saver.WriteLine(aw4m);
            saver.WriteLine(aw5m);
            saver.WriteLine(aw6m);
            saver.WriteLine(aw7m);
            saver.WriteLine(aw8m);

            saver.WriteLine(aw1c);
            saver.WriteLine(aw2c);
            saver.WriteLine(aw3c);
            saver.WriteLine(aw4c);
            saver.WriteLine(aw5c);
            saver.WriteLine(aw6c);
            saver.WriteLine(aw7c);
            saver.WriteLine(aw8c);
            saver.Close();
        }
        private void LoadProcess()
        {
            TextReader reader = new StreamReader("Save.txt");
            dimGalaxy = BigDouble.Parse(reader.ReadLine());
            dimGalaxyC = BigDouble.Parse(reader.ReadLine());
            tickSpeedMultScale = BigDouble.Parse(reader.ReadLine());

            aw1dbm = BigDouble.Parse(reader.ReadLine());
            aw2dbm = BigDouble.Parse(reader.ReadLine());
            aw3dbm = BigDouble.Parse(reader.ReadLine());
            aw4dbm = BigDouble.Parse(reader.ReadLine());
            aw5dbm = BigDouble.Parse(reader.ReadLine());
            aw6dbm = BigDouble.Parse(reader.ReadLine());
            aw7dbm = BigDouble.Parse(reader.ReadLine());
            aw8dbm = BigDouble.Parse(reader.ReadLine());

            button5.Enabled = Convert.ToBoolean(reader.ReadLine());
            button6.Enabled = Convert.ToBoolean(reader.ReadLine());
            button7.Enabled = Convert.ToBoolean(reader.ReadLine());
            button8.Enabled = Convert.ToBoolean(reader.ReadLine());
            sacrificeBuy.Enabled = Convert.ToBoolean(reader.ReadLine());

            dimBoostsCostString = reader.ReadLine();

            dimBoostC = BigDouble.Parse(reader.ReadLine());
            dimBoostsBought = Int32.Parse(reader.ReadLine());
            canSacrifice = Convert.ToBoolean(reader.ReadLine());

            totalDim1 = BigDouble.Parse(reader.ReadLine());
            previousTotalDim1 = BigDouble.Parse(reader.ReadLine());

            tickSpeedC = BigDouble.Parse(reader.ReadLine());
            tickSpeedMult = BigDouble.Parse(reader.ReadLine());
            antimatterCount = BigDouble.Parse(reader.ReadLine());
            aw1 = BigDouble.Parse(reader.ReadLine());
            aw2 = BigDouble.Parse(reader.ReadLine());
            aw3 = BigDouble.Parse(reader.ReadLine());
            aw4 = BigDouble.Parse(reader.ReadLine());
            aw5 = BigDouble.Parse(reader.ReadLine());
            aw6 = BigDouble.Parse(reader.ReadLine());
            aw7 = BigDouble.Parse(reader.ReadLine());
            aw8 = BigDouble.Parse(reader.ReadLine());

            aw1Bought = Double.Parse(reader.ReadLine());
            aw2Bought = Double.Parse(reader.ReadLine());
            aw3Bought = Double.Parse(reader.ReadLine());
            aw4Bought = Double.Parse(reader.ReadLine());
            aw5Bought = Double.Parse(reader.ReadLine());
            aw6Bought = Double.Parse(reader.ReadLine());
            aw7Bought = Double.Parse(reader.ReadLine());
            aw8Bought = Double.Parse(reader.ReadLine());

            sacrificeMultiply = BigDouble.Parse(reader.ReadLine());
            totalSacrificeMultiply = BigDouble.Parse(reader.ReadLine());


            aw1m = BigDouble.Parse(reader.ReadLine());
            aw2m = BigDouble.Parse(reader.ReadLine());
            aw3m = BigDouble.Parse(reader.ReadLine());
            aw4m = BigDouble.Parse(reader.ReadLine());
            aw5m = BigDouble.Parse(reader.ReadLine());
            aw6m = BigDouble.Parse(reader.ReadLine());
            aw7m = BigDouble.Parse(reader.ReadLine());
            aw8m = BigDouble.Parse(reader.ReadLine());

            aw1c = BigDouble.Parse(reader.ReadLine());
            aw2c = BigDouble.Parse(reader.ReadLine());
            aw3c = BigDouble.Parse(reader.ReadLine());
            aw4c = BigDouble.Parse(reader.ReadLine());
            aw5c = BigDouble.Parse(reader.ReadLine());
            aw6c = BigDouble.Parse(reader.ReadLine());
            aw7c = BigDouble.Parse(reader.ReadLine());
            aw8c = BigDouble.Parse(reader.ReadLine());
            reader.Close();
        }
    }
}
