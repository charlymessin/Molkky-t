using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molkky_t
{
    public partial class ChoixMode : MetroFramework.Forms.MetroForm
    {
        public ChoixMode()
        {
            InitializeComponent();
        }

        private void btnModeSolo_Click(object sender, EventArgs e)
        {
            ChoixJoueurSolo cjs = new ChoixJoueurSolo();
            this.Close();
            cjs.ShowDialog();
        }
    }
}
