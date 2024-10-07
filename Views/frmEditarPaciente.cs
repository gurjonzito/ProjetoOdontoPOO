using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmEditarPaciente : Form
    {
        private readonly PacienteController _pacienteController;
        private readonly EnderecoController _enderecoController;
        private readonly ConvenioService _convenioService;
        private readonly ResponsavelService _responsavelService;
        private int _pacienteId;

        public frmEditarPaciente(int pacienteId)
        {
            InitializeComponent();
            _pacienteId = pacienteId;

            _pacienteController = new PacienteController();
            _enderecoController = new EnderecoController();
            _convenioService = new ConvenioService();
            _responsavelService = new ResponsavelService();

            CarregarComboBoxes();
            CarregarDadosPaciente();
        }

        private void CarregarComboBoxes()
        {
            // Carrega os convênios
            List<Convenio> convenios = _convenioService.ObterConvenios();
            cbConvenioPaciente.DataSource = convenios;
            cbConvenioPaciente.DisplayMember = "Nome";
            cbConvenioPaciente.ValueMember = "Id";

            // Carrega os responsáveis
            List<Responsavel> responsaveis = _responsavelService.ObterResponsaveis();
            cbResponsavelPaciente.DataSource = responsaveis;
            cbResponsavelPaciente.DisplayMember = "Nome";
            cbResponsavelPaciente.ValueMember = "Id";
        }


        private void CarregarDadosPaciente()
        {
            Paciente paciente = _pacienteController.ObterDadosPacientePorId(_pacienteId);
            Endereco endereco = _enderecoController.ObterDadosEnderecoPorId(_pacienteId);

            if (paciente != null)
            {
                txtNomePaciente.Text = paciente.Nome;
                dtpDataPaciente.Value = paciente.DataNascimento;
                txtIdadePaciente.Text = paciente.Idade.ToString();
                txtCPFPaciente.Text = paciente.CPF;
                txtSexoPaciente.Text = paciente.Sexo;
                txtTelefonePaciente.Text = paciente.Telefone;
                txtEmailPaciente.Text = paciente.Email;

                cbConvenioPaciente.SelectedValue = paciente.Convenio?.Id ?? -1;
                cbResponsavelPaciente.SelectedValue = paciente.Responsavel?.Id ?? -1;

                // Verificação se o endereço foi encontrado
                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.Logradouro;
                    txtNumeroEndereco.Text = endereco.Numero;
                    txtCidadeEndereco.Text = endereco.Cidade;
                    txtUFEndereco.Text = endereco.Estado;
                    txtCEPEndereco.Text = endereco.CEP;
                    txtComplementoEndereco.Text = endereco.Complemento;
                }
                else
                {
                    MessageBox.Show($"Endereço para o paciente com ID {_pacienteId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Paciente com ID {_pacienteId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
