﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClassKetNoi
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btDulieuvaoDG_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDulieuvaoDG().Show();
        }

        private void btDulieuvaoCB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDulieuvaoCB().Show();
        }

        private void btDieuchinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDieuchinh().Show();
        }
    }
}
