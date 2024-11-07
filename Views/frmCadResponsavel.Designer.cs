namespace ProjetoOdontoPOO.Views
{
    partial class frmCadResponsavel
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
            this.btnSalvarResponsavel = new System.Windows.Forms.Button();
            this.btnLimparResponsavel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSexoRes = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIdadeRes = new System.Windows.Forms.TextBox();
            this.txtCPFRes = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefoneRes = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParentescoRes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataRes = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeRes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarResponsavel
            // 
            this.btnSalvarResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvarResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarResponsavel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarResponsavel.Location = new System.Drawing.Point(410, 265);
            this.btnSalvarResponsavel.Name = "btnSalvarResponsavel";
            this.btnSalvarResponsavel.Size = new System.Drawing.Size(113, 35);
            this.btnSalvarResponsavel.TabIndex = 57;
            this.btnSalvarResponsavel.Text = "Salvar";
            this.btnSalvarResponsavel.UseVisualStyleBackColor = false;
            this.btnSalvarResponsavel.Click += new System.EventHandler(this.btnSalvarResponsavel_Click);
            // 
            // btnLimparResponsavel
            // 
            this.btnLimparResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimparResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparResponsavel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparResponsavel.Location = new System.Drawing.Point(45, 265);
            this.btnLimparResponsavel.Name = "btnLimparResponsavel";
            this.btnLimparResponsavel.Size = new System.Drawing.Size(113, 35);
            this.btnLimparResponsavel.TabIndex = 56;
            this.btnLimparResponsavel.Text = "Limpar";
            this.btnLimparResponsavel.UseVisualStyleBackColor = false;
            this.btnLimparResponsavel.Click += new System.EventHandler(this.btnLimparResponsavel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 47);
            this.panel1.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(170, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cadastrar Responsável";
            // 
            // cbSexoRes
            // 
            this.cbSexoRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexoRes.FormattingEnabled = true;
            this.cbSexoRes.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexoRes.Location = new System.Drawing.Point(297, 151);
            this.cbSexoRes.Name = "cbSexoRes";
            this.cbSexoRes.Size = new System.Drawing.Size(226, 21);
            this.cbSexoRes.TabIndex = 71;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(297, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 78;
            this.label18.Text = "Sexo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(45, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 77;
            this.label17.Text = "Idade";
            // 
            // txtIdadeRes
            // 
            this.txtIdadeRes.Location = new System.Drawing.Point(45, 151);
            this.txtIdadeRes.Name = "txtIdadeRes";
            this.txtIdadeRes.ReadOnly = true;
            this.txtIdadeRes.Size = new System.Drawing.Size(54, 20);
            this.txtIdadeRes.TabIndex = 68;
            // 
            // txtCPFRes
            // 
            this.txtCPFRes.Location = new System.Drawing.Point(105, 151);
            this.txtCPFRes.Mask = "999.999.999-99";
            this.txtCPFRes.Name = "txtCPFRes";
            this.txtCPFRes.Size = new System.Drawing.Size(186, 20);
            this.txtCPFRes.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(105, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 16);
            this.label16.TabIndex = 76;
            this.label16.Text = "CPF";
            // 
            // txtTelefoneRes
            // 
            this.txtTelefoneRes.Location = new System.Drawing.Point(45, 198);
            this.txtTelefoneRes.Mask = "(00) 00000-0000";
            this.txtTelefoneRes.Name = "txtTelefoneRes";
            this.txtTelefoneRes.Size = new System.Drawing.Size(186, 20);
            this.txtTelefoneRes.TabIndex = 73;
            this.txtTelefoneRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneRes_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(237, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Parentesco";
            // 
            // txtParentescoRes
            // 
            this.txtParentescoRes.Location = new System.Drawing.Point(237, 198);
            this.txtParentescoRes.Name = "txtParentescoRes";
            this.txtParentescoRes.Size = new System.Drawing.Size(286, 20);
            this.txtParentescoRes.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(45, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(362, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "Data de Nascimento";
            // 
            // dtpDataRes
            // 
            this.dtpDataRes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRes.Location = new System.Drawing.Point(365, 103);
            this.dtpDataRes.Name = "dtpDataRes";
            this.dtpDataRes.Size = new System.Drawing.Size(158, 20);
            this.dtpDataRes.TabIndex = 66;
            this.dtpDataRes.Leave += new System.EventHandler(this.dtpDataRes_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(45, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Nome Completo";
            // 
            // txtNomeRes
            // 
            this.txtNomeRes.Location = new System.Drawing.Point(45, 103);
            this.txtNomeRes.Name = "txtNomeRes";
            this.txtNomeRes.Size = new System.Drawing.Size(313, 20);
            this.txtNomeRes.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProjetoOdontoPOO.Properties.Resources.icons8_close_window_32_outro;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(520, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // frmCadResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(566, 336);
            this.Controls.Add(this.cbSexoRes);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtIdadeRes);
            this.Controls.Add(this.txtCPFRes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTelefoneRes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParentescoRes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataRes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomeRes);
            this.Controls.Add(this.btnSalvarResponsavel);
            this.Controls.Add(this.btnLimparResponsavel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCadResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Responsável";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvarResponsavel;
        private System.Windows.Forms.Button btnLimparResponsavel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSexoRes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIdadeRes;
        private System.Windows.Forms.MaskedTextBox txtCPFRes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtTelefoneRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParentescoRes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataRes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeRes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}