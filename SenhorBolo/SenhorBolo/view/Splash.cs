using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhorBolo {
    public partial class Splash : Form {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            fundoCarregamento.Width += 3;
            if (fundoCarregamento.Width >= 500)
            {
                timer.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
