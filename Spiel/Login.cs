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
            reg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controlling controlling = new Controlling();
            controlling.login(username,password);

            Startseite set = new Startseite();
           
            Login login = new Login();
            login.Dispose();
            set.Show();
        }
    }
}