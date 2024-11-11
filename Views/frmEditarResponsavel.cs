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
        private bool _modoVisualizacao;

        // Modificado para aceitar o parâmetro 'modoVisualizacao'
        public frmEditarResponsavel(int responsavelId, bool modoVisualizacao = false)
        {
            InitializeComponent();

            _responsavelId = responsavelId;
            _modoVisualizacao = modoVisualizacao; // Armazena o modo

            _responsavelController = new ResponsavelController();

            CarregarComboBoxes();
            CarregarDadosResponsavel();

            // Se for modo de visualização, desabilitar os campos
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

                // Seleção do status Ativo/Inativo
                if (responsavel.Ativo_Inativo == 1)
                {
                    cbAtivoInativo.SelectedItem = "Ativo";
                }
                else if (responsavel.Ativo_Inativo == 0)
                {
                    cbAtivoInativo.SelectedItem = "Inativo";
                }
                else
                {
                    cbAtivoInativo.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show($"Responsável com ID {_responsavelId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para desabilitar os campos no modo de visualização
        private void DesabilitarCampos()
        {
            txtNomeRes.Enabled = false;
            txtIdadeRes.Enabled = false;
            txtCPFRes.Enabled = false;
            txtTelefoneRes.Enabled = false;
            txtParentescoRes.Enabled = false;
            cbSexoRes.Enabled = false;
            cbAtivoInativo.Enabled = false;
            dtpDataRes.Enabled = false;
            btnLimparResponsavel.Visible = false;
            btnSalvarResponsavel.Visible = false;
        }

        private void btnSalvarResponsavel_Click(object sender, EventArgs e)
        {
            // Coleta os dados do responsável
            string nome = txtNomeRes.Text;
            DateTime dataNascimento = dtpDataRes.Value;
            int idade = int.Parse(txtIdadeRes.Text);
            string cpf = txtCPFRes.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            string sexo = cbSexoRes.Text;
            string telefone = txtTelefoneRes.Text;
            string parentesco = txtParentescoRes.Text;

            // Coleta o status Ativo/Inativo
            string status = cbAtivoInativo.SelectedItem.ToString();
            int ativoInativo = status == "Ativo" ? 1 : 0;

            // Cria o objeto Responsável
            Responsavel responsavel = new Responsavel
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Idade = idade,
                CPF = cpf,
                Sexo = sexo,
                Telefone = telefone,
                Parentesco = parentesco,
                Ativo_Inativo = ativoInativo
            };

            // Chama o método de atualização
            bool atualizado = _responsavelController.AtualizarResponsavel(_responsavelId, responsavel);

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
            txtNomeRes.Clear();
            txtIdadeRes.Clear();
            txtCPFRes.Clear();
            txtTelefoneRes.Clear();
            txtParentescoRes.Clear();
            cbSexoRes.SelectedIndex = -1;
            cbAtivoInativo.SelectedIndex = -1;
            dtpDataRes.Value = DateTime.Now;
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
