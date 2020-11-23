using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenhorBolo.model;

namespace SenhorBolo.view
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        ControleFornecedor fornecedor = new ControleFornecedor();

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTexto();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "" || txtDescricao.Text == "" || txtContato.Text == "" || txtEndereco.Text == "" || txtCidade.Text == "")
            {
                MessageBox.Show("Pro favor, preencha todos os campos obrigatórios");
            }
            else
            {
                fornecedor.Cadastrar(txtCNPJ.Text, txtDescricao.Text, txtContato.Text, txtEndereco.Text, txtCidade.Text);
                limparTexto();
            }
        }

        private void limparTexto()
        {
            txtCNPJ.Text = null;
            txtDescricao.Text = null;
            txtContato.Text = null;
            txtEndereco.Text = null;
            txtCidade.Text = null;
        }
    }
}
