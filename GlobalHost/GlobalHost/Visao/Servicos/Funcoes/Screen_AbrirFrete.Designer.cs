﻿namespace GlobalHost.Visao.Servicos.Funcoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvFrete = new System.Windows.Forms.DataGridView();
            this.Pedido_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lValorFreteAtual = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lValorFreteFinal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lPrevisaoEntrega = new System.Windows.Forms.Label();
            this.gbFrete = new System.Windows.Forms.GroupBox();
            this.listCargas = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lTransporte = new System.Windows.Forms.Label();
            this.lOrigem = new System.Windows.Forms.Label();
            this.lDestino = new System.Windows.Forms.Label();
            this.lRemessa = new System.Windows.Forms.Label();
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
            this.label11.Location = new System.Drawing.Point(757, 130);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido_Data,
            this.Pedido_Situação});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFrete.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFrete.EnableHeadersVisualStyles = false;
            this.dgvFrete.Location = new System.Drawing.Point(661, 68);
            this.dgvFrete.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFrete.Name = "dgvFrete";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrete.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFrete.RowHeadersVisible = false;
            this.dgvFrete.RowHeadersWidth = 51;
            this.dgvFrete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFrete.Size = new System.Drawing.Size(375, 174);
            this.dgvFrete.TabIndex = 128;
            // 
            // Pedido_Data
            // 
            this.Pedido_Data.DataPropertyName = "data";
            this.Pedido_Data.HeaderText = "Data";
            this.Pedido_Data.MinimumWidth = 6;
            this.Pedido_Data.Name = "Pedido_Data";
            this.Pedido_Data.Width = 125;
            // 
            // Pedido_Situação
            // 
            this.Pedido_Situação.DataPropertyName = "situacao";
            this.Pedido_Situação.HeaderText = "Situação";
            this.Pedido_Situação.MinimumWidth = 6;
            this.Pedido_Situação.Name = "Pedido_Situação";
            this.Pedido_Situação.Width = 250;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
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
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbPedido
            // 
            this.cbPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbPedido.FormattingEnabled = true;
            this.cbPedido.Items.AddRange(new object[] {
            "Data do Pedido",
            "Modalidade",
            "Origem",
            "Destino",
            "Despachante",
            "Situacao",
            "Cliente",
            "Funcionario",
            "Remessa"});
            this.cbPedido.Location = new System.Drawing.Point(41, 106);
            this.cbPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cbPedido.Name = "cbPedido";
            this.cbPedido.Size = new System.Drawing.Size(195, 29);
            this.cbPedido.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 136;
            this.label3.Text = "Código do Pedido";
            // 
            // btnOk
            // 
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
            this.label4.Location = new System.Drawing.Point(297, 310);
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
            this.label7.Location = new System.Drawing.Point(37, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 142;
            this.label7.Text = "Origem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(37, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 143;
            this.label8.Text = "Transporte";
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
            this.lValorFreteAtual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValorFreteAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lValorFreteAtual.Location = new System.Drawing.Point(907, 250);
            this.lValorFreteAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lValorFreteAtual.Name = "lValorFreteAtual";
            this.lValorFreteAtual.Size = new System.Drawing.Size(16, 19);
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
            this.lValorFreteFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValorFreteFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lValorFreteFinal.Location = new System.Drawing.Point(907, 285);
            this.lValorFreteFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lValorFreteFinal.Name = "lValorFreteFinal";
            this.lValorFreteFinal.Size = new System.Drawing.Size(16, 19);
            this.lValorFreteFinal.TabIndex = 152;
            this.lValorFreteFinal.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(659, 338);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 23);
            this.label14.TabIndex = 153;
            this.label14.Text = "Previsão de Entrega:";
            // 
            // lPrevisaoEntrega
            // 
            this.lPrevisaoEntrega.AutoSize = true;
            this.lPrevisaoEntrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrevisaoEntrega.ForeColor = System.Drawing.Color.Red;
            this.lPrevisaoEntrega.Location = new System.Drawing.Point(875, 342);
            this.lPrevisaoEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrevisaoEntrega.Name = "lPrevisaoEntrega";
            this.lPrevisaoEntrega.Size = new System.Drawing.Size(16, 19);
            this.lPrevisaoEntrega.TabIndex = 154;
            this.lPrevisaoEntrega.Text = "-";
            // 
            // gbFrete
            // 
            this.gbFrete.Controls.Add(this.listCargas);
            this.gbFrete.Controls.Add(this.label15);
            this.gbFrete.Controls.Add(this.label13);
            this.gbFrete.Controls.Add(this.lTransporte);
            this.gbFrete.Controls.Add(this.lOrigem);
            this.gbFrete.Controls.Add(this.lDestino);
            this.gbFrete.Controls.Add(this.lRemessa);
            this.gbFrete.Controls.Add(this.label10);
            this.gbFrete.Controls.Add(this.label3);
            this.gbFrete.Controls.Add(this.lPrevisaoEntrega);
            this.gbFrete.Controls.Add(this.cbPedido);
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
            this.gbFrete.Controls.Add(this.label8);
            this.gbFrete.Controls.Add(this.dgvFrete);
            this.gbFrete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbFrete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFrete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbFrete.Location = new System.Drawing.Point(51, 130);
            this.gbFrete.Margin = new System.Windows.Forms.Padding(4);
            this.gbFrete.Name = "gbFrete";
            this.gbFrete.Padding = new System.Windows.Forms.Padding(4);
            this.gbFrete.Size = new System.Drawing.Size(1107, 449);
            this.gbFrete.TabIndex = 158;
            this.gbFrete.TabStop = false;
            this.gbFrete.Text = "Dados do Frete";
            // 
            // listCargas
            // 
            this.listCargas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCargas.FormattingEnabled = true;
            this.listCargas.ItemHeight = 19;
            this.listCargas.Location = new System.Drawing.Point(309, 198);
            this.listCargas.Margin = new System.Windows.Forms.Padding(4);
            this.listCargas.Name = "listCargas";
            this.listCargas.Size = new System.Drawing.Size(265, 80);
            this.listCargas.TabIndex = 163;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label15.Location = new System.Drawing.Point(869, 246);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 23);
            this.label15.TabIndex = 162;
            this.label15.Text = "R$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label13.Location = new System.Drawing.Point(869, 281);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 23);
            this.label13.TabIndex = 161;
            this.label13.Text = "R$";
            // 
            // lTransporte
            // 
            this.lTransporte.AutoSize = true;
            this.lTransporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTransporte.ForeColor = System.Drawing.Color.Black;
            this.lTransporte.Location = new System.Drawing.Point(37, 409);
            this.lTransporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTransporte.Name = "lTransporte";
            this.lTransporte.Size = new System.Drawing.Size(16, 19);
            this.lTransporte.TabIndex = 160;
            this.lTransporte.Text = "-";
            this.lTransporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lOrigem
            // 
            this.lOrigem.AutoSize = true;
            this.lOrigem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrigem.ForeColor = System.Drawing.Color.Black;
            this.lOrigem.Location = new System.Drawing.Point(37, 334);
            this.lOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOrigem.Name = "lOrigem";
            this.lOrigem.Size = new System.Drawing.Size(16, 19);
            this.lOrigem.TabIndex = 159;
            this.lOrigem.Text = "-";
            this.lOrigem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDestino.ForeColor = System.Drawing.Color.Black;
            this.lDestino.Location = new System.Drawing.Point(297, 334);
            this.lDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(16, 19);
            this.lDestino.TabIndex = 158;
            this.lDestino.Text = "-";
            this.lDestino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRemessa
            // 
            this.lRemessa.AutoSize = true;
            this.lRemessa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRemessa.ForeColor = System.Drawing.Color.Black;
            this.lRemessa.Location = new System.Drawing.Point(37, 194);
            this.lRemessa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRemessa.Name = "lRemessa";
            this.lRemessa.Size = new System.Drawing.Size(16, 19);
            this.lRemessa.TabIndex = 156;
            this.lRemessa.Text = "-";
            this.lRemessa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox cbPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lValorFreteAtual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lValorFreteFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lPrevisaoEntrega;
        private System.Windows.Forms.GroupBox gbFrete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lTransporte;
        private System.Windows.Forms.Label lOrigem;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.Label lRemessa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listCargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Situação;
    }
}
