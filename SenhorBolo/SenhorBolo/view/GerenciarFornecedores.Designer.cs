namespace SenhorBolo.view
{
    partial class GerenciarFornecedores
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
            this.lblAsteristico = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCampoObrigatorio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.controlFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.dataGrid_Fornecedor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPesquisa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBox_Pesquisa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblEscrevaAlgo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.lblCGerenciarFornecedores = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsteristico
            // 
            this.lblAsteristico.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteristico.Font = new System.Drawing.Font("Helvetica", 13F);
            this.lblAsteristico.ForeColor = System.Drawing.Color.Red;
            this.lblAsteristico.Location = new System.Drawing.Point(80, 620);
            this.lblAsteristico.Name = "lblAsteristico";
            this.lblAsteristico.Size = new System.Drawing.Size(10, 22);
            this.lblAsteristico.TabIndex = 40;
            this.lblAsteristico.Text = "*";
            // 
            // lblCampoObrigatorio
            // 
            this.lblCampoObrigatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblCampoObrigatorio.Font = new System.Drawing.Font("Helvetica", 12F);
            this.lblCampoObrigatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblCampoObrigatorio.Location = new System.Drawing.Point(92, 618);
            this.lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            this.lblCampoObrigatorio.Size = new System.Drawing.Size(153, 21);
            this.lblCampoObrigatorio.TabIndex = 39;
            this.lblCampoObrigatorio.Text = "Selecione um campo";
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
            this.controlFechar.TabIndex = 38;
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
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGrid_Fornecedor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGrid_Fornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Fornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Fornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Fornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Fornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Fornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Fornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Fornecedor.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Fornecedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Fornecedor.EnableHeadersVisualStyles = false;
            this.dataGrid_Fornecedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dataGrid_Fornecedor.Location = new System.Drawing.Point(80, 224);
            this.dataGrid_Fornecedor.Name = "dataGrid_Fornecedor";
            this.dataGrid_Fornecedor.ReadOnly = true;
            this.dataGrid_Fornecedor.RowHeadersVisible = false;
            this.dataGrid_Fornecedor.RowHeadersWidth = 50;
            this.dataGrid_Fornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Fornecedor.Size = new System.Drawing.Size(768, 366);
            this.dataGrid_Fornecedor.TabIndex = 35;
            this.dataGrid_Fornecedor.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dataGrid_Fornecedor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGrid_Fornecedor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_Fornecedor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Fornecedor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_Fornecedor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_Fornecedor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_Fornecedor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dataGrid_Fornecedor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dataGrid_Fornecedor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid_Fornecedor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Fornecedor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_Fornecedor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_Fornecedor.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGrid_Fornecedor.ThemeStyle.ReadOnly = true;
            this.dataGrid_Fornecedor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dataGrid_Fornecedor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Fornecedor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_Fornecedor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_Fornecedor.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid_Fornecedor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dataGrid_Fornecedor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.btnPesquisa.TabIndex = 34;
            this.btnPesquisa.Text = "Pesquisar";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Helvetica", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(481, 133);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(153, 21);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "Selecione um campo";
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
            "CNPJ",
            "Descrição",
            "Contato",
            "Endereço",
            "Cidade"});
            this.comboBox_Pesquisa.ItemsAppearance.Parent = this.comboBox_Pesquisa;
            this.comboBox_Pesquisa.Location = new System.Drawing.Point(483, 163);
            this.comboBox_Pesquisa.Name = "comboBox_Pesquisa";
            this.comboBox_Pesquisa.ShadowDecoration.Parent = this.comboBox_Pesquisa;
            this.comboBox_Pesquisa.Size = new System.Drawing.Size(150, 36);
            this.comboBox_Pesquisa.TabIndex = 32;
            // 
            // lblEscrevaAlgo
            // 
            this.lblEscrevaAlgo.BackColor = System.Drawing.Color.Transparent;
            this.lblEscrevaAlgo.Font = new System.Drawing.Font("Helvetica", 12F);
            this.lblEscrevaAlgo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.lblEscrevaAlgo.Location = new System.Drawing.Point(92, 133);
            this.lblEscrevaAlgo.Name = "lblEscrevaAlgo";
            this.lblEscrevaAlgo.Size = new System.Drawing.Size(96, 21);
            this.lblEscrevaAlgo.TabIndex = 31;
            this.lblEscrevaAlgo.Text = "Escreva algo";
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
            this.txtPesquisa.TabIndex = 30;
            // 
            // separator
            // 
            this.separator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.separator.FillThickness = 2;
            this.separator.Location = new System.Drawing.Point(56, 103);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(816, 10);
            this.separator.TabIndex = 29;
            // 
            // lblCGerenciarFornecedores
            // 
            this.lblCGerenciarFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.lblCGerenciarFornecedores.Font = new System.Drawing.Font("Helvetica", 22F, System.Drawing.FontStyle.Bold);
            this.lblCGerenciarFornecedores.ForeColor = System.Drawing.Color.Black;
            this.lblCGerenciarFornecedores.Location = new System.Drawing.Point(56, 48);
            this.lblCGerenciarFornecedores.Name = "lblCGerenciarFornecedores";
            this.lblCGerenciarFornecedores.Size = new System.Drawing.Size(331, 37);
            this.lblCGerenciarFornecedores.TabIndex = 28;
            this.lblCGerenciarFornecedores.Text = "Gerenciar fornecedores";
            // 
            // GerenciarFornecedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 686);
            this.Controls.Add(this.lblAsteristico);
            this.Controls.Add(this.lblCampoObrigatorio);
            this.Controls.Add(this.controlFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGrid_Fornecedor);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBox_Pesquisa);
            this.Controls.Add(this.lblEscrevaAlgo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.lblCGerenciarFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarFornecedores";
            this.Text = "GerenciarFornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblAsteristico;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCampoObrigatorio;
        private Guna.UI2.WinForms.Guna2ControlBox controlFechar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_Fornecedor;
        private Guna.UI2.WinForms.Guna2Button btnPesquisa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_Pesquisa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEscrevaAlgo;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCGerenciarFornecedores;
    }
}