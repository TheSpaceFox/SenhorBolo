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
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtCEP.Text = null;
            txtCPF.Text = null;
            txtEmail.Text = null;
            txtID.Text = null;
            txtNome.Text = null;
            txtRG.Text = null;
            txtSalario.Text = null;
            txtSenha.Text = null;
            txtTelefone.Text = null;
        }

        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNome.Text == "" || txtSenha.Text == "" || txtRG.Text == "" || txtCPF.Text == "" || txtSalario.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Pro favor, preencha todos os campos obrigatórios");
            }
            else
            {
                CadastroFuncionarioModel cadastro = new CadastroFuncionarioModel();
                cadastro.Cadastrar(Convert.ToInt32(txtID.Text), txtNome.Text, txtSenha.Text, txtRG.Text, txtCPF.Text, Convert.ToDouble(txtSalario.Text), txtEmail.Text, txtTelefone.Text, txtCEP.Text);
            }
        }
    }
}
