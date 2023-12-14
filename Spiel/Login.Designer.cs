namespace Spiel
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(321, 28);
            label1.Name = "label1";
            label1.Size = new Size(284, 41);
            label1.TabIndex = 2;
            label1.Text = "Wer wird Millionär";
            label1.AutoSizeChanged += label1_AutoSizeChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(365, 355);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(240, 49);
            button2.TabIndex = 3;
            button2.Text = "Einloggen";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseHover += button1_MouseHover;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(140, 154);
            label2.Name = "label2";
            label2.Size = new Size(192, 37);
            label2.TabIndex = 4;
            label2.Text = "Benutzername:";
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(586, 154);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.PlaceholderText = "Benutzername";
            username.Size = new Size(290, 39);
            username.TabIndex = 5;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(586, 220);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.PlaceholderText = "Passwort";
            password.Size = new Size(290, 39);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(140, 220);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 7;
            label3.Text = "Passwort:";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(717, 355);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(159, 49);
            button3.TabIndex = 8;
            button3.Text = "Regristrieren";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseHover += button1_MouseHover;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(94, 355);
            button1.Name = "button1";
            button1.Size = new Size(164, 49);
            button1.TabIndex = 9;
            button1.Text = "Als Gast Spielen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(951, 464);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Label label3;
        private Button button3;
        private Button button1;
    }
}