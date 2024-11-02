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
            this.cbSelecionarArquivo = new System.Windows.Forms.ComboBox();
            this.cbPacienteArquivo = new System.Windows.Forms.ComboBox();
            this.cbDentistaArquivo = new System.Windows.Forms.ComboBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 53);
            this.panel1.TabIndex = 0;
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
            // cbPacienteArquivo
            // 
            this.cbPacienteArquivo.FormattingEnabled = true;
            this.cbPacienteArquivo.Location = new System.Drawing.Point(52, 223);
            this.cbPacienteArquivo.Name = "cbPacienteArquivo";
            this.cbPacienteArquivo.Size = new System.Drawing.Size(315, 21);
            this.cbPacienteArquivo.TabIndex = 3;
            // 
            // cbDentistaArquivo
            // 
            this.cbDentistaArquivo.FormattingEnabled = true;
            this.cbDentistaArquivo.Location = new System.Drawing.Point(373, 223);
            this.cbDentistaArquivo.Name = "cbDentistaArquivo";
            this.cbDentistaArquivo.Size = new System.Drawing.Size(307, 21);
            this.cbDentistaArquivo.TabIndex = 4;
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
            this.label5.Location = new System.Drawing.Point(371, 204);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(248, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "Gerar Receita ou Atestado";
            // 
            // frmGerarReceitaAtestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(739, 574);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.btnLimparArquivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObsArquivo);
            this.Controls.Add(this.cbDentistaArquivo);
            this.Controls.Add(this.cbPacienteArquivo);
            this.Controls.Add(this.cbSelecionarArquivo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGerarReceitaAtestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerarReceitaAtestado";
            this.Load += new System.EventHandler(this.frmGerarReceitaAtestado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSelecionarArquivo;
        private System.Windows.Forms.ComboBox cbPacienteArquivo;
        private System.Windows.Forms.ComboBox cbDentistaArquivo;
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
    }
}