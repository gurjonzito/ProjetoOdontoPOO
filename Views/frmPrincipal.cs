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

            btnPaciente.FlatAppearance.BorderSize = 0;
            btnDentista.FlatAppearance.BorderSize = 0;
            btnConvenio.FlatAppearance.BorderSize = 0;
            btnConsulta.FlatAppearance.BorderSize = 0;
            btnPagamento.FlatAppearance.BorderSize = 0;
            btnReceita.FlatAppearance.BorderSize = 0;
            btnAtestado.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.BorderSize = 0;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmCadPaciente frm = new frmCadPaciente();
            frm.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmAgendarConsulta frm = new frmAgendarConsulta();
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
    }
}
