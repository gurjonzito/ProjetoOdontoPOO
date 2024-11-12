namespace ProjetoOdontoPOO.Views
{
    partial class frmAgendarConsulta
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
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObsConsulta = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarConsulta = new System.Windows.Forms.Button();
            this.btnLimparConsulta = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnDentista = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtDentista = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(689, 48);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(633, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 11;
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
            this.label7.Location = new System.Drawing.Point(220, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 28);
            this.label7.TabIndex = 60;
            this.label7.Text = "Agendar Consulta";
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataConsulta.Location = new System.Drawing.Point(76, 121);
            this.dtpDataConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(537, 22);
            this.dtpDataConsulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(72, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // txtObsConsulta
            // 
            this.txtObsConsulta.Location = new System.Drawing.Point(76, 186);
            this.txtObsConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObsConsulta.Name = "txtObsConsulta";
            this.txtObsConsulta.Size = new System.Drawing.Size(537, 117);
            this.txtObsConsulta.TabIndex = 3;
            this.txtObsConsulta.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(72, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Observações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(72, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(345, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dentista";
            // 
            // btnSalvarConsulta
            // 
            this.btnSalvarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConsulta.Location = new System.Drawing.Point(464, 433);
            this.btnSalvarConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvarConsulta.Name = "btnSalvarConsulta";
            this.btnSalvarConsulta.Size = new System.Drawing.Size(151, 43);
            this.btnSalvarConsulta.TabIndex = 10;
            this.btnSalvarConsulta.Text = "Salvar";
            this.btnSalvarConsulta.UseVisualStyleBackColor = false;
            this.btnSalvarConsulta.Click += new System.EventHandler(this.btnSalvarConsulta_Click);
            // 
            // btnLimparConsulta
            // 
            this.btnLimparConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparConsulta.Location = new System.Drawing.Point(76, 433);
            this.btnLimparConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparConsulta.Name = "btnLimparConsulta";
            this.btnLimparConsulta.Size = new System.Drawing.Size(151, 43);
            this.btnLimparConsulta.TabIndex = 9;
            this.btnLimparConsulta.Text = "Limpar";
            this.btnLimparConsulta.UseVisualStyleBackColor = false;
            this.btnLimparConsulta.Click += new System.EventHandler(this.btnLimparConsulta_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(303, 345);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(39, 28);
            this.btnPaciente.TabIndex = 38;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnDentista
            // 
            this.btnDentista.Location = new System.Drawing.Point(576, 345);
            this.btnDentista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDentista.Name = "btnDentista";
            this.btnDentista.Size = new System.Drawing.Size(39, 28);
            this.btnDentista.TabIndex = 39;
            this.btnDentista.Text = "...";
            this.btnDentista.UseVisualStyleBackColor = true;
            this.btnDentista.Click += new System.EventHandler(this.btnDentista_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(76, 348);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(220, 22);
            this.txtPaciente.TabIndex = 40;
            // 
            // txtDentista
            // 
            this.txtDentista.Location = new System.Drawing.Point(349, 348);
            this.txtDentista.Name = "txtDentista";
            this.txtDentista.Size = new System.Drawing.Size(220, 22);
            this.txtDentista.TabIndex = 41;
            // 
            // frmAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(689, 530);
            this.Controls.Add(this.txtDentista);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnSalvarConsulta);
            this.Controls.Add(this.btnLimparConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObsConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataConsulta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgendarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Consulta";
            this.Load += new System.EventHandler(this.frmAgendarConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDataConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtObsConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarConsulta;
        private System.Windows.Forms.Button btnLimparConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnDentista;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtDentista;
    }
}