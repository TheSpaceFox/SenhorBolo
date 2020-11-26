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
    public partial class EditarFornecedor : Form
    {
        ControleFornecedor fornecedores = new ControleFornecedor();
        public EditarFornecedor()
        {
            InitializeComponent();
            comboID();
        }

        public void comboID()
        {
            DataTable Dt = new DataTable();
            Dt = fornecedores.getFornecedores();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                comboBoxCNPJ.Items.Add(Dt.Rows[i]["CNPJ"].ToString());
            }
        }

        private void EditarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTexto();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparTexto();
            fornecedores.setFornecedores(comboBoxCNPJ.GetItemText(comboBoxCNPJ.SelectedItem));
            txtNome.Text = fornecedor.descFor;
            txtContato.Text = fornecedor.contatoFor;
            txtEndereco.Text = fornecedor.enderecoFor;
            txtCidade.Text = fornecedor.cidade;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool funcionou;
            fornecedor.descFor = txtNome.Text;
            fornecedor.contatoFor = txtContato.Text;
            fornecedor.enderecoFor = txtEndereco.Text;
            fornecedor.cidade = txtCidade.Text;
            funcionou = fornecedores.updateFornecedor();
            if (funcionou == true)
            {
                MessageBox.Show("Fornecedor alterado com sucesso!");
            }
            LimparTexto();
        }

        public void LimparTexto()
        {
            txtNome.Text = null;
            txtContato.Text = null;
            txtEndereco.Text = null;
            txtCidade.Text = null;
        }
    }
}