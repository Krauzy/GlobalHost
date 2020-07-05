namespace GlobalHost.Visao.Servicos.Funcoes
{
    partial class Screen_AbrirFrete
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvFrete = new System.Windows.Forms.DataGridView();
            this.ID_Remessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_AbrirFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao_AbrirFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orçamento_AbrirFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remessa_AbrirFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Pedido_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Despachante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Remessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.cbFiltroPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 47);
            this.label1.TabIndex = 103;
            this.label1.Text = "ABRIR FRETE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1124, 46);
            this.label2.TabIndex = 102;
            this.label2.Text = "________________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(575, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 131;
            this.label11.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBusca.Location = new System.Drawing.Point(579, 161);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(206, 27);
            this.txtBusca.TabIndex = 129;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Id",
            "Total",
            "Situacao"});
            this.cbFiltro.Location = new System.Drawing.Point(838, 161);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(192, 29);
            this.cbFiltro.TabIndex = 130;
            // 
            // dgvFrete
            // 
            this.dgvFrete.AllowUserToAddRows = false;
            this.dgvFrete.AllowUserToResizeRows = false;
            this.dgvFrete.BackgroundColor = System.Drawing.Color.White;
            this.dgvFrete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvFrete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Remessa,
            this.Total_AbrirFrete,
            this.Situacao_AbrirFrete,
            this.Orçamento_AbrirFrete,
            this.Remessa_AbrirFrete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFrete.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFrete.EnableHeadersVisualStyles = false;
            this.dgvFrete.Location = new System.Drawing.Point(579, 206);
            this.dgvFrete.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFrete.Name = "dgvFrete";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrete.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFrete.RowHeadersVisible = false;
            this.dgvFrete.RowHeadersWidth = 51;
            this.dgvFrete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFrete.Size = new System.Drawing.Size(451, 363);
            this.dgvFrete.TabIndex = 128;
            // 
            // ID_Remessa
            // 
            this.ID_Remessa.DataPropertyName = "id";
            this.ID_Remessa.HeaderText = "ID";
            this.ID_Remessa.MinimumWidth = 6;
            this.ID_Remessa.Name = "ID_Remessa";
            this.ID_Remessa.Width = 50;
            // 
            // Total_AbrirFrete
            // 
            this.Total_AbrirFrete.DataPropertyName = "total";
            this.Total_AbrirFrete.HeaderText = "Total";
            this.Total_AbrirFrete.MinimumWidth = 6;
            this.Total_AbrirFrete.Name = "Total_AbrirFrete";
            this.Total_AbrirFrete.Width = 150;
            // 
            // Situacao_AbrirFrete
            // 
            this.Situacao_AbrirFrete.DataPropertyName = "situacao";
            this.Situacao_AbrirFrete.HeaderText = "Situação";
            this.Situacao_AbrirFrete.MinimumWidth = 6;
            this.Situacao_AbrirFrete.Name = "Situacao_AbrirFrete";
            this.Situacao_AbrirFrete.Width = 125;
            // 
            // Orçamento_AbrirFrete
            // 
            this.Orçamento_AbrirFrete.DataPropertyName = "orcamento";
            this.Orçamento_AbrirFrete.HeaderText = "Orçamento";
            this.Orçamento_AbrirFrete.MinimumWidth = 6;
            this.Orçamento_AbrirFrete.Name = "Orçamento_AbrirFrete";
            this.Orçamento_AbrirFrete.Width = 125;
            // 
            // Remessa_AbrirFrete
            // 
            this.Remessa_AbrirFrete.DataPropertyName = "remessa";
            this.Remessa_AbrirFrete.HeaderText = "Remessa";
            this.Remessa_AbrirFrete.MinimumWidth = 6;
            this.Remessa_AbrirFrete.Name = "Remessa_AbrirFrete";
            this.Remessa_AbrirFrete.Width = 125;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido_ID,
            this.Pedido_Data,
            this.Pedido_Modalidade,
            this.Pedido_Origem,
            this.Pedido_Destino,
            this.Pedido_Despachante,
            this.Pedido_Situacao,
            this.Pedido_Cliente,
            this.Pedido_Funcionario,
            this.Pedido_Remessa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.Location = new System.Drawing.Point(51, 206);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedido.Name = "dgvPedido";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(455, 363);
            this.dgvPedido.TabIndex = 132;
            // 
            // Pedido_ID
            // 
            this.Pedido_ID.DataPropertyName = "id";
            this.Pedido_ID.HeaderText = "ID";
            this.Pedido_ID.MinimumWidth = 6;
            this.Pedido_ID.Name = "Pedido_ID";
            this.Pedido_ID.ReadOnly = true;
            this.Pedido_ID.Width = 125;
            // 
            // Pedido_Data
            // 
            this.Pedido_Data.DataPropertyName = "data";
            this.Pedido_Data.HeaderText = "Data do Pedido";
            this.Pedido_Data.MinimumWidth = 6;
            this.Pedido_Data.Name = "Pedido_Data";
            this.Pedido_Data.ReadOnly = true;
            this.Pedido_Data.Width = 125;
            // 
            // Pedido_Modalidade
            // 
            this.Pedido_Modalidade.DataPropertyName = "modalidade";
            this.Pedido_Modalidade.HeaderText = "Modalidade";
            this.Pedido_Modalidade.MinimumWidth = 6;
            this.Pedido_Modalidade.Name = "Pedido_Modalidade";
            this.Pedido_Modalidade.ReadOnly = true;
            this.Pedido_Modalidade.Width = 125;
            // 
            // Pedido_Origem
            // 
            this.Pedido_Origem.DataPropertyName = "origem";
            this.Pedido_Origem.HeaderText = "Origem";
            this.Pedido_Origem.MinimumWidth = 6;
            this.Pedido_Origem.Name = "Pedido_Origem";
            this.Pedido_Origem.ReadOnly = true;
            this.Pedido_Origem.Width = 125;
            // 
            // Pedido_Destino
            // 
            this.Pedido_Destino.DataPropertyName = "destino";
            this.Pedido_Destino.HeaderText = "Destino";
            this.Pedido_Destino.MinimumWidth = 6;
            this.Pedido_Destino.Name = "Pedido_Destino";
            this.Pedido_Destino.ReadOnly = true;
            this.Pedido_Destino.Width = 125;
            // 
            // Pedido_Despachante
            // 
            this.Pedido_Despachante.DataPropertyName = "despachante";
            this.Pedido_Despachante.HeaderText = "Despachante";
            this.Pedido_Despachante.MinimumWidth = 6;
            this.Pedido_Despachante.Name = "Pedido_Despachante";
            this.Pedido_Despachante.ReadOnly = true;
            this.Pedido_Despachante.Width = 200;
            // 
            // Pedido_Situacao
            // 
            this.Pedido_Situacao.DataPropertyName = "situacao";
            this.Pedido_Situacao.HeaderText = "Situação";
            this.Pedido_Situacao.MinimumWidth = 6;
            this.Pedido_Situacao.Name = "Pedido_Situacao";
            this.Pedido_Situacao.ReadOnly = true;
            this.Pedido_Situacao.Width = 125;
            // 
            // Pedido_Cliente
            // 
            this.Pedido_Cliente.DataPropertyName = "cliente";
            this.Pedido_Cliente.HeaderText = "Cliente";
            this.Pedido_Cliente.MinimumWidth = 6;
            this.Pedido_Cliente.Name = "Pedido_Cliente";
            this.Pedido_Cliente.ReadOnly = true;
            this.Pedido_Cliente.Width = 125;
            // 
            // Pedido_Funcionario
            // 
            this.Pedido_Funcionario.DataPropertyName = "funcionario";
            this.Pedido_Funcionario.HeaderText = "Funcionário";
            this.Pedido_Funcionario.MinimumWidth = 6;
            this.Pedido_Funcionario.Name = "Pedido_Funcionario";
            this.Pedido_Funcionario.ReadOnly = true;
            this.Pedido_Funcionario.Width = 125;
            // 
            // Pedido_Remessa
            // 
            this.Pedido_Remessa.DataPropertyName = "remessa";
            this.Pedido_Remessa.HeaderText = "Remessa";
            this.Pedido_Remessa.MinimumWidth = 6;
            this.Pedido_Remessa.Name = "Pedido_Remessa";
            this.Pedido_Remessa.ReadOnly = true;
            this.Pedido_Remessa.Width = 125;
            // 
            // btMenos
            // 
            this.btMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btMenos.Enabled = false;
            this.btMenos.FlatAppearance.BorderSize = 0;
            this.btMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.ForeColor = System.Drawing.Color.White;
            this.btMenos.Location = new System.Drawing.Point(313, 149);
            this.btMenos.Margin = new System.Windows.Forms.Padding(0);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(42, 39);
            this.btMenos.TabIndex = 135;
            this.btMenos.Text = "‒";
            this.btMenos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMenos.UseVisualStyleBackColor = false;
            // 
            // btMais
            // 
            this.btMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btMais.Enabled = false;
            this.btMais.FlatAppearance.BorderSize = 0;
            this.btMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMais.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMais.ForeColor = System.Drawing.Color.White;
            this.btMais.Location = new System.Drawing.Point(260, 149);
            this.btMais.Margin = new System.Windows.Forms.Padding(0);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(42, 39);
            this.btMais.TabIndex = 134;
            this.btMais.Text = "+";
            this.btMais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMais.UseVisualStyleBackColor = false;
            // 
            // cbFiltroPedido
            // 
            this.cbFiltroPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltroPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltroPedido.FormattingEnabled = true;
            this.cbFiltroPedido.Items.AddRange(new object[] {
            "Data do Pedido",
            "Modalidade",
            "Origem",
            "Destino",
            "Despachante",
            "Situacao",
            "Cliente",
            "Funcionario",
            "Remessa"});
            this.cbFiltroPedido.Location = new System.Drawing.Point(51, 159);
            this.cbFiltroPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiltroPedido.Name = "cbFiltroPedido";
            this.cbFiltroPedido.Size = new System.Drawing.Size(195, 29);
            this.cbFiltroPedido.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(47, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 136;
            this.label3.Text = "Pedidos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.Image = global::GlobalHost.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1042, 473);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 96);
            this.btnCancelar.TabIndex = 138;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOk.Image = global::GlobalHost.Properties.Resources.ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.Location = new System.Drawing.Point(1042, 369);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 96);
            this.btnOk.TabIndex = 137;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Screen_AbrirFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.cbFiltroPedido);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.dgvFrete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Screen_AbrirFrete";
            this.Size = new System.Drawing.Size(1375, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView dgvFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Remessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_AbrirFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao_AbrirFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orçamento_AbrirFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remessa_AbrirFrete;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Despachante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Remessa;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.ComboBox cbFiltroPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
    }
}
