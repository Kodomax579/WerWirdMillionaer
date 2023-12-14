namespace Spiel
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            SchriftGrößeButton = new Button();
            SchriftGrößeSlider = new TrackBar();
            SchwierigkeitsSlider = new TrackBar();
            SchwierigkeitsButton = new Button();
            DarkModeButton = new Button();
            LightModeImg = new PictureBox();
            DarkModeImg = new PictureBox();
            checkBox1 = new CheckBox();
            ZuruckZurStartseite = new Button();
            ((System.ComponentModel.ISupportInitialize)SchriftGrößeSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SchwierigkeitsSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LightModeImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DarkModeImg).BeginInit();
            SuspendLayout();
            // 
            // SchriftGrößeButton
            // 
            SchriftGrößeButton.Location = new Point(86, 28);
            SchriftGrößeButton.Margin = new Padding(3, 2, 3, 2);
            SchriftGrößeButton.Name = "SchriftGrößeButton";
            SchriftGrößeButton.Size = new Size(82, 42);
            SchriftGrößeButton.TabIndex = 0;
            SchriftGrößeButton.Text = "button1";
            SchriftGrößeButton.UseVisualStyleBackColor = true;
            // 
            // SchriftGrößeSlider
            // 
            SchriftGrößeSlider.Location = new Point(149, 28);
            SchriftGrößeSlider.Margin = new Padding(3, 2, 3, 2);
            SchriftGrößeSlider.Name = "SchriftGrößeSlider";
            SchriftGrößeSlider.Size = new Size(175, 45);
            SchriftGrößeSlider.TabIndex = 1;
            // 
            // SchwierigkeitsSlider
            // 
            SchwierigkeitsSlider.Location = new Point(149, 100);
            SchwierigkeitsSlider.Margin = new Padding(3, 2, 3, 2);
            SchwierigkeitsSlider.Name = "SchwierigkeitsSlider";
            SchwierigkeitsSlider.Size = new Size(175, 45);
            SchwierigkeitsSlider.TabIndex = 3;
            // 
            // SchwierigkeitsButton
            // 
            SchwierigkeitsButton.Location = new Point(86, 100);
            SchwierigkeitsButton.Margin = new Padding(3, 2, 3, 2);
            SchwierigkeitsButton.Name = "SchwierigkeitsButton";
            SchwierigkeitsButton.Size = new Size(82, 42);
            SchwierigkeitsButton.TabIndex = 2;
            SchwierigkeitsButton.Text = "button1";
            SchwierigkeitsButton.UseVisualStyleBackColor = true;
            // 
            // DarkModeButton
            // 
            DarkModeButton.Location = new Point(86, 175);
            DarkModeButton.Margin = new Padding(3, 2, 3, 2);
            DarkModeButton.Name = "DarkModeButton";
            DarkModeButton.Size = new Size(82, 42);
            DarkModeButton.TabIndex = 4;
            DarkModeButton.Text = "button1";
            DarkModeButton.UseVisualStyleBackColor = true;
            // 
            // LightModeImg
            // 
            LightModeImg.Image = (Image)resources.GetObject("LightModeImg.Image");
            LightModeImg.Location = new Point(199, 175);
            LightModeImg.Margin = new Padding(3, 2, 3, 2);
            LightModeImg.Name = "LightModeImg";
            LightModeImg.Size = new Size(49, 42);
            LightModeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            LightModeImg.TabIndex = 5;
            LightModeImg.TabStop = false;
            // 
            // DarkModeImg
            // 
            DarkModeImg.Image = Properties.Resources.moon;
            DarkModeImg.Location = new Point(275, 175);
            DarkModeImg.Margin = new Padding(3, 2, 3, 2);
            DarkModeImg.Name = "DarkModeImg";
            DarkModeImg.Size = new Size(49, 42);
            DarkModeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DarkModeImg.TabIndex = 7;
            DarkModeImg.TabStop = false;
            DarkModeImg.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(86, 254);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ZuruckZurStartseite
            // 
            ZuruckZurStartseite.Location = new Point(86, 316);
            ZuruckZurStartseite.Margin = new Padding(3, 2, 3, 2);
            ZuruckZurStartseite.Name = "ZuruckZurStartseite";
            ZuruckZurStartseite.Size = new Size(113, 39);
            ZuruckZurStartseite.TabIndex = 9;
            ZuruckZurStartseite.Text = "´Zurück zur Startseite";
            ZuruckZurStartseite.UseVisualStyleBackColor = true;
            ZuruckZurStartseite.Click += ZuruckZurStartseite_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1090, 428);
            Controls.Add(ZuruckZurStartseite);
            Controls.Add(checkBox1);
            Controls.Add(DarkModeImg);
            Controls.Add(LightModeImg);
            Controls.Add(DarkModeButton);
            Controls.Add(SchwierigkeitsSlider);
            Controls.Add(SchwierigkeitsButton);
            Controls.Add(SchriftGrößeSlider);
            Controls.Add(SchriftGrößeButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Settings";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)SchriftGrößeSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)SchwierigkeitsSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)LightModeImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)DarkModeImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SchriftGrößeButton;

        private Button SchwierigkeitsButton;
        private Button DarkModeButton;
        private PictureBox LightModeImg;
        private PictureBox DarkModeImg;
        private CheckBox checkBox1;
        private Button ZuruckZurStartseite;
    }
}