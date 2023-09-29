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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Einstellung";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(412, 65);
            label1.Name = "label1";
            label1.Size = new Size(263, 38);
            label1.TabIndex = 2;
            label1.Text = "Wer wird Millionär";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(469, 522);
            button2.Name = "button2";
            button2.Size = new Size(123, 41);
            button2.TabIndex = 3;
            button2.Text = "Einloggen";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(241, 201);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 4;
            label2.Text = "Benutzername:";
            // 
            // username
            // 
            username.Location = new Point(601, 202);
            username.Name = "username";
            username.Size = new Size(283, 27);
            username.TabIndex = 5;
            // 
            // password
            // 
            password.Location = new Point(601, 290);
            password.Name = "password";
            password.Size = new Size(283, 27);
            password.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(241, 292);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 7;
            label3.Text = "Passwort:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(842, 522);
            button3.Name = "button3";
            button3.Size = new Size(148, 41);
            button3.TabIndex = 8;
            button3.Text = "Regristrieren";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 619);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Label label3;
        private Button button3;
    }
}