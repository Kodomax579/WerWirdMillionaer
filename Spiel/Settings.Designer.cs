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
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTonSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsTonButton
            // 
            this.SettingsTonButton.Location = new System.Drawing.Point(168, 151);
            this.SettingsTonButton.Name = "SettingsTonButton";
            this.SettingsTonButton.Size = new System.Drawing.Size(94, 29);
            this.SettingsTonButton.TabIndex = 0;
            this.SettingsTonButton.Text = "button1";
            this.SettingsTonButton.UseVisualStyleBackColor = true;
            // 
            // SettingsTonSlider
            // 
            this.SettingsTonSlider.Location = new System.Drawing.Point(331, 151);
            this.SettingsTonSlider.Name = "SettingsTonSlider";
            this.SettingsTonSlider.Size = new System.Drawing.Size(130, 56);
            this.SettingsTonSlider.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 571);
            this.Controls.Add(this.SettingsTonSlider);
            this.Controls.Add(this.SettingsTonButton);
            this.Name = "Settings";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTonSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SettingsTonButton;
        private TrackBar SettingsTonSlider;
    }
}