﻿using System;
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
    public partial class EditarFornecedor : Form
    {
        public EditarFornecedor()
        {
            InitializeComponent();
        }

        private void EditarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCidade.Text = null;
            txtCNPJ.Text = null;
            txtContato.Text = null;
            txtEndereco.Text = null;
            txtNome.Text = null;
        }
    }
}
