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
            this.SettingsTonButton = new System.Windows.Forms.Button();
            this.SettingsTonSlider = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.SchwierigkeitsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTonSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsTonButton
            // 
            this.SettingsTonButton.Location = new System.Drawing.Point(164, 111);
            this.SettingsTonButton.Name = "SettingsTonButton";
            this.SettingsTonButton.Size = new System.Drawing.Size(94, 56);
            this.SettingsTonButton.TabIndex = 0;
            this.SettingsTonButton.Text = "button1";
            this.SettingsTonButton.UseVisualStyleBackColor = true;
            this.SettingsTonButton.MouseEnter += new System.EventHandler(this.SettingsTonButton_MouseEnter);
            this.SettingsTonButton.MouseLeave += new System.EventHandler(this.SettingsTonButton_MouseLeave);
            // 
            // SettingsTonSlider
            // 
            this.SettingsTonSlider.Location = new System.Drawing.Point(236, 111);
            this.SettingsTonSlider.Name = "SettingsTonSlider";
            this.SettingsTonSlider.Size = new System.Drawing.Size(200, 56);
            this.SettingsTonSlider.TabIndex = 1;
            this.SettingsTonSlider.MouseEnter += new System.EventHandler(this.SettingsTonSlider_MouseEnter);
            this.SettingsTonSlider.MouseLeave += new System.EventHandler(this.SettingsTonSlider_MouseLeave);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(236, 207);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 56);
            this.trackBar1.TabIndex = 3;
            // 
            // SchwierigkeitsButton
            // 
            this.SchwierigkeitsButton.Location = new System.Drawing.Point(164, 207);
            this.SchwierigkeitsButton.Name = "SchwierigkeitsButton";
            this.SchwierigkeitsButton.Size = new System.Drawing.Size(94, 56);
            this.SchwierigkeitsButton.TabIndex = 2;
            this.SchwierigkeitsButton.Text = "button1";
            this.SchwierigkeitsButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 571);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.SchwierigkeitsButton);
            this.Controls.Add(this.SettingsTonSlider);
            this.Controls.Add(this.SettingsTonButton);
            this.Name = "Settings";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTonSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SettingsTonButton;
        private TrackBar trackBar1;
        private Button SchwierigkeitsButton;
    }
}