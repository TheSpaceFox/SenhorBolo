using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhorBolo.view
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = null;
            txtID.Text = null;
            txtMaisValia.Text = null;
            txtValor.Text = null;
        }
    }
}
