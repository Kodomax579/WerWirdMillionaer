﻿namespace Spiel
{
    partial class Startseite
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(384, 43);
            label1.Name = "label1";
            label1.Size = new Size(259, 41);
            label1.TabIndex = 0;
            label1.Text = "Wer wird Millionär";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(416, 354);
            button1.Name = "button1";
            button1.Size = new Size(200, 43);
            button1.TabIndex = 1;
            button1.Text = "Neues Spiel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(416, 427);
            button2.Name = "button2";
            button2.Size = new Size(200, 43);
            button2.TabIndex = 2;
            button2.Text = "Optionen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(416, 495);
            button3.Name = "button3";
            button3.Size = new Size(200, 43);
            button3.TabIndex = 3;
            button3.Text = "Rangliste";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(45, 509);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Einstellung";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Startseite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 607);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Startseite";
            Text = "Startseite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}