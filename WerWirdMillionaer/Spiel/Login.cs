namespace Spiel
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();
        }

        private void RegristrierenButton(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

            this.WindowState = FormWindowState.Maximized;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Regristrieren reg = new Regristrieren();

            this.Hide();
            reg.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ControllerLogin controlling = new ControllerLogin();


            int ID = controlling.login(username, password);
            if (ID > 0)
            {
                Startseite set = new Startseite(controlling.getSpielerID());

                this.Hide();
                set.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Passwort", "Wrong Username or Passwort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Startseite set = new Startseite(0);
            this.Hide();
            set.Show();
        }

        private void label1_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}