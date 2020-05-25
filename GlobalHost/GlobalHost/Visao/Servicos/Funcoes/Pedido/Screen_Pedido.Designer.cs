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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.cbFiltroPedido = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdExpresso = new System.Windows.Forms.RadioButton();
            this.rdExclusivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.txtBuscaCarga = new System.Windows.Forms.TextBox();
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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btDestino = new System.Windows.Forms.Button();
            this.btOrigem = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.Strip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).BeginInit();
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
            this.dgvPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.Location = new System.Drawing.Point(647, 155);
            this.dgvPedido.Name = "dgvPedido";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(339, 376);
            this.dgvPedido.TabIndex = 43;
            // 
            // Pedido_ID
            // 
            this.Pedido_ID.HeaderText = "ID";
            this.Pedido_ID.Name = "Pedido_ID";
            this.Pedido_ID.ReadOnly = true;
            // 
            // Pedido_Data
            // 
            this.Pedido_Data.HeaderText = "Data do Pedido";
            this.Pedido_Data.Name = "Pedido_Data";
            // 
            // Pedido_Modalidade
            // 
            this.Pedido_Modalidade.HeaderText = "Modalidade";
            this.Pedido_Modalidade.Name = "Pedido_Modalidade";
            // 
            // Pedido_Origem
            // 
            this.Pedido_Origem.HeaderText = "Origem";
            this.Pedido_Origem.Name = "Pedido_Origem";
            // 
            // Pedido_Destino
            // 
            this.Pedido_Destino.HeaderText = "Destino";
            this.Pedido_Destino.Name = "Pedido_Destino";
            // 
            // Pedido_Despachante
            // 
            this.Pedido_Despachante.HeaderText = "Despachante";
            this.Pedido_Despachante.Name = "Pedido_Despachante";
            // 
            // Pedido_Situacao
            // 
            this.Pedido_Situacao.HeaderText = "Situação";
            this.Pedido_Situacao.Name = "Pedido_Situacao";
            // 
            // Pedido_Cliente
            // 
            this.Pedido_Cliente.HeaderText = "Cliente";
            this.Pedido_Cliente.Name = "Pedido_Cliente";
            // 
            // Pedido_Funcionario
            // 
            this.Pedido_Funcionario.HeaderText = "Funcionário";
            this.Pedido_Funcionario.Name = "Pedido_Funcionario";
            // 
            // Pedido_Remessa
            // 
            this.Pedido_Remessa.HeaderText = "Remessa";
            this.Pedido_Remessa.Name = "Pedido_Remessa";
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
            "Remessa"});
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btUpdate);
            this.groupBox2.Controls.Add(this.btMenos);
            this.groupBox2.Controls.Add(this.btMais);
            this.groupBox2.Controls.Add(this.txtBuscaCarga);
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
            // txtBuscaCarga
            // 
            this.txtBuscaCarga.BackColor = System.Drawing.Color.White;
            this.txtBuscaCarga.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBuscaCarga.Location = new System.Drawing.Point(26, 25);
            this.txtBuscaCarga.Name = "txtBuscaCarga";
            this.txtBuscaCarga.Size = new System.Drawing.Size(310, 23);
            this.txtBuscaCarga.TabIndex = 41;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarga.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCarga.EnableHeadersVisualStyles = false;
            this.dgvCarga.Location = new System.Drawing.Point(26, 55);
            this.dgvCarga.Name = "dgvCarga";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarga.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCarga.RowHeadersVisible = false;
            this.dgvCarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarga.Size = new System.Drawing.Size(463, 107);
            this.dgvCarga.TabIndex = 40;
            // 
            // Carga_ID
            // 
            this.Carga_ID.HeaderText = "ID";
            this.Carga_ID.Name = "Carga_ID";
            this.Carga_ID.Width = 50;
            // 
            // Carga_Descricao
            // 
            this.Carga_Descricao.HeaderText = "Descrição";
            this.Carga_Descricao.Name = "Carga_Descricao";
            this.Carga_Descricao.Width = 200;
            // 
            // Carga_Volume
            // 
            this.Carga_Volume.HeaderText = "Volume";
            this.Carga_Volume.Name = "Carga_Volume";
            this.Carga_Volume.Width = 50;
            // 
            // Carga_Peso
            // 
            this.Carga_Peso.HeaderText = "Peso";
            this.Carga_Peso.Name = "Carga_Peso";
            this.Carga_Peso.Width = 60;
            // 
            // Carga_Dimensoes
            // 
            this.Carga_Dimensoes.HeaderText = "Dimensões";
            this.Carga_Dimensoes.Name = "Carga_Dimensoes";
            // 
            // Carga_ValorUnit
            // 
            this.Carga_ValorUnit.HeaderText = "Valor Unitário";
            this.Carga_ValorUnit.Name = "Carga_ValorUnit";
            this.Carga_ValorUnit.Width = 50;
            // 
            // Carga_Valor
            // 
            this.Carga_Valor.HeaderText = "Valor";
            this.Carga_Valor.Name = "Carga_Valor";
            this.Carga_Valor.Width = 50;
            // 
            // Carga_Tipo
            // 
            this.Carga_Tipo.HeaderText = "Tipo";
            this.Carga_Tipo.Name = "Carga_Tipo";
            this.Carga_Tipo.Width = 80;
            // 
            // cbCliente
            // 
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
            // Screen_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.TextBox txtBuscaCarga;
        private System.Windows.Forms.ComboBox cbFiltroCarga;
        private System.Windows.Forms.DataGridView dgvCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Dimensoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_ValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga_Tipo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btDestino;
        private System.Windows.Forms.Button btOrigem;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ToolTip Strip;
    }
}
