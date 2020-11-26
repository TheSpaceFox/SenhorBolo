namespace SenhorBolo
{
    partial class GerenciarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.lblCadastroFuncionarios = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEscrevaAlgo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBox_Pesquisa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPesquisa = new Guna.UI2.WinForms.Guna2Button();
            this.dataGrid_Funcionario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.controlFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblAsteristico = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCampoObrigatorio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // separator
            // 
            this.separator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.separator.FillThickness = 2;
            this.separator.Location = new System.Drawing.Point(56, 103);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(816, 10);
            this.separator.TabIndex = 3;
            // 
            // lblCadastroFuncionarios
            // 
            this.lblCadastroFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroFuncionarios.Font = new System.Drawing.Font("Helvetica", 22F, System.Drawing.FontStyle.Bold);
            this.lblCadastroFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.lblCadastroFuncionarios.Location = new System.Drawing.Point(56, 48);
            this.lblCadastroFuncionarios.Name = "lblCadastroFuncionarios";
            this.lblCadastroFuncionarios.Size = new System.Drawing.Size(321, 37);
            this.lblCadastroFuncionarios.TabIndex = 2;
            this.lblCadastroFuncionarios.Text = "Gerenciar funcionários";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.DefaultText = "";
            this.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.DisabledState.Parent = this.txtPesquisa;
            this.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.FocusedState.Parent = this.txtPesquisa;
            this.txtPesquisa.Font = new System.Drawing.Font("Helvetica", 12.75F);
            this.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.HoverState.Parent = this.txtPesquisa;
            this.txtPesquisa.Location = new System.Drawing.Point(92, 160);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderText = "";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.ShadowDecoration.Parent = this.txtPesquisa;
            this.txtPesquisa.Size = new System.Drawing.Size(370, 42);
            this.txtPesquisa.TabIndex = 4;
            // 
            // lblEscrevaAlgo
            // 
            this.lblEscrevaAlgo.BackColor = System.Drawing.Color.Transparent;
            this.lblEscrevaAlgo.Font = new System.Drawing.Font("Helvetica", 12F);
            this.lblEscrevaAlgo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblEscrevaAlgo.Location = new System.Drawing.Point(92, 133);
            this.lblEscrevaAlgo.Name = "lblEscrevaAlgo";
            this.lblEscrevaAlgo.Size = new System.Drawing.Size(96, 21);
            this.lblEscrevaAlgo.TabIndex = 5;
            this.lblEscrevaAlgo.Text = "Escreva algo";
            // 
            // comboBox_Pesquisa
            // 
            this.comboBox_Pesquisa.Animated = true;
            this.comboBox_Pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Pesquisa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Pesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Pesquisa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Pesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Pesquisa.FocusedState.Parent = this.comboBox_Pesquisa;
            this.comboBox_Pesquisa.Font = new System.Drawing.Font("Helvetica", 12F);
            this.comboBox_Pesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_Pesquisa.HoverState.Parent = this.comboBox_Pesquisa;
            this.comboBox_Pesquisa.ItemHeight = 30;
            this.comboBox_Pesquisa.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Senha",
            "RG",
            "Salario",
            "Email",
            "Telefone",
            "CEP"});
            this.comboBox_Pesquisa.ItemsAppearance.Parent = this.comboBox_Pesquisa;
            this.comboBox_Pesquisa.Location = new System.Drawing.Point(483, 163);
            this.comboBox_Pesquisa.Name = "comboBox_Pesquisa";
            this.comboBox_Pesquisa.ShadowDecoration.Parent = this.comboBox_Pesquisa;
            this.comboBox_Pesquisa.Size = new System.Drawing.Size(150, 36);
            this.comboBox_Pesquisa.TabIndex = 6;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Helvetica", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(481, 133);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(153, 21);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Selecione um campo";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.CheckedState.Parent = this.btnPesquisa;
            this.btnPesquisa.CustomImages.Parent = this.btnPesquisa;
            this.btnPesquisa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(153)))));
            this.btnPesquisa.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa.HoverState.Parent = this.btnPesquisa;
            this.btnPesquisa.Location = new System.Drawing.Point(661, 163);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.ShadowDecoration.Parent = this.btnPesquisa;
            this.btnPesquisa.Size = new System.Drawing.Size(145, 36);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // dataGrid_Funcionario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGrid_Funcionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Funcionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Funcionario.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Funcionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Funcionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Funcionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Funcionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Funcionario.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Funcionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Funcionario.EnableHeadersVisualStyles = false;
            this.dataGrid_Funcionario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dataGrid_Funcionario.Location = new System.Drawing.Point(80, 224);
            this.dataGrid_Funcionario.Name = "dataGrid_Funcionario";
            this.dataGrid_Funcionario.ReadOnly = true;
            this.dataGrid_Funcionario.RowHeadersVisible = false;
            this.dataGrid_Funcionario.RowHeadersWidth = 50;
            this.dataGrid_Funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Funcionario.Size = new System.Drawing.Size(768, 366);
            this.dataGrid_Funcionario.TabIndex = 9;
            this.dataGrid_Funcionario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dataGrid_Funcionario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGrid_Funcionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_Funcionario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Funcionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_Funcionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Funcionario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Funcionario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dataGrid_Funcionario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dataGrid_Funcionario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid_Funcionario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Funcionario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_Funcionario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Funcionario.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGrid_Funcionario.ThemeStyle.ReadOnly = true;
            this.dataGrid_Funcionario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dataGrid_Funcionario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Funcionario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Funcionario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_Funcionario.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid_Funcionario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dataGrid_Funcionario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnEditar
            // 
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(153)))));
            this.btnEditar.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(703, 612);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(145, 36);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.CheckedState.Parent = this.btnExcluir;
            this.btnExcluir.CustomImages.Parent = this.btnExcluir;
            this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnExcluir.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.HoverState.Parent = this.btnExcluir;
            this.btnExcluir.Location = new System.Drawing.Point(521, 612);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.Size = new System.Drawing.Size(145, 36);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // controlFechar
            // 
            this.controlFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlFechar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlFechar.HoverState.Parent = this.controlFechar;
            this.controlFechar.IconColor = System.Drawing.Color.White;
            this.controlFechar.Location = new System.Drawing.Point(892, 12);
            this.controlFechar.Name = "controlFechar";
            this.controlFechar.ShadowDecoration.Parent = this.controlFechar;
            this.controlFechar.Size = new System.Drawing.Size(25, 25);
            this.controlFechar.TabIndex = 25;
            this.controlFechar.Click += new System.EventHandler(this.controlFechar_Click);
            // 
            // lblAsteristico
            // 
            this.lblAsteristico.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteristico.Font = new System.Drawing.Font("Helvetica", 13F);
            this.lblAsteristico.ForeColor = System.Drawing.Color.Red;
            this.lblAsteristico.Location = new System.Drawing.Point(80, 620);
            this.lblAsteristico.Name = "lblAsteristico";
            this.lblAsteristico.Size = new System.Drawing.Size(10, 22);
            this.lblAsteristico.TabIndex = 27;
            this.lblAsteristico.Text = "*";
            // 
            // lblCampoObrigatorio
            // 
            this.lblCampoObrigatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoObrigatorio.Font = new System.Drawing.Font("Helvetica", 12F);
            this.lblCampoObrigatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblCampoObrigatorio.Location = new System.Drawing.Point(92, 618);
            this.lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            this.lblCampoObrigatorio.Size = new System.Drawing.Size(243, 21);
            this.lblCampoObrigatorio.TabIndex = 26;
            this.lblCampoObrigatorio.Text = "Para excluir, selecione um campo";
            // 
            // GerenciarFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 686);
            this.Controls.Add(this.lblAsteristico);
            this.Controls.Add(this.lblCampoObrigatorio);
            this.Controls.Add(this.controlFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGrid_Funcionario);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBox_Pesquisa);
            this.Controls.Add(this.lblEscrevaAlgo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.lblCadastroFuncionarios);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarFuncionario";
            this.Text = "GerenciarFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCadastroFuncionarios;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEscrevaAlgo;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_Pesquisa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnPesquisa;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_Funcionario;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2ControlBox controlFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAsteristico;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCampoObrigatorio;
    }
}