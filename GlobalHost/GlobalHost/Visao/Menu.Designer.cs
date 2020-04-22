namespace GlobalHost.Visao
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.paneMenu = new System.Windows.Forms.Panel();
            this.btSobre = new System.Windows.Forms.Button();
            this.btCot = new System.Windows.Forms.Button();
            this.btServ = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.brMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScreenSobre = new GlobalHost.Visao.Sobre();
            this.ScreenCotacao = new GlobalHost.Visao.Cotacao();
            this.pnHome = new GlobalHost.Visao.PaneHome();
            this.paneServ = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.paneMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneServ.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneMenu
            // 
            this.paneMenu.Controls.Add(this.btSobre);
            this.paneMenu.Controls.Add(this.btCot);
            this.paneMenu.Controls.Add(this.btServ);
            this.paneMenu.Controls.Add(this.btHome);
            this.paneMenu.Location = new System.Drawing.Point(0, 99);
            this.paneMenu.Name = "paneMenu";
            this.paneMenu.Size = new System.Drawing.Size(227, 490);
            this.paneMenu.TabIndex = 1;
            // 
            // btSobre
            // 
            this.btSobre.BackColor = System.Drawing.Color.Transparent;
            this.btSobre.FlatAppearance.BorderSize = 0;
            this.btSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSobre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btSobre.Location = new System.Drawing.Point(0, 180);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(225, 59);
            this.btSobre.TabIndex = 3;
            this.btSobre.Text = "SOBRE NÓS";
            this.btSobre.UseVisualStyleBackColor = false;
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // btCot
            // 
            this.btCot.BackColor = System.Drawing.Color.Transparent;
            this.btCot.FlatAppearance.BorderSize = 0;
            this.btCot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btCot.Location = new System.Drawing.Point(0, 120);
            this.btCot.Name = "btCot";
            this.btCot.Size = new System.Drawing.Size(225, 59);
            this.btCot.TabIndex = 2;
            this.btCot.Text = "COTAÇÃO";
            this.btCot.UseVisualStyleBackColor = false;
            this.btCot.Click += new System.EventHandler(this.btCot_Click);
            // 
            // btServ
            // 
            this.btServ.BackColor = System.Drawing.Color.Transparent;
            this.btServ.FlatAppearance.BorderSize = 0;
            this.btServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btServ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btServ.Location = new System.Drawing.Point(0, 60);
            this.btServ.Name = "btServ";
            this.btServ.Size = new System.Drawing.Size(225, 59);
            this.btServ.TabIndex = 1;
            this.btServ.Text = "SERVIÇOS";
            this.btServ.UseVisualStyleBackColor = false;
            this.btServ.Click += new System.EventHandler(this.btServ_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.Transparent;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(225, 59);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "PÁGINA INICIAL";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(1218, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(38, 27);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "✕";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            // 
            // brMinimize
            // 
            this.brMinimize.BackColor = System.Drawing.Color.White;
            this.brMinimize.FlatAppearance.BorderSize = 0;
            this.brMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brMinimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brMinimize.ForeColor = System.Drawing.Color.Black;
            this.brMinimize.Location = new System.Drawing.Point(1180, 0);
            this.brMinimize.Name = "brMinimize";
            this.brMinimize.Size = new System.Drawing.Size(38, 27);
            this.brMinimize.TabIndex = 4;
            this.brMinimize.Text = "—";
            this.brMinimize.UseVisualStyleBackColor = false;
            this.brMinimize.Click += new System.EventHandler(this.brMinimize_Click);
            this.brMinimize.MouseEnter += new System.EventHandler(this.brMinimize_MouseEnter);
            this.brMinimize.MouseLeave += new System.EventHandler(this.brMinimize_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::GlobalHost.Properties.Resources.logo_cgf_200x47;
            this.pictureBox1.Location = new System.Drawing.Point(15, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ScreenSobre
            // 
            this.ScreenSobre.BackColor = System.Drawing.Color.White;
            this.ScreenSobre.Location = new System.Drawing.Point(225, 27);
            this.ScreenSobre.Name = "ScreenSobre";
            this.ScreenSobre.Size = new System.Drawing.Size(1031, 562);
            this.ScreenSobre.TabIndex = 6;
            // 
            // ScreenCotacao
            // 
            this.ScreenCotacao.BackColor = System.Drawing.Color.White;
            this.ScreenCotacao.Location = new System.Drawing.Point(225, 27);
            this.ScreenCotacao.Name = "ScreenCotacao";
            this.ScreenCotacao.Size = new System.Drawing.Size(1031, 562);
            this.ScreenCotacao.TabIndex = 5;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.White;
            this.pnHome.Location = new System.Drawing.Point(225, 27);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(1031, 562);
            this.pnHome.TabIndex = 7;
            // 
            // paneServ
            // 
            this.paneServ.Controls.Add(this.button1);
            this.paneServ.Controls.Add(this.button2);
            this.paneServ.Controls.Add(this.button3);
            this.paneServ.Controls.Add(this.bt);
            this.paneServ.Location = new System.Drawing.Point(0, 99);
            this.paneServ.Name = "paneServ";
            this.paneServ.Size = new System.Drawing.Size(227, 490);
            this.paneServ.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.Location = new System.Drawing.Point(0, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "SERVIÇO 4";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "SERVIÇO 3";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.Location = new System.Drawing.Point(0, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 59);
            this.button3.TabIndex = 1;
            this.button3.Text = "SERVIÇO 2";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.Transparent;
            this.bt.FlatAppearance.BorderSize = 0;
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bt.Location = new System.Drawing.Point(0, 0);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(225, 59);
            this.bt.TabIndex = 0;
            this.bt.Text = "SERVIÇO 1";
            this.bt.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 590);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.ScreenSobre);
            this.Controls.Add(this.ScreenCotacao);
            this.Controls.Add(this.brMinimize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paneServ);
            this.Controls.Add(this.paneMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.paneMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneServ.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paneMenu;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button brMinimize;
        private System.Windows.Forms.Button btSobre;
        private System.Windows.Forms.Button btCot;
        private System.Windows.Forms.Button btServ;
        private System.Windows.Forms.Button btHome;
        private Cotacao ScreenCotacao;
        private Sobre ScreenSobre;
        private PaneHome pnHome;
        private System.Windows.Forms.Panel paneServ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt;
    }
}