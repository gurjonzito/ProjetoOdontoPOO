using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmCadConvenio : Form
    {
        private readonly ConvenioController _convenioController;

        public frmCadConvenio()
        {
            InitializeComponent();

            _convenioController = new ConvenioController();
        }

        private void btnSalvarConvenio_Click(object sender, EventArgs e)
        {
            var convenio = CriarConvenio();

            string mensagem = _convenioController.InserirConvenio(convenio);
            MessageBox.Show(mensagem);

            if (mensagem.Contains("Convênio cadastrado com sucesso!"))
            {
                LimparCampos();
            }
        }

        private Convenio CriarConvenio()
        {
            return new Convenio
            {
                Nome = txtNomeConvenio.Text,
                CNPJ = txtCNPJConvenio.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", ""),
                Telefone = txtTelefoneConvenio.Text,
                Endereco = txtEnderecoConvenio.Text,
                Email = txtEmailConvenio.Text,
                DataCriacao = dtpDataConvenio.Value,
            };
        }

        private void btnLimparConvenio_Click(object sender, EventArgs e)
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

        private void txtTelefoneConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntradaNumerica(e);
        }

        private void LimparCampos()
        {
            txtNomeConvenio.Clear();
            txtCNPJConvenio.Clear();
            txtTelefoneConvenio.Clear();
            txtEnderecoConvenio.Clear();
            txtEmailConvenio.Clear();

            dtpDataConvenio.Value = DateTime.Now;
        }
    }
}
