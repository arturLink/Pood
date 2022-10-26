using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pood
{
    public partial class PeaVorm : Form
    {
        public PeaVorm()
        {
            InitializeComponent();
        }

        private void juhtimineRunBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void kaasaRunBtn_Click(object sender, EventArgs e)
        {
            Kaasa kaasa = new Kaasa();
            kaasa.ShowDialog();
        }
    }
}
