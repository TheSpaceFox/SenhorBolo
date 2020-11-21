namespace SenhorBolo {
    partial class Caixa {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.imagemProduto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblCodigoBarras = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantidade = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPrecoUnitario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrecoUnitario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalItem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSubtotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSubtotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtValorPago = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblValorPago = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTroco = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTroco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.datagridListaProdutos = new System.Windows.Forms.DataGridView();
            this.lblListaProdutos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelListaProdutos = new Guna.UI2.WinForms.Guna2Panel();
            this.numItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNomeFuncionario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHorario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.relógio = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaProdutos)).BeginInit();
            this.panelListaProdutos.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagemProduto
            // 
            this.imagemProduto.Image = global::SenhorBolo.Properties.Resources.randomblock;
            this.imagemProduto.Location = new System.Drawing.Point(24, 125);
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.ShadowDecoration.Parent = this.imagemProduto;
            this.imagemProduto.Size = new System.Drawing.Size(363, 251);
            this.imagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemProduto.TabIndex = 1;
            this.imagemProduto.TabStop = false;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Helvetica", 15F, System.Drawing.FontStyle.Bold);
            this.lblCodigoBarras.Location = new System.Drawing.Point(24, 382);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(169, 26);
            this.lblCodigoBarras.TabIndex = 5;
            this.lblCodigoBarras.Text = "Código de barras";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.Parent = this.txtCodigo;
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.FocusedState.Parent = this.txtCodigo;
            this.txtCodigo.Font = new System.Drawing.Font("Helvetica", 18F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.HoverState.Parent = this.txtCodigo;
            this.txtCodigo.Location = new System.Drawing.Point(24, 416);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(363, 48);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.DefaultText = "";
            this.txtQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.DisabledState.Parent = this.txtQuantidade;
            this.txtQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.FocusedState.Parent = this.txtQuantidade;
            this.txtQuantidade.Font = new System.Drawing.Font("Helvetica", 18F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.HoverState.Parent = this.txtQuantidade;
            this.txtQuantidade.Location = new System.Drawing.Point(24, 506);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.PlaceholderText = "";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.ShadowDecoration.Parent = this.txtQuantidade;
            this.txtQuantidade.Size = new System.Drawing.Size(363, 48);
            this.txtQuantidade.TabIndex = 8;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Helvetica", 15F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.Location = new System.Drawing.Point(24, 472);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(114, 26);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoUnitario.DefaultText = "";
            this.txtPrecoUnitario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecoUnitario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecoUnitario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoUnitario.DisabledState.Parent = this.txtPrecoUnitario;
            this.txtPrecoUnitario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoUnitario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoUnitario.FocusedState.Parent = this.txtPrecoUnitario;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Helvetica", 18F);
            this.txtPrecoUnitario.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoUnitario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoUnitario.HoverState.Parent = this.txtPrecoUnitario;
            this.txtPrecoUnitario.Location = new System.Drawing.Point(24, 596);
            this.txtPrecoUnitario.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.PasswordChar = '\0';
            this.txtPrecoUnitario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPrecoUnitario.PlaceholderText = "";
            this.txtPrecoUnitario.SelectedText = "";
            this.txtPrecoUnitario.ShadowDecoration.Parent = this.txtPrecoUnitario;
            this.txtPrecoUnitario.Size = new System.Drawing.Size(363, 48);
            this.txtPrecoUnitario.TabIndex = 10;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Helvetica", 15F, System.Drawing.FontStyle.Bold);
            this.lblPrecoUnitario.Location = new System.Drawing.Point(24, 562);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(142, 26);
            this.lblPrecoUnitario.TabIndex = 9;
            this.lblPrecoUnitario.Text = "Preço Unitário";
            // 
            // txtTotalItem
            // 
            this.txtTotalItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalItem.DefaultText = "";
            this.txtTotalItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalItem.DisabledState.Parent = this.txtTotalItem;
            this.txtTotalItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalItem.FocusedState.Parent = this.txtTotalItem;
            this.txtTotalItem.Font = new System.Drawing.Font("Helvetica", 18F);
            this.txtTotalItem.ForeColor = System.Drawing.Color.Black;
            this.txtTotalItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalItem.HoverState.Parent = this.txtTotalItem;
            this.txtTotalItem.Location = new System.Drawing.Point(24, 686);
            this.txtTotalItem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalItem.Name = "txtTotalItem";
            this.txtTotalItem.PasswordChar = '\0';
            this.txtTotalItem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTotalItem.PlaceholderText = "";
            this.txtTotalItem.SelectedText = "";
            this.txtTotalItem.ShadowDecoration.Parent = this.txtTotalItem;
            this.txtTotalItem.Size = new System.Drawing.Size(363, 48);
            this.txtTotalItem.TabIndex = 12;
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalItem.Font = new System.Drawing.Font("Helvetica", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalItem.Location = new System.Drawing.Point(24, 652);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(101, 26);
            this.lblTotalItem.TabIndex = 11;
            this.lblTotalItem.Text = "Total Item";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtotal.DefaultText = "";
            this.txtSubtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubtotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubtotal.DisabledState.Parent = this.txtSubtotal;
            this.txtSubtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubtotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubtotal.FocusedState.Parent = this.txtSubtotal;
            this.txtSubtotal.Font = new System.Drawing.Font("Helvetica", 18F);
            this.txtSubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubtotal.HoverState.Parent = this.txtSubtotal;
            this.txtSubtotal.Location = new System.Drawing.Point(614, 566);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.PlaceholderText = "";
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.ShadowDecoration.Parent = this.txtSubtotal;
            this.txtSubtotal.Size = new System.Drawing.Size(538, 67);
            this.txtSubtotal.TabIndex = 13;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Helvetica", 28F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(444, 576);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(150, 47);
            this.lblSubtotal.TabIndex = 14;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorPago.DefaultText = "";
            this.txtValorPago.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValorPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValorPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorPago.DisabledState.Parent = this.txtValorPago;
            this.txtValorPago.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorPago.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorPago.FocusedState.Parent = this.txtValorPago;
            this.txtValorPago.Font = new System.Drawing.Font("Helvetica", 18F);
            this.txtValorPago.ForeColor = System.Drawing.Color.Black;
            this.txtValorPago.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorPago.HoverState.Parent = this.txtValorPago;
            this.txtValorPago.Location = new System.Drawing.Point(444, 686);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.PasswordChar = '\0';
            this.txtValorPago.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtValorPago.PlaceholderText = "";
            this.txtValorPago.SelectedText = "";
            this.txtValorPago.ShadowDecoration.Parent = this.txtValorPago;
            this.txtValorPago.Size = new System.Drawing.Size(316, 48);
            this.txtValorPago.TabIndex = 16;
            // 
            // lblValorPago
            // 
            this.lblValorPago.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPago.Font = new System.Drawing.Font("Helvetica", 17F, System.Drawing.FontStyle.Bold);
            this.lblValorPago.Location = new System.Drawing.Point(444, 650);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(124, 29);
            this.lblValorPago.TabIndex = 15;
            this.lblValorPago.Text = "Valor Pago";
            // 
            // txtTroco
            // 
            this.txtTroco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTroco.DefaultText = "";
            this.txtTroco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTroco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTroco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTroco.DisabledState.Parent = this.txtTroco;
            this.txtTroco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTroco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTroco.FocusedState.Parent = this.txtTroco;
            this.txtTroco.Font = new System.Drawing.Font("Helvetica", 18F);
            this.txtTroco.ForeColor = System.Drawing.Color.Black;
            this.txtTroco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTroco.HoverState.Parent = this.txtTroco;
            this.txtTroco.Location = new System.Drawing.Point(837, 685);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(5);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.PasswordChar = '\0';
            this.txtTroco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTroco.PlaceholderText = "";
            this.txtTroco.SelectedText = "";
            this.txtTroco.ShadowDecoration.Parent = this.txtTroco;
            this.txtTroco.Size = new System.Drawing.Size(316, 48);
            this.txtTroco.TabIndex = 18;
            // 
            // lblTroco
            // 
            this.lblTroco.BackColor = System.Drawing.Color.Transparent;
            this.lblTroco.Font = new System.Drawing.Font("Helvetica", 17F, System.Drawing.FontStyle.Bold);
            this.lblTroco.Location = new System.Drawing.Point(837, 649);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(68, 29);
            this.lblTroco.TabIndex = 17;
            this.lblTroco.Text = "Troco";
            // 
            // datagridListaProdutos
            // 
            this.datagridListaProdutos.BackgroundColor = System.Drawing.Color.White;
            this.datagridListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numItem,
            this.codigo,
            this.descricao,
            this.qtde,
            this.vlrUnit,
            this.total});
            this.datagridListaProdutos.Location = new System.Drawing.Point(444, 169);
            this.datagridListaProdutos.Name = "datagridListaProdutos";
            this.datagridListaProdutos.Size = new System.Drawing.Size(711, 385);
            this.datagridListaProdutos.TabIndex = 19;
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProdutos.Font = new System.Drawing.Font("Helvetica", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProdutos.ForeColor = System.Drawing.Color.White;
            this.lblListaProdutos.Location = new System.Drawing.Point(3, 12);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(177, 26);
            this.lblListaProdutos.TabIndex = 21;
            this.lblListaProdutos.Text = " Lista de produtos";
            // 
            // panelListaProdutos
            // 
            this.panelListaProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(186)))), ((int)(((byte)(179)))));
            this.panelListaProdutos.Controls.Add(this.lblListaProdutos);
            this.panelListaProdutos.Location = new System.Drawing.Point(444, 125);
            this.panelListaProdutos.Name = "panelListaProdutos";
            this.panelListaProdutos.ShadowDecoration.Parent = this.panelListaProdutos;
            this.panelListaProdutos.Size = new System.Drawing.Size(711, 46);
            this.panelListaProdutos.TabIndex = 22;
            // 
            // numItem
            // 
            this.numItem.HeaderText = "Nº Item";
            this.numItem.Name = "numItem";
            this.numItem.ReadOnly = true;
            this.numItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numItem.Width = 85;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descricao.Width = 222;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Qtde";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qtde.Width = 60;
            // 
            // vlrUnit
            // 
            this.vlrUnit.HeaderText = "Vlr. Unit";
            this.vlrUnit.Name = "vlrUnit";
            this.vlrUnit.ReadOnly = true;
            this.vlrUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.Controls.Add(this.lblHorario);
            this.panelHeader.Controls.Add(this.lblNomeFuncionario);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShadowDecoration.Parent = this.panelHeader;
            this.panelHeader.Size = new System.Drawing.Size(1180, 92);
            this.panelHeader.TabIndex = 24;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(986, 22);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(149, 21);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Edson Koshikumo";
            // 
            // lblHorario
            // 
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(1068, 49);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(67, 21);
            this.lblHorario.TabIndex = 1;
            this.lblHorario.Text = "19:51:55";
            // 
            // relógio
            // 
            this.relógio.Enabled = true;
            this.relógio.Tick += new System.EventHandler(this.relógio_Tick);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1180, 757);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelListaProdutos);
            this.Controls.Add(this.datagridListaProdutos);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtTotalItem);
            this.Controls.Add(this.lblTotalItem);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.imagemProduto);
            this.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridListaProdutos)).EndInit();
            this.panelListaProdutos.ResumeLayout(false);
            this.panelListaProdutos.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox imagemProduto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCodigoBarras;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantidade;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecoUnitario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecoUnitario;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalItem;
        private Guna.UI2.WinForms.Guna2TextBox txtSubtotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtotal;
        private Guna.UI2.WinForms.Guna2TextBox txtValorPago;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValorPago;
        private Guna.UI2.WinForms.Guna2TextBox txtTroco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTroco;
        private System.Windows.Forms.DataGridView datagridListaProdutos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblListaProdutos;
        private Guna.UI2.WinForms.Guna2Panel panelListaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHorario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeFuncionario;
        private System.Windows.Forms.Timer relógio;
    }
}