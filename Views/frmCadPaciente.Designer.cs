namespace ProjetoOdontoPOO.Views
{
    partial class frmCadPaciente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataPaciente = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbConvenioPaciente = new System.Windows.Forms.ComboBox();
            this.cbResponsavelPaciente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidadeEndereco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComplementoEndereco = new System.Windows.Forms.TextBox();
            this.btnLimparPaciente = new System.Windows.Forms.Button();
            this.btnSalvarPaciente = new System.Windows.Forms.Button();
            this.txtTelefonePaciente = new System.Windows.Forms.MaskedTextBox();
            this.txtCEPEndereco = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIdadePaciente = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbSexoPaciente = new System.Windows.Forms.ComboBox();
            this.cbUFEndereco = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 47);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(180, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cadastrar Paciente";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(44, 144);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(313, 20);
            this.txtNomePaciente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(44, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Completo";
            // 
            // dtpDataPaciente
            // 
            this.dtpDataPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPaciente.Location = new System.Drawing.Point(364, 144);
            this.dtpDataPaciente.Name = "dtpDataPaciente";
            this.dtpDataPaciente.Size = new System.Drawing.Size(158, 20);
            this.dtpDataPaciente.TabIndex = 2;
            this.dtpDataPaciente.Leave += new System.EventHandler(this.dtpDataPaciente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(361, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(44, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(236, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // txtEmailPaciente
            // 
            this.txtEmailPaciente.Location = new System.Drawing.Point(236, 239);
            this.txtEmailPaciente.Name = "txtEmailPaciente";
            this.txtEmailPaciente.Size = new System.Drawing.Size(286, 20);
            this.txtEmailPaciente.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(41, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Convênio (Se houver)";
            // 
            // cbConvenioPaciente
            // 
            this.cbConvenioPaciente.FormattingEnabled = true;
            this.cbConvenioPaciente.Location = new System.Drawing.Point(44, 288);
            this.cbConvenioPaciente.Name = "cbConvenioPaciente";
            this.cbConvenioPaciente.Size = new System.Drawing.Size(236, 21);
            this.cbConvenioPaciente.TabIndex = 8;
            // 
            // cbResponsavelPaciente
            // 
            this.cbResponsavelPaciente.FormattingEnabled = true;
            this.cbResponsavelPaciente.Location = new System.Drawing.Point(286, 288);
            this.cbResponsavelPaciente.Name = "cbResponsavelPaciente";
            this.cbResponsavelPaciente.Size = new System.Drawing.Size(236, 21);
            this.cbResponsavelPaciente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(283, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Responsável (Se houver)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(40, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dados Pessoais";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(40, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(44, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(44, 408);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(313, 20);
            this.txtLogradouro.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(363, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Número";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.Location = new System.Drawing.Point(363, 408);
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(159, 20);
            this.txtNumeroEndereco.TabIndex = 11;
            this.txtNumeroEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroEndereco_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(44, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cidade";
            // 
            // txtCidadeEndereco
            // 
            this.txtCidadeEndereco.Location = new System.Drawing.Point(44, 456);
            this.txtCidadeEndereco.Name = "txtCidadeEndereco";
            this.txtCidadeEndereco.Size = new System.Drawing.Size(228, 20);
            this.txtCidadeEndereco.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(278, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "UF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(363, 437);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "CEP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(44, 485);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Complemento";
            // 
            // txtComplementoEndereco
            // 
            this.txtComplementoEndereco.Location = new System.Drawing.Point(44, 504);
            this.txtComplementoEndereco.Name = "txtComplementoEndereco";
            this.txtComplementoEndereco.Size = new System.Drawing.Size(478, 20);
            this.txtComplementoEndereco.TabIndex = 15;
            // 
            // btnLimparPaciente
            // 
            this.btnLimparPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPaciente.Location = new System.Drawing.Point(44, 562);
            this.btnLimparPaciente.Name = "btnLimparPaciente";
            this.btnLimparPaciente.Size = new System.Drawing.Size(113, 35);
            this.btnLimparPaciente.TabIndex = 16;
            this.btnLimparPaciente.Text = "Limpar";
            this.btnLimparPaciente.UseVisualStyleBackColor = false;
            this.btnLimparPaciente.Click += new System.EventHandler(this.btnLimparPaciente_Click);
            // 
            // btnSalvarPaciente
            // 
            this.btnSalvarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPaciente.Location = new System.Drawing.Point(409, 562);
            this.btnSalvarPaciente.Name = "btnSalvarPaciente";
            this.btnSalvarPaciente.Size = new System.Drawing.Size(113, 35);
            this.btnSalvarPaciente.TabIndex = 17;
            this.btnSalvarPaciente.Text = "Salvar";
            this.btnSalvarPaciente.UseVisualStyleBackColor = false;
            this.btnSalvarPaciente.Click += new System.EventHandler(this.btnSalvarPaciente_Click);
            // 
            // txtTelefonePaciente
            // 
            this.txtTelefonePaciente.Location = new System.Drawing.Point(44, 239);
            this.txtTelefonePaciente.Mask = "(00) 00000-0000";
            this.txtTelefonePaciente.Name = "txtTelefonePaciente";
            this.txtTelefonePaciente.Size = new System.Drawing.Size(186, 20);
            this.txtTelefonePaciente.TabIndex = 6;
            this.txtTelefonePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonePaciente_KeyPress);
            // 
            // txtCEPEndereco
            // 
            this.txtCEPEndereco.Location = new System.Drawing.Point(363, 456);
            this.txtCEPEndereco.Mask = "00000-000";
            this.txtCEPEndereco.Name = "txtCEPEndereco";
            this.txtCEPEndereco.Size = new System.Drawing.Size(159, 20);
            this.txtCEPEndereco.TabIndex = 14;
            // 
            // txtCPFPaciente
            // 
            this.txtCPFPaciente.Location = new System.Drawing.Point(104, 192);
            this.txtCPFPaciente.Mask = "000.000.000-00";
            this.txtCPFPaciente.Name = "txtCPFPaciente";
            this.txtCPFPaciente.Size = new System.Drawing.Size(186, 20);
            this.txtCPFPaciente.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(104, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "CPF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(44, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Idade";
            // 
            // txtIdadePaciente
            // 
            this.txtIdadePaciente.Location = new System.Drawing.Point(44, 192);
            this.txtIdadePaciente.Name = "txtIdadePaciente";
            this.txtIdadePaciente.ReadOnly = true;
            this.txtIdadePaciente.Size = new System.Drawing.Size(54, 20);
            this.txtIdadePaciente.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(296, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "Sexo";
            // 
            // cbSexoPaciente
            // 
            this.cbSexoPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexoPaciente.FormattingEnabled = true;
            this.cbSexoPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexoPaciente.Location = new System.Drawing.Point(296, 192);
            this.cbSexoPaciente.Name = "cbSexoPaciente";
            this.cbSexoPaciente.Size = new System.Drawing.Size(226, 21);
            this.cbSexoPaciente.TabIndex = 5;
            // 
            // cbUFEndereco
            // 
            this.cbUFEndereco.DropDownHeight = 80;
            this.cbUFEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUFEndereco.DropDownWidth = 79;
            this.cbUFEndereco.FormattingEnabled = true;
            this.cbUFEndereco.IntegralHeight = false;
            this.cbUFEndereco.ItemHeight = 13;
            this.cbUFEndereco.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUFEndereco.Location = new System.Drawing.Point(278, 456);
            this.cbUFEndereco.Name = "cbUFEndereco";
            this.cbUFEndereco.Size = new System.Drawing.Size(79, 21);
            this.cbUFEndereco.TabIndex = 13;
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(566, 642);
            this.Controls.Add(this.cbUFEndereco);
            this.Controls.Add(this.cbSexoPaciente);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtIdadePaciente);
            this.Controls.Add(this.txtCPFPaciente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCEPEndereco);
            this.Controls.Add(this.txtTelefonePaciente);
            this.Controls.Add(this.btnSalvarPaciente);
            this.Controls.Add(this.btnLimparPaciente);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtComplementoEndereco);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCidadeEndereco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumeroEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbResponsavelPaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbConvenioPaciente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadPaciente";
            this.Load += new System.EventHandler(this.frmCadPaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConvenioPaciente;
        private System.Windows.Forms.ComboBox cbResponsavelPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroEndereco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidadeEndereco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComplementoEndereco;
        private System.Windows.Forms.Button btnLimparPaciente;
        private System.Windows.Forms.Button btnSalvarPaciente;
        private System.Windows.Forms.MaskedTextBox txtTelefonePaciente;
        private System.Windows.Forms.MaskedTextBox txtCEPEndereco;
        private System.Windows.Forms.MaskedTextBox txtCPFPaciente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIdadePaciente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbSexoPaciente;
        private System.Windows.Forms.ComboBox cbUFEndereco;
    }
}