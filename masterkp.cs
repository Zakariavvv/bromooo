﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromoo_Airliness
{
    public partial class masterkp : Form
    {
        public masterkp()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ubahsp form = new ubahsp();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu form = new menu();
            form.ShowDialog();
        }
    }
}