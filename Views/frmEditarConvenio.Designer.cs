namespace ProjetoOdontoPOO.Views
{
    partial class frmEditarConvenio
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
            this.txtCNPJConvenio = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataConvenio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoConvenio = new System.Windows.Forms.TextBox();
            this.txtTelefoneConvenio = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarConvenio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailConvenio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeConvenio = new System.Windows.Forms.TextBox();
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
            // txtCNPJConvenio
            // 
            this.txtCNPJConvenio.Location = new System.Drawing.Point(477, 130);
            this.txtCNPJConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCNPJConvenio.Mask = "00.000.000/0000-00";
            this.txtCNPJConvenio.Name = "txtCNPJConvenio";
            this.txtCNPJConvenio.Size = new System.Drawing.Size(209, 22);
            this.txtCNPJConvenio.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(472, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 101;
            this.label6.Text = "Data de Criação";
            // 
            // dtpDataConvenio
            // 
            this.dtpDataConvenio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConvenio.Location = new System.Drawing.Point(476, 247);
            this.dtpDataConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataConvenio.Name = "dtpDataConvenio";
            this.dtpDataConvenio.Size = new System.Drawing.Size(211, 22);
            this.dtpDataConvenio.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(47, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 100;
            this.label5.Text = "Endereço";
            // 
            // txtEnderecoConvenio
            // 
            this.txtEnderecoConvenio.Location = new System.Drawing.Point(51, 247);
            this.txtEnderecoConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnderecoConvenio.Name = "txtEnderecoConvenio";
            this.txtEnderecoConvenio.Size = new System.Drawing.Size(416, 22);
            this.txtEnderecoConvenio.TabIndex = 91;
            // 
            // txtTelefoneConvenio
            // 
            this.txtTelefoneConvenio.Location = new System.Drawing.Point(51, 188);
            this.txtTelefoneConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefoneConvenio.Mask = "(00) 00000-0000";
            this.txtTelefoneConvenio.Name = "txtTelefoneConvenio";
            this.txtTelefoneConvenio.Size = new System.Drawing.Size(247, 22);
            this.txtTelefoneConvenio.TabIndex = 89;
            // 
            // btnSalvarConvenio
            // 
            this.btnSalvarConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarConvenio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarConvenio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConvenio.Location = new System.Drawing.Point(49, 464);
            this.btnSalvarConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvarConvenio.Name = "btnSalvarConvenio";
            this.btnSalvarConvenio.Size = new System.Drawing.Size(637, 43);
            this.btnSalvarConvenio.TabIndex = 94;
            this.btnSalvarConvenio.Text = "Salvar";
            this.btnSalvarConvenio.UseVisualStyleBackColor = false;
            this.btnSalvarConvenio.Click += new System.EventHandler(this.btnSalvarConvenio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(303, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 99;
            this.label4.Text = "E-mail";
            // 
            // txtEmailConvenio
            // 
            this.txtEmailConvenio.Location = new System.Drawing.Point(307, 188);
            this.txtEmailConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailConvenio.Name = "txtEmailConvenio";
            this.txtEmailConvenio.Size = new System.Drawing.Size(380, 22);
            this.txtEmailConvenio.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(47, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 98;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(472, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(47, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Nome";
            // 
            // txtNomeConvenio
            // 
            this.txtNomeConvenio.Location = new System.Drawing.Point(51, 130);
            this.txtNomeConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeConvenio.Name = "txtNomeConvenio";
            this.txtNomeConvenio.Size = new System.Drawing.Size(416, 22);
            this.txtNomeConvenio.TabIndex = 87;
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
            this.panel1.Size = new System.Drawing.Size(745, 58);
            this.panel1.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(687, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 102;
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
            this.label7.Location = new System.Drawing.Point(227, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Editar/Visualizar Convênio";
            // 
            // cbAtivoInativo
            // 
            this.cbAtivoInativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtivoInativo.FormattingEnabled = true;
            this.cbAtivoInativo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbAtivoInativo.Location = new System.Drawing.Point(50, 393);
            this.cbAtivoInativo.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtivoInativo.Name = "cbAtivoInativo";
            this.cbAtivoInativo.Size = new System.Drawing.Size(351, 24);
            this.cbAtivoInativo.TabIndex = 104;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(50, 370);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 19);
            this.label20.TabIndex = 103;
            this.label20.Text = "Convênio Ativo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(44, 311);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 28);
            this.label19.TabIndex = 102;
            this.label19.Text = "Desligamento";
            // 
            // frmEditarConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(745, 559);
            this.Controls.Add(this.cbAtivoInativo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCNPJConvenio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataConvenio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnderecoConvenio);
            this.Controls.Add(this.txtTelefoneConvenio);
            this.Controls.Add(this.btnSalvarConvenio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailConvenio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeConvenio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditarConvenio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Convênio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCNPJConvenio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataConvenio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoConvenio;
        private System.Windows.Forms.MaskedTextBox txtTelefoneConvenio;
        private System.Windows.Forms.Button btnSalvarConvenio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailConvenio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeConvenio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbAtivoInativo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}