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
        private bool MouseOnS_Slider = false;
        public bool SchriftGrößeSliderVisibility;
        public bool SchwierigkeitsSliderVisibility;
        int ID;

        private void Settings_Load(object sender, EventArgs e)
        {
            SchriftGrößeSlider.Visible = false;
            SchwierigkeitsSlider.Visible = false;
        }

        public CheckBox GetCheckBoxFromSettings()
        {
            return checkBox1;
        }
        //wda
        public Settings(int SpielerID)
        {
            ID = SpielerID;
            InitializeComponent();
            checkBox1 = new CheckBox();
        }
        private TrackBar SchriftGrößeSlider = new TrackBar();



        private void SchriftGrößeButton_MouseEnter(object sender, EventArgs e)
        {
            this.Controls.Add(SchriftGrößeSlider);

            SchriftGrößeButton.SendToBack();
            SchriftGrößeSlider.BringToFront();
            SchriftGrößeSliderVisibility = true;
            SchriftGrößeSliderVisible();

        }

        private void SchriftGrößeSlider_MouseEnter(object sender, EventArgs e)
        {
            MouseOnSlider = true;
            SchriftGrößeSliderVisibility = true;
            SchriftGrößeButton.SendToBack();
            SchriftGrößeSlider.BringToFront();
            SchriftGrößeSliderVisible();
        }

        private void SchriftGrößeSlider_MouseLeave(object sender, EventArgs e)
        {
            SchriftGrößeSliderVisibility = false;
            SchriftGrößeSliderVisible();
        }

        private void SchriftGrößeButton_MouseLeave(object sender, EventArgs e)
        {
            if (MouseOnSlider == false)
            {
                SchriftGrößeSliderVisibility = false;
                SchriftGrößeSliderVisible();
            }
        }

        private void SchriftGrößeSliderVisible()
        {
            if (SchriftGrößeSliderVisibility == true)
            {
                SchriftGrößeSlider.Visible = true;
            }
            else if (SchriftGrößeSliderVisibility == false)
            {
                SchriftGrößeSlider.Visible = false;
            }
        }

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////

        private TrackBar SchwierigkeitsSlider = new TrackBar();

        private void SchwierigkeitsButton_MouseEnter(object sender, EventArgs e)
        {
            this.Controls.Add(SchwierigkeitsSlider);

            SchwierigkeitsButton.SendToBack();
            SchwierigkeitsSlider.BringToFront();
            SchwierigkeitsSliderVisibility = true;
            SchwierigkeitsSliderVisible();
        }

        private void SchwierigkeitsSlider_MouseEnter(object sender, EventArgs e)
        {
            MouseOnS_Slider = true;
            SchwierigkeitsSliderVisibility = true;
            SchwierigkeitsButton.SendToBack();
            SchwierigkeitsSlider.BringToFront();
            SchwierigkeitsSliderVisible();
        }

        private void SchwierigkeitsSlider_MouseLeave(object sender, EventArgs e)
        {
            SchwierigkeitsSliderVisibility = false;
            SchwierigkeitsSliderVisible();
        }

        private void SchwierigkeitsButton_MouseLeave(object sender, EventArgs e)
        {
            if (MouseOnS_Slider == false)
            {
                SchwierigkeitsSliderVisibility = false;
                SchwierigkeitsSliderVisible();
            }
        }

        private void SchwierigkeitsSliderVisible()
        {
            if (SchwierigkeitsSliderVisibility == true)
            {
                SchwierigkeitsSlider.Visible = true;
            }
            else if (SchwierigkeitsSliderVisibility == false)
            {
                SchwierigkeitsSlider.Visible = false;
            }
        }

        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        private void DarkModeButton_Click(object sender, EventArgs e)
        {
            if (DarkModeImg.Visible == true)
            {
                DarkModeImg.Visible = false;
            }
            else if (DarkModeImg.Visible == false)
            {
                DarkModeImg.Visible = true;
            }

            if (LightModeImg.Visible == true)
            {
                LightModeImg.Visible = false;
            }
            else if (LightModeImg.Visible == false)
            {
                LightModeImg.Visible = true;
            }
        }

        public bool GetCheckBoxState()
        {
            return checkBox1.Checked;
        }

        public void SetCheckBoxState(bool newState)
        {
            checkBox1.Checked = newState;
        }

        private void ZuruckZurStartseite_Click(object sender, EventArgs e)
        {
            Startseite start = new Startseite(ID);
            this.Close();
            start.Show();
        }
    }
}
