﻿namespace GlobalHost.Visao.Servicos.Funcoes
{
    partial class Screen_Orcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPedido = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTaxa = new System.Windows.Forms.DataGridView();
            this.Taxa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxa_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxa_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip_dgvPedido = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolMS_dgvPedido_Exluir = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTab = new System.Windows.Forms.GroupBox();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.listaCargas = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbValHead = new System.Windows.Forms.Label();
            this.lbVal = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.lbValCabec = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTransp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxa)).BeginInit();
            this.MenuStrip_dgvPedido.SuspendLayout();
            this.gbTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "ORÇAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(929, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "________________________________________________";
            // 
            // cbPedido
            // 
            this.cbPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbPedido.FormattingEnabled = true;
            this.cbPedido.IntegralHeight = false;
            this.cbPedido.Location = new System.Drawing.Point(36, 119);
            this.cbPedido.Name = "cbPedido";
            this.cbPedido.Size = new System.Drawing.Size(252, 25);
            this.cbPedido.TabIndex = 56;
            this.cbPedido.SelectedIndexChanged += new System.EventHandler(this.cbPedido_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(32, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 55;
            this.label8.Text = "Pedido";
            // 
            // dgvTaxa
            // 
            this.dgvTaxa.AllowUserToAddRows = false;
            this.dgvTaxa.AllowUserToResizeRows = false;
            this.dgvTaxa.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaxa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTaxa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaxa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTaxa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Taxa_ID,
            this.Taxa_Descricao,
            this.Taxa_Valor});
            this.dgvTaxa.ContextMenuStrip = this.MenuStrip_dgvPedido;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaxa.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTaxa.EnableHeadersVisualStyles = false;
            this.dgvTaxa.Location = new System.Drawing.Point(36, 150);
            this.dgvTaxa.Name = "dgvTaxa";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaxa.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTaxa.RowHeadersVisible = false;
            this.dgvTaxa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaxa.Size = new System.Drawing.Size(658, 201);
            this.dgvTaxa.TabIndex = 57;
            this.dgvTaxa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaxa_CellDoubleClick);
            // 
            // Taxa_ID
            // 
            this.Taxa_ID.DataPropertyName = "id";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.Taxa_ID.DefaultCellStyle = dataGridViewCellStyle6;
            this.Taxa_ID.HeaderText = "ID";
            this.Taxa_ID.Name = "Taxa_ID";
            this.Taxa_ID.ReadOnly = true;
            this.Taxa_ID.Width = 85;
            // 
            // Taxa_Descricao
            // 
            this.Taxa_Descricao.DataPropertyName = "descricao";
            this.Taxa_Descricao.HeaderText = "Descrição";
            this.Taxa_Descricao.Name = "Taxa_Descricao";
            this.Taxa_Descricao.ReadOnly = true;
            this.Taxa_Descricao.Width = 420;
            // 
            // Taxa_Valor
            // 
            this.Taxa_Valor.DataPropertyName = "valor";
            this.Taxa_Valor.HeaderText = "Valor";
            this.Taxa_Valor.Name = "Taxa_Valor";
            this.Taxa_Valor.ReadOnly = true;
            this.Taxa_Valor.Width = 150;
            // 
            // MenuStrip_dgvPedido
            // 
            this.MenuStrip_dgvPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolMS_dgvPedido_Exluir});
            this.MenuStrip_dgvPedido.Name = "MenuStrip_dgvPedido";
            this.MenuStrip_dgvPedido.Size = new System.Drawing.Size(110, 26);
            // 
            // ToolMS_dgvPedido_Exluir
            // 
            this.ToolMS_dgvPedido_Exluir.Image = global::GlobalHost.Properties.Resources.lixo2;
            this.ToolMS_dgvPedido_Exluir.Name = "ToolMS_dgvPedido_Exluir";
            this.ToolMS_dgvPedido_Exluir.Size = new System.Drawing.Size(109, 22);
            this.ToolMS_dgvPedido_Exluir.Text = "Excluir";
            this.ToolMS_dgvPedido_Exluir.Click += new System.EventHandler(this.ToolMS_dgvPedido_Exluir_Click);
            // 
            // gbTab
            // 
            this.gbTab.Controls.Add(this.btAtualizar);
            this.gbTab.Controls.Add(this.btAdicionar);
            this.gbTab.Controls.Add(this.label4);
            this.gbTab.Controls.Add(this.txtValor);
            this.gbTab.Controls.Add(this.label6);
            this.gbTab.Controls.Add(this.label3);
            this.gbTab.Controls.Add(this.txtDesc);
            this.gbTab.Controls.Add(this.txtID);
            this.gbTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbTab.Location = new System.Drawing.Point(36, 357);
            this.gbTab.Name = "gbTab";
            this.gbTab.Size = new System.Drawing.Size(658, 86);
            this.gbTab.TabIndex = 58;
            this.gbTab.TabStop = false;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(541, 38);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(85, 31);
            this.btAtualizar.TabIndex = 63;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Location = new System.Drawing.Point(438, 38);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(85, 31);
            this.btAdicionar.TabIndex = 62;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(263, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtValor.Location = new System.Drawing.Point(267, 43);
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtValor.Size = new System.Drawing.Size(114, 21);
            this.txtValor.TabIndex = 61;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(14, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(112, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDesc.Location = new System.Drawing.Point(116, 43);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDesc.Size = new System.Drawing.Size(114, 21);
            this.txtDesc.TabIndex = 59;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtID.Location = new System.Drawing.Point(18, 43);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtID.Size = new System.Drawing.Size(62, 21);
            this.txtID.TabIndex = 59;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // listaCargas
            // 
            this.listaCargas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCargas.FormattingEnabled = true;
            this.listaCargas.ItemHeight = 17;
            this.listaCargas.Location = new System.Drawing.Point(714, 150);
            this.listaCargas.Name = "listaCargas";
            this.listaCargas.Size = new System.Drawing.Size(235, 293);
            this.listaCargas.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(710, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Carga";
            // 
            // btAbrir
            // 
            this.btAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAbrir.FlatAppearance.BorderSize = 0;
            this.btAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrir.ForeColor = System.Drawing.Color.White;
            this.btAbrir.Location = new System.Drawing.Point(420, 504);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(85, 31);
            this.btAbrir.TabIndex = 64;
            this.btAbrir.Text = "Confirmar";
            this.btAbrir.UseVisualStyleBackColor = false;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(527, 504);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(85, 31);
            this.btCancelar.TabIndex = 65;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(458, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Total: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbTotal.Location = new System.Drawing.Point(506, 462);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(15, 21);
            this.lbTotal.TabIndex = 67;
            this.lbTotal.Text = "-";
            // 
            // lbValHead
            // 
            this.lbValHead.AutoSize = true;
            this.lbValHead.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbValHead.Location = new System.Drawing.Point(33, 465);
            this.lbValHead.Name = "lbValHead";
            this.lbValHead.Size = new System.Drawing.Size(61, 16);
            this.lbValHead.TabIndex = 68;
            this.lbValHead.Text = "Validade:";
            // 
            // lbVal
            // 
            this.lbVal.AutoSize = true;
            this.lbVal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVal.Location = new System.Drawing.Point(92, 466);
            this.lbVal.Name = "lbVal";
            this.lbVal.Size = new System.Drawing.Size(12, 15);
            this.lbVal.TabIndex = 69;
            this.lbVal.Text = "-";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(342, 119);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(127, 23);
            this.dtpVencimento.TabIndex = 71;
            this.dtpVencimento.ValueChanged += new System.EventHandler(this.dtpVencimento_ValueChanged);
            // 
            // lbValCabec
            // 
            this.lbValCabec.AutoSize = true;
            this.lbValCabec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValCabec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbValCabec.Location = new System.Drawing.Point(338, 97);
            this.lbValCabec.Name = "lbValCabec";
            this.lbValCabec.Size = new System.Drawing.Size(82, 19);
            this.lbValCabec.TabIndex = 72;
            this.lbValCabec.Text = "Validade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(506, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 74;
            this.label9.Text = "Transportadora";
            // 
            // cbTransp
            // 
            this.cbTransp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbTransp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbTransp.FormattingEnabled = true;
            this.cbTransp.IntegralHeight = false;
            this.cbTransp.Location = new System.Drawing.Point(510, 119);
            this.cbTransp.Name = "cbTransp";
            this.cbTransp.Size = new System.Drawing.Size(184, 25);
            this.cbTransp.TabIndex = 56;
            this.cbTransp.SelectedIndexChanged += new System.EventHandler(this.cbPedido_SelectedIndexChanged);
            // 
            // Screen_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbValCabec);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.lbVal);
            this.Controls.Add(this.lbValHead);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaCargas);
            this.Controls.Add(this.gbTab);
            this.Controls.Add(this.dgvTaxa);
            this.Controls.Add(this.cbTransp);
            this.Controls.Add(this.cbPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Screen_Orcamento";
            this.Size = new System.Drawing.Size(1031, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxa)).EndInit();
            this.MenuStrip_dgvPedido.ResumeLayout(false);
            this.gbTab.ResumeLayout(false);
            this.gbTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTaxa;
        private System.Windows.Forms.GroupBox gbTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.ListBox listaCargas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ContextMenuStrip MenuStrip_dgvPedido;
        private System.Windows.Forms.ToolStripMenuItem ToolMS_dgvPedido_Exluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxa_Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxa_Valor;
        private System.Windows.Forms.Label lbValHead;
        private System.Windows.Forms.Label lbVal;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Label lbValCabec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTransp;
    }
}
