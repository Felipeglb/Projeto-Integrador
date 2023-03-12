namespace ProjetoIntegrador
{
    partial class CadUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            label1 = new Label();
            cboStatus = new ComboBox();
            label3 = new Label();
            btoPesquisa = new Button();
            label4 = new Label();
            mtbCPF = new MaskedTextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtLogin = new TextBox();
            label7 = new Label();
            cboIDdepart = new ComboBox();
            label8 = new Label();
            txtBairro = new TextBox();
            label9 = new Label();
            txtLogradouro = new TextBox();
            label10 = new Label();
            txtCity = new TextBox();
            cboUF = new ComboBox();
            label11 = new Label();
            label14 = new Label();
            mtbTel1 = new MaskedTextBox();
            mtbTel2 = new MaskedTextBox();
            label15 = new Label();
            groupBox1 = new GroupBox();
            label17 = new Label();
            mtbDataC = new MaskedTextBox();
            groupBox2 = new GroupBox();
            cboDepart = new ComboBox();
            label12 = new Label();
            label20 = new Label();
            txtSenha = new TextBox();
            label19 = new Label();
            txtEmail = new TextBox();
            label18 = new Label();
            txtComple = new TextBox();
            label13 = new Label();
            txtNumero = new TextBox();
            label6 = new Label();
            mtbCEP = new MaskedTextBox();
            groupBox3 = new GroupBox();
            label21 = new Label();
            txtObs = new TextBox();
            groupBox4 = new GroupBox();
            btoExcluir = new Button();
            btoLimpar = new Button();
            btoCadastro = new Button();
            btoAlterar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(5, 42);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(113, 29);
            txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(902, 49);
            cboStatus.Margin = new Padding(4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(139, 29);
            cboStatus.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(902, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // btoPesquisa
            // 
            btoPesquisa.Location = new Point(126, 39);
            btoPesquisa.Margin = new Padding(4);
            btoPesquisa.Name = "btoPesquisa";
            btoPesquisa.Size = new Size(96, 32);
            btoPesquisa.TabIndex = 1;
            btoPesquisa.Text = "&Pesquisar";
            btoPesquisa.UseVisualStyleBackColor = true;
            btoPesquisa.Click += btoPesquisa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(738, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 8;
            label4.Text = "CPF";
            // 
            // mtbCPF
            // 
            mtbCPF.Location = new Point(738, 49);
            mtbCPF.Margin = new Padding(4);
            mtbCPF.Mask = "___.___.___-__";
            mtbCPF.Name = "mtbCPF";
            mtbCPF.Size = new Size(156, 29);
            mtbCPF.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(8, 49);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(355, 29);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(230, 207);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 11;
            label5.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(230, 231);
            txtLogin.Margin = new Padding(4);
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '*';
            txtLogin.Size = new Size(187, 29);
            txtLogin.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 207);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 14;
            label7.Text = "ID Depart.";
            // 
            // cboIDdepart
            // 
            cboIDdepart.FormattingEnabled = true;
            cboIDdepart.Location = new Point(8, 232);
            cboIDdepart.Margin = new Padding(4);
            cboIDdepart.Name = "cboIDdepart";
            cboIDdepart.Size = new Size(76, 29);
            cboIDdepart.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(708, 91);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 19;
            label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(708, 116);
            txtBairro.Margin = new Padding(4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(186, 29);
            txtBairro.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 85);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(92, 21);
            label9.TabIndex = 17;
            label9.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(8, 116);
            txtLogradouro.Margin = new Padding(4);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(355, 29);
            txtLogradouro.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(8, 149);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 21;
            label10.Text = "Cidade";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(8, 174);
            txtCity.Margin = new Padding(4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(260, 29);
            txtCity.TabIndex = 11;
            // 
            // cboUF
            // 
            cboUF.FormattingEnabled = true;
            cboUF.Location = new Point(276, 174);
            cboUF.Margin = new Padding(4);
            cboUF.Name = "cboUF";
            cboUF.Size = new Size(87, 29);
            cboUF.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(276, 150);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(26, 19);
            label11.TabIndex = 23;
            label11.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(371, 148);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(76, 21);
            label14.TabIndex = 28;
            label14.Text = "Telefone1";
            // 
            // mtbTel1
            // 
            mtbTel1.Location = new Point(371, 173);
            mtbTel1.Margin = new Padding(4);
            mtbTel1.Mask = "(__)_____-____";
            mtbTel1.Name = "mtbTel1";
            mtbTel1.Size = new Size(166, 29);
            mtbTel1.TabIndex = 13;
            // 
            // mtbTel2
            // 
            mtbTel2.Location = new Point(545, 174);
            mtbTel2.Margin = new Padding(4);
            mtbTel2.Mask = "(__)_____-____";
            mtbTel2.Name = "mtbTel2";
            mtbTel2.Size = new Size(156, 29);
            mtbTel2.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(543, 148);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(76, 21);
            label15.TabIndex = 30;
            label15.Text = "Telefone2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(mtbDataC);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btoPesquisa);
            groupBox1.Location = new Point(15, 10);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1051, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(902, 17);
            label17.Name = "label17";
            label17.Size = new Size(129, 21);
            label17.TabIndex = 8;
            label17.Text = "Data de Cadastro";
            // 
            // mtbDataC
            // 
            mtbDataC.Enabled = false;
            mtbDataC.Location = new Point(902, 45);
            mtbDataC.Mask = "00/00/0000 90:00";
            mtbDataC.Name = "mtbDataC";
            mtbDataC.Size = new Size(139, 29);
            mtbDataC.TabIndex = 7;
            mtbDataC.ValidatingType = typeof(DateTime);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboDepart);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cboIDdepart);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(txtSenha);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(txtComple);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLogin);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(mtbCEP);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cboUF);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(mtbCPF);
            groupBox2.Controls.Add(mtbTel2);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(mtbTel1);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtLogradouro);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(15, 104);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1051, 276);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // cboDepart
            // 
            cboDepart.FormattingEnabled = true;
            cboDepart.Location = new Point(91, 231);
            cboDepart.Name = "cboDepart";
            cboDepart.Size = new Size(132, 29);
            cboDepart.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(95, 207);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(110, 21);
            label12.TabIndex = 25;
            label12.Text = "Departamento";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(425, 207);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(53, 21);
            label20.TabIndex = 44;
            label20.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(425, 231);
            txtSenha.Margin = new Padding(4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(217, 29);
            txtSenha.TabIndex = 20;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(708, 147);
            label19.Name = "label19";
            label19.Size = new Size(54, 21);
            label19.TabIndex = 42;
            label19.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(708, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 29);
            txtEmail.TabIndex = 15;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(463, 92);
            label18.Name = "label18";
            label18.Size = new Size(109, 21);
            label18.TabIndex = 40;
            label18.Text = "Complemento";
            // 
            // txtComple
            // 
            txtComple.Location = new Point(463, 116);
            txtComple.Name = "txtComple";
            txtComple.Size = new Size(238, 29);
            txtComple.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(371, 92);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(29, 21);
            label13.TabIndex = 37;
            label13.Text = "Nº";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(371, 116);
            txtNumero.Margin = new Padding(4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(85, 29);
            txtNumero.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(902, 92);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 21);
            label6.TabIndex = 35;
            label6.Text = "CEP";
            // 
            // mtbCEP
            // 
            mtbCEP.Location = new Point(902, 116);
            mtbCEP.Margin = new Padding(4);
            mtbCEP.Mask = "_____-___";
            mtbCEP.Name = "mtbCEP";
            mtbCEP.Size = new Size(139, 29);
            mtbCEP.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(txtObs);
            groupBox3.Location = new Point(15, 388);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(1051, 141);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 19);
            label21.Name = "label21";
            label21.Size = new Size(92, 21);
            label21.TabIndex = 1;
            label21.Text = "Observação";
            // 
            // txtObs
            // 
            txtObs.Location = new Point(8, 43);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(1033, 85);
            txtObs.TabIndex = 21;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btoExcluir);
            groupBox4.Controls.Add(btoLimpar);
            groupBox4.Controls.Add(btoCadastro);
            groupBox4.Controls.Add(btoAlterar);
            groupBox4.Location = new Point(15, 537);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(1051, 70);
            groupBox4.TabIndex = 37;
            groupBox4.TabStop = false;
            // 
            // btoExcluir
            // 
            btoExcluir.Location = new Point(947, 17);
            btoExcluir.Margin = new Padding(4);
            btoExcluir.Name = "btoExcluir";
            btoExcluir.Size = new Size(94, 40);
            btoExcluir.TabIndex = 25;
            btoExcluir.Text = "&Excluir";
            btoExcluir.UseVisualStyleBackColor = true;
            // 
            // btoLimpar
            // 
            btoLimpar.Location = new Point(845, 17);
            btoLimpar.Margin = new Padding(4);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(94, 40);
            btoLimpar.TabIndex = 24;
            btoLimpar.Text = "&Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            btoLimpar.Click += btoLimpar_Click;
            // 
            // btoCadastro
            // 
            btoCadastro.Location = new Point(641, 17);
            btoCadastro.Margin = new Padding(4);
            btoCadastro.Name = "btoCadastro";
            btoCadastro.Size = new Size(94, 40);
            btoCadastro.TabIndex = 22;
            btoCadastro.Text = "&Cadastro";
            btoCadastro.UseVisualStyleBackColor = true;
            btoCadastro.Click += btoCadastro_Click;
            // 
            // btoAlterar
            // 
            btoAlterar.Location = new Point(743, 17);
            btoAlterar.Margin = new Padding(4);
            btoAlterar.Name = "btoAlterar";
            btoAlterar.Size = new Size(94, 40);
            btoAlterar.TabIndex = 23;
            btoAlterar.Text = "&Alterar";
            btoAlterar.UseVisualStyleBackColor = true;
            // 
            // CadUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 616);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CadUsuario";
            RightToLeft = RightToLeft.No;
            Text = "CadastroUsuário";
            Load += CadUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCodigo;
        private Label label1;
        private ComboBox cboStatus;
        private Label label3;
        private Button btoPesquisa;
        private Label label4;
        private MaskedTextBox mtbCPF;
        private TextBox txtNome;
        private Label label2;
        private Label label5;
        private TextBox txtLogin;
        private Label label7;
        private ComboBox cboIDdepart;
        private Label label8;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtLogradouro;
        private Label label10;
        private TextBox txtCity;
        private ComboBox cboUF;
        private Label label11;
        private Label label14;
        private MaskedTextBox mtbTel1;
        private MaskedTextBox mtbTel2;
        private Label label15;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private MaskedTextBox mtbCEP;
        private GroupBox groupBox4;
        private Button btoAlterar;
        private Button btoExcluir;
        private Button btoLimpar;
        private Button btoCadastro;
        private Label label13;
        private TextBox txtNumero;
        private Label label12;
        private Label label17;
        private MaskedTextBox mtbDataC;
        private Label label19;
        private TextBox txtEmail;
        private Label label18;
        private TextBox txtComple;
        private Label label20;
        private TextBox txtSenha;
        private Label label21;
        private TextBox txtObs;
        private ComboBox cboDepart;
    }
}