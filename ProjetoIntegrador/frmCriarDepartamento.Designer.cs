﻿namespace ProjetoIntegrador
{
    partial class frmCriarDepartamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbDataC = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btoPesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeDepartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbDataC);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btoPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mtbDataC
            // 
            this.mtbDataC.Location = new System.Drawing.Point(520, 48);
            this.mtbDataC.Mask = "##/##/#### ##:##";
            this.mtbDataC.Name = "mtbDataC";
            this.mtbDataC.Size = new System.Drawing.Size(147, 29);
            this.mtbDataC.TabIndex = 4;
            this.mtbDataC.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 29);
            this.txtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data de Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // btoPesquisar
            // 
            this.btoPesquisar.Location = new System.Drawing.Point(117, 48);
            this.btoPesquisar.Name = "btoPesquisar";
            this.btoPesquisar.Size = new System.Drawing.Size(87, 31);
            this.btoPesquisar.TabIndex = 0;
            this.btoPesquisar.Text = "&Pesquisar";
            this.btoPesquisar.UseVisualStyleBackColor = true;
            this.btoPesquisar.Click += new System.EventHandler(this.btoPesquisar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtArea);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.txtNomeDepartamento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Área";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(329, 38);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(185, 29);
            this.txtArea.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Observação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descrição";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.cboStatus.Location = new System.Drawing.Point(520, 38);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(147, 29);
            this.cboStatus.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(13, 172);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(655, 58);
            this.txtObs.TabIndex = 4;
            this.txtObs.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(11, 95);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(656, 50);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TabStop = false;
            // 
            // txtNomeDepartamento
            // 
            this.txtNomeDepartamento.Location = new System.Drawing.Point(11, 38);
            this.txtNomeDepartamento.Name = "txtNomeDepartamento";
            this.txtNomeDepartamento.Size = new System.Drawing.Size(312, 29);
            this.txtNomeDepartamento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoCadastrar);
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Location = new System.Drawing.Point(12, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.Location = new System.Drawing.Point(200, 28);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(87, 31);
            this.btoCadastrar.TabIndex = 4;
            this.btoCadastrar.Text = "&Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(572, 28);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(87, 31);
            this.btoSair.TabIndex = 3;
            this.btoSair.Text = "&Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(479, 28);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(87, 31);
            this.btoLimpar.TabIndex = 2;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(386, 28);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(87, 31);
            this.btoExcluir.TabIndex = 1;
            this.btoExcluir.Text = "&Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click_1);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(293, 28);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(87, 31);
            this.btoAlterar.TabIndex = 0;
            this.btoAlterar.Text = "&Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click_1);
            // 
            // frmCriarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCriarDepartamento";
            this.Text = "Tela de Cadastro de Departamantos";
            this.Load += new System.EventHandler(this.frmCriarDepartamento_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtbDataC;
        private TextBox txtCodigo;
        private Label label4;
        private Label label1;
        private Button btoPesquisar;
        private GroupBox groupBox2;
        private ComboBox cboStatus;
        private TextBox txtObs;
        private TextBox txtDescricao;
        private TextBox txtNomeDepartamento;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Button btoCadastrar;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoExcluir;
        private Button btoAlterar;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox txtArea;
    }
}