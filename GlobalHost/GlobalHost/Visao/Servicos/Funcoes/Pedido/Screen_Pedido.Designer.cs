namespace GlobalHost.Visao.Servicos.Funcoes
{
    partial class Screen_Pedido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalDBDataSet2 = new GlobalHost.GlobalDBDataSet2();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.cbFiltroPedido = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdExpresso = new System.Windows.Forms.RadioButton();
            this.rdExclusivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.cbFiltroCarga = new System.Windows.Forms.ComboBox();
            this.dgvCarga = new System.Windows.Forms.DataGridView();
            this.Carga_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga_Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga_Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga_Dimensoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga_ValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btDestino = new System.Windows.Forms.Button();
            this.btOrigem = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.Strip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pedidoTableAdapter = new GlobalHost.GlobalDBDataSet2TableAdapters.PedidoTableAdapter();
            this.globalDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotID = new System.Windows.Forms.Label();
            this.dotCliente = new System.Windows.Forms.Label();
            this.dotOrigem = new System.Windows.Forms.Label();
            this.dotDestino = new System.Windows.Forms.Label();
            this.dotModalidade = new System.Windows.Forms.Label();
            this.dotOrder = new System.Windows.Forms.Label();
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
            this.autorizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "REALIZAR PEDIDO ADUANEIRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(929, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "________________________________________________";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtID.Location = new System.Drawing.Point(55, 115);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtID.Size = new System.Drawing.Size(90, 23);
            this.txtID.TabIndex = 29;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(51, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(51, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Origem";
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.AutoGenerateColumns = false;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.Pedido_Remessa,
            this.autorizacao});
            this.dgvPedido.DataSource = this.pedidoBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.Location = new System.Drawing.Point(647, 155);
            this.dgvPedido.Name = "dgvPedido";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(339, 376);
            this.dgvPedido.TabIndex = 43;
            this.dgvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellDoubleClick);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.globalDBDataSet2;
            // 
            // globalDBDataSet2
            // 
            this.globalDBDataSet2.DataSetName = "GlobalDBDataSet2";
            this.globalDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(643, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Buscar";
            // 
            // txtBuscarPedido
            // 
            this.txtBuscarPedido.BackColor = System.Drawing.Color.White;
            this.txtBuscarPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBuscarPedido.Location = new System.Drawing.Point(647, 115);
            this.txtBuscarPedido.Name = "txtBuscarPedido";
            this.txtBuscarPedido.Size = new System.Drawing.Size(183, 23);
            this.txtBuscarPedido.TabIndex = 40;
            this.txtBuscarPedido.TextChanged += new System.EventHandler(this.txtBuscarPedido_TextChanged);
            // 
            // cbFiltroPedido
            // 
            this.cbFiltroPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltroPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltroPedido.FormattingEnabled = true;
            this.cbFiltroPedido.Items.AddRange(new object[] {
            "Data",
            "Modalidade",
            "Origem",
            "Destino",
            "Despachante",
            "Situação",
            "Cliente",
            "Funcionário",
            "Remessa",
            "Autorização"});
            this.cbFiltroPedido.Location = new System.Drawing.Point(836, 114);
            this.cbFiltroPedido.Name = "cbFiltroPedido";
            this.cbFiltroPedido.Size = new System.Drawing.Size(149, 25);
            this.cbFiltroPedido.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(351, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(183, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cliente";
            // 
            // rdExpresso
            // 
            this.rdExpresso.AutoSize = true;
            this.rdExpresso.Checked = true;
            this.rdExpresso.Enabled = false;
            this.rdExpresso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdExpresso.Location = new System.Drawing.Point(55, 233);
            this.rdExpresso.Name = "rdExpresso";
            this.rdExpresso.Size = new System.Drawing.Size(79, 21);
            this.rdExpresso.TabIndex = 50;
            this.rdExpresso.TabStop = true;
            this.rdExpresso.Text = "Expresso";
            this.Strip.SetToolTip(this.rdExpresso, "Pedidos expressos são efetuados normalmentes, não possuem taxas adicionais,\r\nporé" +
        "m, não são tratados como prioridade");
            this.rdExpresso.UseVisualStyleBackColor = true;
            // 
            // rdExclusivo
            // 
            this.rdExclusivo.AutoSize = true;
            this.rdExclusivo.Enabled = false;
            this.rdExclusivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdExclusivo.Location = new System.Drawing.Point(140, 233);
            this.rdExclusivo.Name = "rdExclusivo";
            this.rdExclusivo.Size = new System.Drawing.Size(83, 21);
            this.rdExclusivo.TabIndex = 51;
            this.rdExclusivo.Text = "Exclusivo";
            this.Strip.SetToolTip(this.rdExclusivo, "Pedidos Exclusivos são processados e importados/exportados mais rapidamente,\r\npor" +
        "ém, possui uma taxa extra por carga, e necessita de uma entrada de 50% do valor\r" +
        "\ndo orçamento");
            this.rdExclusivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(51, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Modalidade";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btUpdate.Enabled = false;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Image = global::GlobalHost.Properties.Resources.icons8_atualizações_disponíveis_18;
            this.btUpdate.Location = new System.Drawing.Point(496, 130);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(35, 32);
            this.btUpdate.TabIndex = 45;
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Strip.SetToolTip(this.btUpdate, "Altera as informações de uma carga já existente");
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btMenos
            // 
            this.btMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btMenos.Enabled = false;
            this.btMenos.FlatAppearance.BorderSize = 0;
            this.btMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.ForeColor = System.Drawing.Color.White;
            this.btMenos.Location = new System.Drawing.Point(496, 93);
            this.btMenos.Margin = new System.Windows.Forms.Padding(0);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(35, 32);
            this.btMenos.TabIndex = 44;
            this.btMenos.Text = "‒";
            this.btMenos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Strip.SetToolTip(this.btMenos, "Remove uma carga");
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
            this.btMais.Location = new System.Drawing.Point(496, 55);
            this.btMais.Margin = new System.Windows.Forms.Padding(0);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(35, 32);
            this.btMais.TabIndex = 43;
            this.btMais.Text = "+";
            this.btMais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Strip.SetToolTip(this.btMais, "Insere uma nova carga");
            this.btMais.UseVisualStyleBackColor = false;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // cbFiltroCarga
            // 
            this.cbFiltroCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroCarga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltroCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltroCarga.FormattingEnabled = true;
            this.cbFiltroCarga.Items.AddRange(new object[] {
            "Descrição",
            "Volume",
            "Peso",
            "Dimensões",
            "Valor Unitário",
            "Valor",
            "Tipo"});
            this.cbFiltroCarga.Location = new System.Drawing.Point(342, 24);
            this.cbFiltroCarga.Name = "cbFiltroCarga";
            this.cbFiltroCarga.Size = new System.Drawing.Size(147, 25);
            this.cbFiltroCarga.TabIndex = 42;
            // 
            // dgvCarga
            // 
            this.dgvCarga.AllowUserToAddRows = false;
            this.dgvCarga.AllowUserToResizeRows = false;
            this.dgvCarga.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarga.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvCarga.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carga_ID,
            this.Carga_Descricao,
            this.Carga_Volume,
            this.Carga_Peso,
            this.Carga_Dimensoes,
            this.Carga_ValorUnit,
            this.Carga_Valor,
            this.Carga_Tipo});
            this.dgvCarga.ContextMenuStrip = this.MenuStrip;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarga.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCarga.EnableHeadersVisualStyles = false;
            this.dgvCarga.Location = new System.Drawing.Point(26, 55);
            this.dgvCarga.Name = "dgvCarga";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarga.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCarga.RowHeadersVisible = false;
            this.dgvCarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarga.Size = new System.Drawing.Size(463, 107);
            this.dgvCarga.TabIndex = 40;
            this.dgvCarga.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarga_CellDoubleClick);
            // 
            // Carga_ID
            // 
            this.Carga_ID.DataPropertyName = "id";
            this.Carga_ID.HeaderText = "ID";
            this.Carga_ID.Name = "Carga_ID";
            this.Carga_ID.Width = 50;
            // 
            // Carga_Descricao
            // 
            this.Carga_Descricao.DataPropertyName = "descricao";
            this.Carga_Descricao.HeaderText = "Descrição";
            this.Carga_Descricao.Name = "Carga_Descricao";
            this.Carga_Descricao.Width = 200;
            // 
            // Carga_Volume
            // 
            this.Carga_Volume.DataPropertyName = "volume";
            this.Carga_Volume.HeaderText = "Volume";
            this.Carga_Volume.Name = "Carga_Volume";
            this.Carga_Volume.Width = 50;
            // 
            // Carga_Peso
            // 
            this.Carga_Peso.DataPropertyName = "peso";
            this.Carga_Peso.HeaderText = "Peso";
            this.Carga_Peso.Name = "Carga_Peso";
            this.Carga_Peso.Width = 60;
            // 
            // Carga_Dimensoes
            // 
            this.Carga_Dimensoes.DataPropertyName = "dimensoes";
            this.Carga_Dimensoes.HeaderText = "Dimensões";
            this.Carga_Dimensoes.Name = "Carga_Dimensoes";
            // 
            // Carga_ValorUnit
            // 
            this.Carga_ValorUnit.DataPropertyName = "valor_unitario";
            this.Carga_ValorUnit.HeaderText = "Valor Unitário";
            this.Carga_ValorUnit.Name = "Carga_ValorUnit";
            this.Carga_ValorUnit.Width = 50;
            // 
            // Carga_Valor
            // 
            this.Carga_Valor.DataPropertyName = "valor";
            this.Carga_Valor.HeaderText = "Valor";
            this.Carga_Valor.Name = "Carga_Valor";
            this.Carga_Valor.Width = 50;
            // 
            // Carga_Tipo
            // 
            this.Carga_Tipo.DataPropertyName = "tipo";
            this.Carga_Tipo.HeaderText = "Tipo";
            this.Carga_Tipo.Name = "Carga_Tipo";
            this.Carga_Tipo.Width = 80;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripExcluir,
            this.ToolStripAlterar});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(110, 48);
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // ToolStripExcluir
            // 
            this.ToolStripExcluir.Name = "ToolStripExcluir";
            this.ToolStripExcluir.Size = new System.Drawing.Size(109, 22);
            this.ToolStripExcluir.Text = "Exluir";
            // 
            // ToolStripAlterar
            // 
            this.ToolStripAlterar.Name = "ToolStripAlterar";
            this.ToolStripAlterar.Size = new System.Drawing.Size(109, 22);
            this.ToolStripAlterar.Text = "Alterar";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Enabled = false;
            this.cbCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(187, 115);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(404, 25);
            this.cbCliente.TabIndex = 54;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.White;
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDestino.Location = new System.Drawing.Point(355, 171);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDestino.Size = new System.Drawing.Size(211, 23);
            this.txtDestino.TabIndex = 101;
            // 
            // btDestino
            // 
            this.btDestino.Enabled = false;
            this.btDestino.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btDestino.Location = new System.Drawing.Point(565, 171);
            this.btDestino.Name = "btDestino";
            this.btDestino.Size = new System.Drawing.Size(32, 23);
            this.btDestino.TabIndex = 102;
            this.btDestino.Text = "+";
            this.btDestino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDestino.UseVisualStyleBackColor = true;
            this.btDestino.Click += new System.EventHandler(this.btDestino_Click);
            // 
            // btOrigem
            // 
            this.btOrigem.Enabled = false;
            this.btOrigem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrigem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btOrigem.Location = new System.Drawing.Point(265, 171);
            this.btOrigem.Name = "btOrigem";
            this.btOrigem.Size = new System.Drawing.Size(32, 23);
            this.btOrigem.TabIndex = 104;
            this.btOrigem.Text = "+";
            this.btOrigem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOrigem.UseVisualStyleBackColor = true;
            this.btOrigem.Click += new System.EventHandler(this.btOrigem_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.BackColor = System.Drawing.Color.White;
            this.txtOrigem.Enabled = false;
            this.txtOrigem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtOrigem.Location = new System.Drawing.Point(55, 171);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOrigem.Size = new System.Drawing.Size(211, 23);
            this.txtOrigem.TabIndex = 103;
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
            this.btnCancelar.Location = new System.Drawing.Point(503, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 78);
            this.btnCancelar.TabIndex = 45;
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
            this.btnOk.Location = new System.Drawing.Point(403, 453);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 78);
            this.btnOk.TabIndex = 44;
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
            this.btnExcluir.Location = new System.Drawing.Point(236, 453);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 78);
            this.btnExcluir.TabIndex = 25;
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
            this.btnAlterar.Location = new System.Drawing.Point(136, 453);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 78);
            this.btnAlterar.TabIndex = 24;
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
            this.btnInserir.Location = new System.Drawing.Point(36, 453);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(94, 78);
            this.btnInserir.TabIndex = 23;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCarga
            // 
            this.txtCarga.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCarga.Location = new System.Drawing.Point(26, 24);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(310, 23);
            this.txtCarga.TabIndex = 46;
            this.txtCarga.TextChanged += new System.EventHandler(this.txtCarga_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCarga);
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btMenos);
            this.groupBox2.Controls.Add(this.btMais);
            this.groupBox2.Controls.Add(this.cbFiltroCarga);
            this.groupBox2.Controls.Add(this.dgvCarga);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBox2.Location = new System.Drawing.Point(55, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 173);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerenciamento de Carga";
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // globalDBDataSet2BindingSource
            // 
            this.globalDBDataSet2BindingSource.DataSource = this.globalDBDataSet2;
            this.globalDBDataSet2BindingSource.Position = 0;
            // 
            // dotID
            // 
            this.dotID.AutoSize = true;
            this.dotID.ForeColor = System.Drawing.Color.Red;
            this.dotID.Location = new System.Drawing.Point(69, 91);
            this.dotID.Name = "dotID";
            this.dotID.Size = new System.Drawing.Size(11, 13);
            this.dotID.TabIndex = 105;
            this.dotID.Text = "*";
            // 
            // dotCliente
            // 
            this.dotCliente.AutoSize = true;
            this.dotCliente.ForeColor = System.Drawing.Color.Red;
            this.dotCliente.Location = new System.Drawing.Point(240, 95);
            this.dotCliente.Name = "dotCliente";
            this.dotCliente.Size = new System.Drawing.Size(11, 13);
            this.dotCliente.TabIndex = 106;
            this.dotCliente.Text = "*";
            // 
            // dotOrigem
            // 
            this.dotOrigem.AutoSize = true;
            this.dotOrigem.ForeColor = System.Drawing.Color.Red;
            this.dotOrigem.Location = new System.Drawing.Point(113, 152);
            this.dotOrigem.Name = "dotOrigem";
            this.dotOrigem.Size = new System.Drawing.Size(11, 13);
            this.dotOrigem.TabIndex = 107;
            this.dotOrigem.Text = "*";
            // 
            // dotDestino
            // 
            this.dotDestino.AutoSize = true;
            this.dotDestino.ForeColor = System.Drawing.Color.Red;
            this.dotDestino.Location = new System.Drawing.Point(409, 152);
            this.dotDestino.Name = "dotDestino";
            this.dotDestino.Size = new System.Drawing.Size(11, 13);
            this.dotDestino.TabIndex = 108;
            this.dotDestino.Text = "*";
            // 
            // dotModalidade
            // 
            this.dotModalidade.AutoSize = true;
            this.dotModalidade.ForeColor = System.Drawing.Color.Red;
            this.dotModalidade.Location = new System.Drawing.Point(151, 209);
            this.dotModalidade.Name = "dotModalidade";
            this.dotModalidade.Size = new System.Drawing.Size(11, 13);
            this.dotModalidade.TabIndex = 109;
            this.dotModalidade.Text = "*";
            // 
            // dotOrder
            // 
            this.dotOrder.AutoSize = true;
            this.dotOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotOrder.ForeColor = System.Drawing.Color.Red;
            this.dotOrder.Location = new System.Drawing.Point(501, 245);
            this.dotOrder.Name = "dotOrder";
            this.dotOrder.Size = new System.Drawing.Size(96, 12);
            this.dotOrder.TabIndex = 110;
            this.dotOrder.Text = "* Campos obrigatórios";
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
            // autorizacao
            // 
            this.autorizacao.DataPropertyName = "autorizacao";
            this.autorizacao.HeaderText = "Autorização";
            this.autorizacao.Name = "autorizacao";
            // 
            // Screen_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dotOrder);
            this.Controls.Add(this.dotModalidade);
            this.Controls.Add(this.dotDestino);
            this.Controls.Add(this.dotOrigem);
            this.Controls.Add(this.dotCliente);
            this.Controls.Add(this.dotID);
            this.Controls.Add(this.btOrigem);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.btDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdExclusivo);
            this.Controls.Add(this.rdExpresso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBuscarPedido);
            this.Controls.Add(this.cbFiltroPedido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Name = "Screen_Pedido";
            this.Size = new System.Drawing.Size(1031, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarPedido;
        private System.Windows.Forms.ComboBox cbFiltroPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdExpresso;
        private System.Windows.Forms.RadioButton rdExclusivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.ComboBox cbFiltroCarga;
        private System.Windows.Forms.DataGridView dgvCarga;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btDestino;
        private System.Windows.Forms.Button btOrigem;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ToolTip Strip;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExcluir;
        private System.Windows.Forms.ToolStripMenuItem ToolStripAlterar;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Dimensoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_ValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Tipo;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private GlobalDBDataSet2 globalDBDataSet2;
        private GlobalDBDataSet2TableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource globalDBDataSet2BindingSource;
        private System.Windows.Forms.Label dotID;
        private System.Windows.Forms.Label dotCliente;
        private System.Windows.Forms.Label dotOrigem;
        private System.Windows.Forms.Label dotDestino;
        private System.Windows.Forms.Label dotModalidade;
        private System.Windows.Forms.Label dotOrder;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn autorizacao;
    }
}
