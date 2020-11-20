using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhorBolo
{
    public partial class GerenciarFuncionario : Form
    {
        public GerenciarFuncionario()
        {
            InitializeComponent();
            dataGrid_Funcionario.Rows.Add();
            dataGrid_Funcionario[0, 0].Value = 1;
            dataGrid_Funcionario[1, 0].Value = "Edson Bolsonaro";
            dataGrid_Funcionario[2, 0].Value = "Lolicon01203";
            dataGrid_Funcionario[3, 0].Value = 1200.00;
            dataGrid_Funcionario[4, 0].Value = "40.661.702-8";
            dataGrid_Funcionario[5, 0].Value = "40.661.702-8";
            dataGrid_Funcionario[6, 0].Value = "edson.koiti@etec.sp.gov.br";
            dataGrid_Funcionario[7, 0].Value = "58428-500";

        }


        private void controlFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
