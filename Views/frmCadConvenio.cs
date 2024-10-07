using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmCadConvenio : Form
    {
        private ConvenioController _convenioController = new ConvenioController();

        public frmCadConvenio()
        {
            InitializeComponent();

            _convenioController = new ConvenioController();
        }

        private void btnSalvarConvenio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeConvenio.Text))
            {
                MessageBox.Show("Nome é obrigatório e não pode estar vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmailConvenio.Text.Contains(" "))
            {
                MessageBox.Show("E-mail não pode conter espaços em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var convenio = new Convenio
            {
                Nome = txtNomeConvenio.Text,
                CNPJ = txtCNPJConvenio.Text,
                Telefone = txtTelefoneConvenio.Text,
                Endereco = txtEnderecoConvenio.Text,
                Email = txtEmailConvenio.Text,
                DataCriacao = dtpDataConvenio.Value
            };

            _convenioController.InserirConvenio(convenio);
            MessageBox.Show("Convênio cadastrado com sucesso!");

            LimparCampos();
        }

        private void btnLimparConvenio_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtTelefoneConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LimparCampos()
        {
            // Limpar campos de texto
            txtNomeConvenio.Clear();
            txtTelefoneConvenio.Clear();
            txtEmailConvenio.Clear();
            txtCNPJConvenio.Clear();
            txtEnderecoConvenio.Clear();

            // Resetar DateTimePicker
            dtpDataConvenio.Value = DateTime.Now;
        }
    }
}
