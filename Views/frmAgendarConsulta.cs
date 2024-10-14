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
    public partial class frmAgendarConsulta : Form
    {
        private readonly ConsultaController _consultaController;
        private readonly PacienteController _pacienteController;
        private readonly DentistaController _dentistaController;

        public frmAgendarConsulta()
        {
            InitializeComponent();

            _consultaController = new ConsultaController();
            _pacienteController = new PacienteController();
            _dentistaController = new DentistaController();
        }

        private void frmAgendarConsulta_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxPaciente();
            ConfigurarComboBoxDentista();
        }

        private void ConfigurarComboBoxPaciente()
        {
            var pacientes = _pacienteController.ObterTodosPacientes(); // Obtenha a lista de pacientes
            cbPacienteConsulta.DataSource = pacientes; // Defina a fonte de dados como a lista de pacientes
            cbPacienteConsulta.DisplayMember = "Nome"; // Propriedade a ser exibida
            cbPacienteConsulta.ValueMember = "Id"; // Propriedade de valor
            cbPacienteConsulta.SelectedIndex = -1; // Nenhum item selecionado inicialmente
        }

        private void ConfigurarComboBoxDentista()
        {
            var dentistas = _dentistaController.ObterTodosDentistas(); // Obtenha a lista de dentistas
            cbDentistaConsulta.DataSource = dentistas; // Defina a fonte de dados como a lista de dentistas
            cbDentistaConsulta.DisplayMember = "Nome"; // Propriedade a ser exibida
            cbDentistaConsulta.ValueMember = "Id"; // Propriedade de valor
            cbDentistaConsulta.SelectedIndex = -1; // Nenhum item selecionado inicialmente
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private Consulta CriarConsulta()
        {
            // Cria a nova consulta
            return new Consulta
            {
                DataConsulta = dtpDataConsulta.Value,
                Observacoes = txtObsConsulta.Text,
                Paciente = new Paciente
                {
                    Id = (int)cbPacienteConsulta.SelectedValue,
                    Nome = cbPacienteConsulta.Text
                },
                Dentista = new Dentista
                {
                    Id = (int)cbDentistaConsulta.SelectedValue,
                    Nome = cbDentistaConsulta.Text
                }
            };
        }

        private void btnLimparConsulta_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtObsConsulta.Clear();

            cbPacienteConsulta.SelectedIndex = -1;
            cbDentistaConsulta.SelectedIndex = -1;

            dtpDataConsulta.Value = DateTime.Now;
        }
    }
}
