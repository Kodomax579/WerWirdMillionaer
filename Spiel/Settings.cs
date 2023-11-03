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
        
        private void Settings_Load(object sender, EventArgs e)
        {}

        public Settings()
        {
            InitializeComponent();

        }
        private TrackBar SettingsTonSlider = new TrackBar();

        private void SettingsTonButton_MouseEnter(object sender, EventArgs e)
        {
            // Add the TrackBar control to your form
            this.Controls.Add(SettingsTonSlider);

            // Set the control's properties
            SettingsTonSlider.Location = new Point(50, 50); // Adjust the location as needed
            SettingsTonSlider.Size = new Size(200, 45);   // Adjust the size as needed
            SettingsTonSlider.Visible = true;

            // Handle the MouseLeave event to make it invisible when the mouse leaves
            SettingsTonButton.MouseLeave += new EventHandler(SettingsTonButton_MouseLeave);
        }

        private void SettingsTonButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsTonSlider.Visible = false;
        }

        
    }
}
