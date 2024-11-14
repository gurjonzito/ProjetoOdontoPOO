using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmAgendarConsulta : Form
    {
        private readonly ConsultaController _consultaController;
        private readonly PacienteController _pacienteController;
        private readonly DentistaController _dentistaController;

        Paciente pacienteConsulta;
        Dentista dentistaConsulta;

        public frmAgendarConsulta()
        {
            InitializeComponent();

            _consultaController = new ConsultaController();
            _pacienteController = new PacienteController();
            _dentistaController = new DentistaController();
        }

        private void frmAgendarConsulta_Load(object sender, EventArgs e)
        {
            DefinirDataHora();
        }

        private void DefinirDataHora()
        {
            dtpDataConsulta.Format = DateTimePickerFormat.Custom;
            dtpDataConsulta.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            PesquisarPaciente();
        }

        private void btnDentista_Click(object sender, EventArgs e)
        {
            PesquisarDentista();
        }

        private void PesquisarPaciente()
        {
            frmSelecionarPaciente frm = new frmSelecionarPaciente(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pacienteConsulta = frm.pacienteSelecao;

                txtPaciente.Text = pacienteConsulta.Nome;
            }
        }

        private void PesquisarDentista()
        {
            frmSelecionarDentista frm = new frmSelecionarDentista(true);
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                dentistaConsulta = frm.dentistaSelecao;

                txtDentista.Text = dentistaConsulta.Nome;
            }
        }

        private void btnSalvarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                var consulta = CriarConsulta();

                string mensagem = _consultaController.InserirConsulta(consulta);
                MessageBox.Show(mensagem);

                if (mensagem.Contains("Consulta agendada com sucesso!"))
                {
                    LimparCampos();
                    dtpDataConsulta.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Consulta CriarConsulta()
        {
            // Cria a nova consulta
            return new Consulta
            {
                DataConsulta = dtpDataConsulta.Value,
                Observacoes = txtObsConsulta.Text,
                Paciente = pacienteConsulta,
                Dentista = dentistaConsulta
            };
        }

        private void btnLimparConsulta_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtObsConsulta.Clear();
            txtPaciente.Clear();
            txtDentista.Clear();

            dtpDataConsulta.Value = DateTime.Now;

            dtpDataConsulta.Focus();
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
