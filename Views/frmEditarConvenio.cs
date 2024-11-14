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
    public partial class frmEditarConvenio : Form
    {
        private readonly ConvenioController _convenioController;
        private int _convenioId;
        private bool _modoVisualizacao;
        public frmEditarConvenio(int convenioId, bool modoVisualizacao = false)
        {
            InitializeComponent();

            _convenioId = convenioId;

            _modoVisualizacao = modoVisualizacao;

            _convenioController = new ConvenioController();

            CarregarComboBoxes();
            CarregarDadosConvenio();

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

        private void CarregarDadosConvenio()
        {
            Convenio convenio = _convenioController.ObterConvenioPorId(_convenioId);

            if (convenio != null)
            {
                txtNomeConvenio.Text = convenio.Nome;
                txtCNPJConvenio.Text = convenio.CNPJ;
                txtTelefoneConvenio.Text = convenio.Telefone;
                txtEmailConvenio.Text = convenio.Email;
                txtEnderecoConvenio.Text = convenio.Endereco;
                dtpDataConvenio.Value = convenio.DataCriacao;
                cbAtivoInativo.Text = convenio.Ativo_Inativo == 1 ? "Ativo" : "Inativo";
            }
            else
            {
                MessageBox.Show($"Convênio com ID {_convenioId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesabilitarCampos()
        {
            txtCNPJConvenio.Enabled = false;
            txtCNPJConvenio.Enabled = false;
            txtEmailConvenio.Enabled = false;
            txtEnderecoConvenio.Enabled = false;
            txtNomeConvenio.Enabled = false;
            txtTelefoneConvenio.Enabled = false;
            dtpDataConvenio.Enabled = false;
            btnSalvarConvenio.Visible = false;
            cbAtivoInativo.Enabled = false;
        }

        private void btnSalvarConvenio_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeConvenio.Text;
                string cnpj = txtCNPJConvenio.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "");
                string telefone = txtTelefoneConvenio.Text;
                string email = txtEmailConvenio.Text;
                string endereco = txtEnderecoConvenio.Text;
                DateTime dataCriacao = dtpDataConvenio.Value;

                string status = cbAtivoInativo.SelectedItem.ToString();
                int ativoInativo = status == "Ativo" ? 1 : 0;

                Convenio convenio = new Convenio
                {
                    Nome = nome,
                    CNPJ = cnpj,
                    Telefone = telefone,
                    Email = email,
                    Endereco = endereco,
                    DataCriacao = dataCriacao,
                    Ativo_Inativo = ativoInativo
                };

                bool atualizado = _convenioController.AtualizarConvenio(_convenioId, convenio);

                if (atualizado)
                {
                    MessageBox.Show("Convênio atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o convênio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
