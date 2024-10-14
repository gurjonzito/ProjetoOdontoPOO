using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
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
    public partial class frmCadDentista : Form
    {
        private readonly DentistaController _dentistaController;

        public frmCadDentista()
        {
            InitializeComponent();

            _dentistaController = new DentistaController();
        }

        private void btnSalvarDentista_Click(object sender, EventArgs e)
        {
            var dentista = CriarDentista();

            string mensagem = _dentistaController.InserirDentista(dentista);
            MessageBox.Show(mensagem);

            if (mensagem.Contains("Dentista cadastrado com sucesso!"))
            {
                LimparCampos();
            }
        }

        private Dentista CriarDentista()
        {
            return new Dentista
            {
                Nome = txtNomeDentista.Text,
                CRM = txtCRMDentista.Text,
                Estado = cbEstadoDentista.Text,
                Especialidade = txtEspDentista.Text,
                Telefone = txtTelefoneDentista.Text,
            };
        }

        private void btnLimparDentista_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void ValidarEntradaNumerica(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefoneDentista_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void LimparCampos()
        {
            txtNomeDentista.Clear();
            txtCRMDentista.Clear();
            txtEspDentista.Clear();
            txtTelefoneDentista.Clear();

            cbEstadoDentista.SelectedIndex = -1;
        }
    }
}
