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
            this.panel1.Location = new System.Drawing.Point(-4, -9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 65);
            this.panel1.TabIndex = 0;
            // 
            // cbSelecionarArquivo
            // 
            this.cbSelecionarArquivo.FormattingEnabled = true;
            this.cbSelecionarArquivo.Items.AddRange(new object[] {
            "Atestado",
            "Receita"});
            this.cbSelecionarArquivo.Location = new System.Drawing.Point(72, 134);
            this.cbSelecionarArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelecionarArquivo.Name = "cbSelecionarArquivo";
            this.cbSelecionarArquivo.Size = new System.Drawing.Size(380, 24);
            this.cbSelecionarArquivo.TabIndex = 1;
            // 
            // cbPacienteArquivo
            // 
            this.cbPacienteArquivo.FormattingEnabled = true;
            this.cbPacienteArquivo.Location = new System.Drawing.Point(70, 198);
            this.cbPacienteArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPacienteArquivo.Name = "cbPacienteArquivo";
            this.cbPacienteArquivo.Size = new System.Drawing.Size(419, 24);
            this.cbPacienteArquivo.TabIndex = 3;
            // 
            // cbDentistaArquivo
            // 
            this.cbDentistaArquivo.FormattingEnabled = true;
            this.cbDentistaArquivo.Location = new System.Drawing.Point(498, 198);
            this.cbDentistaArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDentistaArquivo.Name = "cbDentistaArquivo";
            this.cbDentistaArquivo.Size = new System.Drawing.Size(408, 24);
            this.cbDentistaArquivo.TabIndex = 4;
            // 
            // txtObsArquivo
            // 
            this.txtObsArquivo.Location = new System.Drawing.Point(72, 279);
            this.txtObsArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObsArquivo.Name = "txtObsArquivo";
            this.txtObsArquivo.Size = new System.Drawing.Size(833, 210);
            this.txtObsArquivo.TabIndex = 5;
            this.txtObsArquivo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o tipo de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(67, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(495, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dentista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(68, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGerarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarArquivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarArquivo.Location = new System.Drawing.Point(756, 534);
            this.btnGerarArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(151, 43);
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
            this.btnLimparArquivo.Location = new System.Drawing.Point(71, 534);
            this.btnLimparArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparArquivo.Name = "btnLimparArquivo";
            this.btnLimparArquivo.Size = new System.Drawing.Size(151, 43);
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
            this.label7.Location = new System.Drawing.Point(315, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 28);
            this.label7.TabIndex = 59;
            this.label7.Text = "Gerador de Atestados e Receitas";
            // 
            // frmGerarReceitaAtestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(985, 632);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.btnLimparArquivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObsArquivo);
            this.Controls.Add(this.cbDentistaArquivo);
            this.Controls.Add(this.cbPacienteArquivo);
            this.Controls.Add(this.cbSelecionarArquivo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.Button btnLimparArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
    }
}