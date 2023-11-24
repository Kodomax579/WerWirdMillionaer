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
            this.SchriftGrößeButton = new System.Windows.Forms.Button();
            this.SchriftGrößeSlider = new System.Windows.Forms.TrackBar();
            this.SchwierigkeitsSlider = new System.Windows.Forms.TrackBar();
            this.SchwierigkeitsButton = new System.Windows.Forms.Button();
            this.DarkModeButton = new System.Windows.Forms.Button();
            this.LightModeImg = new System.Windows.Forms.PictureBox();
            this.DarkModeImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SchriftGrößeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchwierigkeitsSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightModeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DarkModeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // SchriftGrößeButton
            // 
            this.SchriftGrößeButton.Location = new System.Drawing.Point(98, 37);
            this.SchriftGrößeButton.Name = "SchriftGrößeButton";
            this.SchriftGrößeButton.Size = new System.Drawing.Size(94, 56);
            this.SchriftGrößeButton.TabIndex = 0;
            this.SchriftGrößeButton.Text = "button1";
            this.SchriftGrößeButton.UseVisualStyleBackColor = true;
            this.SchriftGrößeButton.MouseEnter += new System.EventHandler(this.SchriftGrößeButton_MouseEnter);
            this.SchriftGrößeButton.MouseLeave += new System.EventHandler(this.SchriftGrößeButton_MouseLeave);
            // 
            // SchriftGrößeSlider
            // 
            this.SchriftGrößeSlider.Location = new System.Drawing.Point(170, 37);
            this.SchriftGrößeSlider.Name = "SchriftGrößeSlider";
            this.SchriftGrößeSlider.Size = new System.Drawing.Size(200, 56);
            this.SchriftGrößeSlider.TabIndex = 1;
            this.SchriftGrößeSlider.MouseEnter += new System.EventHandler(this.SchriftGrößeSlider_MouseEnter);
            this.SchriftGrößeSlider.MouseLeave += new System.EventHandler(this.SchriftGrößeSlider_MouseLeave);
            // 
            // SchwierigkeitsSlider
            // 
            this.SchwierigkeitsSlider.Location = new System.Drawing.Point(170, 133);
            this.SchwierigkeitsSlider.Name = "SchwierigkeitsSlider";
            this.SchwierigkeitsSlider.Size = new System.Drawing.Size(200, 56);
            this.SchwierigkeitsSlider.TabIndex = 3;
            this.SchwierigkeitsSlider.MouseEnter += new System.EventHandler(this.SchwierigkeitsSlider_MouseEnter);
            this.SchwierigkeitsSlider.MouseLeave += new System.EventHandler(this.SchwierigkeitsSlider_MouseLeave);
            // 
            // SchwierigkeitsButton
            // 
            this.SchwierigkeitsButton.Location = new System.Drawing.Point(98, 133);
            this.SchwierigkeitsButton.Name = "SchwierigkeitsButton";
            this.SchwierigkeitsButton.Size = new System.Drawing.Size(94, 56);
            this.SchwierigkeitsButton.TabIndex = 2;
            this.SchwierigkeitsButton.Text = "button1";
            this.SchwierigkeitsButton.UseVisualStyleBackColor = true;
            this.SchwierigkeitsButton.MouseEnter += new System.EventHandler(this.SchwierigkeitsButton_MouseEnter);
            this.SchwierigkeitsButton.MouseLeave += new System.EventHandler(this.SchwierigkeitsButton_MouseLeave);
            // 
            // DarkModeButton
            // 
            this.DarkModeButton.Location = new System.Drawing.Point(98, 233);
            this.DarkModeButton.Name = "DarkModeButton";
            this.DarkModeButton.Size = new System.Drawing.Size(94, 56);
            this.DarkModeButton.TabIndex = 4;
            this.DarkModeButton.Text = "button1";
            this.DarkModeButton.UseVisualStyleBackColor = true;
            this.DarkModeButton.Click += new System.EventHandler(this.DarkModeButton_Click);
            // 
            // LightModeImg
            // 
            this.LightModeImg.Image = ((System.Drawing.Image)(resources.GetObject("LightModeImg.Image")));
            this.LightModeImg.Location = new System.Drawing.Point(227, 233);
            this.LightModeImg.Name = "LightModeImg";
            this.LightModeImg.Size = new System.Drawing.Size(56, 56);
            this.LightModeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LightModeImg.TabIndex = 5;
            this.LightModeImg.TabStop = false;
            // 
            // DarkModeImg
            // 
            this.DarkModeImg.Image = global::Spiel.Properties.Resources.moon;
            this.DarkModeImg.Location = new System.Drawing.Point(314, 233);
            this.DarkModeImg.Name = "DarkModeImg";
            this.DarkModeImg.Size = new System.Drawing.Size(56, 56);
            this.DarkModeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DarkModeImg.TabIndex = 7;
            this.DarkModeImg.TabStop = false;
            this.DarkModeImg.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 571);
            this.Controls.Add(this.DarkModeImg);
            this.Controls.Add(this.LightModeImg);
            this.Controls.Add(this.DarkModeButton);
            this.Controls.Add(this.SchwierigkeitsSlider);
            this.Controls.Add(this.SchwierigkeitsButton);
            this.Controls.Add(this.SchriftGrößeSlider);
            this.Controls.Add(this.SchriftGrößeButton);
            this.Name = "Settings";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchriftGrößeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchwierigkeitsSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightModeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DarkModeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SchriftGrößeButton;
        
        private Button SchwierigkeitsButton;
        private Button DarkModeButton;
        private PictureBox LightModeImg;
        private PictureBox DarkModeImg;
    }
}