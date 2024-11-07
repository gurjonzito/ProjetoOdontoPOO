namespace ProjetoOdontoPOO.Views
{
    partial class frmCadDentista
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimparDentista = new System.Windows.Forms.Button();
            this.btnSalvarDentista = new System.Windows.Forms.Button();
            this.cbEstadoDentista = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneDentista = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspDentista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.txtCRMDentista = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(172, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cadastrar Dentista";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 47);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.Location = new System.Drawing.Point(520, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnLimparDentista
            // 
            this.btnLimparDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparDentista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparDentista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparDentista.Location = new System.Drawing.Point(47, 227);
            this.btnLimparDentista.Name = "btnLimparDentista";
            this.btnLimparDentista.Size = new System.Drawing.Size(113, 35);
            this.btnLimparDentista.TabIndex = 5;
            this.btnLimparDentista.Text = "Limpar";
            this.btnLimparDentista.UseVisualStyleBackColor = false;
            this.btnLimparDentista.Click += new System.EventHandler(this.btnLimparDentista_Click);
            // 
            // btnSalvarDentista
            // 
            this.btnSalvarDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarDentista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarDentista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDentista.Location = new System.Drawing.Point(412, 227);
            this.btnSalvarDentista.Name = "btnSalvarDentista";
            this.btnSalvarDentista.Size = new System.Drawing.Size(113, 35);
            this.btnSalvarDentista.TabIndex = 6;
            this.btnSalvarDentista.Text = "Salvar";
            this.btnSalvarDentista.UseVisualStyleBackColor = false;
            this.btnSalvarDentista.Click += new System.EventHandler(this.btnSalvarDentista_Click);
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
            this.cbEstadoDentista.Location = new System.Drawing.Point(449, 111);
            this.cbEstadoDentista.Name = "cbEstadoDentista";
            this.cbEstadoDentista.Size = new System.Drawing.Size(76, 21);
            this.cbEstadoDentista.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(446, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Estado";
            // 
            // txtTelefoneDentista
            // 
            this.txtTelefoneDentista.Location = new System.Drawing.Point(339, 159);
            this.txtTelefoneDentista.Mask = "(00) 00000-0000";
            this.txtTelefoneDentista.Name = "txtTelefoneDentista";
            this.txtTelefoneDentista.Size = new System.Drawing.Size(186, 20);
            this.txtTelefoneDentista.TabIndex = 68;
            this.txtTelefoneDentista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneDentista_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(47, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Especialidade";
            // 
            // txtEspDentista
            // 
            this.txtEspDentista.Location = new System.Drawing.Point(47, 159);
            this.txtEspDentista.Name = "txtEspDentista";
            this.txtEspDentista.Size = new System.Drawing.Size(286, 20);
            this.txtEspDentista.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(339, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(320, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "CRM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(47, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nome Completo";
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(47, 111);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(269, 20);
            this.txtNomeDentista.TabIndex = 65;
            // 
            // txtCRMDentista
            // 
            this.txtCRMDentista.Location = new System.Drawing.Point(323, 111);
            this.txtCRMDentista.Mask = "000000";
            this.txtCRMDentista.Name = "txtCRMDentista";
            this.txtCRMDentista.Size = new System.Drawing.Size(120, 20);
            this.txtCRMDentista.TabIndex = 75;
            // 
            // frmCadDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(568, 309);
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
            this.Controls.Add(this.btnLimparDentista);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCadDentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Dentista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimparDentista;
        private System.Windows.Forms.Button btnSalvarDentista;
        private System.Windows.Forms.ComboBox cbEstadoDentista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTelefoneDentista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspDentista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDentista;
        private System.Windows.Forms.MaskedTextBox txtCRMDentista;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}