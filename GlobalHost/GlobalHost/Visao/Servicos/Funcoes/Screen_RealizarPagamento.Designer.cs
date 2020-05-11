namespace GlobalHost.Visao.Servicos.Funcoes
{
    partial class Screen_RealizarPagamento
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
            this.btPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPagar
            // 
            this.btPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagar.Location = new System.Drawing.Point(119, 84);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(556, 244);
            this.btPagar.TabIndex = 0;
            this.btPagar.Text = "REALIZAR PAGAMENTO";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // Screen_RealizarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btPagar);
            this.Name = "Screen_RealizarPagamento";
            this.Size = new System.Drawing.Size(835, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPagar;
    }
}
