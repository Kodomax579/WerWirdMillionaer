using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiel
{
    public partial class Spielfeld : Form
    {
        public Spielfeld()
        {
            InitializeComponent();
        }

        private void Spielfeld_Load(object sender, EventArgs e)
        {
            int stage = 1;
            Controller controller = new Controller();
            controller.GetFrage(stage,frage,Antwort1,Antwort2,Antwort3,Antwort4);

        }
    }
}
