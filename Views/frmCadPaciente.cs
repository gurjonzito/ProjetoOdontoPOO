﻿using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmCadPaciente : Form
    {
        private readonly PacienteController _pacienteController;
        private readonly ConvenioController _convenioController;
        private readonly ResponsavelController _responsavelController;

        public frmCadPaciente()
        {
            InitializeComponent();
            _pacienteController = new PacienteController();
            _convenioController = new ConvenioController();
            _responsavelController = new ResponsavelController();
        }

        private void frmCadPaciente_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxConvenio();
            ConfigurarComboBoxResponsavel();
        }

        private void ConfigurarComboBoxConvenio()
        {
            cbConvenioPaciente.DataSource = _convenioController.ObterTodosConvenios();
            cbConvenioPaciente.DisplayMember = "Nome";
            cbConvenioPaciente.ValueMember = "Id";
            cbConvenioPaciente.SelectedIndex = -1;
        }

        private void ConfigurarComboBoxResponsavel()
        {
            cbResponsavelPaciente.DataSource = _responsavelController.ObterTodosResponsaveis();
            cbResponsavelPaciente.DisplayMember = "Nome";
            cbResponsavelPaciente.ValueMember = "Id";
            cbResponsavelPaciente.SelectedIndex = -1;
        }

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            var paciente = CriarPaciente();
            var endereco = CriarEndereco();

            string mensagem = _pacienteController.InserirPacienteComEndereco(paciente, endereco);
            MessageBox.Show(mensagem);

            if (mensagem.Contains("Paciente adicionado com sucesso!"))
            {
                LimparCampos();
            }
        }

        private Paciente CriarPaciente()
        {
            return new Paciente
            {
                Nome = txtNomePaciente.Text,
                DataNascimento = dtpDataPaciente.Value,
                Idade = int.TryParse(txtIdadePaciente.Text, out int idade) ? idade : 0,
                CPF = txtCPFPaciente.Text.Replace(".", "").Replace("-", ""),
                Sexo = cbSexoPaciente.Text,
                Telefone = txtTelefonePaciente.Text,
                Email = txtEmailPaciente.Text,
                Convenio = cbConvenioPaciente.SelectedValue != null
                    ? new Convenio
                    {
                        Id = (int)cbConvenioPaciente.SelectedValue,
                        Nome = cbConvenioPaciente.Text
                    }
                    : null,
                Responsavel = cbResponsavelPaciente.SelectedValue != null
                    ? new Responsavel
                    {
                        Id = (int)cbResponsavelPaciente.SelectedValue,
                        Nome = cbResponsavelPaciente.Text
                    }
                    : null
            };
        }

        private Endereco CriarEndereco()
        {
            return new Endereco
            {
                Logradouro = txtLogradouro.Text,
                Numero = txtNumeroEndereco.Text,
                Cidade = txtCidadeEndereco.Text,
                Estado = cbUFEndereco.Text,
                CEP = txtCEPEndereco.Text.Replace("-", ""),
                Complemento = txtComplementoEndereco.Text
            };
        }

        private void dtpDataPaciente_Leave(object sender, EventArgs e)
        {
            txtIdadePaciente.Text = CalcularIdade(dtpDataPaciente.Value).ToString();
        }

        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - dataNascimento.Year;

            if (hoje < dataNascimento.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }

        private void btnLimparPaciente_Click(object sender, EventArgs e)
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

        private void txtTelefonePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void txtNumeroEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void LimparCampos()
        {
            txtNomePaciente.Clear();
            txtIdadePaciente.Clear();
            txtCPFPaciente.Clear();
            txtTelefonePaciente.Clear();
            txtEmailPaciente.Clear();
            txtLogradouro.Clear();
            txtNumeroEndereco.Clear();
            txtCidadeEndereco.Clear();
            txtCEPEndereco.Clear();
            txtComplementoEndereco.Clear();

            cbConvenioPaciente.SelectedIndex = -1;
            cbSexoPaciente.SelectedIndex = -1;
            cbResponsavelPaciente.SelectedIndex = -1;
            cbUFEndereco.SelectedIndex = -1;

            dtpDataPaciente.Value = DateTime.Now;
        }
    }
}
