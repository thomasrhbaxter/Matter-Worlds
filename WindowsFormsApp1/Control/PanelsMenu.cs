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
        private Panel[] panels = new Panel[2];

        private void Init()
        {
            panels[0] = panel2;
            panels[1] = panel3;
        }

        private void infinityMenu_Click(object sender, EventArgs e)
        {
            foreach (Panel p in panels)
            {
                p.Enabled = false;
                p.Visible = false;
            }
            panel2.Enabled = true;
            panel2.Visible = true;
        }

        private void automator_button_Click(object sender, EventArgs e)
        {
            foreach (Panel p in panels)
            {
                p.Enabled = false;
                p.Visible = false;
            }
            panel3.Enabled = true;
            panel3.Visible = true;
        }


    }
}
