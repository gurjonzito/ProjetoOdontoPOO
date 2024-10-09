using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmCadPaciente : Form
    {
        private PacienteController _pacienteController = new PacienteController();
        private PacienteCollection _pacienteCollection = new PacienteCollection();
        private ConvenioController _convenioController = new ConvenioController();
        private ResponsavelController _responsavelController = new ResponsavelController();

        public frmCadPaciente()
        {
            InitializeComponent();

            _pacienteController = new PacienteController();
            _pacienteCollection = new PacienteCollection();
            _convenioController = new ConvenioController();
            _responsavelController = new ResponsavelController();
        }

        private void frmCadPaciente_Load(object sender, EventArgs e)
        {
            cbConvenioPaciente.DataSource = _convenioController.ObterConvenios();
            cbConvenioPaciente.DisplayMember = "Nome";
            cbConvenioPaciente.ValueMember = "Id";
            cbConvenioPaciente.SelectedIndex = -1;

            cbResponsavelPaciente.DataSource = _responsavelController.ObterResponsaveis();
            cbResponsavelPaciente.DisplayMember = "Nome";
            cbResponsavelPaciente.ValueMember = "Id";
            cbResponsavelPaciente.SelectedIndex = -1; 
        }

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomePaciente.Text))
            {
                MessageBox.Show("Nome é obrigatório e não pode estar vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe o fluxo, impedindo o cadastro
            }

            if (txtEmailPaciente.Text.Contains(" "))
            {
                MessageBox.Show("E-mail não pode conter espaços em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var paciente = new Paciente
            {
                Nome = txtNomePaciente.Text,
                DataNascimento = dtpDataPaciente.Value,
                Idade = int.TryParse(txtIdadePaciente.Text, out int idade) ? idade : 0,
                CPF = txtCPFPaciente.Text,
                Sexo = cbSexoPaciente.Text,
                Telefone = txtTelefonePaciente.Text,
                Email = txtEmailPaciente.Text,
                Convenio = cbConvenioPaciente.SelectedValue != null
                ? new Convenio
                {
                    Id = (int)cbConvenioPaciente.SelectedValue,
                    Nome = cbConvenioPaciente.Text
                }
                : null, // Permite que o convênio seja nulo

                Responsavel = cbResponsavelPaciente.SelectedValue != null
                ? new Responsavel
                {
                    Id = (int)cbResponsavelPaciente.SelectedValue,
                    Nome = cbResponsavelPaciente.Text
                }
                : null // Permite que o responsável seja nulo
                };

            var endereco = new Endereco
            {
                Logradouro = txtLogradouro.Text,
                Numero = txtNumeroEndereco.Text,
                Cidade = txtCidadeEndereco.Text,
                Estado = txtUFEndereco.Text,
                CEP = txtCEPEndereco.Text,
                Complemento = txtComplementoEndereco.Text
            };

            _pacienteController.InserirPacienteComEndereco(paciente, endereco);
            MessageBox.Show("Paciente cadastrado com sucesso!");

            LimparCampos();
        }

        private void dtpDataPaciente_Leave(object sender, EventArgs e)
        {
            if (DateTime.TryParse(dtpDataPaciente.Text, out DateTime dataNascimento))
            {
                DateTime hoje = DateTime.Now;
                int idade = hoje.Year - dataNascimento.Year;

                // Ajusta se o aniversário ainda não aconteceu este ano
                if (hoje < dataNascimento.AddYears(idade))
                {
                    idade--;
                }

                txtIdadePaciente.Text = idade.ToString();
            }
            else
            {
                txtIdadePaciente.Text = string.Empty; // Limpa a idade se a data for inválida
            }
        }
        private void btnLimparPaciente_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtTelefonePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada de caractere
            }
        }

        private void txtNumeroEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) &&
                ch != 8 &&
                ch != 13)
            {
                e.Handled = true;
                MessageBox.Show(
                    "Este campo aceita apenas números",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomePaciente.Clear();
            txtIdadePaciente.Clear();
            txtCPFPaciente.Clear();
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
            cbSexoPaciente.SelectedIndex = -1;
            cbResponsavelPaciente.SelectedIndex = -1;

            // Resetar DateTimePicker
            dtpDataPaciente.Value = DateTime.Now;
        }
    }
}
