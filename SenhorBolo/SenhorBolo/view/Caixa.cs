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
    public partial class Caixa : Form {
        public Caixa()
        {
            InitializeComponent();
        }

        private void relógio_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("T");
        }
    }
}
