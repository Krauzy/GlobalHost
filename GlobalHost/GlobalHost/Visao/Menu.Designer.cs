﻿using GlobalHost.Visao.Servicos.Funcoes;

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
            this.paneServ = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btRel = new System.Windows.Forms.Button();
            this.btFun = new System.Windows.Forms.Button();
            this.btGer = new System.Windows.Forms.Button();
            this.pnGerenciamento = new System.Windows.Forms.Panel();
            this.btTransportadora = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.btTipoTransporte = new System.Windows.Forms.Button();
            this.btTipoCarga = new System.Windows.Forms.Button();
            this.btRemessa = new System.Windows.Forms.Button();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.pnFuncoes = new System.Windows.Forms.Panel();
            this.btOrcamento = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btAbrirFrete = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btPedido = new System.Windows.Forms.Button();
            this.btDespesa = new System.Windows.Forms.Button();
            this.pnRelatorios = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scrAbrirFrete = new GlobalHost.Visao.Servicos.Funcoes.Screen_AbrirFrete();
            this.scrFuncionario = new GlobalHost.Visao.Servicos.Screen_Funcionarios();
            this.scrRemessa = new GlobalHost.Visao.Servicos.Gerencia.Screen_Remessa();
            this.scrPedido = new GlobalHost.Visao.Servicos.Funcoes.Screen_Pedido();
            this.scrTipo_Transporte = new GlobalHost.Visao.Servicos.ScreenTipo_Transporte();
            this.ScreenSobre = new GlobalHost.Visao.Sobre();
            this.ScreenCotacao = new GlobalHost.Visao.Cotacao();
            this.paneHome = new GlobalHost.Visao.PaneHome();
            this.scrOrcamento = new GlobalHost.Visao.Servicos.Funcoes.Screen_Orcamento();
            this.screen_Transportadora = new GlobalHost.Visao.Servicos.Screen_Transportadora();
            this.scrRealizarPagamento = new GlobalHost.Visao.Servicos.Funcoes.ScreenRealizarPagamento();
            this.screOrcamento = new GlobalHost.Visao.Servicos.Funcoes.Screen_Orcamento();
            this.scrPagamento = new GlobalHost.Visao.Servicos.Funcoes.ScreenRealizarPagamento();
            this.scrLancarDesp = new GlobalHost.Visao.Servicos.Funcoes.Screen_LancarDespesa();
            this.paneMenu.SuspendLayout();
            this.paneServ.SuspendLayout();
            this.pnGerenciamento.SuspendLayout();
            this.pnFuncoes.SuspendLayout();
            this.pnRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.brMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // paneServ
            // 
            this.paneServ.Controls.Add(this.btVoltar);
            this.paneServ.Controls.Add(this.btRel);
            this.paneServ.Controls.Add(this.btFun);
            this.paneServ.Controls.Add(this.btGer);
            this.paneServ.Location = new System.Drawing.Point(0, 99);
            this.paneServ.Name = "paneServ";
            this.paneServ.Size = new System.Drawing.Size(227, 490);
            this.paneServ.TabIndex = 4;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btVoltar.Location = new System.Drawing.Point(0, 180);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(225, 59);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btRel
            // 
            this.btRel.BackColor = System.Drawing.Color.Transparent;
            this.btRel.FlatAppearance.BorderSize = 0;
            this.btRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btRel.Location = new System.Drawing.Point(0, 120);
            this.btRel.Name = "btRel";
            this.btRel.Size = new System.Drawing.Size(225, 59);
            this.btRel.TabIndex = 2;
            this.btRel.Text = "RELATÓRIOS";
            this.btRel.UseVisualStyleBackColor = false;
            this.btRel.Click += new System.EventHandler(this.btRel_Click);
            // 
            // btFun
            // 
            this.btFun.BackColor = System.Drawing.Color.Transparent;
            this.btFun.FlatAppearance.BorderSize = 0;
            this.btFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btFun.Location = new System.Drawing.Point(0, 60);
            this.btFun.Name = "btFun";
            this.btFun.Size = new System.Drawing.Size(225, 59);
            this.btFun.TabIndex = 1;
            this.btFun.Text = "FUNÇÕES";
            this.btFun.UseVisualStyleBackColor = false;
            this.btFun.Click += new System.EventHandler(this.btFun_Click);
            // 
            // btGer
            // 
            this.btGer.BackColor = System.Drawing.Color.Transparent;
            this.btGer.FlatAppearance.BorderSize = 0;
            this.btGer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btGer.Location = new System.Drawing.Point(0, 0);
            this.btGer.Name = "btGer";
            this.btGer.Size = new System.Drawing.Size(225, 59);
            this.btGer.TabIndex = 0;
            this.btGer.Text = "GERENCIAMENTO";
            this.btGer.UseVisualStyleBackColor = false;
            this.btGer.Click += new System.EventHandler(this.btGer_Click);
            // 
            // pnGerenciamento
            // 
            this.pnGerenciamento.Controls.Add(this.btTransportadora);
            this.pnGerenciamento.Controls.Add(this.btCliente);
            this.pnGerenciamento.Controls.Add(this.btTipoTransporte);
            this.pnGerenciamento.Controls.Add(this.btTipoCarga);
            this.pnGerenciamento.Controls.Add(this.btRemessa);
            this.pnGerenciamento.Controls.Add(this.btFuncionario);
            this.pnGerenciamento.Location = new System.Drawing.Point(225, 27);
            this.pnGerenciamento.Name = "pnGerenciamento";
            this.pnGerenciamento.Size = new System.Drawing.Size(1031, 562);
            this.pnGerenciamento.TabIndex = 8;
            // 
            // btTransportadora
            // 
            this.btTransportadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btTransportadora.FlatAppearance.BorderSize = 0;
            this.btTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransportadora.ForeColor = System.Drawing.Color.White;
            this.btTransportadora.Location = new System.Drawing.Point(374, 103);
            this.btTransportadora.Name = "btTransportadora";
            this.btTransportadora.Size = new System.Drawing.Size(304, 115);
            this.btTransportadora.TabIndex = 5;
            this.btTransportadora.Text = "TRANSPORTADORA";
            this.btTransportadora.UseVisualStyleBackColor = false;
            this.btTransportadora.Click += new System.EventHandler(this.btTransportadora_Click);
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.ForeColor = System.Drawing.Color.White;
            this.btCliente.Location = new System.Drawing.Point(229, 103);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(139, 334);
            this.btCliente.TabIndex = 4;
            this.btCliente.Text = "CLIENTE";
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // btTipoTransporte
            // 
            this.btTipoTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btTipoTransporte.FlatAppearance.BorderSize = 0;
            this.btTipoTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTipoTransporte.ForeColor = System.Drawing.Color.White;
            this.btTipoTransporte.Location = new System.Drawing.Point(374, 224);
            this.btTipoTransporte.Name = "btTipoTransporte";
            this.btTipoTransporte.Size = new System.Drawing.Size(149, 111);
            this.btTipoTransporte.TabIndex = 3;
            this.btTipoTransporte.Text = "TIPO DE TRANSPORTE";
            this.btTipoTransporte.UseVisualStyleBackColor = false;
            this.btTipoTransporte.Click += new System.EventHandler(this.btTipoTransporte_Click);
            // 
            // btTipoCarga
            // 
            this.btTipoCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btTipoCarga.FlatAppearance.BorderSize = 0;
            this.btTipoCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTipoCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTipoCarga.ForeColor = System.Drawing.Color.White;
            this.btTipoCarga.Location = new System.Drawing.Point(529, 224);
            this.btTipoCarga.Name = "btTipoCarga";
            this.btTipoCarga.Size = new System.Drawing.Size(149, 111);
            this.btTipoCarga.TabIndex = 2;
            this.btTipoCarga.Text = "TIPO DE CARGA";
            this.btTipoCarga.UseVisualStyleBackColor = false;
            this.btTipoCarga.Click += new System.EventHandler(this.btTipoCarga_Click);
            // 
            // btRemessa
            // 
            this.btRemessa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btRemessa.FlatAppearance.BorderSize = 0;
            this.btRemessa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemessa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemessa.ForeColor = System.Drawing.Color.White;
            this.btRemessa.Location = new System.Drawing.Point(684, 103);
            this.btRemessa.Name = "btRemessa";
            this.btRemessa.Size = new System.Drawing.Size(149, 334);
            this.btRemessa.TabIndex = 1;
            this.btRemessa.Text = "REMESSA";
            this.btRemessa.UseVisualStyleBackColor = false;
            this.btRemessa.Click += new System.EventHandler(this.btRemessa_Click);
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btFuncionario.FlatAppearance.BorderSize = 0;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionario.ForeColor = System.Drawing.Color.White;
            this.btFuncionario.Location = new System.Drawing.Point(374, 341);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(304, 96);
            this.btFuncionario.TabIndex = 0;
            this.btFuncionario.Text = "FUNCIONÁRIO";
            this.btFuncionario.UseVisualStyleBackColor = false;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // pnFuncoes
            // 
            this.pnFuncoes.Controls.Add(this.btOrcamento);
            this.pnFuncoes.Controls.Add(this.button14);
            this.pnFuncoes.Controls.Add(this.button13);
            this.pnFuncoes.Controls.Add(this.btnPagamentos);
            this.pnFuncoes.Controls.Add(this.button10);
            this.pnFuncoes.Controls.Add(this.btAbrirFrete);
            this.pnFuncoes.Controls.Add(this.button8);
            this.pnFuncoes.Controls.Add(this.btPedido);
            this.pnFuncoes.Controls.Add(this.btDespesa);
            this.pnFuncoes.Location = new System.Drawing.Point(225, 27);
            this.pnFuncoes.Name = "pnFuncoes";
            this.pnFuncoes.Size = new System.Drawing.Size(1031, 562);
            this.pnFuncoes.TabIndex = 10;
            // 
            // btOrcamento
            // 
            this.btOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btOrcamento.FlatAppearance.BorderSize = 0;
            this.btOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrcamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrcamento.ForeColor = System.Drawing.Color.White;
            this.btOrcamento.Location = new System.Drawing.Point(320, 326);
            this.btOrcamento.Name = "btOrcamento";
            this.btOrcamento.Size = new System.Drawing.Size(113, 98);
            this.btOrcamento.TabIndex = 8;
            this.btOrcamento.Text = "Orçamento";
            this.btOrcamento.UseVisualStyleBackColor = false;
            this.btOrcamento.Click += new System.EventHandler(this.btOrcamento_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(439, 326);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(274, 98);
            this.button14.TabIndex = 7;
            this.button14.Text = "Controle de Transporte";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(201, 101);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(232, 98);
            this.button13.TabIndex = 6;
            this.button13.Text = "Recebimentos";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPagamentos.FlatAppearance.BorderSize = 0;
            this.btnPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentos.ForeColor = System.Drawing.Color.White;
            this.btnPagamentos.Location = new System.Drawing.Point(719, 270);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(119, 154);
            this.btnPagamentos.TabIndex = 5;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.UseVisualStyleBackColor = false;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(579, 101);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(134, 219);
            this.button10.TabIndex = 3;
            this.button10.Text = "Fechar Frete";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btAbrirFrete
            // 
            this.btAbrirFrete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btAbrirFrete.FlatAppearance.BorderSize = 0;
            this.btAbrirFrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirFrete.ForeColor = System.Drawing.Color.White;
            this.btAbrirFrete.Location = new System.Drawing.Point(439, 101);
            this.btAbrirFrete.Name = "btAbrirFrete";
            this.btAbrirFrete.Size = new System.Drawing.Size(134, 219);
            this.btAbrirFrete.TabIndex = 2;
            this.btAbrirFrete.Text = "Abrir Frete";
            this.btAbrirFrete.UseVisualStyleBackColor = false;
            this.btAbrirFrete.Click += new System.EventHandler(this.btAbrirFrete_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(320, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 115);
            this.button8.TabIndex = 1;
            this.button8.Text = "Autorização";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btPedido
            // 
            this.btPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btPedido.FlatAppearance.BorderSize = 0;
            this.btPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPedido.ForeColor = System.Drawing.Color.White;
            this.btPedido.Location = new System.Drawing.Point(201, 205);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(113, 219);
            this.btPedido.TabIndex = 0;
            this.btPedido.Text = "Pedido";
            this.btPedido.UseVisualStyleBackColor = false;
            this.btPedido.Click += new System.EventHandler(this.btPedido_Click);
            // 
            // btDespesa
            // 
            this.btDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btDespesa.FlatAppearance.BorderSize = 0;
            this.btDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDespesa.ForeColor = System.Drawing.Color.White;
            this.btDespesa.Location = new System.Drawing.Point(719, 101);
            this.btDespesa.Name = "btDespesa";
            this.btDespesa.Size = new System.Drawing.Size(119, 163);
            this.btDespesa.TabIndex = 4;
            this.btDespesa.Text = "Despesas";
            this.btDespesa.UseVisualStyleBackColor = false;
            this.btDespesa.Click += new System.EventHandler(this.btDespesa_Click);
            // 
            // pnRelatorios
            // 
            this.pnRelatorios.Controls.Add(this.button17);
            this.pnRelatorios.Controls.Add(this.button16);
            this.pnRelatorios.Controls.Add(this.button19);
            this.pnRelatorios.Controls.Add(this.button18);
            this.pnRelatorios.Controls.Add(this.button15);
            this.pnRelatorios.Location = new System.Drawing.Point(225, 27);
            this.pnRelatorios.Name = "pnRelatorios";
            this.pnRelatorios.Size = new System.Drawing.Size(1031, 562);
            this.pnRelatorios.TabIndex = 11;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(430, 115);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(303, 98);
            this.button17.TabIndex = 2;
            this.button17.Text = "TRANSPORTE";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(430, 326);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(303, 108);
            this.button16.TabIndex = 1;
            this.button16.Text = "CARGA";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(430, 219);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(143, 101);
            this.button19.TabIndex = 0;
            this.button19.Text = "FUNCIONÁRIO";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(579, 219);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(154, 101);
            this.button18.TabIndex = 0;
            this.button18.Text = "CLIENTE";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(273, 115);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(151, 319);
            this.button15.TabIndex = 0;
            this.button15.Text = "REMESSA";
            this.button15.UseVisualStyleBackColor = false;
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
            // scrAbrirFrete
            // 
            this.scrAbrirFrete.BackColor = System.Drawing.Color.White;
            this.scrAbrirFrete.Location = new System.Drawing.Point(225, 27);
            this.scrAbrirFrete.Margin = new System.Windows.Forms.Padding(2);
            this.scrAbrirFrete.Name = "scrAbrirFrete";
            this.scrAbrirFrete.Size = new System.Drawing.Size(1031, 562);
            this.scrAbrirFrete.TabIndex = 24;
            // 
            // scrFuncionario
            // 
            this.scrFuncionario.BackColor = System.Drawing.Color.White;
            this.scrFuncionario.Location = new System.Drawing.Point(225, 27);
            this.scrFuncionario.Name = "scrFuncionario";
            this.scrFuncionario.Size = new System.Drawing.Size(1031, 562);
            this.scrFuncionario.TabIndex = 14;
            // 
            // scrRemessa
            // 
            this.scrRemessa.BackColor = System.Drawing.Color.White;
            this.scrRemessa.Location = new System.Drawing.Point(225, 27);
            this.scrRemessa.Name = "scrRemessa";
            this.scrRemessa.Size = new System.Drawing.Size(1031, 562);
            this.scrRemessa.TabIndex = 17;
            // 
            // scrPedido
            // 
            this.scrPedido.BackColor = System.Drawing.Color.White;
            this.scrPedido.Location = new System.Drawing.Point(225, 27);
            this.scrPedido.Name = "scrPedido";
            this.scrPedido.Size = new System.Drawing.Size(1031, 562);
            this.scrPedido.TabIndex = 16;
            // 
            // scrTipo_Transporte
            // 
            this.scrTipo_Transporte.BackColor = System.Drawing.Color.White;
            this.scrTipo_Transporte.Location = new System.Drawing.Point(225, 27);
            this.scrTipo_Transporte.Name = "scrTipo_Transporte";
            this.scrTipo_Transporte.Size = new System.Drawing.Size(1031, 562);
            this.scrTipo_Transporte.TabIndex = 13;
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
            // paneHome
            // 
            this.paneHome.BackColor = System.Drawing.Color.White;
            this.paneHome.Location = new System.Drawing.Point(225, 27);
            this.paneHome.Name = "paneHome";
            this.paneHome.Size = new System.Drawing.Size(1031, 562);
            this.paneHome.TabIndex = 18;
            // 
            // scrOrcamento
            // 
            this.scrOrcamento.BackColor = System.Drawing.Color.White;
            this.scrOrcamento.Location = new System.Drawing.Point(225, 27);
            this.scrOrcamento.Name = "scrOrcamento";
            this.scrOrcamento.Size = new System.Drawing.Size(1031, 562);
            this.scrOrcamento.TabIndex = 20;
            // 
            // screen_Transportadora
            // 
            this.screen_Transportadora.BackColor = System.Drawing.Color.White;
            this.screen_Transportadora.Location = new System.Drawing.Point(225, 27);
            this.screen_Transportadora.Name = "screen_Transportadora";
            this.screen_Transportadora.Size = new System.Drawing.Size(1031, 562);
            this.screen_Transportadora.TabIndex = 19;
            // 
            // scrRealizarPagamento
            // 
            this.scrRealizarPagamento.BackColor = System.Drawing.Color.White;
            this.scrRealizarPagamento.Location = new System.Drawing.Point(225, 27);
            this.scrRealizarPagamento.Name = "scrRealizarPagamento";
            this.scrRealizarPagamento.Size = new System.Drawing.Size(1031, 562);
            this.scrRealizarPagamento.TabIndex = 18;
            // 
            // screOrcamento
            // 
            this.screOrcamento.BackColor = System.Drawing.Color.White;
            this.screOrcamento.Location = new System.Drawing.Point(225, 27);
            this.screOrcamento.Name = "screOrcamento";
            this.screOrcamento.Size = new System.Drawing.Size(1031, 562);
            this.screOrcamento.TabIndex = 21;
            // 
            // scrPagamento
            // 
            this.scrPagamento.Location = new System.Drawing.Point(225, 27);
            this.scrPagamento.Name = "scrPagamento";
            this.scrPagamento.Size = new System.Drawing.Size(1031, 562);
            this.scrPagamento.TabIndex = 22;
            // 
            // scrLancarDesp
            // 
            this.scrLancarDesp.Location = new System.Drawing.Point(225, 27);
            this.scrLancarDesp.Name = "scrLancarDesp";
            this.scrLancarDesp.Size = new System.Drawing.Size(1031, 562);
            this.scrLancarDesp.TabIndex = 23;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 590);
            this.Controls.Add(this.brMinimize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paneServ);
            this.Controls.Add(this.paneMenu);
            this.Controls.Add(this.pnFuncoes);
            this.Controls.Add(this.pnRelatorios);
            this.Controls.Add(this.scrFuncionario);
            this.Controls.Add(this.scrRemessa);
            this.Controls.Add(this.scrPedido);
            this.Controls.Add(this.scrTipo_Transporte);
            this.Controls.Add(this.ScreenSobre);
            this.Controls.Add(this.ScreenCotacao);
            this.Controls.Add(this.paneHome);
            this.Controls.Add(this.scrOrcamento);
            this.Controls.Add(this.screen_Transportadora);
            this.Controls.Add(this.scrRealizarPagamento);
            this.Controls.Add(this.pnGerenciamento);
            this.Controls.Add(this.screOrcamento);
            this.Controls.Add(this.scrPagamento);
            this.Controls.Add(this.scrLancarDesp);
            this.Controls.Add(this.scrAbrirFrete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.paneMenu.ResumeLayout(false);
            this.paneServ.ResumeLayout(false);
            this.pnGerenciamento.ResumeLayout(false);
            this.pnFuncoes.ResumeLayout(false);
            this.pnRelatorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel paneServ;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btRel;
        private System.Windows.Forms.Button btFun;
        private System.Windows.Forms.Button btGer;
        private System.Windows.Forms.Panel pnGerenciamento;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.Button btTransportadora;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btTipoTransporte;
        private System.Windows.Forms.Button btTipoCarga;
        private System.Windows.Forms.Button btRemessa;
        private System.Windows.Forms.Panel pnFuncoes;
        private System.Windows.Forms.Button btPedido;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Button btDespesa;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btAbrirFrete;
        private System.Windows.Forms.Panel pnRelatorios;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private Servicos.ScreenTipo_Transporte scrTipo_Transporte;
        private Servicos.Screen_Funcionarios scrFuncionario;
        private Servicos.Funcoes.Screen_Pedido scrPedido;
        private Servicos.Gerencia.Screen_Remessa scrRemessa;
        private Servicos.Funcoes.ScreenRealizarPagamento scrRealizarPagamento;
        private PaneHome paneHome;
        private Servicos.Screen_Transportadora screen_Transportadora;
        private Servicos.Funcoes.Screen_Orcamento scrOrcamento;
        private System.Windows.Forms.Button btOrcamento;
        private Screen_Orcamento screOrcamento;
        private ScreenRealizarPagamento scrPagamento;
        private Screen_LancarDespesa scrLancarDesp;
        private Screen_AbrirFrete scrAbrirFrete;
    }
}