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

            CarregarComboBoxes();
            CarregarDadosDentista();

            if (_modoVisualizacao)
            {
                DesabilitarCampos();
            }
        }

        private void CarregarComboBoxes()
        {
            cbAtivoInativo.Items.Clear();
            cbAtivoInativo.Items.Add("Ativo");
            cbAtivoInativo.Items.Add("Inativo");
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
                cbAtivoInativo.Text = dentista.Ativo_Inativo == 1 ? "Ativo" : "Inativo";
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
            btnSalvarDentista.Visible = false;
            cbAtivoInativo.Enabled = false;
        }

        private void btnSalvarDentista_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeDentista.Text;
                string crm = txtCRMDentista.Text;
                string estado = cbEstadoDentista.Text;
                string telefone = txtTelefoneDentista.Text;
                string especialidade = txtEspDentista.Text;

                string status = cbAtivoInativo.SelectedItem.ToString();
                int ativoInativo = status == "Ativo" ? 1 : 0;

                Dentista dentista = new Dentista
                {
                    Nome = nome,
                    CRM = crm,
                    Estado = estado,
                    Telefone = telefone,
                    Especialidade = especialidade,
                    Ativo_Inativo = ativoInativo
                };

                bool atualizado = _dentistaController.AtualizarDentista(_dentistaId, dentista);

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
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
