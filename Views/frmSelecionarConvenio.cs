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
                    Convenio convenio = new Convenio
                    {
                        Id = (int)row["ID"],
                        Nome = (string)row["Nome"],
                        CNPJ = (string)row["CNPJ"],
                        Telefone = (string)row["Telefone"],
                        Email = (string)row["E-mail"]
                    };

                    int index = dgvRegistros.Rows.Add(
                        convenio.Id,
                        convenio.Nome,
                        convenio.CNPJ,
                        convenio.Telefone,
                        convenio.Email
                    );

                    // Associar o objeto Convenio à linha
                    dgvRegistros.Rows[index].Tag = convenio;
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
                // Acessa o Convenio diretamente do Tag da linha selecionada
                return dgvRegistros.SelectedRows[0].Tag as Convenio;
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

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a linha clicada é válida (não é uma linha em branco)
            if (e.RowIndex >= 0 && e.RowIndex < dgvRegistros.Rows.Count)
            {
                // Verifica se a célula clicada contém dados (no caso, a primeira célula que é o ID)
                var row = dgvRegistros.Rows[e.RowIndex];
                if (row.Cells[0].Value != null) // Supondo que o ID esteja na primeira coluna
                {
                    // Se a célula contiver dados, seleciona o convênio
                    convenioSelecao = row.Tag as Convenio;

                    if (convenioSelecao != null)
                    {
                        this.DialogResult = DialogResult.OK; // Fecha o formulário e retorna o convênio selecionado
                    }
                }
                else
                {
                    // Caso o clique tenha sido no "vácuo", não faça nada
                    // Opcional: mostrar uma mensagem ou apenas ignorar
                    MessageBox.Show("Clique em uma linha com dados válidos.");
                }
            }
        }
    }
}
