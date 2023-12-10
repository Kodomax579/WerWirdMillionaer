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
            ((System.ComponentModel.ISupportInitialize)SchriftGrößeSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SchwierigkeitsSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LightModeImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DarkModeImg).BeginInit();
            SuspendLayout();
            // 
            // SchriftGrößeButton
            // 
            SchriftGrößeButton.Location = new Point(98, 37);
            SchriftGrößeButton.Name = "SchriftGrößeButton";
            SchriftGrößeButton.Size = new Size(94, 56);
            SchriftGrößeButton.TabIndex = 0;
            SchriftGrößeButton.Text = "button1";
            SchriftGrößeButton.UseVisualStyleBackColor = true;
            SchriftGrößeButton.MouseEnter += SchriftGrößeButton_MouseEnter;
            SchriftGrößeButton.MouseLeave += SchriftGrößeButton_MouseLeave;
            // 
            // SchriftGrößeSlider
            // 
            SchriftGrößeSlider.Location = new Point(170, 37);
            SchriftGrößeSlider.Name = "SchriftGrößeSlider";
            SchriftGrößeSlider.Size = new Size(200, 56);
            SchriftGrößeSlider.TabIndex = 1;
            SchriftGrößeSlider.MouseEnter += SchriftGrößeSlider_MouseEnter;
            SchriftGrößeSlider.MouseLeave += SchriftGrößeSlider_MouseLeave;
            // 
            // SchwierigkeitsSlider
            // 
            SchwierigkeitsSlider.Location = new Point(170, 133);
            SchwierigkeitsSlider.Name = "SchwierigkeitsSlider";
            SchwierigkeitsSlider.Size = new Size(200, 56);
            SchwierigkeitsSlider.TabIndex = 3;
            SchwierigkeitsSlider.MouseEnter += SchwierigkeitsSlider_MouseEnter;
            SchwierigkeitsSlider.MouseLeave += SchwierigkeitsSlider_MouseLeave;
            // 
            // SchwierigkeitsButton
            // 
            SchwierigkeitsButton.Location = new Point(98, 133);
            SchwierigkeitsButton.Name = "SchwierigkeitsButton";
            SchwierigkeitsButton.Size = new Size(94, 56);
            SchwierigkeitsButton.TabIndex = 2;
            SchwierigkeitsButton.Text = "button1";
            SchwierigkeitsButton.UseVisualStyleBackColor = true;
            SchwierigkeitsButton.MouseEnter += SchwierigkeitsButton_MouseEnter;
            SchwierigkeitsButton.MouseLeave += SchwierigkeitsButton_MouseLeave;
            // 
            // DarkModeButton
            // 
            DarkModeButton.Location = new Point(98, 233);
            DarkModeButton.Name = "DarkModeButton";
            DarkModeButton.Size = new Size(94, 56);
            DarkModeButton.TabIndex = 4;
            DarkModeButton.Text = "button1";
            DarkModeButton.UseVisualStyleBackColor = true;
            DarkModeButton.Click += DarkModeButton_Click;
            // 
            // LightModeImg
            // 
            LightModeImg.Image = (Image)resources.GetObject("LightModeImg.Image");
            LightModeImg.Location = new Point(227, 233);
            LightModeImg.Name = "LightModeImg";
            LightModeImg.Size = new Size(56, 56);
            LightModeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            LightModeImg.TabIndex = 5;
            LightModeImg.TabStop = false;
            // 
            // DarkModeImg
            // 
            DarkModeImg.Image = Properties.Resources.moon;
            DarkModeImg.Location = new Point(314, 233);
            DarkModeImg.Name = "DarkModeImg";
            DarkModeImg.Size = new Size(56, 56);
            DarkModeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DarkModeImg.TabIndex = 7;
            DarkModeImg.TabStop = false;
            DarkModeImg.Visible = false;
            DarkModeImg.Click += DarkModeImg_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 571);
            Controls.Add(DarkModeImg);
            Controls.Add(LightModeImg);
            Controls.Add(DarkModeButton);
            Controls.Add(SchwierigkeitsSlider);
            Controls.Add(SchwierigkeitsButton);
            Controls.Add(SchriftGrößeSlider);
            Controls.Add(SchriftGrößeButton);
            Name = "Settings";
            Text = "Form2";
            Load += Settings_Load;
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
    }
}