namespace ProjetoOdontoPOO.Views
{
    partial class frmCadConvenio
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
            this.txtTelefoneConvenio = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarConvenio = new System.Windows.Forms.Button();
            this.btnLimparConvenio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailConvenio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeConvenio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoConvenio = new System.Windows.Forms.TextBox();
            this.dtpDataConvenio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCNPJConvenio = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefoneConvenio
            // 
            this.txtTelefoneConvenio.Location = new System.Drawing.Point(39, 143);
            this.txtTelefoneConvenio.Mask = "(00) 00000-0000";
            this.txtTelefoneConvenio.Name = "txtTelefoneConvenio";
            this.txtTelefoneConvenio.Size = new System.Drawing.Size(186, 20);
            this.txtTelefoneConvenio.TabIndex = 3;
            this.txtTelefoneConvenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneConvenio_KeyPress);
            // 
            // btnSalvarConvenio
            // 
            this.btnSalvarConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarConvenio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarConvenio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConvenio.Location = new System.Drawing.Point(404, 244);
            this.btnSalvarConvenio.Name = "btnSalvarConvenio";
            this.btnSalvarConvenio.Size = new System.Drawing.Size(113, 35);
            this.btnSalvarConvenio.TabIndex = 8;
            this.btnSalvarConvenio.Text = "Salvar";
            this.btnSalvarConvenio.UseVisualStyleBackColor = false;
            this.btnSalvarConvenio.Click += new System.EventHandler(this.btnSalvarConvenio_Click);
            // 
            // btnLimparConvenio
            // 
            this.btnLimparConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparConvenio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparConvenio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparConvenio.Location = new System.Drawing.Point(39, 244);
            this.btnLimparConvenio.Name = "btnLimparConvenio";
            this.btnLimparConvenio.Size = new System.Drawing.Size(113, 35);
            this.btnLimparConvenio.TabIndex = 7;
            this.btnLimparConvenio.Text = "Limpar";
            this.btnLimparConvenio.UseVisualStyleBackColor = false;
            this.btnLimparConvenio.Click += new System.EventHandler(this.btnLimparConvenio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(228, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "E-mail";
            // 
            // txtEmailConvenio
            // 
            this.txtEmailConvenio.Location = new System.Drawing.Point(231, 143);
            this.txtEmailConvenio.Name = "txtEmailConvenio";
            this.txtEmailConvenio.Size = new System.Drawing.Size(286, 20);
            this.txtEmailConvenio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(355, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nome";
            // 
            // txtNomeConvenio
            // 
            this.txtNomeConvenio.Location = new System.Drawing.Point(39, 96);
            this.txtNomeConvenio.Name = "txtNomeConvenio";
            this.txtNomeConvenio.Size = new System.Drawing.Size(313, 20);
            this.txtNomeConvenio.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 47);
            this.panel1.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(180, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cadastrar Convênio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(36, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Endereço";
            // 
            // txtEnderecoConvenio
            // 
            this.txtEnderecoConvenio.Location = new System.Drawing.Point(39, 191);
            this.txtEnderecoConvenio.Name = "txtEnderecoConvenio";
            this.txtEnderecoConvenio.Size = new System.Drawing.Size(313, 20);
            this.txtEnderecoConvenio.TabIndex = 5;
            // 
            // dtpDataConvenio
            // 
            this.dtpDataConvenio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConvenio.Location = new System.Drawing.Point(358, 191);
            this.dtpDataConvenio.Name = "dtpDataConvenio";
            this.dtpDataConvenio.Size = new System.Drawing.Size(159, 20);
            this.dtpDataConvenio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(355, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Data de Criação";
            // 
            // txtCNPJConvenio
            // 
            this.txtCNPJConvenio.Location = new System.Drawing.Point(359, 96);
            this.txtCNPJConvenio.Mask = "00.000.000/0000-00";
            this.txtCNPJConvenio.Name = "txtCNPJConvenio";
            this.txtCNPJConvenio.Size = new System.Drawing.Size(158, 20);
            this.txtCNPJConvenio.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(515, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // frmCadConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(559, 332);
            this.Controls.Add(this.txtCNPJConvenio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataConvenio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnderecoConvenio);
            this.Controls.Add(this.txtTelefoneConvenio);
            this.Controls.Add(this.btnSalvarConvenio);
            this.Controls.Add(this.btnLimparConvenio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailConvenio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeConvenio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCadConvenio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Convênio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtTelefoneConvenio;
        private System.Windows.Forms.Button btnSalvarConvenio;
        private System.Windows.Forms.Button btnLimparConvenio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailConvenio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeConvenio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoConvenio;
        private System.Windows.Forms.DateTimePicker dtpDataConvenio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCNPJConvenio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}