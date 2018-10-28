using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KruArchInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfAcct_Click(object sender, EventArgs e)
        {
            cbAccounts.Checked = true;
        }

        private void btnConfirmPackages_Click(object sender, EventArgs e)
        {
            cbPackages.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
