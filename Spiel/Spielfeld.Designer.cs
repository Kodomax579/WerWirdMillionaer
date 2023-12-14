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
            frage = new Label();
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
            SuspendLayout();
            // 
            // Antwort1
            // 
            Antwort1.Anchor = AnchorStyles.Bottom;
            Antwort1.Location = new Point(72, 337);
            Antwort1.Margin = new Padding(3, 4, 3, 4);
            Antwort1.Name = "Antwort1";
            Antwort1.Size = new Size(219, 67);
            Antwort1.TabIndex = 0;
            Antwort1.Text = "button1";
            Antwort1.UseVisualStyleBackColor = true;
            Antwort1.Click += Antwort1_Click;
            // 
            // Antwort2
            // 
            Antwort2.Anchor = AnchorStyles.Bottom;
            Antwort2.Location = new Point(385, 337);
            Antwort2.Margin = new Padding(3, 4, 3, 4);
            Antwort2.Name = "Antwort2";
            Antwort2.Size = new Size(211, 67);
            Antwort2.TabIndex = 1;
            Antwort2.Text = "button2";
            Antwort2.UseVisualStyleBackColor = true;
            Antwort2.Click += Antwort2_Click;
            // 
            // Antwort3
            // 
            Antwort3.Anchor = AnchorStyles.Bottom;
            Antwort3.Location = new Point(72, 440);
            Antwort3.Margin = new Padding(3, 4, 3, 4);
            Antwort3.Name = "Antwort3";
            Antwort3.Size = new Size(219, 68);
            Antwort3.TabIndex = 2;
            Antwort3.Text = "button3";
            Antwort3.UseVisualStyleBackColor = true;
            Antwort3.Click += Antwort3_Click;
            // 
            // Antwort4
            // 
            Antwort4.Anchor = AnchorStyles.Bottom;
            Antwort4.Location = new Point(385, 440);
            Antwort4.Margin = new Padding(3, 4, 3, 4);
            Antwort4.Name = "Antwort4";
            Antwort4.Size = new Size(211, 68);
            Antwort4.TabIndex = 3;
            Antwort4.Text = "button4";
            Antwort4.UseVisualStyleBackColor = true;
            Antwort4.Click += Antwort4_Click;
            // 
            // frage
            // 
            frage.Anchor = AnchorStyles.None;
            frage.AutoSize = true;
            frage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            frage.Location = new Point(90, 166);
            frage.MaximumSize = new Size(571, 107);
            frage.Name = "frage";
            frage.Size = new Size(0, 41);
            frage.TabIndex = 4;
            // 
            // Stufe1
            // 
            Stufe1.Anchor = AnchorStyles.Right;
            Stufe1.AutoCheck = false;
            Stufe1.BackColor = Color.Transparent;
            Stufe1.Location = new Point(715, 533);
            Stufe1.Margin = new Padding(3, 4, 3, 4);
            Stufe1.Name = "Stufe1";
            Stufe1.Size = new Size(55, 24);
            Stufe1.TabIndex = 5;
            Stufe1.Text = "50€";
            Stufe1.UseVisualStyleBackColor = false;
            Stufe1.CheckedChanged += Stufe1_CheckedChanged;
            // 
            // Stufe2
            // 
            Stufe2.Anchor = AnchorStyles.Right;
            Stufe2.AutoCheck = false;
            Stufe2.AutoSize = true;
            Stufe2.BackColor = Color.Transparent;
            Stufe2.Location = new Point(715, 476);
            Stufe2.Margin = new Padding(3, 4, 3, 4);
            Stufe2.Name = "Stufe2";
            Stufe2.Size = new Size(63, 24);
            Stufe2.TabIndex = 6;
            Stufe2.Text = "100€";
            Stufe2.UseVisualStyleBackColor = false;
            // 
            // Stufe4
            // 
            Stufe4.Anchor = AnchorStyles.Right;
            Stufe4.AutoCheck = false;
            Stufe4.AutoSize = true;
            Stufe4.BackColor = Color.Transparent;
            Stufe4.Location = new Point(715, 363);
            Stufe4.Margin = new Padding(3, 4, 3, 4);
            Stufe4.Name = "Stufe4";
            Stufe4.Size = new Size(71, 24);
            Stufe4.TabIndex = 8;
            Stufe4.Text = "1000€";
            Stufe4.UseVisualStyleBackColor = false;
            // 
            // Stufe3
            // 
            Stufe3.Anchor = AnchorStyles.Right;
            Stufe3.AutoCheck = false;
            Stufe3.AutoSize = true;
            Stufe3.BackColor = Color.Transparent;
            Stufe3.Location = new Point(715, 417);
            Stufe3.Margin = new Padding(3, 4, 3, 4);
            Stufe3.Name = "Stufe3";
            Stufe3.Size = new Size(63, 24);
            Stufe3.TabIndex = 7;
            Stufe3.Text = "500€";
            Stufe3.UseVisualStyleBackColor = false;
            // 
            // Stufe6
            // 
            Stufe6.Anchor = AnchorStyles.Right;
            Stufe6.AutoCheck = false;
            Stufe6.AutoSize = true;
            Stufe6.BackColor = Color.Transparent;
            Stufe6.Location = new Point(715, 253);
            Stufe6.Margin = new Padding(3, 4, 3, 4);
            Stufe6.Name = "Stufe6";
            Stufe6.Size = new Size(82, 24);
            Stufe6.TabIndex = 10;
            Stufe6.Text = "10.000€";
            Stufe6.UseVisualStyleBackColor = false;
            // 
            // Stufe5
            // 
            Stufe5.Anchor = AnchorStyles.Right;
            Stufe5.AutoCheck = false;
            Stufe5.AutoSize = true;
            Stufe5.BackColor = Color.Transparent;
            Stufe5.Location = new Point(715, 305);
            Stufe5.Margin = new Padding(3, 4, 3, 4);
            Stufe5.Name = "Stufe5";
            Stufe5.Size = new Size(71, 24);
            Stufe5.TabIndex = 9;
            Stufe5.Text = "5000€";
            Stufe5.UseVisualStyleBackColor = false;
            // 
            // Stufe8
            // 
            Stufe8.Anchor = AnchorStyles.Right;
            Stufe8.AutoCheck = false;
            Stufe8.AutoSize = true;
            Stufe8.BackColor = Color.Transparent;
            Stufe8.Location = new Point(715, 149);
            Stufe8.Margin = new Padding(3, 4, 3, 4);
            Stufe8.Name = "Stufe8";
            Stufe8.Size = new Size(90, 24);
            Stufe8.TabIndex = 12;
            Stufe8.Text = "100.000€";
            Stufe8.UseVisualStyleBackColor = false;
            Stufe8.CheckedChanged += Stufe8_CheckedChanged;
            // 
            // Stufe7
            // 
            Stufe7.Anchor = AnchorStyles.Right;
            Stufe7.AutoCheck = false;
            Stufe7.AutoSize = true;
            Stufe7.BackColor = Color.Transparent;
            Stufe7.Location = new Point(715, 201);
            Stufe7.Margin = new Padding(3, 4, 3, 4);
            Stufe7.Name = "Stufe7";
            Stufe7.Size = new Size(82, 24);
            Stufe7.TabIndex = 11;
            Stufe7.Text = "50.000€";
            Stufe7.UseVisualStyleBackColor = false;
            // 
            // Stufe10
            // 
            Stufe10.Anchor = AnchorStyles.Right;
            Stufe10.AutoCheck = false;
            Stufe10.AutoSize = true;
            Stufe10.BackColor = Color.Transparent;
            Stufe10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Stufe10.Location = new Point(715, 39);
            Stufe10.Margin = new Padding(3, 4, 3, 4);
            Stufe10.Name = "Stufe10";
            Stufe10.Size = new Size(111, 24);
            Stufe10.TabIndex = 14;
            Stufe10.Text = "1.000.000€";
            Stufe10.UseVisualStyleBackColor = false;
            // 
            // Stufe9
            // 
            Stufe9.Anchor = AnchorStyles.Right;
            Stufe9.AutoCheck = false;
            Stufe9.AutoSize = true;
            Stufe9.BackColor = Color.Transparent;
            Stufe9.Location = new Point(715, 91);
            Stufe9.Margin = new Padding(3, 4, 3, 4);
            Stufe9.Name = "Stufe9";
            Stufe9.Size = new Size(90, 24);
            Stufe9.TabIndex = 13;
            Stufe9.Text = "500.000€";
            Stufe9.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 558);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 15;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Spielfeld
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
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
            Controls.Add(frage);
            Controls.Add(Antwort4);
            Controls.Add(Antwort3);
            Controls.Add(Antwort2);
            Controls.Add(Antwort1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Spielfeld";
            Text = "Spielfeld";
            Load += Spielfeld_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}