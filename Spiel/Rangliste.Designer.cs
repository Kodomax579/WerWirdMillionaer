﻿namespace Spiel
{
    partial class Rangliste
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
            label1 = new Label();
            erster = new Label();
            zweiter = new Label();
            dritter = new Label();
            MeinPlatz = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(346, 50);
            label1.Name = "label1";
            label1.Size = new Size(130, 38);
            label1.TabIndex = 0;
            label1.Text = "Rangliste";
            label1.Click += label1_Click;
            // 
            // erster
            // 
            erster.AutoSize = true;
            erster.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            erster.Location = new Point(356, 228);
            erster.Name = "erster";
            erster.Size = new Size(63, 25);
            erster.TabIndex = 1;
            erster.Text = "1.Platz";
            // 
            // zweiter
            // 
            zweiter.AutoSize = true;
            zweiter.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            zweiter.Location = new Point(216, 309);
            zweiter.Name = "zweiter";
            zweiter.Size = new Size(63, 25);
            zweiter.TabIndex = 2;
            zweiter.Text = "2.Platz";
            // 
            // dritter
            // 
            dritter.AutoSize = true;
            dritter.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dritter.Location = new Point(479, 330);
            dritter.Name = "dritter";
            dritter.Size = new Size(63, 25);
            dritter.TabIndex = 3;
            dritter.Text = "3.Platz";
            // 
            // MeinPlatz
            // 
            MeinPlatz.AutoSize = true;
            MeinPlatz.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MeinPlatz.Location = new Point(650, 330);
            MeinPlatz.Name = "MeinPlatz";
            MeinPlatz.Size = new Size(93, 25);
            MeinPlatz.TabIndex = 4;
            MeinPlatz.Text = "Mein Platz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(650, 293);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 8;
            label6.Text = "Mein Platz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(479, 293);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 7;
            label7.Text = "3.Platz";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(216, 272);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 6;
            label8.Text = "2.Platz";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(356, 191);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 5;
            label9.Text = "1.Platz";
            // 
            // Rangliste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 478);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(MeinPlatz);
            Controls.Add(dritter);
            Controls.Add(zweiter);
            Controls.Add(erster);
            Controls.Add(label1);
            Name = "Rangliste";
            Text = "Rangliste";
            Load += Rangliste_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label erster;
        private Label zweiter;
        private Label dritter;
        private Label MeinPlatz;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}