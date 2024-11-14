namespace ProjetoOdontoPOO.Views
{
    partial class frmEditarDentista
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
            this.txtCRMDentista = new System.Windows.Forms.MaskedTextBox();
            this.cbEstadoDentista = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneDentista = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspDentista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.btnSalvarDentista = new System.Windows.Forms.Button();
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
            // txtCRMDentista
            // 
            this.txtCRMDentista.Location = new System.Drawing.Point(431, 132);
            this.txtCRMDentista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCRMDentista.Mask = "000000";
            this.txtCRMDentista.Name = "txtCRMDentista";
            this.txtCRMDentista.Size = new System.Drawing.Size(159, 22);
            this.txtCRMDentista.TabIndex = 88;
            // 
            // cbEstadoDentista
            // 
            this.cbEstadoDentista.DropDownHeight = 80;
            this.cbEstadoDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoDentista.FormattingEnabled = true;
            this.cbEstadoDentista.IntegralHeight = false;
            this.cbEstadoDentista.Items.AddRange(new object[] {
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
            this.cbEstadoDentista.Location = new System.Drawing.Point(599, 132);
            this.cbEstadoDentista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstadoDentista.Name = "cbEstadoDentista";
            this.cbEstadoDentista.Size = new System.Drawing.Size(100, 24);
            this.cbEstadoDentista.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(595, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 86;
            this.label5.Text = "Estado";
            // 
            // txtTelefoneDentista
            // 
            this.txtTelefoneDentista.Location = new System.Drawing.Point(452, 191);
            this.txtTelefoneDentista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefoneDentista.Mask = "(00) 00000-0000";
            this.txtTelefoneDentista.Name = "txtTelefoneDentista";
            this.txtTelefoneDentista.Size = new System.Drawing.Size(247, 22);
            this.txtTelefoneDentista.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(63, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 85;
            this.label4.Text = "Especialidade";
            // 
            // txtEspDentista
            // 
            this.txtEspDentista.Location = new System.Drawing.Point(63, 191);
            this.txtEspDentista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEspDentista.Name = "txtEspDentista";
            this.txtEspDentista.Size = new System.Drawing.Size(380, 22);
            this.txtEspDentista.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(452, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(427, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "CRM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(63, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "Nome Completo";
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(63, 132);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(357, 22);
            this.txtNomeDentista.TabIndex = 79;
            // 
            // btnSalvarDentista
            // 
            this.btnSalvarDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarDentista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarDentista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDentista.Location = new System.Drawing.Point(63, 398);
            this.btnSalvarDentista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvarDentista.Name = "btnSalvarDentista";
            this.btnSalvarDentista.Size = new System.Drawing.Size(636, 43);
            this.btnSalvarDentista.TabIndex = 77;
            this.btnSalvarDentista.Text = "Salvar";
            this.btnSalvarDentista.UseVisualStyleBackColor = false;
            this.btnSalvarDentista.Click += new System.EventHandler(this.btnSalvarDentista_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 58);
            this.panel1.TabIndex = 78;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(707, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 89;
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
            this.label7.Location = new System.Drawing.Point(243, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Editar/Visualizar Dentista";
            // 
            // cbAtivoInativo
            // 
            this.cbAtivoInativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivoInativo.FormattingEnabled = true;
            this.cbAtivoInativo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbAtivoInativo.Location = new System.Drawing.Point(63, 330);
            this.cbAtivoInativo.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtivoInativo.Name = "cbAtivoInativo";
            this.cbAtivoInativo.Size = new System.Drawing.Size(351, 24);
            this.cbAtivoInativo.TabIndex = 101;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(63, 307);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 19);
            this.label20.TabIndex = 100;
            this.label20.Text = "Dentista Ativo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(60, 249);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 28);
            this.label19.TabIndex = 99;
            this.label19.Text = "Desligamento";
            // 
            // frmEditarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(768, 507);
            this.Controls.Add(this.cbAtivoInativo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCRMDentista);
            this.Controls.Add(this.cbEstadoDentista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefoneDentista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEspDentista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.btnSalvarDentista);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditarDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Dentista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCRMDentista;
        private System.Windows.Forms.ComboBox cbEstadoDentista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTelefoneDentista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspDentista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDentista;
        private System.Windows.Forms.Button btnSalvarDentista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbAtivoInativo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}