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

        public frmEditarConvenio(int convenioId)
        {
            InitializeComponent();

            _convenioId = convenioId;

            _convenioController = new ConvenioController();

            CarregarDadosConvenio();
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
            }
            else
            {
                MessageBox.Show($"Convênio com ID {_convenioId} não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarConvenio_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConvenio.Text;
            string cnpj = txtCNPJConvenio.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "");
            string telefone = txtTelefoneConvenio.Text;
            string email = txtEmailConvenio.Text;
            string endereco = txtEnderecoConvenio.Text;
            DateTime dataCriacao = dtpDataConvenio.Value;

            Convenio convenio = new Convenio
            {
                Nome = nome,
                CNPJ = cnpj,
                Telefone = telefone,
                Email = email,
                Endereco = endereco,
                DataCriacao = dataCriacao,
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

        private void btnLimparConvenio_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomeConvenio.Clear();
            txtCNPJConvenio.Clear();
            txtTelefoneConvenio.Clear();
            txtEmailConvenio.Clear();
            txtEnderecoConvenio.Clear();

            // Resetar DateTimePicker
            dtpDataConvenio.Value = DateTime.Now;
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
