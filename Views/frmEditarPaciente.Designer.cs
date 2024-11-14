namespace ProjetoOdontoPOO.Views
{
    partial class frmEditarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPaciente));
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIdadePaciente = new System.Windows.Forms.TextBox();
            this.txtCPFPaciente = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCEPEndereco = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonePaciente = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarPaciente = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComplementoEndereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidadeEndereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataPaciente = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbUFPaciente = new System.Windows.Forms.ComboBox();
            this.cbSexoPaciente = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbAtivoInativo = new System.Windows.Forms.ComboBox();
            this.btnConvenio = new System.Windows.Forms.Button();
            this.btnResponsavel = new System.Windows.Forms.Button();
            this.txtConvenioPaciente = new System.Windows.Forms.TextBox();
            this.txtResponsavelPaciente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(296, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 70;
            this.label18.Text = "Sexo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(44, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 68;
            this.label17.Text = "Idade";
            // 
            // txtIdadePaciente
            // 
            this.txtIdadePaciente.Location = new System.Drawing.Point(44, 190);
            this.txtIdadePaciente.Name = "txtIdadePaciente";
            this.txtIdadePaciente.Size = new System.Drawing.Size(54, 20);
            this.txtIdadePaciente.TabIndex = 67;
            // 
            // txtCPFPaciente
            // 
            this.txtCPFPaciente.Location = new System.Drawing.Point(104, 190);
            this.txtCPFPaciente.Mask = "000.000.000-00";
            this.txtCPFPaciente.Name = "txtCPFPaciente";
            this.txtCPFPaciente.Size = new System.Drawing.Size(186, 20);
            this.txtCPFPaciente.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(104, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 16);
            this.label16.TabIndex = 66;
            this.label16.Text = "CPF";
            // 
            // txtCEPEndereco
            // 
            this.txtCEPEndereco.Location = new System.Drawing.Point(363, 454);
            this.txtCEPEndereco.Mask = "00000-000";
            this.txtCEPEndereco.Name = "txtCEPEndereco";
            this.txtCEPEndereco.Size = new System.Drawing.Size(159, 20);
            this.txtCEPEndereco.TabIndex = 52;
            // 
            // txtTelefonePaciente
            // 
            this.txtTelefonePaciente.Location = new System.Drawing.Point(44, 237);
            this.txtTelefonePaciente.Mask = "(00) 00000-0000";
            this.txtTelefonePaciente.Name = "txtTelefonePaciente";
            this.txtTelefonePaciente.Size = new System.Drawing.Size(186, 20);
            this.txtTelefonePaciente.TabIndex = 41;
            // 
            // btnSalvarPaciente
            // 
            this.btnSalvarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPaciente.Location = new System.Drawing.Point(44, 688);
            this.btnSalvarPaciente.Name = "btnSalvarPaciente";
            this.btnSalvarPaciente.Size = new System.Drawing.Size(477, 35);
            this.btnSalvarPaciente.TabIndex = 56;
            this.btnSalvarPaciente.Text = "Salvar";
            this.btnSalvarPaciente.UseVisualStyleBackColor = false;
            this.btnSalvarPaciente.Click += new System.EventHandler(this.btnSalvarPaciente_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(44, 483);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 64;
            this.label15.Text = "Complemento";
            // 
            // txtComplementoEndereco
            // 
            this.txtComplementoEndereco.Location = new System.Drawing.Point(44, 502);
            this.txtComplementoEndereco.Name = "txtComplementoEndereco";
            this.txtComplementoEndereco.Size = new System.Drawing.Size(478, 20);
            this.txtComplementoEndereco.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(363, 435);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 63;
            this.label14.Text = "CEP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(278, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 62;
            this.label13.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(44, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Cidade";
            // 
            // txtCidadeEndereco
            // 
            this.txtCidadeEndereco.Location = new System.Drawing.Point(44, 454);
            this.txtCidadeEndereco.Name = "txtCidadeEndereco";
            this.txtCidadeEndereco.Size = new System.Drawing.Size(228, 20);
            this.txtCidadeEndereco.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(363, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "Número";
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.Location = new System.Drawing.Point(363, 406);
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(159, 20);
            this.txtNumeroEndereco.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(44, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(44, 406);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(313, 20);
            this.txtLogradouro.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(40, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(40, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Dados Pessoais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(283, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Responsável (Se houver)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(41, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Convênio (Se houver)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(236, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "E-mail";
            // 
            // txtEmailPaciente
            // 
            this.txtEmailPaciente.Location = new System.Drawing.Point(236, 237);
            this.txtEmailPaciente.Name = "txtEmailPaciente";
            this.txtEmailPaciente.Size = new System.Drawing.Size(286, 20);
            this.txtEmailPaciente.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(44, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(361, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data de Nascimento";
            // 
            // dtpDataPaciente
            // 
            this.dtpDataPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPaciente.Location = new System.Drawing.Point(364, 142);
            this.dtpDataPaciente.Name = "dtpDataPaciente";
            this.dtpDataPaciente.Size = new System.Drawing.Size(158, 20);
            this.dtpDataPaciente.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(44, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nome Completo";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(44, 142);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(313, 20);
            this.txtNomePaciente.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 47);
            this.panel1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(171, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Editar/Visualizar Paciente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(43, 559);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 23);
            this.label19.TabIndex = 71;
            this.label19.Text = "Desligamento";
            // 
            // cbUFPaciente
            // 
            this.cbUFPaciente.FormattingEnabled = true;
            this.cbUFPaciente.Location = new System.Drawing.Point(278, 453);
            this.cbUFPaciente.Name = "cbUFPaciente";
            this.cbUFPaciente.Size = new System.Drawing.Size(79, 21);
            this.cbUFPaciente.TabIndex = 75;
            // 
            // cbSexoPaciente
            // 
            this.cbSexoPaciente.FormattingEnabled = true;
            this.cbSexoPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexoPaciente.Location = new System.Drawing.Point(296, 190);
            this.cbSexoPaciente.Name = "cbSexoPaciente";
            this.cbSexoPaciente.Size = new System.Drawing.Size(226, 21);
            this.cbSexoPaciente.TabIndex = 76;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(47, 610);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 16);
            this.label20.TabIndex = 73;
            this.label20.Text = "Paciente Ativo";
            // 
            // cbAtivoInativo
            // 
            this.cbAtivoInativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivoInativo.FormattingEnabled = true;
            this.cbAtivoInativo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbAtivoInativo.Location = new System.Drawing.Point(47, 629);
            this.cbAtivoInativo.Name = "cbAtivoInativo";
            this.cbAtivoInativo.Size = new System.Drawing.Size(264, 21);
            this.cbAtivoInativo.TabIndex = 74;
            // 
            // btnConvenio
            // 
            this.btnConvenio.Location = new System.Drawing.Point(251, 286);
            this.btnConvenio.Name = "btnConvenio";
            this.btnConvenio.Size = new System.Drawing.Size(29, 23);
            this.btnConvenio.TabIndex = 80;
            this.btnConvenio.Text = "...";
            this.btnConvenio.UseVisualStyleBackColor = true;
            this.btnConvenio.Click += new System.EventHandler(this.btnConvenio_Click);
            // 
            // btnResponsavel
            // 
            this.btnResponsavel.Location = new System.Drawing.Point(493, 286);
            this.btnResponsavel.Name = "btnResponsavel";
            this.btnResponsavel.Size = new System.Drawing.Size(29, 23);
            this.btnResponsavel.TabIndex = 79;
            this.btnResponsavel.Text = "...";
            this.btnResponsavel.UseVisualStyleBackColor = true;
            this.btnResponsavel.Click += new System.EventHandler(this.btnResponsavel_Click);
            // 
            // txtConvenioPaciente
            // 
            this.txtConvenioPaciente.Location = new System.Drawing.Point(44, 288);
            this.txtConvenioPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtConvenioPaciente.Name = "txtConvenioPaciente";
            this.txtConvenioPaciente.ReadOnly = true;
            this.txtConvenioPaciente.Size = new System.Drawing.Size(204, 20);
            this.txtConvenioPaciente.TabIndex = 81;
            // 
            // txtResponsavelPaciente
            // 
            this.txtResponsavelPaciente.Location = new System.Drawing.Point(286, 288);
            this.txtResponsavelPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtResponsavelPaciente.Name = "txtResponsavelPaciente";
            this.txtResponsavelPaciente.ReadOnly = true;
            this.txtResponsavelPaciente.Size = new System.Drawing.Size(203, 20);
            this.txtResponsavelPaciente.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(525, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // frmEditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(570, 762);
            this.Controls.Add(this.txtResponsavelPaciente);
            this.Controls.Add(this.txtConvenioPaciente);
            this.Controls.Add(this.btnConvenio);
            this.Controls.Add(this.btnResponsavel);
            this.Controls.Add(this.cbSexoPaciente);
            this.Controls.Add(this.cbUFPaciente);
            this.Controls.Add(this.cbAtivoInativo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtIdadePaciente);
            this.Controls.Add(this.txtCPFPaciente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCEPEndereco);
            this.Controls.Add(this.txtTelefonePaciente);
            this.Controls.Add(this.btnSalvarPaciente);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Paciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIdadePaciente;
        private System.Windows.Forms.MaskedTextBox txtCPFPaciente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtCEPEndereco;
        private System.Windows.Forms.MaskedTextBox txtTelefonePaciente;
        private System.Windows.Forms.Button btnSalvarPaciente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComplementoEndereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidadeEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbUFPaciente;
        private System.Windows.Forms.ComboBox cbSexoPaciente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbAtivoInativo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConvenio;
        private System.Windows.Forms.Button btnResponsavel;
        private System.Windows.Forms.TextBox txtConvenioPaciente;
        private System.Windows.Forms.TextBox txtResponsavelPaciente;
    }
}