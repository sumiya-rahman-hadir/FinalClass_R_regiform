﻿using System;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.Show(this);

        }
    }
}
