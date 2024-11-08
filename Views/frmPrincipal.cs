using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            AtualizaDataHora();

            btnPaciente.FlatAppearance.BorderSize = 0;
            btnDentista.FlatAppearance.BorderSize = 0;
            btnConvenio.FlatAppearance.BorderSize = 0;
            btnConsulta.FlatAppearance.BorderSize = 0;
            btnPagamento.FlatAppearance.BorderSize = 0;
            btnReceitaAtestado.FlatAppearance.BorderSize = 0;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnResponsavel.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.BorderSize = 0;
        }

        public void AtualizaDataHora()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizaDataHora();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmCadPaciente frm = new frmCadPaciente();
            frm.ShowDialog();
        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            frmCadConvenio frm = new frmCadConvenio();
            frm.ShowDialog();
        }

        private void btnDentista_Click(object sender, EventArgs e)
        {
            frmCadDentista frm = new frmCadDentista();
            frm.ShowDialog();
        }

        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            frmCadResponsavel frm = new frmCadResponsavel();
            frm.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmAgendarConsulta frm = new frmAgendarConsulta();
            frm.ShowDialog();
        }

        private void btnReceitaAtestado_Click(object sender, EventArgs e)
        {
            frmGerarReceitaAtestado frm = new frmGerarReceitaAtestado();
            frm.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmViewCadastros frm = new frmViewCadastros();
            frm.ShowDialog();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmCadPagamento frm = new frmCadPagamento();
            frm.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o programa?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Meditooth - Versão: " + Application.ProductVersion.ToString();
        }


    }
}
