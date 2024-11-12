using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmEditarDentista : Form
    {
        private readonly DentistaController _dentistaController;
        private int _dentistaId;
        private bool _modoVisualizacao;
        public frmEditarDentista(int dentistaId, bool modoVisualizacao = false)
        {
            InitializeComponent();

            _dentistaId = dentistaId;

            _modoVisualizacao = modoVisualizacao;

            _dentistaController = new DentistaController();

            CarregarDadosDentista();

            if (_modoVisualizacao)
            {
                DesabilitarCampos();
            }
        }

        private void CarregarDadosDentista()
        {
            Dentista dentista = _dentistaController.ObterDentistaPorId(_dentistaId);

            if (dentista != null)
            {
                txtNomeDentista.Text = dentista.Nome;
                txtCRMDentista.Text = dentista.CRM;
                cbEstadoDentista.Text = dentista.Estado;
                txtEspDentista.Text = dentista.Especialidade;
                txtTelefoneDentista.Text = dentista.Telefone;
            }
            else
            {
                MessageBox.Show($"Dentista com ID {_dentistaId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesabilitarCampos()
        {
            txtNomeDentista.Enabled = false;
            txtCRMDentista.Enabled = false;
            txtEspDentista.Enabled = false;
            txtTelefoneDentista.Enabled = false;
            cbEstadoDentista.Enabled = false;
            btnLimparDentista.Visible = false;
            btnSalvarDentista.Visible = false;
        }

        private void btnSalvarDentista_Click(object sender, EventArgs e)
        {
            // Coleta os dados do paciente
            string nome = txtNomeDentista.Text;
            string crm = txtCRMDentista.Text;
            string estado = cbEstadoDentista.Text;
            string telefone = txtTelefoneDentista.Text;
            string especialidade = txtEspDentista.Text;

            // Cria o objeto de Paciente
            Dentista dentista = new Dentista
            {
                Nome = nome,
                CRM = crm,
                Estado = estado,
                Telefone = telefone,
                Especialidade = especialidade,
            };

            // Chama o método de atualização com os objetos Paciente e Endereço
            bool atualizado = _dentistaController.AtualizarDentista(_dentistaId, dentista);

            // Exibe o resultado
            if (atualizado)
            {
                MessageBox.Show("Dentista atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o dentista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparDentista_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomeDentista.Clear();
            txtCRMDentista.Clear();
            txtEspDentista.Clear();
            txtTelefoneDentista.Clear();

            // Resetar ComboBoxes
            cbEstadoDentista.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_fechar_janela_32;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_close_window_32_outro;
        }
    }
}
