namespace ProjetoOdontoPOO.Views
{
    partial class frmEditarResponsavel
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
            this.cbSexoRes = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIdadeRes = new System.Windows.Forms.TextBox();
            this.txtCPFRes = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefoneRes = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParentescoRes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataRes = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeRes = new System.Windows.Forms.TextBox();
            this.btnSalvarResponsavel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAtivoInativo = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSexoRes
            // 
            this.cbSexoRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexoRes.FormattingEnabled = true;
            this.cbSexoRes.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexoRes.Location = new System.Drawing.Point(397, 199);
            this.cbSexoRes.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexoRes.Name = "cbSexoRes";
            this.cbSexoRes.Size = new System.Drawing.Size(300, 24);
            this.cbSexoRes.TabIndex = 88;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(397, 176);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 19);
            this.label18.TabIndex = 95;
            this.label18.Text = "Sexo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(61, 176);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 19);
            this.label17.TabIndex = 94;
            this.label17.Text = "Idade";
            // 
            // txtIdadeRes
            // 
            this.txtIdadeRes.Location = new System.Drawing.Point(61, 199);
            this.txtIdadeRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdadeRes.Name = "txtIdadeRes";
            this.txtIdadeRes.ReadOnly = true;
            this.txtIdadeRes.Size = new System.Drawing.Size(71, 22);
            this.txtIdadeRes.TabIndex = 85;
            // 
            // txtCPFRes
            // 
            this.txtCPFRes.Location = new System.Drawing.Point(141, 199);
            this.txtCPFRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFRes.Mask = "999.999.999-99";
            this.txtCPFRes.Name = "txtCPFRes";
            this.txtCPFRes.Size = new System.Drawing.Size(247, 22);
            this.txtCPFRes.TabIndex = 87;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(141, 176);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 19);
            this.label16.TabIndex = 93;
            this.label16.Text = "CPF";
            // 
            // txtTelefoneRes
            // 
            this.txtTelefoneRes.Location = new System.Drawing.Point(61, 257);
            this.txtTelefoneRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefoneRes.Mask = "(00) 00000-0000";
            this.txtTelefoneRes.Name = "txtTelefoneRes";
            this.txtTelefoneRes.Size = new System.Drawing.Size(247, 22);
            this.txtTelefoneRes.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(317, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 92;
            this.label6.Text = "Parentesco";
            // 
            // txtParentescoRes
            // 
            this.txtParentescoRes.Location = new System.Drawing.Point(317, 257);
            this.txtParentescoRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtParentescoRes.Name = "txtParentescoRes";
            this.txtParentescoRes.Size = new System.Drawing.Size(380, 22);
            this.txtParentescoRes.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(61, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 89;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(484, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 19);
            this.label9.TabIndex = 86;
            this.label9.Text = "Data de Nascimento";
            // 
            // dtpDataRes
            // 
            this.dtpDataRes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRes.Location = new System.Drawing.Point(488, 140);
            this.dtpDataRes.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataRes.Name = "dtpDataRes";
            this.dtpDataRes.Size = new System.Drawing.Size(209, 22);
            this.dtpDataRes.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(61, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 84;
            this.label10.Text = "Nome Completo";
            // 
            // txtNomeRes
            // 
            this.txtNomeRes.Location = new System.Drawing.Point(61, 140);
            this.txtNomeRes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeRes.Name = "txtNomeRes";
            this.txtNomeRes.Size = new System.Drawing.Size(416, 22);
            this.txtNomeRes.TabIndex = 82;
            // 
            // btnSalvarResponsavel
            // 
            this.btnSalvarResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarResponsavel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarResponsavel.Location = new System.Drawing.Point(61, 470);
            this.btnSalvarResponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarResponsavel.Name = "btnSalvarResponsavel";
            this.btnSalvarResponsavel.Size = new System.Drawing.Size(637, 43);
            this.btnSalvarResponsavel.TabIndex = 80;
            this.btnSalvarResponsavel.Text = "Salvar";
            this.btnSalvarResponsavel.UseVisualStyleBackColor = false;
            this.btnSalvarResponsavel.Click += new System.EventHandler(this.btnSalvarResponsavel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 58);
            this.panel1.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(707, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(211, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Editar/Visualizar Responsável";
            // 
            // cbAtivoInativo
            // 
            this.cbAtivoInativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivoInativo.FormattingEnabled = true;
            this.cbAtivoInativo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbAtivoInativo.Location = new System.Drawing.Point(61, 400);
            this.cbAtivoInativo.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtivoInativo.Name = "cbAtivoInativo";
            this.cbAtivoInativo.Size = new System.Drawing.Size(351, 24);
            this.cbAtivoInativo.TabIndex = 98;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(61, 377);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 19);
            this.label20.TabIndex = 97;
            this.label20.Text = "Responsável Ativo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(58, 319);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 28);
            this.label19.TabIndex = 96;
            this.label19.Text = "Desligamento";
            // 
            // frmEditarResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(764, 567);
            this.Controls.Add(this.cbAtivoInativo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbSexoRes);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtIdadeRes);
            this.Controls.Add(this.txtCPFRes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTelefoneRes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParentescoRes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataRes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomeRes);
            this.Controls.Add(this.btnSalvarResponsavel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEditarResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Responsável";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSexoRes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIdadeRes;
        private System.Windows.Forms.MaskedTextBox txtCPFRes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtTelefoneRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParentescoRes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataRes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeRes;
        private System.Windows.Forms.Button btnSalvarResponsavel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAtivoInativo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}