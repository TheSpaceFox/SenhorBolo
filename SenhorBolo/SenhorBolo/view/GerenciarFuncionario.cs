using SenhorBolo.view;
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
using System.Data.SqlClient;

namespace SenhorBolo
{
    public partial class GerenciarFuncionario : Form
    {
        ControleFuncionarios funcionarios = new ControleFuncionarios();
        public GerenciarFuncionario()
        {
            InitializeComponent();
            dataGrid_Funcionario.DataSource = funcionarios.funcionariosCadastrados();
        }

        
        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarFuncionario gerenciar = new EditarFuncionario();
            gerenciar.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox_Pesquisa.SelectedIndex.ToString());
            MessageBox.Show(txtPesquisa.Text);
            limparDataGrid();
            dataGrid_Funcionario.DataSource = funcionarios.Pesquisa(txtPesquisa.Text, comboBox_Pesquisa.SelectedIndex);
        }

        private void limparDataGrid()
        {
            for (int i = 0; i < dataGrid_Funcionario.RowCount; i++)
            {
                dataGrid_Funcionario.Rows[i].DataGridView.Columns.Clear();
            }
        }
    }
}
