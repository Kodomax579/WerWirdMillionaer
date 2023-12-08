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

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Regristrieren reg = new Regristrieren();

            this.Hide();
            reg.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Spieler controlling = new Spieler();


            int ID = controlling.login(username, password);
            if (ID > 0)
            {

                Startseite set = new Startseite(controlling.getSpielerID());

                this.Hide();
                set.Show();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}