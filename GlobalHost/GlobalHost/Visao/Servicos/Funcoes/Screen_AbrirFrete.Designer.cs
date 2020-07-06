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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvFrete = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbFiltroRemessa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.txtRemessa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lValorFreteAtual = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lValorFreteFinal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lPrevisaoEntrega = new System.Windows.Forms.Label();
            this.gbFrete = new System.Windows.Forms.GroupBox();
            this.Remessa_DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remessa_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrete)).BeginInit();
            this.gbFrete.SuspendLayout();
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
            this.label11.Location = new System.Drawing.Point(758, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 131;
            this.label11.Text = "Situação:";
            // 
            // dgvFrete
            // 
            this.dgvFrete.AllowUserToAddRows = false;
            this.dgvFrete.AllowUserToResizeRows = false;
            this.dgvFrete.BackgroundColor = System.Drawing.Color.White;
            this.dgvFrete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvFrete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remessa_DataSaida,
            this.Remessa_Descricao});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFrete.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFrete.EnableHeadersVisualStyles = false;
            this.dgvFrete.Location = new System.Drawing.Point(661, 68);
            this.dgvFrete.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFrete.Name = "dgvFrete";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrete.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFrete.RowHeadersVisible = false;
            this.dgvFrete.RowHeadersWidth = 51;
            this.dgvFrete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFrete.Size = new System.Drawing.Size(391, 174);
            this.dgvFrete.TabIndex = 128;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btBuscar.Enabled = false;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.White;
            this.btBuscar.Location = new System.Drawing.Point(245, 106);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(113, 30);
            this.btBuscar.TabIndex = 134;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btMais_Click);
            // 
            // cbFiltroRemessa
            // 
            this.cbFiltroRemessa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroRemessa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltroRemessa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltroRemessa.FormattingEnabled = true;
            this.cbFiltroRemessa.Items.AddRange(new object[] {
            "Data do Pedido",
            "Modalidade",
            "Origem",
            "Destino",
            "Despachante",
            "Situacao",
            "Cliente",
            "Funcionario",
            "Remessa"});
            this.cbFiltroRemessa.Location = new System.Drawing.Point(41, 106);
            this.cbFiltroRemessa.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiltroRemessa.Name = "cbFiltroRemessa";
            this.cbFiltroRemessa.Size = new System.Drawing.Size(195, 29);
            this.cbFiltroRemessa.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.TabIndex = 136;
            this.label3.Text = "Código da Remessa";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.Location = new System.Drawing.Point(857, 393);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(195, 32);
            this.btnOk.TabIndex = 137;
            this.btnOk.Text = "Confirmar Entrega";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(304, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 139;
            this.label4.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(37, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 140;
            this.label5.Text = "Remessa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(304, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 141;
            this.label6.Text = "Carga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(37, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 142;
            this.label7.Text = "Origem";
            // 
            // txtTransporte
            // 
            this.txtTransporte.BackColor = System.Drawing.Color.White;
            this.txtTransporte.Enabled = false;
            this.txtTransporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtTransporte.Location = new System.Drawing.Point(41, 349);
            this.txtTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTransporte.Size = new System.Drawing.Size(408, 27);
            this.txtTransporte.TabIndex = 144;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.White;
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDestino.Location = new System.Drawing.Point(308, 273);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDestino.Size = new System.Drawing.Size(141, 27);
            this.txtDestino.TabIndex = 145;
            // 
            // txtCarga
            // 
            this.txtCarga.BackColor = System.Drawing.Color.White;
            this.txtCarga.Enabled = false;
            this.txtCarga.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCarga.Location = new System.Drawing.Point(308, 198);
            this.txtCarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCarga.Size = new System.Drawing.Size(141, 27);
            this.txtCarga.TabIndex = 146;
            // 
            // txtRemessa
            // 
            this.txtRemessa.BackColor = System.Drawing.Color.White;
            this.txtRemessa.Enabled = false;
            this.txtRemessa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemessa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRemessa.Location = new System.Drawing.Point(41, 198);
            this.txtRemessa.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemessa.Name = "txtRemessa";
            this.txtRemessa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRemessa.Size = new System.Drawing.Size(141, 27);
            this.txtRemessa.TabIndex = 147;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(37, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 143;
            this.label8.Text = "Transporte";
            // 
            // txtOrigem
            // 
            this.txtOrigem.BackColor = System.Drawing.Color.White;
            this.txtOrigem.Enabled = false;
            this.txtOrigem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtOrigem.Location = new System.Drawing.Point(41, 273);
            this.txtOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOrigem.Size = new System.Drawing.Size(141, 27);
            this.txtOrigem.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(657, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 23);
            this.label9.TabIndex = 149;
            this.label9.Text = "Valor de Frete Atual:";
            // 
            // lValorFreteAtual
            // 
            this.lValorFreteAtual.AutoSize = true;
            this.lValorFreteAtual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValorFreteAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lValorFreteAtual.Location = new System.Drawing.Point(880, 246);
            this.lValorFreteAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lValorFreteAtual.Name = "lValorFreteAtual";
            this.lValorFreteAtual.Size = new System.Drawing.Size(18, 23);
            this.lValorFreteAtual.TabIndex = 150;
            this.lValorFreteAtual.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label12.Location = new System.Drawing.Point(657, 281);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 23);
            this.label12.TabIndex = 151;
            this.label12.Text = "Valor de Frete Final:";
            // 
            // lValorFreteFinal
            // 
            this.lValorFreteFinal.AutoSize = true;
            this.lValorFreteFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValorFreteFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lValorFreteFinal.Location = new System.Drawing.Point(880, 281);
            this.lValorFreteFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lValorFreteFinal.Name = "lValorFreteFinal";
            this.lValorFreteFinal.Size = new System.Drawing.Size(18, 23);
            this.lValorFreteFinal.TabIndex = 152;
            this.lValorFreteFinal.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(659, 339);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 23);
            this.label14.TabIndex = 153;
            this.label14.Text = "Previsão de Entrega:";
            // 
            // lPrevisaoEntrega
            // 
            this.lPrevisaoEntrega.AutoSize = true;
            this.lPrevisaoEntrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrevisaoEntrega.ForeColor = System.Drawing.Color.Red;
            this.lPrevisaoEntrega.Location = new System.Drawing.Point(880, 339);
            this.lPrevisaoEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrevisaoEntrega.Name = "lPrevisaoEntrega";
            this.lPrevisaoEntrega.Size = new System.Drawing.Size(18, 23);
            this.lPrevisaoEntrega.TabIndex = 154;
            this.lPrevisaoEntrega.Text = "-";
            // 
            // gbFrete
            // 
            this.gbFrete.Controls.Add(this.label10);
            this.gbFrete.Controls.Add(this.label3);
            this.gbFrete.Controls.Add(this.lPrevisaoEntrega);
            this.gbFrete.Controls.Add(this.cbFiltroRemessa);
            this.gbFrete.Controls.Add(this.label14);
            this.gbFrete.Controls.Add(this.btBuscar);
            this.gbFrete.Controls.Add(this.lValorFreteFinal);
            this.gbFrete.Controls.Add(this.label4);
            this.gbFrete.Controls.Add(this.label12);
            this.gbFrete.Controls.Add(this.label5);
            this.gbFrete.Controls.Add(this.lValorFreteAtual);
            this.gbFrete.Controls.Add(this.label6);
            this.gbFrete.Controls.Add(this.label9);
            this.gbFrete.Controls.Add(this.label7);
            this.gbFrete.Controls.Add(this.btnOk);
            this.gbFrete.Controls.Add(this.txtOrigem);
            this.gbFrete.Controls.Add(this.label8);
            this.gbFrete.Controls.Add(this.dgvFrete);
            this.gbFrete.Controls.Add(this.txtRemessa);
            this.gbFrete.Controls.Add(this.txtTransporte);
            this.gbFrete.Controls.Add(this.txtCarga);
            this.gbFrete.Controls.Add(this.txtDestino);
            this.gbFrete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbFrete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFrete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbFrete.Location = new System.Drawing.Point(51, 131);
            this.gbFrete.Margin = new System.Windows.Forms.Padding(4);
            this.gbFrete.Name = "gbFrete";
            this.gbFrete.Padding = new System.Windows.Forms.Padding(4);
            this.gbFrete.Size = new System.Drawing.Size(1106, 449);
            this.gbFrete.TabIndex = 158;
            this.gbFrete.TabStop = false;
            this.gbFrete.Text = "Dados do Frete";
            // 
            // Remessa_DataSaida
            // 
            this.Remessa_DataSaida.DataPropertyName = "data_saida";
            this.Remessa_DataSaida.HeaderText = "Data Saída";
            this.Remessa_DataSaida.MinimumWidth = 6;
            this.Remessa_DataSaida.Name = "Remessa_DataSaida";
            this.Remessa_DataSaida.Width = 150;
            // 
            // Remessa_Descricao
            // 
            this.Remessa_Descricao.DataPropertyName = "descricao";
            this.Remessa_Descricao.HeaderText = "Descrição";
            this.Remessa_Descricao.MinimumWidth = 6;
            this.Remessa_Descricao.Name = "Remessa_Descricao";
            this.Remessa_Descricao.Width = 250;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(659, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 155;
            this.label10.Text = "Situação:";
            // 
            // Screen_AbrirFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFrete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Screen_AbrirFrete";
            this.Size = new System.Drawing.Size(1375, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrete)).EndInit();
            this.gbFrete.ResumeLayout(false);
            this.gbFrete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvFrete;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ComboBox cbFiltroRemessa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.TextBox txtRemessa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lValorFreteAtual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lValorFreteFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lPrevisaoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remessa_DataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remessa_Descricao;
        private System.Windows.Forms.GroupBox gbFrete;
        private System.Windows.Forms.Label label10;
    }
}
