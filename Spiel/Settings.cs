using System;
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
    public partial class Settings : Form
    {
        

        public Settings()
        {
            InitializeComponent();

        }

        private void SettingsTonButton_MouseEnter(object sender, EventArgs e)
        {
            TrackBar SettingsTonSlider;
            SettingsTonSlider = new TrackBar();
            SettingsTonSlider.Visible = true;
        }


    }
}
