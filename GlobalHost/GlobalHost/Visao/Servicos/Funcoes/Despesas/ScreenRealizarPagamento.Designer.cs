﻿namespace GlobalHost.Visao.Servicos.Funcoes
{
    partial class ScreenRealizarPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.cbDespesa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 86);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(161, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtValor.Location = new System.Drawing.Point(165, 43);
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtValor.Size = new System.Drawing.Size(114, 20);
            this.txtValor.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtID.Location = new System.Drawing.Point(14, 43);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.TabIndex = 59;
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AllowUserToResizeRows = false;
            this.dgvContas.BackgroundColor = System.Drawing.Color.White;
            this.dgvContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvContas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.valor,
            this.tipo,
            this.situacao,
            this.frete,
            this.despesa,
            this.data_emissao,
            this.data_vencimento,
            this.data_pagto,
            this.valor_pago});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvContas.EnableHeadersVisualStyles = false;
            this.dgvContas.Location = new System.Drawing.Point(22, 146);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvContas.RowHeadersVisible = false;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(872, 148);
            this.dgvContas.TabIndex = 65;
            this.dgvContas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellContentClick);
            this.dgvContas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellContentClick);
            this.dgvContas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellContentClick);
            // 
            // cbDespesa
            // 
            this.cbDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbDespesa.FormattingEnabled = true;
            this.cbDespesa.Location = new System.Drawing.Point(22, 115);
            this.cbDespesa.Name = "cbDespesa";
            this.cbDespesa.Size = new System.Drawing.Size(252, 24);
            this.cbDespesa.TabIndex = 64;
            this.cbDespesa.SelectedIndexChanged += new System.EventHandler(this.cbDespesa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(18, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Despesa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "REALIZAR PAGAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(929, 37);
            this.label2.TabIndex = 62;
            this.label2.Text = "________________________________________________";
            // 
            // txtAPagar
            // 
            this.txtAPagar.BackColor = System.Drawing.Color.White;
            this.txtAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAPagar.Location = new System.Drawing.Point(478, 345);
            this.txtAPagar.Name = "txtAPagar";
            this.txtAPagar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAPagar.Size = new System.Drawing.Size(114, 20);
            this.txtAPagar.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(474, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Valor a pagar*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(302, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Data de emissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(446, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 71;
            this.label7.Text = "Data de vencimento";
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Location = new System.Drawing.Point(306, 119);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(122, 20);
            this.dtpEmissao.TabIndex = 72;
            this.dtpEmissao.ValueChanged += new System.EventHandler(this.dtpEmissao_ValueChanged);
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Location = new System.Drawing.Point(449, 119);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(123, 20);
            this.dtpVencimento.TabIndex = 73;
            this.dtpVencimento.ValueChanged += new System.EventHandler(this.dtpVencimento_ValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOk.Image = global::GlobalHost.Properties.Resources.ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.Location = new System.Drawing.Point(800, 321);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 78);
            this.btnOk.TabIndex = 69;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.Image = global::GlobalHost.Properties.Resources.alterar2;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(700, 321);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 78);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.ID.DefaultCellStyle = dataGridViewCellStyle6;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // frete
            // 
            this.frete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frete.HeaderText = "Frete";
            this.frete.Name = "frete";
            this.frete.ReadOnly = true;
            // 
            // despesa
            // 
            this.despesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.despesa.HeaderText = "Despesa";
            this.despesa.Name = "despesa";
            this.despesa.ReadOnly = true;
            // 
            // data_emissao
            // 
            this.data_emissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_emissao.HeaderText = "Dt Emissão";
            this.data_emissao.Name = "data_emissao";
            this.data_emissao.ReadOnly = true;
            // 
            // data_vencimento
            // 
            this.data_vencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_vencimento.HeaderText = "Dt Venc.";
            this.data_vencimento.Name = "data_vencimento";
            this.data_vencimento.ReadOnly = true;
            // 
            // data_pagto
            // 
            this.data_pagto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_pagto.HeaderText = "Dt. Pagto.";
            this.data_pagto.Name = "data_pagto";
            this.data_pagto.ReadOnly = true;
            // 
            // valor_pago
            // 
            this.valor_pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor_pago.HeaderText = "Valor Pago";
            this.valor_pago.Name = "valor_pago";
            this.valor_pago.ReadOnly = true;
            // 
            // ScreenRealizarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.dtpEmissao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAPagar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvContas);
            this.Controls.Add(this.cbDespesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ScreenRealizarPagamento";
            this.Size = new System.Drawing.Size(912, 418);
            this.Load += new System.EventHandler(this.ScreenRealizarPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.ComboBox cbDespesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtAPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete;
        private System.Windows.Forms.DataGridViewTextBoxColumn despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pago;
    }
}
