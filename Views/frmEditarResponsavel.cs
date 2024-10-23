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
    public partial class frmEditarResponsavel : Form
    {
        private readonly ResponsavelController _responsavelController;
        private int _responsavelId;

        public frmEditarResponsavel(int responsavelId)
        {
            InitializeComponent();

            _responsavelId = responsavelId;

            _responsavelController = new ResponsavelController();

            CarregarDadosResponsavel();
        }

        private void CarregarDadosResponsavel()
        {
            Responsavel responsavel = _responsavelController.ObterResponsavelPorId(_responsavelId);

            if (responsavel != null)
            {
                txtNomeRes.Text = responsavel.Nome;
                dtpDataRes.Value = responsavel.DataNascimento;
                txtIdadeRes.Text = responsavel.Idade.ToString();
                txtCPFRes.Text = responsavel.CPF;
                cbSexoRes.Text = responsavel.Sexo;
                txtTelefoneRes.Text = responsavel.Telefone;
                txtParentescoRes.Text = responsavel.Parentesco;
            }
            else
            {
                MessageBox.Show($"Responsável com ID {_responsavelId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarResponsavel_Click(object sender, EventArgs e)
        {
            // Coleta os dados do paciente
            string nome = txtNomeRes.Text;
            DateTime dataNascimento = dtpDataRes.Value;
            int idade = int.Parse(txtIdadeRes.Text);
            string cpf = txtCPFRes.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            string sexo = cbSexoRes.Text;
            string telefone = txtTelefoneRes.Text;
            string parentesco = txtParentescoRes.Text;

            // Cria o objeto de Paciente
            Responsavel responsavel = new Responsavel
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Idade = idade,
                CPF = cpf,
                Sexo = sexo,
                Telefone = telefone,
                Parentesco = parentesco,
            };

            // Chama o método de atualização com os objetos Paciente e Endereço
            bool atualizado = _responsavelController.AtualizarResponsavel(_responsavelId, responsavel);

            // Exibe o resultado
            if (atualizado)
            {
                MessageBox.Show("Responsável atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o responsável.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparResponsavel_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomeRes.Clear();
            txtIdadeRes.Clear();
            txtCPFRes.Clear();
            txtTelefoneRes.Clear();
            txtParentescoRes.Clear();

            // Resetar ComboBoxes
            cbSexoRes.SelectedIndex = -1;

            // Resetar DateTimePicker
            dtpDataRes.Value = DateTime.Now;
        }
    }
}
