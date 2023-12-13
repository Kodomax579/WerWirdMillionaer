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
            label1.Location = new Point(504, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 0;
            label1.Text = "Rangliste";
            label1.Click += label1_Click;
            // 
            // erster
            // 
            erster.AutoSize = true;
            erster.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            erster.Location = new Point(492, 52);
            erster.Name = "erster";
            erster.Size = new Size(75, 30);
            erster.TabIndex = 1;
            erster.Text = "1.Platz";
            erster.Click += erster_Click;
            // 
            // zweiter
            // 
            zweiter.AutoSize = true;
            zweiter.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            zweiter.Location = new Point(250, 124);
            zweiter.Name = "zweiter";
            zweiter.Size = new Size(75, 30);
            zweiter.TabIndex = 2;
            zweiter.Text = "2.Platz";
            // 
            // dritter
            // 
            dritter.AutoSize = true;
            dritter.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dritter.Location = new Point(704, 161);
            dritter.Name = "dritter";
            dritter.Size = new Size(75, 30);
            dritter.TabIndex = 3;
            dritter.Text = "3.Platz";
            // 
            // MeinPlatz
            // 
            MeinPlatz.AutoSize = true;
            MeinPlatz.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MeinPlatz.Location = new Point(895, 354);
            MeinPlatz.Name = "MeinPlatz";
            MeinPlatz.Size = new Size(106, 30);
            MeinPlatz.TabIndex = 4;
            MeinPlatz.Text = "Kein Platz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(895, 295);
            label6.Name = "label6";
            label6.Size = new Size(120, 30);
            label6.TabIndex = 8;
            label6.Text = "Platzierung";
            // 
            // button1
            // 
            button1.Location = new Point(519, 548);
            button1.Name = "button1";
            button1.Size = new Size(132, 35);
            button1.TabIndex = 9;
            button1.Text = "Startseite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Rangliste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1100, 627);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(MeinPlatz);
            Controls.Add(dritter);
            Controls.Add(zweiter);
            Controls.Add(erster);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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