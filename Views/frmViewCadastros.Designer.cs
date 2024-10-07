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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscarCPFPac = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCPFPaciente = new System.Windows.Forms.Button();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBuscarCPFRes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCPFResponsavel = new System.Windows.Forms.Button();
            this.dgvResponsavel = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBuscarCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarCNPJ = new System.Windows.Forms.Button();
            this.dgvConvenio = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 544);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.btnBuscarCPFPaciente_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.tabPage1.Controls.Add(this.txtBuscarCPFPac);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnBuscarCPFPaciente);
            this.tabPage1.Controls.Add(this.dgvPaciente);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paciente";
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
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(46, 124);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.Size = new System.Drawing.Size(889, 353);
            this.dgvPaciente.TabIndex = 0;
            this.dgvPaciente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.tabPage2.Controls.Add(this.txtBuscarCPFRes);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnBuscarCPFResponsavel);
            this.tabPage2.Controls.Add(this.dgvResponsavel);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Responsável";
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
            this.dgvResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsavel.Location = new System.Drawing.Point(46, 120);
            this.dgvResponsavel.Name = "dgvResponsavel";
            this.dgvResponsavel.Size = new System.Drawing.Size(889, 355);
            this.dgvResponsavel.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.tabPage3.Controls.Add(this.txtBuscarCNPJ);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnBuscarCNPJ);
            this.tabPage3.Controls.Add(this.dgvConvenio);
            this.tabPage3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(983, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convênio";
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
            this.dgvConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvenio.Location = new System.Drawing.Point(49, 124);
            this.dgvConvenio.Name = "dgvConvenio";
            this.dgvConvenio.Size = new System.Drawing.Size(889, 355);
            this.dgvConvenio.TabIndex = 8;
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
            this.Controls.Add(this.tabControl1);
            this.Name = "frmViewCadastros";
            this.Text = "frmViewCadastros";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsavel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCPFPaciente;
        private System.Windows.Forms.DataGridView dgvResponsavel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox txtBuscarCPFPac;
        private System.Windows.Forms.MaskedTextBox txtBuscarCPFRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCPFResponsavel;
        private System.Windows.Forms.MaskedTextBox txtBuscarCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarCNPJ;
        private System.Windows.Forms.DataGridView dgvConvenio;
    }
}