namespace ProjetoOdontoPOO.Views
{
    partial class frmCadPagamento
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPacientePag = new System.Windows.Forms.TextBox();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorPag = new System.Windows.Forms.TextBox();
            this.cbStatusPag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarPagamento = new System.Windows.Forms.Button();
            this.dtpDataPag = new System.Windows.Forms.DateTimePicker();
            this.cbMetodoPag = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 62);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(573, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // txtPacientePag
            // 
            this.txtPacientePag.Location = new System.Drawing.Point(51, 124);
            this.txtPacientePag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPacientePag.Name = "txtPacientePag";
            this.txtPacientePag.Size = new System.Drawing.Size(480, 22);
            this.txtPacientePag.TabIndex = 2;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(538, 120);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(39, 28);
            this.btnPaciente.TabIndex = 37;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(330, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Valor";
            // 
            // txtValorPag
            // 
            this.txtValorPag.Location = new System.Drawing.Point(334, 187);
            this.txtValorPag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorPag.Name = "txtValorPag";
            this.txtValorPag.Size = new System.Drawing.Size(243, 22);
            this.txtValorPag.TabIndex = 39;
            this.txtValorPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPag_KeyPress);
            // 
            // cbStatusPag
            // 
            this.cbStatusPag.FormattingEnabled = true;
            this.cbStatusPag.Items.AddRange(new object[] {
            "Em aberto",
            "Pendente",
            "Pago"});
            this.cbStatusPag.Location = new System.Drawing.Point(51, 248);
            this.cbStatusPag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusPag.Name = "cbStatusPag";
            this.cbStatusPag.Size = new System.Drawing.Size(270, 24);
            this.cbStatusPag.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(47, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(323, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Método de Pagamento";
            // 
            // btnSalvarPagamento
            // 
            this.btnSalvarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarPagamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPagamento.Location = new System.Drawing.Point(49, 322);
            this.btnSalvarPagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvarPagamento.Name = "btnSalvarPagamento";
            this.btnSalvarPagamento.Size = new System.Drawing.Size(528, 43);
            this.btnSalvarPagamento.TabIndex = 46;
            this.btnSalvarPagamento.Text = "Confirmar Pagamento";
            this.btnSalvarPagamento.UseVisualStyleBackColor = false;
            this.btnSalvarPagamento.Click += new System.EventHandler(this.btnSalvarPagamento_Click);
            // 
            // dtpDataPag
            // 
            this.dtpDataPag.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPag.Location = new System.Drawing.Point(51, 187);
            this.dtpDataPag.Name = "dtpDataPag";
            this.dtpDataPag.Size = new System.Drawing.Size(277, 22);
            this.dtpDataPag.TabIndex = 47;
            // 
            // cbMetodoPag
            // 
            this.cbMetodoPag.FormattingEnabled = true;
            this.cbMetodoPag.Items.AddRange(new object[] {
            "Cartão",
            "Dinheiro",
            "Pix"});
            this.cbMetodoPag.Location = new System.Drawing.Point(327, 248);
            this.cbMetodoPag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMetodoPag.Name = "cbMetodoPag";
            this.cbMetodoPag.Size = new System.Drawing.Size(250, 24);
            this.cbMetodoPag.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(47, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Data de Pagamento";
            // 
            // frmCadPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(628, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMetodoPag);
            this.Controls.Add(this.dtpDataPag);
            this.Controls.Add(this.btnSalvarPagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatusPag);
            this.Controls.Add(this.txtValorPag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.txtPacientePag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmCadPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadPagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPacientePag;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorPag;
        private System.Windows.Forms.ComboBox cbStatusPag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarPagamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDataPag;
        private System.Windows.Forms.ComboBox cbMetodoPag;
        private System.Windows.Forms.Label label6;
    }
}