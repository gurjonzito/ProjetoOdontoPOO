using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmEditarPaciente : Form
    {
        private readonly PacienteController _pacienteController;
        private readonly EnderecoController _enderecoController;
        private readonly ConvenioController _convenioController;
        private readonly ResponsavelController _responsavelController;
        private int _pacienteId;

        public frmEditarPaciente(int pacienteId)
        {
            InitializeComponent();
            _pacienteId = pacienteId;

            _pacienteController = new PacienteController();
            _enderecoController = new EnderecoController();
            _convenioController = new ConvenioController();
            _responsavelController = new ResponsavelController();

            CarregarComboBoxes();
            CarregarDadosPaciente();
        }

        private void CarregarComboBoxes()
        {
            // Carrega os convênios
            cbConvenioPaciente.DataSource = _convenioController.ObterTodosConvenios();
            cbConvenioPaciente.DisplayMember = "Nome";
            cbConvenioPaciente.ValueMember = "Id";

            // Carrega os responsáveis
            cbResponsavelPaciente.DataSource = _responsavelController.ObterTodosResponsaveis();
            cbResponsavelPaciente.DisplayMember = "Nome";
            cbResponsavelPaciente.ValueMember = "Id";
        }

        private void CarregarDadosPaciente()
        {
            Paciente paciente = _pacienteController.ObterPacientePorId(_pacienteId);
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

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            // Coleta os dados do paciente
            string nome = txtNomePaciente.Text;
            DateTime dataNascimento = dtpDataPaciente.Value;
            int idade = int.Parse(txtIdadePaciente.Text);
            string cpf = txtCPFPaciente.Text;
            string sexo = txtSexoPaciente.Text;
            string telefone = txtTelefonePaciente.Text;
            string email = txtEmailPaciente.Text;

            // Convênio e responsável podem ser nulos
            int? convenioId = cbConvenioPaciente.SelectedIndex > -1 ? (int?)cbConvenioPaciente.SelectedValue : null;
            int? responsavelId = cbResponsavelPaciente.SelectedIndex > -1 ? (int?)cbResponsavelPaciente.SelectedValue : null;

            // Cria o objeto de Paciente
            Paciente paciente = new Paciente
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Idade = idade,
                CPF = cpf,
                Sexo = sexo,
                Telefone = telefone,
                Email = email,
                Convenio = convenioId.HasValue ? new Convenio { Id = convenioId.Value } : null,
                Responsavel = responsavelId.HasValue ? new Responsavel { Id = responsavelId.Value } : null
            };

            // Coleta os dados de endereço
            string logradouro = txtLogradouro.Text;
            string numero = txtNumeroEndereco.Text;
            string cidade = txtCidadeEndereco.Text;
            string estado = txtUFEndereco.Text;
            string cep = txtCEPEndereco.Text;
            string complemento = txtComplementoEndereco.Text;

            // Cria o objeto de Endereço
            Endereco endereco = new Endereco
            {
                Logradouro = logradouro,
                Numero = numero,
                Cidade = cidade,
                Estado = estado,
                CEP = cep,
                Complemento = complemento
            };

            // Chama o método de atualização com os objetos Paciente e Endereço
            bool atualizado = _pacienteController.AtualizarPacienteComEndereco(_pacienteId, paciente, endereco);

            // Exibe o resultado
            if (atualizado)
            {
                MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o paciente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparPaciente_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomePaciente.Clear();
            txtIdadePaciente.Clear();
            txtCPFPaciente.Clear();
            txtSexoPaciente.Clear();
            txtTelefonePaciente.Clear();
            txtEmailPaciente.Clear();
            txtLogradouro.Clear();
            txtNumeroEndereco.Clear();
            txtCidadeEndereco.Clear();
            txtUFEndereco.Clear();
            txtCEPEndereco.Clear();
            txtComplementoEndereco.Clear();

            // Resetar ComboBoxes
            cbConvenioPaciente.SelectedIndex = -1;
            cbResponsavelPaciente.SelectedIndex = -1;

            // Resetar DateTimePicker
            dtpDataPaciente.Value = DateTime.Now;
        }
    }
}
