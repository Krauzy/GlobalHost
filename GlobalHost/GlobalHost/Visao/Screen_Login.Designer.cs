namespace GlobalHost.Visao
{
    partial class Screen_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.linkFrgtPass = new System.Windows.Forms.LinkLabel();
            this.btEye = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.PopUp = new System.Windows.Forms.NotifyIcon(this.components);
            this.LittleMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itFechar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.LittleMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUsuario.Location = new System.Drawing.Point(81, 229);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtUsuario.Size = new System.Drawing.Size(176, 23);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.Text = "Usuário";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BeepOnError = true;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSenha.HidePromptOnLeave = true;
            this.txtSenha.Location = new System.Drawing.Point(81, 270);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(176, 23);
            this.txtSenha.TabIndex = 16;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // linkFrgtPass
            // 
            this.linkFrgtPass.AutoSize = true;
            this.linkFrgtPass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFrgtPass.Location = new System.Drawing.Point(111, 358);
            this.linkFrgtPass.Name = "linkFrgtPass";
            this.linkFrgtPass.Size = new System.Drawing.Size(125, 16);
            this.linkFrgtPass.TabIndex = 17;
            this.linkFrgtPass.TabStop = true;
            this.linkFrgtPass.Text = "Esqueci Minha Senha";
            this.linkFrgtPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFrgtPass_LinkClicked);
            // 
            // btEye
            // 
            this.btEye.FlatAppearance.BorderSize = 0;
            this.btEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEye.Image = global::GlobalHost.Properties.Resources.icons8_visível_18;
            this.btEye.Location = new System.Drawing.Point(264, 269);
            this.btEye.Name = "btEye";
            this.btEye.Size = new System.Drawing.Size(27, 23);
            this.btEye.TabIndex = 18;
            this.btEye.UseVisualStyleBackColor = true;
            this.btEye.Click += new System.EventHandler(this.btEye_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GlobalHost.Properties.Resources.user100;
            this.pictureBox2.Location = new System.Drawing.Point(124, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 98);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox.Image = global::GlobalHost.Properties.Resources.logo_cgf_200x47;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(124, 42);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // btEntrar
            // 
            this.btEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btEntrar.Location = new System.Drawing.Point(124, 308);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(100, 35);
            this.btEntrar.TabIndex = 19;
            this.btEntrar.Text = "ENTRAR";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(321, -1);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(38, 27);
            this.btClose.TabIndex = 20;
            this.btClose.Text = "✕";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            // 
            // PopUp
            // 
            this.PopUp.Icon = ((System.Drawing.Icon)(resources.GetObject("PopUp.Icon")));
            this.PopUp.Text = "Global Host";
            this.PopUp.Visible = true;
            // 
            // LittleMenu
            // 
            this.LittleMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itFechar});
            this.LittleMenu.Name = "LittleMenu";
            this.LittleMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // itFechar
            // 
            this.itFechar.Name = "itFechar";
            this.itFechar.Size = new System.Drawing.Size(180, 22);
            this.itFechar.Text = "Fechar";
            this.itFechar.Click += new System.EventHandler(this.itFechar_Click);
            // 
            // Screen_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.btEye);
            this.Controls.Add(this.linkFrgtPass);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scree_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.LittleMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.LinkLabel linkFrgtPass;
        private System.Windows.Forms.Button btEye;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.NotifyIcon PopUp;
        private System.Windows.Forms.ContextMenuStrip LittleMenu;
        private System.Windows.Forms.ToolStripMenuItem itFechar;
    }
}