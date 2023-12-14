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
            label1.Location = new Point(367, 38);
            label1.Name = "label1";
            label1.Size = new Size(351, 50);
            label1.TabIndex = 2;
            label1.Text = "Wer wird Millionär";
            label1.AutoSizeChanged += label1_AutoSizeChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(474, 473);
            button2.Name = "button2";
            button2.Size = new Size(167, 65);
            button2.TabIndex = 3;
            button2.Text = "Einloggen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(230, 203);
            label2.Name = "label2";
            label2.Size = new Size(242, 46);
            label2.TabIndex = 4;
            label2.Text = "Benutzername:";
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Right;
            username.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(590, 205);
            username.Name = "username";
            username.PlaceholderText = "Benutzername";
            username.Size = new Size(331, 47);
            username.TabIndex = 5;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Right;
            password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(590, 293);
            password.Name = "password";
            password.PlaceholderText = "Passwort";
            password.Size = new Size(331, 47);
            password.TabIndex = 6;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(230, 294);
            label3.Name = "label3";
            label3.Size = new Size(159, 46);
            label3.TabIndex = 7;
            label3.Text = "Passwort:";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(819, 473);
            button3.Name = "button3";
            button3.Size = new Size(182, 65);
            button3.TabIndex = 8;
            button3.Text = "Regristrieren";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(108, 473);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(188, 65);
            button1.TabIndex = 9;
            button1.Text = "Als Gast Spielen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1087, 619);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
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