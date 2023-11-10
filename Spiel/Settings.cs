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
        private bool MouseOnSlider = false;
        public bool TonSliderVisibility;
        private void Settings_Load(object sender, EventArgs e)
        { SettingsTonSlider.Visible = false; }

        public Settings()
        {
            InitializeComponent();

        }
        private TrackBar SettingsTonSlider = new TrackBar();

        private void SettingsTonButton_MouseEnter(object sender, EventArgs e)
        {
            this.Controls.Add(SettingsTonSlider);

            SettingsTonButton.SendToBack();
            SettingsTonSlider.BringToFront();
            TonSliderVisibility = true;
            TonSliderVisible();
            
        }

        private void SettingsTonSlider_MouseEnter(object sender, EventArgs e)
            {
                MouseOnSlider = true;
                TonSliderVisibility = true;
                SettingsTonButton.SendToBack();
                SettingsTonSlider.BringToFront();
                TonSliderVisible();
        }

        private void SettingsTonSlider_MouseLeave(object sender, EventArgs e)
        {
            TonSliderVisibility = false;
            TonSliderVisible();
        }

        private void SettingsTonButton_MouseLeave(object sender, EventArgs e)
        { 
            if (MouseOnSlider == false)
            {
                TonSliderVisibility = false;
                TonSliderVisible();
            }
        }

        private void TonSliderVisible()
        {
            if (TonSliderVisibility == true)
            {
                SettingsTonSlider.Visible = true;
            }
            else if (TonSliderVisibility == false)
            {
                SettingsTonSlider.Visible = false;
            }
        }
    }
}
