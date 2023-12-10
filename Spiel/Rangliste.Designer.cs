namespace Spiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rangliste));
            label1 = new Label();
            erster = new Label();
            zweiter = new Label();
            dritter = new Label();
            MeinPlatz = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(446, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 0;
            label1.Text = "Rangliste";
            label1.Click += label1_Click;
            // 
            // erster
            // 
            erster.AutoSize = true;
            erster.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            erster.Location = new Point(455, 114);
            erster.Name = "erster";
            erster.Size = new Size(97, 38);
            erster.TabIndex = 1;
            erster.Text = "1.Platz";
            // 
            // zweiter
            // 
            zweiter.AutoSize = true;
            zweiter.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            zweiter.Location = new Point(199, 205);
            zweiter.Name = "zweiter";
            zweiter.Size = new Size(97, 38);
            zweiter.TabIndex = 2;
            zweiter.Text = "2.Platz";
            // 
            // dritter
            // 
            dritter.AutoSize = true;
            dritter.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dritter.Location = new Point(692, 228);
            dritter.Name = "dritter";
            dritter.Size = new Size(97, 38);
            dritter.TabIndex = 3;
            dritter.Text = "3.Platz";
            // 
            // MeinPlatz
            // 
            MeinPlatz.AutoSize = true;
            MeinPlatz.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MeinPlatz.Location = new Point(862, 402);
            MeinPlatz.Name = "MeinPlatz";
            MeinPlatz.Size = new Size(147, 38);
            MeinPlatz.TabIndex = 4;
            MeinPlatz.Text = "Mein Platz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(878, 330);
            label6.Name = "label6";
            label6.Size = new Size(147, 38);
            label6.TabIndex = 8;
            label6.Text = "Mein Platz";
            // 
            // button1
            // 
            button1.Location = new Point(432, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(151, 47);
            button1.TabIndex = 9;
            button1.Text = "Startseite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Rangliste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1098, 619);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(MeinPlatz);
            Controls.Add(dritter);
            Controls.Add(zweiter);
            Controls.Add(erster);
            Controls.Add(label1);
            DoubleBuffered = true;
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
        private Button button1;
    }
}