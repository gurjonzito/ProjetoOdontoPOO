﻿namespace ProjetoOdontoPOO.Views
{
    partial class frmEditarConsulta
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
            this.txtDentista = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.btnDentista = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnSalvarConsulta = new System.Windows.Forms.Button();
            this.btnLimparConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObsConsulta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDentista
            // 
            this.txtDentista.Location = new System.Drawing.Point(334, 332);
            this.txtDentista.Name = "txtDentista";
            this.txtDentista.Size = new System.Drawing.Size(220, 22);
            this.txtDentista.TabIndex = 54;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(61, 332);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(220, 22);
            this.txtPaciente.TabIndex = 53;
            // 
            // btnDentista
            // 
            this.btnDentista.Location = new System.Drawing.Point(561, 329);
            this.btnDentista.Margin = new System.Windows.Forms.Padding(4);
            this.btnDentista.Name = "btnDentista";
            this.btnDentista.Size = new System.Drawing.Size(39, 28);
            this.btnDentista.TabIndex = 52;
            this.btnDentista.Text = "...";
            this.btnDentista.UseVisualStyleBackColor = true;
            this.btnDentista.Click += new System.EventHandler(this.btnDentista_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(288, 329);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(39, 28);
            this.btnPaciente.TabIndex = 51;
            this.btnPaciente.Text = "...";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnSalvarConsulta
            // 
            this.btnSalvarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConsulta.Location = new System.Drawing.Point(447, 407);
            this.btnSalvarConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarConsulta.Name = "btnSalvarConsulta";
            this.btnSalvarConsulta.Size = new System.Drawing.Size(151, 43);
            this.btnSalvarConsulta.TabIndex = 50;
            this.btnSalvarConsulta.Text = "Salvar";
            this.btnSalvarConsulta.UseVisualStyleBackColor = false;
            this.btnSalvarConsulta.Click += new System.EventHandler(this.btnSalvarConsulta_Click);
            // 
            // btnLimparConsulta
            // 
            this.btnLimparConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparConsulta.Location = new System.Drawing.Point(59, 407);
            this.btnLimparConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparConsulta.Name = "btnLimparConsulta";
            this.btnLimparConsulta.Size = new System.Drawing.Size(151, 43);
            this.btnLimparConsulta.TabIndex = 49;
            this.btnLimparConsulta.Text = "Limpar";
            this.btnLimparConsulta.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(330, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Dentista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(57, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(57, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Observações";
            // 
            // txtObsConsulta
            // 
            this.txtObsConsulta.Location = new System.Drawing.Point(61, 170);
            this.txtObsConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtObsConsulta.Name = "txtObsConsulta";
            this.txtObsConsulta.Size = new System.Drawing.Size(537, 117);
            this.txtObsConsulta.TabIndex = 45;
            this.txtObsConsulta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Data";
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataConsulta.Location = new System.Drawing.Point(61, 105);
            this.dtpDataConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(537, 22);
            this.dtpDataConsulta.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 48);
            this.panel1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(239, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 28);
            this.label7.TabIndex = 60;
            this.label7.Text = "Editar Consulta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(598, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmEditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(659, 501);
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
            this.MaximizeBox = false;
            this.Name = "frmEditarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarConsulta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDentista;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Button btnDentista;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnSalvarConsulta;
        private System.Windows.Forms.Button btnLimparConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtObsConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}