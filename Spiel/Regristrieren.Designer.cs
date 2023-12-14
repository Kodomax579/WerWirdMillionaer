namespace Spiel
{
    partial class Regristrieren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regristrieren));
            label3 = new Label();
            nachname = new TextBox();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            passwort = new TextBox();
            username = new TextBox();
            label5 = new Label();
            button1 = new Button();
            Email = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(202, 187);
            label3.Name = "label3";
            label3.Size = new Size(129, 31);
            label3.TabIndex = 11;
            label3.Text = "Nachname:";
            // 
            // nachname
            // 
            nachname.Anchor = AnchorStyles.None;
            nachname.Location = new Point(562, 185);
            nachname.Name = "nachname";
            nachname.PlaceholderText = "Nachname";
            nachname.Size = new Size(283, 27);
            nachname.TabIndex = 10;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Location = new Point(562, 112);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(283, 27);
            name.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(202, 111);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 8;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(413, 12);
            label1.Name = "label1";
            label1.Size = new Size(227, 46);
            label1.TabIndex = 12;
            label1.Text = "Regristrieren";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(202, 432);
            label4.Name = "label4";
            label4.Size = new Size(109, 31);
            label4.TabIndex = 16;
            label4.Text = "Passwort:";
            // 
            // passwort
            // 
            passwort.Anchor = AnchorStyles.None;
            passwort.Location = new Point(562, 431);
            passwort.Name = "passwort";
            passwort.PlaceholderText = "Passwort";
            passwort.Size = new Size(283, 27);
            passwort.TabIndex = 15;
            passwort.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.Location = new Point(562, 269);
            username.Name = "username";
            username.PlaceholderText = "Benutzername";
            username.Size = new Size(283, 27);
            username.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(202, 268);
            label5.Name = "label5";
            label5.Size = new Size(165, 31);
            label5.TabIndex = 13;
            label5.Text = "Benutzername:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(413, 488);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(195, 41);
            button1.TabIndex = 17;
            button1.Text = "Regristrieren";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.Location = new Point(562, 348);
            Email.Name = "Email";
            Email.PlaceholderText = "E-Mail";
            Email.Size = new Size(283, 27);
            Email.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(202, 347);
            label6.Name = "label6";
            label6.Size = new Size(85, 31);
            label6.TabIndex = 18;
            label6.Text = "E-Mail:";
            // 
            // Regristrieren
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1071, 572);
            Controls.Add(Email);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(passwort);
            Controls.Add(username);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(nachname);
            Controls.Add(name);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "Regristrieren";
            Text = "Form2";
            Load += Regristrieren_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox nachname;
        private TextBox name;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox passwort;
        private TextBox username;
        private Label label5;
        private Button button1;
        private TextBox Email;
        private Label label6;
    }
}