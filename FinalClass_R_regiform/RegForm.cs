using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalClass_R_regiform
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Hide();
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Owner!= null)
                this.Owner.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
