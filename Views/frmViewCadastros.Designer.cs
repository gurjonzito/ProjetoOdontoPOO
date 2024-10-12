namespace ProjetoOdontoPOO.Views
{
    partial class frmViewCadastros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlVisualizar = new System.Windows.Forms.TabControl();
            this.tpPaciente = new System.Windows.Forms.TabPage();
            this.txtBuscarCPFPac = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCPFPaciente = new System.Windows.Forms.Button();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Convênio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsável = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo_Inativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpResponsavel = new System.Windows.Forms.TabPage();
            this.txtBuscarCPFRes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCPFResponsavel = new System.Windows.Forms.Button();
            this.dgvResponsavel = new System.Windows.Forms.DataGridView();
            this.IDRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadeRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo_InativoRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpConvenio = new System.Windows.Forms.TabPage();
            this.txtBuscarCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarCNPJ = new System.Windows.Forms.Button();
            this.dgvConvenio = new System.Windows.Forms.DataGridView();
            this.IDConv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeConv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo_InativoConv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlVisualizar.SuspendLayout();
            this.tpPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.tpResponsavel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).BeginInit();
            this.tpConvenio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVisualizar
            // 
            this.tabControlVisualizar.Controls.Add(this.tpPaciente);
            this.tabControlVisualizar.Controls.Add(this.tpResponsavel);
            this.tabControlVisualizar.Controls.Add(this.tpConvenio);
            this.tabControlVisualizar.Location = new System.Drawing.Point(1, 52);
            this.tabControlVisualizar.Name = "tabControlVisualizar";
            this.tabControlVisualizar.SelectedIndex = 0;
            this.tabControlVisualizar.Size = new System.Drawing.Size(991, 544);
            this.tabControlVisualizar.TabIndex = 0;
            this.tabControlVisualizar.SelectedIndexChanged += new System.EventHandler(this.tabControlVisualizar_SelectedIndexChanged);
            this.tabControlVisualizar.Click += new System.EventHandler(this.btnBuscarCPFPaciente_Click);
            // 
            // tpPaciente
            // 
            this.tpPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.tpPaciente.Controls.Add(this.txtBuscarCPFPac);
            this.tpPaciente.Controls.Add(this.label2);
            this.tpPaciente.Controls.Add(this.btnBuscarCPFPaciente);
            this.tpPaciente.Controls.Add(this.dgvPaciente);
            this.tpPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPaciente.Location = new System.Drawing.Point(4, 22);
            this.tpPaciente.Name = "tpPaciente";
            this.tpPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaciente.Size = new System.Drawing.Size(983, 518);
            this.tpPaciente.TabIndex = 0;
            this.tpPaciente.Text = "Paciente";
            // 
            // txtBuscarCPFPac
            // 
            this.txtBuscarCPFPac.Location = new System.Drawing.Point(46, 75);
            this.txtBuscarCPFPac.Mask = "000.000.000-00";
            this.txtBuscarCPFPac.Name = "txtBuscarCPFPac";
            this.txtBuscarCPFPac.Size = new System.Drawing.Size(265, 26);
            this.txtBuscarCPFPac.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Busca por CPF";
            // 
            // btnBuscarCPFPaciente
            // 
            this.btnBuscarCPFPaciente.Location = new System.Drawing.Point(317, 75);
            this.btnBuscarCPFPaciente.Name = "btnBuscarCPFPaciente";
            this.btnBuscarCPFPaciente.Size = new System.Drawing.Size(111, 26);
            this.btnBuscarCPFPaciente.TabIndex = 2;
            this.btnBuscarCPFPaciente.Text = "Buscar";
            this.btnBuscarCPFPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarCPFPaciente.Click += new System.EventHandler(this.btnBuscarCPFPaciente_Click);
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.AllowUserToResizeColumns = false;
            this.dgvPaciente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dgvPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaciente.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Idade,
            this.CPF,
            this.Sexo,
            this.Convênio,
            this.Responsável,
            this.Ativo_Inativo});
            this.dgvPaciente.Location = new System.Drawing.Point(46, 124);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.RowHeadersVisible = false;
            this.dgvPaciente.Size = new System.Drawing.Size(889, 353);
            this.dgvPaciente.TabIndex = 0;
            this.dgvPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 170;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 200;
            // 
            // Convênio
            // 
            this.Convênio.HeaderText = "Convênio";
            this.Convênio.Name = "Convênio";
            this.Convênio.ReadOnly = true;
            this.Convênio.Width = 250;
            // 
            // Responsável
            // 
            this.Responsável.HeaderText = "Responsável";
            this.Responsável.Name = "Responsável";
            this.Responsável.ReadOnly = true;
            this.Responsável.Width = 250;
            // 
            // Ativo_Inativo
            // 
            this.Ativo_Inativo.HeaderText = "Ativo_Inativo";
            this.Ativo_Inativo.Name = "Ativo_Inativo";
            this.Ativo_Inativo.ReadOnly = true;
            // 
            // tpResponsavel
            // 
            this.tpResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.tpResponsavel.Controls.Add(this.txtBuscarCPFRes);
            this.tpResponsavel.Controls.Add(this.label3);
            this.tpResponsavel.Controls.Add(this.btnBuscarCPFResponsavel);
            this.tpResponsavel.Controls.Add(this.dgvResponsavel);
            this.tpResponsavel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpResponsavel.Location = new System.Drawing.Point(4, 22);
            this.tpResponsavel.Name = "tpResponsavel";
            this.tpResponsavel.Padding = new System.Windows.Forms.Padding(3);
            this.tpResponsavel.Size = new System.Drawing.Size(983, 518);
            this.tpResponsavel.TabIndex = 1;
            this.tpResponsavel.Text = "Responsável";
            // 
            // txtBuscarCPFRes
            // 
            this.txtBuscarCPFRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCPFRes.Location = new System.Drawing.Point(46, 72);
            this.txtBuscarCPFRes.Mask = "000.000.000-00";
            this.txtBuscarCPFRes.Name = "txtBuscarCPFRes";
            this.txtBuscarCPFRes.Size = new System.Drawing.Size(265, 26);
            this.txtBuscarCPFRes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(42, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Busca por CPF";
            // 
            // btnBuscarCPFResponsavel
            // 
            this.btnBuscarCPFResponsavel.Location = new System.Drawing.Point(317, 72);
            this.btnBuscarCPFResponsavel.Name = "btnBuscarCPFResponsavel";
            this.btnBuscarCPFResponsavel.Size = new System.Drawing.Size(111, 26);
            this.btnBuscarCPFResponsavel.TabIndex = 5;
            this.btnBuscarCPFResponsavel.Text = "Buscar";
            this.btnBuscarCPFResponsavel.UseVisualStyleBackColor = true;
            this.btnBuscarCPFResponsavel.Click += new System.EventHandler(this.btnBuscarCPFResponsavel_Click);
            // 
            // dgvResponsavel
            // 
            this.dgvResponsavel.AllowUserToAddRows = false;
            this.dgvResponsavel.AllowUserToDeleteRows = false;
            this.dgvResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsavel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRes,
            this.NomeRes,
            this.IdadeRes,
            this.CPFRes,
            this.SexoRes,
            this.Ativo_InativoRes});
            this.dgvResponsavel.Location = new System.Drawing.Point(46, 120);
            this.dgvResponsavel.Name = "dgvResponsavel";
            this.dgvResponsavel.RowHeadersVisible = false;
            this.dgvResponsavel.Size = new System.Drawing.Size(889, 355);
            this.dgvResponsavel.TabIndex = 1;
            // 
            // IDRes
            // 
            this.IDRes.HeaderText = "ID";
            this.IDRes.Name = "IDRes";
            this.IDRes.ReadOnly = true;
            // 
            // NomeRes
            // 
            this.NomeRes.HeaderText = "Nome";
            this.NomeRes.Name = "NomeRes";
            this.NomeRes.ReadOnly = true;
            this.NomeRes.Width = 250;
            // 
            // IdadeRes
            // 
            this.IdadeRes.HeaderText = "Idade";
            this.IdadeRes.Name = "IdadeRes";
            this.IdadeRes.ReadOnly = true;
            // 
            // CPFRes
            // 
            this.CPFRes.HeaderText = "CPF";
            this.CPFRes.Name = "CPFRes";
            this.CPFRes.ReadOnly = true;
            this.CPFRes.Width = 170;
            // 
            // SexoRes
            // 
            this.SexoRes.HeaderText = "Sexo";
            this.SexoRes.Name = "SexoRes";
            this.SexoRes.ReadOnly = true;
            this.SexoRes.Width = 200;
            // 
            // Ativo_InativoRes
            // 
            this.Ativo_InativoRes.HeaderText = "Ativo_Inativo";
            this.Ativo_InativoRes.Name = "Ativo_InativoRes";
            this.Ativo_InativoRes.ReadOnly = true;
            // 
            // tpConvenio
            // 
            this.tpConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.tpConvenio.Controls.Add(this.txtBuscarCNPJ);
            this.tpConvenio.Controls.Add(this.label4);
            this.tpConvenio.Controls.Add(this.btnBuscarCNPJ);
            this.tpConvenio.Controls.Add(this.dgvConvenio);
            this.tpConvenio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConvenio.Location = new System.Drawing.Point(4, 22);
            this.tpConvenio.Name = "tpConvenio";
            this.tpConvenio.Padding = new System.Windows.Forms.Padding(3);
            this.tpConvenio.Size = new System.Drawing.Size(983, 518);
            this.tpConvenio.TabIndex = 2;
            this.tpConvenio.Text = "Convênio";
            // 
            // txtBuscarCNPJ
            // 
            this.txtBuscarCNPJ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCNPJ.Location = new System.Drawing.Point(49, 76);
            this.txtBuscarCNPJ.Mask = "00.000.000/0000-00";
            this.txtBuscarCNPJ.Name = "txtBuscarCNPJ";
            this.txtBuscarCNPJ.Size = new System.Drawing.Size(265, 26);
            this.txtBuscarCNPJ.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(45, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Busca por CNPJ";
            // 
            // btnBuscarCNPJ
            // 
            this.btnBuscarCNPJ.Location = new System.Drawing.Point(320, 76);
            this.btnBuscarCNPJ.Name = "btnBuscarCNPJ";
            this.btnBuscarCNPJ.Size = new System.Drawing.Size(111, 26);
            this.btnBuscarCNPJ.TabIndex = 9;
            this.btnBuscarCNPJ.Text = "Buscar";
            this.btnBuscarCNPJ.UseVisualStyleBackColor = true;
            this.btnBuscarCNPJ.Click += new System.EventHandler(this.btnBuscarCNPJ_Click);
            // 
            // dgvConvenio
            // 
            this.dgvConvenio.AllowUserToAddRows = false;
            this.dgvConvenio.AllowUserToDeleteRows = false;
            this.dgvConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvenio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDConv,
            this.NomeConv,
            this.CNPJ,
            this.Ativo_InativoConv});
            this.dgvConvenio.Location = new System.Drawing.Point(49, 124);
            this.dgvConvenio.Name = "dgvConvenio";
            this.dgvConvenio.RowHeadersVisible = false;
            this.dgvConvenio.Size = new System.Drawing.Size(889, 355);
            this.dgvConvenio.TabIndex = 8;
            // 
            // IDConv
            // 
            this.IDConv.HeaderText = "ID";
            this.IDConv.Name = "IDConv";
            this.IDConv.ReadOnly = true;
            // 
            // NomeConv
            // 
            this.NomeConv.HeaderText = "Nome";
            this.NomeConv.Name = "NomeConv";
            this.NomeConv.ReadOnly = true;
            this.NomeConv.Width = 250;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Width = 170;
            // 
            // Ativo_InativoConv
            // 
            this.Ativo_InativoConv.HeaderText = "Ativo_Inativo";
            this.Ativo_InativoConv.Name = "Ativo_InativoConv";
            this.Ativo_InativoConv.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 46);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizar Cadastros";
            // 
            // frmViewCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlVisualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmViewCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewCadastros";
            this.tabControlVisualizar.ResumeLayout(false);
            this.tpPaciente.ResumeLayout(false);
            this.tpPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.tpResponsavel.ResumeLayout(false);
            this.tpResponsavel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).EndInit();
            this.tpConvenio.ResumeLayout(false);
            this.tpConvenio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVisualizar;
        private System.Windows.Forms.TabPage tpPaciente;
        private System.Windows.Forms.TabPage tpResponsavel;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCPFPaciente;
        private System.Windows.Forms.DataGridView dgvResponsavel;
        private System.Windows.Forms.TabPage tpConvenio;
        private System.Windows.Forms.MaskedTextBox txtBuscarCPFPac;
        private System.Windows.Forms.MaskedTextBox txtBuscarCPFRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCPFResponsavel;
        private System.Windows.Forms.MaskedTextBox txtBuscarCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarCNPJ;
        private System.Windows.Forms.DataGridView dgvConvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Convênio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsável;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo_Inativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo_InativoRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDConv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeConv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo_InativoConv;
    }
}