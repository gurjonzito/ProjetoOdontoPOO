namespace ProjetoOdontoPOO.Views
{
    partial class frmGerarReceitaAtestado
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbSelecionarArquivo = new System.Windows.Forms.ComboBox();
            this.txtObsArquivo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataArquivo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.btnLimparArquivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnDentista = new System.Windows.Forms.Button();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 53);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(695, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 59;
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
            this.label7.Location = new System.Drawing.Point(250, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "Gerar Receita ou Atestado";
            // 
            // cbSelecionarArquivo
            // 
            this.cbSelecionarArquivo.FormattingEnabled = true;
            this.cbSelecionarArquivo.Items.AddRange(new object[] {
            "Atestado",
            "Receita"});
            this.cbSelecionarArquivo.Location = new System.Drawing.Point(52, 109);
            this.cbSelecionarArquivo.Name = "cbSelecionarArquivo";
            this.cbSelecionarArquivo.Size = new System.Drawing.Size(286, 21);
            this.cbSelecionarArquivo.TabIndex = 1;
            // 
            // txtObsArquivo
            // 
            this.txtObsArquivo.Location = new System.Drawing.Point(54, 289);
            this.txtObsArquivo.Name = "txtObsArquivo";
            this.txtObsArquivo.Size = new System.Drawing.Size(626, 171);
            this.txtObsArquivo.TabIndex = 5;
            this.txtObsArquivo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o tipo de documento";
            // 
            // dtpDataArquivo
            // 
            this.dtpDataArquivo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataArquivo.Location = new System.Drawing.Point(53, 166);
            this.dtpDataArquivo.Name = "dtpDataArquivo";
            this.dtpDataArquivo.Size = new System.Drawing.Size(200, 20);
            this.dtpDataArquivo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selecione a data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(50, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(388, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dentista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(51, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGerarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarArquivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarArquivo.Location = new System.Drawing.Point(567, 496);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(113, 35);
            this.btnGerarArquivo.TabIndex = 58;
            this.btnGerarArquivo.Text = "Gerar";
            this.btnGerarArquivo.UseVisualStyleBackColor = false;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarDocumento_Click);
            // 
            // btnLimparArquivo
            // 
            this.btnLimparArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparArquivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparArquivo.Location = new System.Drawing.Point(53, 496);
            this.btnLimparArquivo.Name = "btnLimparArquivo";
            this.btnLimparArquivo.Size = new System.Drawing.Size(113, 35);
            this.btnLimparArquivo.TabIndex = 57;
            this.btnLimparArquivo.Text = "Limpar";
            this.btnLimparArquivo.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(356, 222);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(29, 23);
            this.btnPaciente.TabIndex = 59;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnDentista
            // 
            this.btnDentista.Location = new System.Drawing.Point(651, 222);
            this.btnDentista.Name = "btnDentista";
            this.btnDentista.Size = new System.Drawing.Size(29, 23);
            this.btnDentista.TabIndex = 60;
            this.btnDentista.Text = "...";
            this.btnDentista.UseVisualStyleBackColor = true;
            this.btnDentista.Click += new System.EventHandler(this.btnDentista_Click);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(54, 225);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.ReadOnly = true;
            this.txtNomePaciente.Size = new System.Drawing.Size(297, 20);
            this.txtNomePaciente.TabIndex = 61;
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Location = new System.Drawing.Point(391, 225);
            this.txtNomeDentista.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.ReadOnly = true;
            this.txtNomeDentista.Size = new System.Drawing.Size(255, 20);
            this.txtNomeDentista.TabIndex = 62;
            // 
            // frmGerarReceitaAtestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(739, 574);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.btnLimparArquivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObsArquivo);
            this.Controls.Add(this.cbSelecionarArquivo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmGerarReceitaAtestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Receita ou Atestado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSelecionarArquivo;
        private System.Windows.Forms.RichTextBox txtObsArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.Button btnLimparArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnDentista;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtNomeDentista;
    }
}