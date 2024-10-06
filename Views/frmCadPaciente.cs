using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
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
    public partial class frmCadPaciente : Form
    {
        private PacienteController _pacienteController = new PacienteController();
        private PacienteCollection _pacienteCollection = new PacienteCollection();
        private ConvenioService _convenioService = new ConvenioService();
        private ResponsavelService _responsavelService = new ResponsavelService();

        public frmCadPaciente()
        {
            InitializeComponent();
        }

        private void frmCadPaciente_Load(object sender, EventArgs e)
        {
            cbConvenioPaciente.DataSource = _convenioService.ObterConvenios();
            cbConvenioPaciente.DisplayMember = "Nome";
            cbConvenioPaciente.ValueMember = "Id";

            cbResponsavelPaciente.DataSource = _responsavelService.ObterResponsaveis();
            cbResponsavelPaciente.DisplayMember = "Nome";
            cbResponsavelPaciente.ValueMember = "Id";
        }

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            var paciente = new Paciente
            {
                Nome = txtNomePaciente.Text,
                DataNascimento = dtpDataPaciente.Value,
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

        private void btnLimparPaciente_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomePaciente.Clear();
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
