namespace GlobalHost.Visao.Servicos
{
    partial class ScreenTipo_Transporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.globalDBDataSet = new GlobalHost.GlobalDBDataSet();
            this.tipoTransporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_TransporteTableAdapter = new GlobalHost.GlobalDBDataSetTableAdapters.Tipo_TransporteTableAdapter();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolExluir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransporteBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "TIPO DE TRANSPORTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(929, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "________________________________________________";
            // 
            // dgvTipo
            // 
            this.dgvTipo.AllowUserToAddRows = false;
            this.dgvTipo.AllowUserToResizeRows = false;
            this.dgvTipo.AutoGenerateColumns = false;
            this.dgvTipo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_desc,
            this.col_peso,
            this.col_dim});
            this.dgvTipo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTipo.DataSource = this.tipoTransporteBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipo.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTipo.EnableHeadersVisualStyles = false;
            this.dgvTipo.Location = new System.Drawing.Point(647, 174);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.RowHeadersVisible = false;
            this.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipo.Size = new System.Drawing.Size(339, 357);
            this.dgvTipo.TabIndex = 6;
            this.dgvTipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipo_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(48, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNome.Location = new System.Drawing.Point(177, 134);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 23);
            this.txtNome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(173, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(48, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Peso Máximo Suportado (Kg)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(356, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dimensões ";
            // 
            // txtLargura
            // 
            this.txtLargura.BackColor = System.Drawing.Color.White;
            this.txtLargura.Enabled = false;
            this.txtLargura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLargura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtLargura.Location = new System.Drawing.Point(360, 219);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(60, 23);
            this.txtLargura.TabIndex = 15;
            this.txtLargura.TextChanged += new System.EventHandler(this.txtLargura_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(422, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(504, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "x";
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.White;
            this.txtAltura.Enabled = false;
            this.txtAltura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAltura.Location = new System.Drawing.Point(442, 219);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(60, 23);
            this.txtAltura.TabIndex = 19;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtComprimento
            // 
            this.txtComprimento.BackColor = System.Drawing.Color.White;
            this.txtComprimento.Enabled = false;
            this.txtComprimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtComprimento.Location = new System.Drawing.Point(524, 219);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(60, 23);
            this.txtComprimento.TabIndex = 20;
            this.txtComprimento.TextChanged += new System.EventHandler(this.txtComprimento_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.White;
            this.txtPeso.Enabled = false;
            this.txtPeso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPeso.Location = new System.Drawing.Point(52, 219);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(133, 23);
            this.txtPeso.TabIndex = 21;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(444, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "(Largura x Altura x Comprimento)";
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
            this.btnCancelar.Location = new System.Drawing.Point(504, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 78);
            this.btnCancelar.TabIndex = 32;
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
            this.btnOk.Location = new System.Drawing.Point(404, 453);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 78);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "Excluir";
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
            this.btnExcluir.TabIndex = 30;
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
            this.btnAlterar.TabIndex = 29;
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
            this.btnInserir.TabIndex = 24;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtID.Location = new System.Drawing.Point(52, 134);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtID.Size = new System.Drawing.Size(78, 23);
            this.txtID.TabIndex = 8;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // globalDBDataSet
            // 
            this.globalDBDataSet.DataSetName = "GlobalDBDataSet";
            this.globalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoTransporteBindingSource
            // 
            this.tipoTransporteBindingSource.DataMember = "Tipo_Transporte";
            this.tipoTransporteBindingSource.DataSource = this.globalDBDataSet;
            // 
            // tipo_TransporteTableAdapter
            // 
            this.tipo_TransporteTableAdapter.ClearBeforeFill = true;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBusca.Location = new System.Drawing.Point(647, 134);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(205, 23);
            this.txtBusca.TabIndex = 33;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "ID",
            "Descrição",
            "Peso",
            "Dimensão"});
            this.cbFiltro.Location = new System.Drawing.Point(858, 133);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(128, 25);
            this.cbFiltro.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(472, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Descrição";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(643, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Buscar";
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.NullValue = "-";
            this.col_id.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 50;
            // 
            // col_desc
            // 
            this.col_desc.DataPropertyName = "descricao";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.col_desc.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_desc.HeaderText = "Descrição";
            this.col_desc.Name = "col_desc";
            this.col_desc.ReadOnly = true;
            this.col_desc.Width = 150;
            // 
            // col_peso
            // 
            this.col_peso.DataPropertyName = "max_peso";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.col_peso.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_peso.HeaderText = "Peso Máximo";
            this.col_peso.Name = "col_peso";
            this.col_peso.ReadOnly = true;
            this.col_peso.Width = 60;
            // 
            // col_dim
            // 
            this.col_dim.DataPropertyName = "dimensoes";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.col_dim.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_dim.HeaderText = "Dimensões";
            this.col_dim.Name = "col_dim";
            this.col_dim.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExluir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolExluir
            // 
            this.toolExluir.Name = "toolExluir";
            this.toolExluir.Size = new System.Drawing.Size(180, 22);
            this.toolExluir.Text = "Excluir";
            // 
            // ScreenTipo_Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ScreenTipo_Transporte";
            this.Size = new System.Drawing.Size(1031, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransporteBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.BindingSource tipoTransporteBindingSource;
        private GlobalDBDataSet globalDBDataSet;
        private GlobalDBDataSetTableAdapters.Tipo_TransporteTableAdapter tipo_TransporteTableAdapter;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolExluir;
    }
}
