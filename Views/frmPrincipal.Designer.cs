namespace ProjetoOdontoPOO.Views
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResponsavel = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnReceitaAtestado = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnDentista = new System.Windows.Forms.Button();
            this.btnConvenio = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1696, 52);
            this.panel1.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Window;
            this.lblData.Location = new System.Drawing.Point(1422, 17);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 24);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "00/00/0000";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(1540, 12);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(120, 31);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnResponsavel);
            this.panel2.Controls.Add(this.btnVisualizar);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnPagamento);
            this.panel2.Controls.Add(this.btnReceitaAtestado);
            this.panel2.Controls.Add(this.btnConsulta);
            this.panel2.Controls.Add(this.btnDentista);
            this.panel2.Controls.Add(this.btnConvenio);
            this.panel2.Controls.Add(this.btnPaciente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 870);
            this.panel2.TabIndex = 1;
            // 
            // btnSobre
            // 
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(16, 677);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(4);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(299, 49);
            this.btnSobre.TabIndex = 7;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(16, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Outros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cadastrar";
            // 
            // btnResponsavel
            // 
            this.btnResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponsavel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponsavel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnResponsavel.Image = ((System.Drawing.Image)(resources.GetObject("btnResponsavel.Image")));
            this.btnResponsavel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResponsavel.Location = new System.Drawing.Point(16, 274);
            this.btnResponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.btnResponsavel.Name = "btnResponsavel";
            this.btnResponsavel.Size = new System.Drawing.Size(299, 49);
            this.btnResponsavel.TabIndex = 4;
            this.btnResponsavel.Text = "Responsável";
            this.btnResponsavel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResponsavel.UseVisualStyleBackColor = true;
            this.btnResponsavel.Click += new System.EventHandler(this.btnResponsavel_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(16, 608);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(299, 49);
            this.btnVisualizar.TabIndex = 9;
            this.btnVisualizar.Text = "Visualizar Cadastros";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(16, 806);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(299, 49);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.Location = new System.Drawing.Point(16, 539);
            this.btnPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(299, 49);
            this.btnPagamento.TabIndex = 8;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnReceitaAtestado
            // 
            this.btnReceitaAtestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitaAtestado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceitaAtestado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReceitaAtestado.Image = ((System.Drawing.Image)(resources.GetObject("btnReceitaAtestado.Image")));
            this.btnReceitaAtestado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitaAtestado.Location = new System.Drawing.Point(16, 470);
            this.btnReceitaAtestado.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceitaAtestado.Name = "btnReceitaAtestado";
            this.btnReceitaAtestado.Size = new System.Drawing.Size(299, 49);
            this.btnReceitaAtestado.TabIndex = 6;
            this.btnReceitaAtestado.Text = "Gerar Receita/Atestado";
            this.btnReceitaAtestado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceitaAtestado.UseVisualStyleBackColor = true;
            this.btnReceitaAtestado.Click += new System.EventHandler(this.btnReceitaAtestado_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(16, 402);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(299, 49);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Agendar Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnDentista
            // 
            this.btnDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDentista.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDentista.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDentista.Image = ((System.Drawing.Image)(resources.GetObject("btnDentista.Image")));
            this.btnDentista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDentista.Location = new System.Drawing.Point(16, 207);
            this.btnDentista.Margin = new System.Windows.Forms.Padding(4);
            this.btnDentista.Name = "btnDentista";
            this.btnDentista.Size = new System.Drawing.Size(299, 49);
            this.btnDentista.TabIndex = 3;
            this.btnDentista.Text = "Dentista";
            this.btnDentista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDentista.UseVisualStyleBackColor = true;
            this.btnDentista.Click += new System.EventHandler(this.btnDentista_Click);
            // 
            // btnConvenio
            // 
            this.btnConvenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvenio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvenio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConvenio.Image = ((System.Drawing.Image)(resources.GetObject("btnConvenio.Image")));
            this.btnConvenio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvenio.Location = new System.Drawing.Point(16, 138);
            this.btnConvenio.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvenio.Name = "btnConvenio";
            this.btnConvenio.Size = new System.Drawing.Size(299, 49);
            this.btnConvenio.TabIndex = 2;
            this.btnConvenio.Text = "Convênio";
            this.btnConvenio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvenio.UseVisualStyleBackColor = true;
            this.btnConvenio.Click += new System.EventHandler(this.btnConvenio_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(16, 70);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(299, 49);
            this.btnPaciente.TabIndex = 0;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(649, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 470);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 922);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnDentista;
        private System.Windows.Forms.Button btnConvenio;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnReceitaAtestado;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnResponsavel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
    }
}