namespace GlobalHost.Visao.Servicos
{
    partial class CEPTool
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
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCEP
            // 
            this.txtCEP.BeepOnError = true;
            this.txtCEP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCEP.HidePromptOnLeave = true;
            this.txtCEP.Location = new System.Drawing.Point(56, 12);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(77, 23);
            this.txtCEP.TabIndex = 48;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Logradouro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "CEP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 173);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(433, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(302, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(60, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(100, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "*";
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUF.Location = new System.Drawing.Point(416, 123);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(61, 23);
            this.txtUF.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(413, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCidade.Location = new System.Drawing.Point(250, 123);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(133, 23);
            this.txtCidade.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(247, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBairro.Location = new System.Drawing.Point(21, 123);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(194, 23);
            this.txtBairro.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Bairro:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNum.Location = new System.Drawing.Point(416, 54);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(61, 23);
            this.txtNum.TabIndex = 53;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(413, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Número:";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtLog.Location = new System.Drawing.Point(21, 54);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(362, 23);
            this.txtLog.TabIndex = 51;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btOK.Location = new System.Drawing.Point(435, 244);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(84, 29);
            this.btOK.TabIndex = 54;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btCancelar.Location = new System.Drawing.Point(343, 244);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(84, 29);
            this.btCancelar.TabIndex = 55;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(21, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 12);
            this.label11.TabIndex = 63;
            this.label11.Text = "* Campos obrigatórios";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Afeganistão",
            "África do Sul",
            "Akrotiri",
            "Albânia",
            "Alemanha",
            "Andorra",
            "Angola",
            "Anguila",
            "Antárctida",
            "Antígua e Barbuda",
            "Arábia Saudita",
            "Arctic Ocean",
            "Argélia",
            "Argentina",
            "Arménia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Austrália",
            "Áustria",
            "Azerbaijão",
            "Baamas",
            "Bangladeche",
            "Barbados",
            "Barém",
            "Bélgica",
            "Belize",
            "Benim",
            "Bermudas",
            "Bielorrússia",
            "Birmânia",
            "Bolívia",
            "Bósnia e Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunei",
            "Bulgária",
            "Burquina Faso",
            "Burúndi",
            "Butão",
            "Cabo Verde",
            "Camarões",
            "Camboja",
            "Canadá",
            "Catar",
            "Cazaquistão",
            "Chade",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colômbia",
            "Comores",
            "Congo-Brazzaville",
            "Congo-Kinshasa",
            "Coral Sea Islands",
            "Coreia do Norte",
            "Coreia do Sul",
            "Costa do Marfim",
            "Costa Rica",
            "Croácia",
            "Cuba",
            "Curacao",
            "Dhekelia",
            "Dinamarca",
            "Domínica",
            "Egipto",
            "Emiratos Árabes Unidos",
            "Equador",
            "Eritreia",
            "Eslováquia",
            "Eslovénia",
            "Espanha",
            "Estados Unidos",
            "Estónia",
            "Etiópia",
            "Faroé",
            "Fiji",
            "Filipinas",
            "Finlândia",
            "França",
            "Gabão",
            "Gâmbia",
            "Gana",
            "Gaza Strip",
            "Geórgia",
            "Geórgia do Sul e Sandwich do Sul",
            "Gibraltar",
            "Granada",
            "Grécia",
            "Gronelândia",
            "Guame",
            "Guatemala",
            "Guernsey",
            "Guiana",
            "Guiné",
            "Guiné Equatorial",
            "Guiné-Bissau",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "Iémen",
            "Ilha Bouvet",
            "Ilha do Natal",
            "Ilha Norfolk",
            "Ilhas Caimão",
            "Ilhas Cook",
            "Ilhas dos Cocos",
            "Ilhas Falkland",
            "Ilhas Heard e McDonald",
            "Ilhas Marshall",
            "Ilhas Salomão",
            "Ilhas Turcas e Caicos",
            "Ilhas Virgens Americanas",
            "Ilhas Virgens Britânicas",
            "Índia",
            "Indian Ocean",
            "Indonésia",
            "Irão",
            "Iraque",
            "Irlanda",
            "Islândia",
            "Israel",
            "Itália",
            "Jamaica",
            "Jan Mayen",
            "Japão",
            "Jersey",
            "Jibuti",
            "Jordânia",
            "Kosovo",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letónia",
            "Líbano",
            "Libéria",
            "Líbia",
            "Listenstaine",
            "Lituânia",
            "Luxemburgo",
            "Macau",
            "Macedónia",
            "Madagáscar",
            "Malásia",
            "Malávi",
            "Maldivas",
            "Mali",
            "Malta",
            "Man, Isle of",
            "Marianas do Norte",
            "Marrocos",
            "Maurícia",
            "Mauritânia",
            "México",
            "Micronésia",
            "Moçambique",
            "Moldávia",
            "Mónaco",
            "Mongólia",
            "Monserrate",
            "Montenegro",
            "Mundo",
            "Namíbia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicarágua",
            "Níger",
            "Nigéria",
            "Niue",
            "Noruega",
            "Nova Caledónia",
            "Nova Zelândia",
            "Omã",
            "Pacific Ocean",
            "Países Baixos",
            "Palau",
            "Panamá",
            "Papua-Nova Guiné",
            "Paquistão",
            "Paracel Islands",
            "Paraguai",
            "Peru",
            "Pitcairn",
            "Polinésia Francesa",
            "Polónia",
            "Porto Rico",
            "Portugal",
            "Quénia",
            "Quirguizistão",
            "Quiribáti",
            "Reino Unido",
            "República Centro-Africana",
            "República Dominicana",
            "Roménia",
            "Ruanda",
            "Rússia",
            "Salvador",
            "Samoa",
            "Samoa Americana",
            "Santa Helena",
            "Santa Lúcia",
            "São Bartolomeu",
            "São Cristóvão e Neves",
            "São Marinho",
            "São Martinho",
            "São Pedro e Miquelon",
            "São Tomé e Príncipe",
            "São Vicente e Granadinas",
            "Sara Ocidental",
            "Seicheles",
            "Senegal",
            "Serra Leoa",
            "Sérvia",
            "Singapura",
            "Sint Maarten",
            "Síria",
            "Somália",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanca",
            "Suazilândia",
            "Sudão",
            "Sudão do Sul",
            "Suécia",
            "Suíça",
            "Suriname",
            "Svalbard e Jan Mayen",
            "Tailândia",
            "Taiwan",
            "Tajiquistão",
            "Tanzânia",
            "Território Britânico do Oceano Índico",
            "Territórios Austrais Franceses",
            "Timor Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trindade e Tobago",
            "Tunísia",
            "Turquemenistão",
            "Turquia",
            "Tuvalu",
            "Ucrânia",
            "Uganda",
            "Uruguai",
            "Usbequistão",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietname",
            "Wake Island",
            "Wallis e Futuna",
            "West Bank",
            "Zâmbia",
            "Zimbabué"});
            this.cbPais.Location = new System.Drawing.Point(397, 15);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(122, 25);
            this.cbPais.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(355, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "País:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(386, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "*";
            // 
            // CEPTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 282);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCEP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CEPTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}