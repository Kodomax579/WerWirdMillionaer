﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiel
{
    public partial class Gewonnen : Form
    {
        public Gewonnen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Startseite startseite = new Startseite();
            startseite.Show();
            this.Close();
        }
    }
}
