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

        private void CarregarDadosConvenio(string termoPesquisa = "")
        {
            try
            {
                DataTable tabela = _convenioController.ObterTodosConvenios();


                if (!string.IsNullOrEmpty(termoPesquisa))
                {
                    // Filtra a tabela com base no nome ou CNPJ
                    DataRow[] rowsFiltrados = tabela.Select($"Nome LIKE '%{termoPesquisa}%' OR CNPJ LIKE '%{termoPesquisa}%'");

                    if (rowsFiltrados.Length == 0)
                    {
                        // Se não houver resultados, exibe uma mensagem de erro
                        MessageBox.Show("Nenhum convênio encontrado com o nome ou CNPJ fornecido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    tabela = rowsFiltrados.CopyToDataTable();
                }

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

                // Selecionar o primeiro item, se disponível
                if (dgvRegistros.Rows.Count > 0)
                {
                    dgvRegistros.Rows[0].Selected = true;
                    convenioSelecao = dgvRegistros.Rows[0].Tag as Convenio;
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
                    MessageBox.Show("Clique em uma linha com dados válidos.");
                }
            }
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida
            if (e.RowIndex >= 0 && e.RowIndex < dgvRegistros.Rows.Count)
            {
                var row = dgvRegistros.Rows[e.RowIndex];
                if (row.Cells[0].Value != null) // Verifica se a célula contém dados (ID)
                {
                    // Se a célula contém dados, seleciona o convênio
                    convenioSelecao = row.Tag as Convenio;

                    // Marca a linha como selecionada visualmente (opcional)
                    dgvRegistros.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (convenioSelecao != null)
            {
                // Cria uma nova instância de frmEditarConvenio em modo visualização
                frmEditarConvenio frmEditar = new frmEditarConvenio(convenioSelecao.Id, modoVisualizacao: true);

                // Exibe o formulário de edição
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum convênio selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisar.Text.Trim().ToLower(); // Converte para minúsculas para facilitar a busca

            // Carrega os pacientes filtrados com o termo de pesquisa
            CarregarDadosConvenio(termoPesquisa);
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Chama o método de pesquisa, ou qualquer ação desejada
                btnPesquisar.PerformClick(); // Simula um clique no botão de pesquisa
            }
        }
    }
}
