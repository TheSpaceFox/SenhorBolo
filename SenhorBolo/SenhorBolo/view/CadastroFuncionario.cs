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

namespace SenhorBolo
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
            ControlHeightWidth();
        }

        ControleFuncionarios funcionario = new ControleFuncionarios();

        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNome.Text == "" || txtSenha.Text == "" || txtRG.Text == "" || txtSalario.Text == ""  || txtTelefone.Text == "")
            {
                MessageBox.Show("Pro favor, preencha todos os campos obrigatórios");
            } else {
                double salario = Convert.ToDouble(txtSalario.Text);
                salario = (salario / 100);
                funcionario.Cadastrar(Convert.ToInt32(txtID.Text), txtNome.Text, txtSenha.Text, txtRG.Text, salario, txtEmail.Text, txtTelefone.Text, txtCEP.Text);
                limparTexto();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblCadastroFuncionarios.Text = txtRG.Text;
            limparTexto();
        }

        private void limparTexto()
        {
            txtCEP.Text = null;
            txtEmail.Text = null;
            txtID.Text = null;
            txtNome.Text = null;
            txtRG.Text = null;
            txtSalario.Text = null;
            txtSenha.Text = null;
            txtTelefone.Text = null;
        }

        private void ControlHeightWidth()
        {
            foreach (Control c in this.Controls)
            {
                if ((c.GetType() == typeof(MaskedTextBox)))
                {
                    ((MaskedTextBox)c).AutoSize = false;
                    c.Size = new Size(252, 35);
                }
            }
        }
    }
}
