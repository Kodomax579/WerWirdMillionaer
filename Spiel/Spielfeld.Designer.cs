namespace Spiel
{
    partial class Spielfeld
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spielfeld));
            Antwort1 = new Button();
            Antwort2 = new Button();
            Antwort3 = new Button();
            Antwort4 = new Button();
            Stufe1 = new CheckBox();
            Stufe2 = new CheckBox();
            Stufe4 = new CheckBox();
            Stufe3 = new CheckBox();
            Stufe6 = new CheckBox();
            Stufe5 = new CheckBox();
            Stufe8 = new CheckBox();
            Stufe7 = new CheckBox();
            Stufe10 = new CheckBox();
            Stufe9 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            frage = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Antwort1
            // 
            Antwort1.Anchor = AnchorStyles.Bottom;
            Antwort1.BackColor = Color.Transparent;
            Antwort1.BackgroundImage = (Image)resources.GetObject("Antwort1.BackgroundImage");
            Antwort1.BackgroundImageLayout = ImageLayout.Stretch;
            Antwort1.FlatAppearance.BorderSize = 0;
            Antwort1.FlatAppearance.CheckedBackColor = Color.Transparent;
            Antwort1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Antwort1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Antwort1.FlatStyle = FlatStyle.Flat;
            Antwort1.ForeColor = SystemColors.Control;
            Antwort1.Location = new Point(163, 250);
            Antwort1.Name = "Antwort1";
            Antwort1.Size = new Size(192, 50);
            Antwort1.TabIndex = 0;
            Antwort1.Text = "button1";
            Antwort1.UseVisualStyleBackColor = false;
            Antwort1.Click += Antwort1_Click;
            // 
            // Antwort2
            // 
            Antwort2.Anchor = AnchorStyles.Bottom;
            Antwort2.BackColor = Color.Transparent;
            Antwort2.BackgroundImage = (Image)resources.GetObject("Antwort2.BackgroundImage");
            Antwort2.BackgroundImageLayout = ImageLayout.Stretch;
            Antwort2.FlatAppearance.BorderSize = 0;
            Antwort2.FlatAppearance.CheckedBackColor = Color.Transparent;
            Antwort2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Antwort2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Antwort2.FlatStyle = FlatStyle.Flat;
            Antwort2.ForeColor = SystemColors.Control;
            Antwort2.Location = new Point(437, 250);
            Antwort2.Name = "Antwort2";
            Antwort2.Size = new Size(185, 50);
            Antwort2.TabIndex = 1;
            Antwort2.Text = "button2";
            Antwort2.UseVisualStyleBackColor = false;
            Antwort2.Click += Antwort2_Click;
            // 
            // Antwort3
            // 
            Antwort3.Anchor = AnchorStyles.Bottom;
            Antwort3.BackColor = Color.Transparent;
            Antwort3.BackgroundImage = (Image)resources.GetObject("Antwort3.BackgroundImage");
            Antwort3.BackgroundImageLayout = ImageLayout.Stretch;
            Antwort3.FlatAppearance.BorderSize = 0;
            Antwort3.FlatAppearance.CheckedBackColor = Color.Transparent;
            Antwort3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Antwort3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Antwort3.FlatStyle = FlatStyle.Flat;
            Antwort3.ForeColor = SystemColors.Control;
            Antwort3.Location = new Point(163, 327);
            Antwort3.Name = "Antwort3";
            Antwort3.Size = new Size(192, 51);
            Antwort3.TabIndex = 2;
            Antwort3.Text = "button3";
            Antwort3.UseVisualStyleBackColor = false;
            Antwort3.Click += Antwort3_Click;
            // 
            // Antwort4
            // 
            Antwort4.Anchor = AnchorStyles.Bottom;
            Antwort4.BackColor = Color.Transparent;
            Antwort4.BackgroundImage = (Image)resources.GetObject("Antwort4.BackgroundImage");
            Antwort4.BackgroundImageLayout = ImageLayout.Stretch;
            Antwort4.FlatAppearance.BorderSize = 0;
            Antwort4.FlatAppearance.CheckedBackColor = Color.Transparent;
            Antwort4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Antwort4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Antwort4.FlatStyle = FlatStyle.Flat;
            Antwort4.ForeColor = SystemColors.Control;
            Antwort4.Location = new Point(437, 327);
            Antwort4.Name = "Antwort4";
            Antwort4.Size = new Size(185, 51);
            Antwort4.TabIndex = 3;
            Antwort4.Text = "button4";
            Antwort4.UseVisualStyleBackColor = false;
            Antwort4.Click += Antwort4_Click;
            // 
            // Stufe1
            // 
            Stufe1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe1.AutoCheck = false;
            Stufe1.BackColor = Color.Transparent;
            Stufe1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe1.ForeColor = Color.Azure;
            Stufe1.Location = new Point(640, 370);
            Stufe1.Name = "Stufe1";
            Stufe1.Size = new Size(147, 26);
            Stufe1.TabIndex = 5;
            Stufe1.Text = "50€";
            Stufe1.UseVisualStyleBackColor = false;
            Stufe1.CheckedChanged += Stufe1_CheckedChanged;
            // 
            // Stufe2
            // 
            Stufe2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe2.AutoCheck = false;
            Stufe2.BackColor = Color.Transparent;
            Stufe2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe2.ForeColor = Color.Azure;
            Stufe2.Location = new Point(640, 330);
            Stufe2.Name = "Stufe2";
            Stufe2.Size = new Size(147, 29);
            Stufe2.TabIndex = 6;
            Stufe2.Text = "100€";
            Stufe2.UseVisualStyleBackColor = false;
            Stufe2.CheckedChanged += Stufe2_CheckedChanged;
            // 
            // Stufe4
            // 
            Stufe4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe4.AutoCheck = false;
            Stufe4.BackColor = Color.Transparent;
            Stufe4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe4.ForeColor = Color.Azure;
            Stufe4.Location = new Point(640, 250);
            Stufe4.Name = "Stufe4";
            Stufe4.Size = new Size(147, 29);
            Stufe4.TabIndex = 8;
            Stufe4.Text = "1.000€";
            Stufe4.UseVisualStyleBackColor = false;
            // 
            // Stufe3
            // 
            Stufe3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe3.AutoCheck = false;
            Stufe3.BackColor = Color.Transparent;
            Stufe3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe3.ForeColor = Color.Azure;
            Stufe3.Location = new Point(640, 290);
            Stufe3.Name = "Stufe3";
            Stufe3.Size = new Size(147, 29);
            Stufe3.TabIndex = 7;
            Stufe3.Text = "500€";
            Stufe3.UseVisualStyleBackColor = false;
            Stufe3.CheckedChanged += Stufe3_CheckedChanged;
            // 
            // Stufe6
            // 
            Stufe6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe6.AutoCheck = false;
            Stufe6.BackColor = Color.Transparent;
            Stufe6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe6.ForeColor = Color.Azure;
            Stufe6.Location = new Point(640, 170);
            Stufe6.Name = "Stufe6";
            Stufe6.Size = new Size(147, 29);
            Stufe6.TabIndex = 10;
            Stufe6.Text = "10.000€";
            Stufe6.UseVisualStyleBackColor = false;
            // 
            // Stufe5
            // 
            Stufe5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe5.AutoCheck = false;
            Stufe5.BackColor = Color.Transparent;
            Stufe5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe5.ForeColor = Color.Azure;
            Stufe5.Location = new Point(640, 210);
            Stufe5.Name = "Stufe5";
            Stufe5.Size = new Size(148, 29);
            Stufe5.TabIndex = 9;
            Stufe5.Text = "5.000€";
            Stufe5.UseVisualStyleBackColor = false;
            Stufe5.CheckedChanged += Stufe5_CheckedChanged;
            // 
            // Stufe8
            // 
            Stufe8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe8.AutoCheck = false;
            Stufe8.BackColor = Color.Transparent;
            Stufe8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe8.ForeColor = Color.Azure;
            Stufe8.Location = new Point(640, 90);
            Stufe8.Name = "Stufe8";
            Stufe8.Size = new Size(147, 29);
            Stufe8.TabIndex = 12;
            Stufe8.Text = "100.000€";
            Stufe8.UseVisualStyleBackColor = false;
            Stufe8.CheckedChanged += Stufe8_CheckedChanged;
            // 
            // Stufe7
            // 
            Stufe7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe7.AutoCheck = false;
            Stufe7.BackColor = Color.Transparent;
            Stufe7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe7.ForeColor = Color.Azure;
            Stufe7.Location = new Point(640, 130);
            Stufe7.Name = "Stufe7";
            Stufe7.Size = new Size(147, 29);
            Stufe7.TabIndex = 11;
            Stufe7.Text = "50.000€";
            Stufe7.UseVisualStyleBackColor = false;
            // 
            // Stufe10
            // 
            Stufe10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe10.AutoCheck = false;
            Stufe10.BackColor = Color.Transparent;
            Stufe10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe10.ForeColor = Color.Azure;
            Stufe10.Location = new Point(640, 10);
            Stufe10.Name = "Stufe10";
            Stufe10.Size = new Size(148, 29);
            Stufe10.TabIndex = 14;
            Stufe10.Text = "1.000.000€";
            Stufe10.UseVisualStyleBackColor = false;
            // 
            // Stufe9
            // 
            Stufe9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Stufe9.AutoCheck = false;
            Stufe9.BackColor = Color.Transparent;
            Stufe9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Stufe9.ForeColor = Color.Azure;
            Stufe9.Location = new Point(640, 50);
            Stufe9.Name = "Stufe9";
            Stufe9.Size = new Size(147, 29);
            Stufe9.TabIndex = 13;
            Stufe9.Text = "500.000€";
            Stufe9.UseVisualStyleBackColor = false;
            Stufe9.CheckedChanged += Stufe9_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(10, 398);
            button1.Name = "button1";
            button1.Size = new Size(135, 42);
            button1.TabIndex = 15;
            button1.Text = "Zurück zur Startseite";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(57, 50);
            button2.Name = "button2";
            button2.Size = new Size(96, 80);
            button2.TabIndex = 16;
            button2.Text = "50/50";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frage
            // 
            frage.Anchor = AnchorStyles.None;
            frage.AutoSize = true;
            frage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            frage.ForeColor = SystemColors.ButtonFace;
            frage.Location = new Point(38, 17);
            frage.MaximumSize = new Size(500, 80);
            frage.Name = "frage";
            frage.Size = new Size(132, 32);
            frage.TabIndex = 4;
            frage.Text = "gdfsgdfgdf";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(frage);
            panel1.Location = new Point(121, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 91);
            panel1.TabIndex = 17;
            // 
            // Spielfeld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(Antwort1);
            Controls.Add(button1);
            Controls.Add(Stufe10);
            Controls.Add(Stufe9);
            Controls.Add(Stufe8);
            Controls.Add(Stufe7);
            Controls.Add(Stufe6);
            Controls.Add(Stufe5);
            Controls.Add(Stufe4);
            Controls.Add(Stufe3);
            Controls.Add(Stufe2);
            Controls.Add(Stufe1);
            Controls.Add(Antwort4);
            Controls.Add(Antwort3);
            Controls.Add(Antwort2);
            Name = "Spielfeld";
            Text = "Spielfeld";
            Load += Spielfeld_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Antwort1;
        private Button Antwort2;
        private Button Antwort3;
        private Button Antwort4;
        private Label frage;
        private CheckBox Stufe1;
        private CheckBox Stufe2;
        private CheckBox Stufe4;
        private CheckBox Stufe3;
        private CheckBox Stufe6;
        private CheckBox Stufe5;
        private CheckBox Stufe8;
        private CheckBox Stufe7;
        private CheckBox Stufe10;
        private CheckBox Stufe9;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}