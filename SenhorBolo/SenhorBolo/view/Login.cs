using SenhorBolo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhorBolo {
    public partial class Login : Form {
        public Login()
        {
            InitializeComponent();
            
        }

        int userType = 0;
        private void comboLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboLogin.SelectedIndex)
            {
                case 0:
                    userType = 0;
                    break;
                case 1:
                    userType = 1;
                    break;
            }
        }

        private void login()
        {
            Controle controle = new Controle();
            controle.Acessar(userType, txtLogin.Text, txtSenha.Text);

            if (controle.Acesso)
            {
                this.Close();
                if (userType == 1)
                {
                    Caixa caixa = new Caixa();
                    caixa.Show();
                }
                else
                {
                    Gerenciamento gerenciamento = new Gerenciamento();
                    gerenciamento.Show();
                }
            }
        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
