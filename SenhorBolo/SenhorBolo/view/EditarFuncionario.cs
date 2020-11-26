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
using SenhorBolo.common;

namespace SenhorBolo.view
{
    public partial class EditarFuncionario : Form
    {
        ControleFuncionarios funcionarios = new ControleFuncionarios();
        public EditarFuncionario()
        {
            InitializeComponent();
            comboID();
        }


        public void comboID()
        {
            DataTable Dt = new DataTable();
            Dt = funcionarios.getFuncionarios();
            for (int i = 0; i< Dt.Rows.Count; i++)
            {
                comboBoxID.Items.Add(Dt.Rows[i]["idFuncionario"].ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTexto();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparTexto();
            funcionarios.setFuncionario(int.Parse(comboBoxID.GetItemText(comboBoxID.SelectedItem)));
            txtSenha.Text = Funcionario.senhaFunc;
            txtNome.Text = Funcionario.nomeFunc;
            txtRG.Text = Funcionario.RG;
            txtCEP.Text = Funcionario.cep;
            txtTelefone.Text = Funcionario.telefone;
            txtEmail.Text = Funcionario.email;
            txtSalario.Text = Convert.ToString(Funcionario.salario);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool funcionou;
            Funcionario.senhaFunc = txtSenha.Text;
            Funcionario.nomeFunc = txtNome.Text;
            Funcionario.RG = txtRG.Text;
            Funcionario.cep = txtCEP.Text; 
            Funcionario.telefone = txtTelefone.Text;
            Funcionario.email = txtEmail.Text;
            Funcionario.salario = double.Parse(txtSalario.Text);
            funcionou = funcionarios.updateFuncionario();
            if (funcionou == false)
            {
                MessageBox.Show("Login inválido, tente novamente", "Erro de Acesso");
            }
            LimparTexto();

        }

        public void LimparTexto()
        {
            txtCEP.Text = null;
            txtEmail.Text = null;
            txtNome.Text = null;
            txtRG.Text = null;
            txtSalario.Text = null;
            txtSenha.Text = null;
            txtTelefone.Text = null;
        }
    }
}
