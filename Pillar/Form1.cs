﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pillar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            Pillar pillar1 = new Pillar();
            pillar1.Height = float.Parse(txtBoxHeight.Text);
            pillar1.Width = float.Parse(txtBoxWidth.Text);
            pillar1.Location = txtBoxLocation.Text;
            
            lblResult.Text = pillar1.FindLocation();
            




        }

    }
}
