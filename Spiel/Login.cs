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
            EventHandler Button3
            Regristrieren reg = new Regristrieren();
            reg.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}