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
    public partial class Rangliste : Form
    {
        Controller controller = new Controller();

        public Rangliste()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rangliste_Load(object sender, EventArgs e)
        {
            controller.getranked(erster, zweiter, dritter, MeinPlatz);
        }
    }
}
