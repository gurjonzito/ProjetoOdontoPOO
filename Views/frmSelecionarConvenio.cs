using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmSelecionarConvenio : Form
    {
        private readonly ConvenioController _convenioController;
        public Convenio convenioSelecao;

        public frmSelecionarConvenio(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();

            _convenioController = new ConvenioController();

            CarregarDadosConvenio();

            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        private void CarregarDadosConvenio()
        {
            try
            {
                DataTable tabela = _convenioController.ObterTodosConvenios();

                dgvRegistros.AutoGenerateColumns = false;

                dgvRegistros.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    dgvRegistros.Rows.Add(
                        row["ID"],
                        row["Nome"],
                        row["CNPJ"],
                        row["Telefone"],
                        row["E-mail"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do convênio: " + ex.Message);
            }
        }

        private Convenio RecuperarConvenio()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return null;
            }
            else
            {
                return dgvRegistros.SelectedRows[0].DataBoundItem
                as Convenio;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            convenioSelecao = RecuperarConvenio();
            if (convenioSelecao != null)
                this.DialogResult = DialogResult.OK;
        }
    }
}
