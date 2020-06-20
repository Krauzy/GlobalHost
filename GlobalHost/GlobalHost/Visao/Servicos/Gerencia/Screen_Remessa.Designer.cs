namespace GlobalHost.Visao.Servicos.Gerencia
{
    partial class Screen_Remessa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCEPOrigem = new System.Windows.Forms.Button();
            this.ordOrder = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbTransportadora = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvRemessa = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpPrevisao = new System.Windows.Forms.DateTimePicker();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCEPDestino = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpRequerimento = new System.Windows.Forms.DateTimePicker();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.cbFiltroPedido = new System.Windows.Forms.ComboBox();
            this.gbRemessa = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_Remessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previsao_requerida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemessa)).BeginInit();
            this.gbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.gbRemessa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCEPOrigem
            // 
            this.btCEPOrigem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btCEPOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCEPOrigem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCEPOrigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btCEPOrigem.Location = new System.Drawing.Point(161, 98);
            this.btCEPOrigem.Name = "btCEPOrigem";
            this.btCEPOrigem.Size = new System.Drawing.Size(32, 23);
            this.btCEPOrigem.TabIndex = 148;
            this.btCEPOrigem.Text = "+";
            this.btCEPOrigem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCEPOrigem.UseVisualStyleBackColor = true;
            this.btCEPOrigem.Click += new System.EventHandler(this.btCEPOrigem_Click);
            // 
            // ordOrder
            // 
            this.ordOrder.AutoSize = true;
            this.ordOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordOrder.ForeColor = System.Drawing.Color.Red;
            this.ordOrder.Location = new System.Drawing.Point(468, 540);
            this.ordOrder.Name = "ordOrder";
            this.ordOrder.Size = new System.Drawing.Size(142, 16);
            this.ordOrder.TabIndex = 147;
            this.ordOrder.Text = "* Campos obrigatórios";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(156, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 18);
            this.label17.TabIndex = 137;
            this.label17.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label15.Location = new System.Drawing.Point(428, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 19);
            this.label15.TabIndex = 135;
            this.label15.Text = "Transportadora";
            // 
            // cbTransportadora
            // 
            this.cbTransportadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransportadora.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbTransportadora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbTransportadora.FormattingEnabled = true;
            this.cbTransportadora.Location = new System.Drawing.Point(432, 94);
            this.cbTransportadora.Name = "cbTransportadora";
            this.cbTransportadora.Size = new System.Drawing.Size(136, 25);
            this.cbTransportadora.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(656, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 127;
            this.label11.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBusca.Location = new System.Drawing.Point(660, 134);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(183, 23);
            this.txtBusca.TabIndex = 125;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Descrição",
            "Origem",
            "Destino",
            "Data de Saída",
            "Previsão Requerida",
            "Data Requerida"});
            this.cbFiltro.Location = new System.Drawing.Point(849, 133);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(149, 25);
            this.cbFiltro.TabIndex = 126;
            // 
            // dgvRemessa
            // 
            this.dgvRemessa.AllowUserToAddRows = false;
            this.dgvRemessa.AllowUserToResizeRows = false;
            this.dgvRemessa.BackgroundColor = System.Drawing.Color.White;
            this.dgvRemessa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvRemessa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemessa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRemessa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemessa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Remessa,
            this.descricao,
            this.origem,
            this.destino,
            this.data_saida,
            this.previsao_requerida,
            this.transportadora});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemessa.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRemessa.EnableHeadersVisualStyles = false;
            this.dgvRemessa.Location = new System.Drawing.Point(660, 180);
            this.dgvRemessa.Name = "dgvRemessa";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemessa.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRemessa.RowHeadersVisible = false;
            this.dgvRemessa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemessa.Size = new System.Drawing.Size(339, 357);
            this.dgvRemessa.TabIndex = 124;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(213, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 19);
            this.label10.TabIndex = 123;
            this.label10.Text = "Data de Previssão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(32, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 122;
            this.label6.Text = "Data de Saída";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaida.Location = new System.Drawing.Point(36, 158);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(107, 23);
            this.dtpSaida.TabIndex = 120;
            // 
            // dtpPrevisao
            // 
            this.dtpPrevisao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrevisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrevisao.Location = new System.Drawing.Point(217, 158);
            this.dtpPrevisao.Name = "dtpPrevisao";
            this.dtpPrevisao.Size = new System.Drawing.Size(112, 23);
            this.dtpPrevisao.TabIndex = 119;
            // 
            // txtOrigem
            // 
            this.txtOrigem.BackColor = System.Drawing.Color.White;
            this.txtOrigem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtOrigem.Location = new System.Drawing.Point(34, 98);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOrigem.Size = new System.Drawing.Size(134, 23);
            this.txtOrigem.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(30, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 115;
            this.label7.Text = "Origem";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDescricao.Location = new System.Drawing.Point(171, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescricao.Size = new System.Drawing.Size(411, 23);
            this.txtDescricao.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(167, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 108;
            this.label4.Text = "Descrição";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtID.Location = new System.Drawing.Point(36, 39);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtID.Size = new System.Drawing.Size(107, 23);
            this.txtID.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(32, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "ID";
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
            this.btnCancelar.Location = new System.Drawing.Point(516, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 78);
            this.btnCancelar.TabIndex = 106;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnOk.Location = new System.Drawing.Point(416, 459);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 78);
            this.btnOk.TabIndex = 105;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnExcluir.Image = global::GlobalHost.Properties.Resources.lixo2;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(248, 459);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 78);
            this.btnExcluir.TabIndex = 104;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterar.Image = global::GlobalHost.Properties.Resources.alterar2;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(148, 459);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 78);
            this.btnAlterar.TabIndex = 103;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInserir.FlatAppearance.BorderSize = 2;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInserir.Image = global::GlobalHost.Properties.Resources.insert2;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(48, 459);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(94, 78);
            this.btnInserir.TabIndex = 102;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 38);
            this.label1.TabIndex = 101;
            this.label1.Text = "CONTROLE DE REMESSA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(32, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(929, 37);
            this.label2.TabIndex = 100;
            this.label2.Text = "________________________________________________";
            // 
            // btCEPDestino
            // 
            this.btCEPDestino.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btCEPDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCEPDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCEPDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btCEPDestino.Location = new System.Drawing.Point(349, 96);
            this.btCEPDestino.Name = "btCEPDestino";
            this.btCEPDestino.Size = new System.Drawing.Size(32, 23);
            this.btCEPDestino.TabIndex = 151;
            this.btCEPDestino.Text = "+";
            this.btCEPDestino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCEPDestino.UseVisualStyleBackColor = true;
            this.btCEPDestino.Click += new System.EventHandler(this.btCEPDestino_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.White;
            this.txtDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDestino.Location = new System.Drawing.Point(217, 96);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDestino.Size = new System.Drawing.Size(134, 23);
            this.txtDestino.TabIndex = 149;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label26.Location = new System.Drawing.Point(214, 67);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 19);
            this.label26.TabIndex = 150;
            this.label26.Text = "Destino";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(17, 67);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 18);
            this.label27.TabIndex = 152;
            this.label27.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(194, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 18);
            this.label28.TabIndex = 153;
            this.label28.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(414, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 18);
            this.label12.TabIndex = 154;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label13.Location = new System.Drawing.Point(398, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 19);
            this.label13.TabIndex = 156;
            this.label13.Text = "Data de Requerimento";
            // 
            // dtpRequerimento
            // 
            this.dtpRequerimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequerimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequerimento.Location = new System.Drawing.Point(402, 158);
            this.dtpRequerimento.Name = "dtpRequerimento";
            this.dtpRequerimento.Size = new System.Drawing.Size(112, 23);
            this.dtpRequerimento.TabIndex = 155;
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.dgvPedido);
            this.gbPedido.Controls.Add(this.btMenos);
            this.gbPedido.Controls.Add(this.btMais);
            this.gbPedido.Controls.Add(this.cbFiltroPedido);
            this.gbPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPedido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbPedido.Location = new System.Drawing.Point(42, 278);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(548, 175);
            this.gbPedido.TabIndex = 157;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Gerenciamento de Pedido";
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.Location = new System.Drawing.Point(26, 45);
            this.dgvPedido.Name = "dgvPedido";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(501, 122);
            this.dgvPedido.TabIndex = 47;
            // 
            // btMenos
            // 
            this.btMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btMenos.Enabled = false;
            this.btMenos.FlatAppearance.BorderSize = 0;
            this.btMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.ForeColor = System.Drawing.Color.White;
            this.btMenos.Location = new System.Drawing.Point(239, 10);
            this.btMenos.Margin = new System.Windows.Forms.Padding(0);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(35, 32);
            this.btMenos.TabIndex = 44;
            this.btMenos.Text = "‒";
            this.btMenos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMenos.UseVisualStyleBackColor = false;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // btMais
            // 
            this.btMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btMais.Enabled = false;
            this.btMais.FlatAppearance.BorderSize = 0;
            this.btMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMais.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMais.ForeColor = System.Drawing.Color.White;
            this.btMais.Location = new System.Drawing.Point(197, 10);
            this.btMais.Margin = new System.Windows.Forms.Padding(0);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(35, 32);
            this.btMais.TabIndex = 43;
            this.btMais.Text = "+";
            this.btMais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMais.UseVisualStyleBackColor = false;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // cbFiltroPedido
            // 
            this.cbFiltroPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltroPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltroPedido.FormattingEnabled = true;
            this.cbFiltroPedido.Items.AddRange(new object[] {
            "Descrição",
            "Volume",
            "Peso",
            "Dimensões",
            "Valor Unitário",
            "Valor",
            "Tipo"});
            this.cbFiltroPedido.Location = new System.Drawing.Point(26, 17);
            this.cbFiltroPedido.Name = "cbFiltroPedido";
            this.cbFiltroPedido.Size = new System.Drawing.Size(147, 25);
            this.cbFiltroPedido.TabIndex = 42;
            // 
            // gbRemessa
            // 
            this.gbRemessa.Controls.Add(this.label5);
            this.gbRemessa.Controls.Add(this.txtDescricao);
            this.gbRemessa.Controls.Add(this.label3);
            this.gbRemessa.Controls.Add(this.label13);
            this.gbRemessa.Controls.Add(this.txtID);
            this.gbRemessa.Controls.Add(this.dtpRequerimento);
            this.gbRemessa.Controls.Add(this.label4);
            this.gbRemessa.Controls.Add(this.btCEPDestino);
            this.gbRemessa.Controls.Add(this.label12);
            this.gbRemessa.Controls.Add(this.txtDestino);
            this.gbRemessa.Controls.Add(this.btCEPOrigem);
            this.gbRemessa.Controls.Add(this.label7);
            this.gbRemessa.Controls.Add(this.label28);
            this.gbRemessa.Controls.Add(this.cbTransportadora);
            this.gbRemessa.Controls.Add(this.label15);
            this.gbRemessa.Controls.Add(this.label27);
            this.gbRemessa.Controls.Add(this.label17);
            this.gbRemessa.Controls.Add(this.label26);
            this.gbRemessa.Controls.Add(this.txtOrigem);
            this.gbRemessa.Controls.Add(this.label10);
            this.gbRemessa.Controls.Add(this.dtpPrevisao);
            this.gbRemessa.Controls.Add(this.label6);
            this.gbRemessa.Controls.Add(this.dtpSaida);
            this.gbRemessa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbRemessa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRemessa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbRemessa.Location = new System.Drawing.Point(39, 86);
            this.gbRemessa.Name = "gbRemessa";
            this.gbRemessa.Size = new System.Drawing.Size(611, 186);
            this.gbRemessa.TabIndex = 158;
            this.gbRemessa.TabStop = false;
            this.gbRemessa.Text = "Gerenciamento de Remessa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 157;
            this.label5.Text = "*";
            // 
            // ID_Remessa
            // 
            this.ID_Remessa.DataPropertyName = "id";
            this.ID_Remessa.HeaderText = "ID";
            this.ID_Remessa.Name = "ID_Remessa";
            this.ID_Remessa.Width = 50;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 150;
            // 
            // origem
            // 
            this.origem.DataPropertyName = "origem";
            this.origem.HeaderText = "Origem";
            this.origem.Name = "origem";
            // 
            // destino
            // 
            this.destino.DataPropertyName = "destino";
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            // 
            // data_saida
            // 
            this.data_saida.DataPropertyName = "data_saida";
            this.data_saida.HeaderText = "Data de Saída";
            this.data_saida.Name = "data_saida";
            // 
            // previsao_requerida
            // 
            this.previsao_requerida.DataPropertyName = "previsao_requerida";
            this.previsao_requerida.HeaderText = "Previsão Requerida";
            this.previsao_requerida.Name = "previsao_requerida";
            // 
            // transportadora
            // 
            this.transportadora.DataPropertyName = "transportadora";
            this.transportadora.HeaderText = "Transportadora";
            this.transportadora.Name = "transportadora";
            // 
            // Pedido_ID
            // 
            this.Pedido_ID.DataPropertyName = "id";
            this.Pedido_ID.HeaderText = "ID";
            this.Pedido_ID.Name = "Pedido_ID";
            this.Pedido_ID.ReadOnly = true;
            // 
            // Pedido_Data
            // 
            this.Pedido_Data.DataPropertyName = "data";
            this.Pedido_Data.HeaderText = "Data do Pedido";
            this.Pedido_Data.Name = "Pedido_Data";
            this.Pedido_Data.ReadOnly = true;
            // 
            // Pedido_Modalidade
            // 
            this.Pedido_Modalidade.DataPropertyName = "modalidade";
            this.Pedido_Modalidade.HeaderText = "Modalidade";
            this.Pedido_Modalidade.Name = "Pedido_Modalidade";
            this.Pedido_Modalidade.ReadOnly = true;
            // 
            // Pedido_Origem
            // 
            this.Pedido_Origem.DataPropertyName = "origem";
            this.Pedido_Origem.HeaderText = "Origem";
            this.Pedido_Origem.Name = "Pedido_Origem";
            this.Pedido_Origem.ReadOnly = true;
            // 
            // Pedido_Destino
            // 
            this.Pedido_Destino.DataPropertyName = "destino";
            this.Pedido_Destino.HeaderText = "Destino";
            this.Pedido_Destino.Name = "Pedido_Destino";
            this.Pedido_Destino.ReadOnly = true;
            // 
            // Pedido_Despachante
            // 
            this.Pedido_Despachante.DataPropertyName = "despachante";
            this.Pedido_Despachante.HeaderText = "Despachante";
            this.Pedido_Despachante.Name = "Pedido_Despachante";
            this.Pedido_Despachante.ReadOnly = true;
            this.Pedido_Despachante.Width = 200;
            // 
            // Pedido_Situacao
            // 
            this.Pedido_Situacao.DataPropertyName = "situacao";
            this.Pedido_Situacao.HeaderText = "Situação";
            this.Pedido_Situacao.Name = "Pedido_Situacao";
            this.Pedido_Situacao.ReadOnly = true;
            // 
            // Pedido_Cliente
            // 
            this.Pedido_Cliente.DataPropertyName = "cliente";
            this.Pedido_Cliente.HeaderText = "Cliente";
            this.Pedido_Cliente.Name = "Pedido_Cliente";
            this.Pedido_Cliente.ReadOnly = true;
            // 
            // Pedido_Funcionario
            // 
            this.Pedido_Funcionario.DataPropertyName = "funcionario";
            this.Pedido_Funcionario.HeaderText = "Funcionário";
            this.Pedido_Funcionario.Name = "Pedido_Funcionario";
            this.Pedido_Funcionario.ReadOnly = true;
            // 
            // Pedido_Remessa
            // 
            this.Pedido_Remessa.DataPropertyName = "remessa";
            this.Pedido_Remessa.HeaderText = "Remessa";
            this.Pedido_Remessa.Name = "Pedido_Remessa";
            this.Pedido_Remessa.ReadOnly = true;
            // 
            // Screen_Remessa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbRemessa);
            this.Controls.Add(this.gbPedido);
            this.Controls.Add(this.ordOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.dgvRemessa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Screen_Remessa";
            this.Size = new System.Drawing.Size(1031, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemessa)).EndInit();
            this.gbPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.gbRemessa.ResumeLayout(false);
            this.gbRemessa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCEPOrigem;
        private System.Windows.Forms.Label ordOrder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbTransportadora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView dgvRemessa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.DateTimePicker dtpPrevisao;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCEPDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpRequerimento;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.ComboBox cbFiltroPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.GroupBox gbRemessa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Remessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn previsao_requerida;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportadora;
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
    }
}
