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
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObsConsulta = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPacienteConsulta = new System.Windows.Forms.ComboBox();
            this.cbDentistaConsulta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarConsulta = new System.Windows.Forms.Button();
            this.btnLimparConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 39);
            this.panel1.TabIndex = 0;
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataConsulta.Location = new System.Drawing.Point(57, 98);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(404, 20);
            this.dtpDataConsulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(54, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // txtObsConsulta
            // 
            this.txtObsConsulta.Location = new System.Drawing.Point(57, 151);
            this.txtObsConsulta.Name = "txtObsConsulta";
            this.txtObsConsulta.Size = new System.Drawing.Size(404, 96);
            this.txtObsConsulta.TabIndex = 3;
            this.txtObsConsulta.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(54, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Observações";
            // 
            // cbPacienteConsulta
            // 
            this.cbPacienteConsulta.FormattingEnabled = true;
            this.cbPacienteConsulta.Location = new System.Drawing.Point(57, 282);
            this.cbPacienteConsulta.Name = "cbPacienteConsulta";
            this.cbPacienteConsulta.Size = new System.Drawing.Size(217, 21);
            this.cbPacienteConsulta.TabIndex = 5;
            // 
            // cbDentistaConsulta
            // 
            this.cbDentistaConsulta.FormattingEnabled = true;
            this.cbDentistaConsulta.Location = new System.Drawing.Point(280, 282);
            this.cbDentistaConsulta.Name = "cbDentistaConsulta";
            this.cbDentistaConsulta.Size = new System.Drawing.Size(181, 21);
            this.cbDentistaConsulta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(54, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(277, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dentista";
            // 
            // btnSalvarConsulta
            // 
            this.btnSalvarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConsulta.Location = new System.Drawing.Point(348, 352);
            this.btnSalvarConsulta.Name = "btnSalvarConsulta";
            this.btnSalvarConsulta.Size = new System.Drawing.Size(113, 35);
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
            this.btnLimparConsulta.Location = new System.Drawing.Point(57, 352);
            this.btnLimparConsulta.Name = "btnLimparConsulta";
            this.btnLimparConsulta.Size = new System.Drawing.Size(113, 35);
            this.btnLimparConsulta.TabIndex = 9;
            this.btnLimparConsulta.Text = "Limpar";
            this.btnLimparConsulta.UseVisualStyleBackColor = false;
            this.btnLimparConsulta.Click += new System.EventHandler(this.btnLimparConsulta_Click);
            // 
            // frmAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(517, 431);
            this.Controls.Add(this.btnSalvarConsulta);
            this.Controls.Add(this.btnLimparConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDentistaConsulta);
            this.Controls.Add(this.cbPacienteConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObsConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataConsulta);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgendarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgendarConsulta";
            this.Load += new System.EventHandler(this.frmAgendarConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDataConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtObsConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPacienteConsulta;
        private System.Windows.Forms.ComboBox cbDentistaConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarConsulta;
        private System.Windows.Forms.Button btnLimparConsulta;
    }
}