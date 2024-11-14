using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmSelecionarDentista : Form
    {
        private readonly DentistaController _dentistaController;
        public Dentista dentistaSelecao;

        public frmSelecionarDentista(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();

            _dentistaController = new DentistaController();

            CarregarDadosDentista();

            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        private void CarregarDadosDentista(string termoPesquisa = "")
        {
            try
            {
                DataTable tabela = _dentistaController.ObterTodosDentistas();

                dgvRegistros.AutoGenerateColumns = false;

                dgvRegistros.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    if ((int)row["Ativo_Inativo"] != 1)
                    {
                        continue; 
                    }

                    if (!string.IsNullOrEmpty(termoPesquisa))
                    {
                        string nome = row["Nome"].ToString().ToLower();
                        string crm = row["CRM"].ToString().ToLower();

                        if (!nome.Contains(termoPesquisa.ToLower()) && !crm.Contains(termoPesquisa.ToLower()))
                        {
                            MessageBox.Show("Nenhum dentista encontrado com o nome ou CRM fornecido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    Dentista dentista = new Dentista
                    {
                        Id = (int)row["ID"],
                        Nome = (string)row["Nome"],
                        CRM = (string)row["CRM"],
                        Especialidade = (string)row["Especialidade"],
                        Telefone = (string)row["Telefone"],
                        Ativo_Inativo = (int)row["Ativo_Inativo"]
                    };

                    int index = dgvRegistros.Rows.Add(
                        dentista.Id,
                        dentista.Nome,
                        dentista.CRM,
                        dentista.Especialidade,
                        dentista.Telefone,
                        dentista.Ativo_Inativo
                    );

                    dgvRegistros.Rows[index].Tag = dentista;
                }

                if (dgvRegistros.Rows.Count > 0)
                {
                    dgvRegistros.Rows[0].Selected = true;
                    dentistaSelecao = dgvRegistros.Rows[0].Tag as Dentista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do dentista: " + ex.Message);
            }
        }

        private Dentista RecuperarDentista()
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
                // Acessa o Dentista diretamente do Tag da linha selecionada
                return dgvRegistros.SelectedRows[0].Tag as Dentista;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            dentistaSelecao = RecuperarDentista();
            if (dentistaSelecao != null)
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
                    // Se a célula contiver dados, seleciona o dentista
                    dentistaSelecao = row.Tag as Dentista;

                    if (dentistaSelecao != null)
                    {
                        this.DialogResult = DialogResult.OK; // Fecha o formulário e retorna o dentista selecionado
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
                    // Se a célula contém dados, seleciona o dentista
                    dentistaSelecao = row.Tag as Dentista;

                    // Marca a linha como selecionada visualmente (opcional)
                    dgvRegistros.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dentistaSelecao != null)
            {
                // Cria uma nova instância de frmEditarDentista em modo visualização
                frmEditarDentista frmEditar = new frmEditarDentista(dentistaSelecao.Id, modoVisualizacao: true);

                // Exibe o formulário de edição
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum dentista selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisar.Text.Trim().ToLower();

            CarregarDadosDentista(termoPesquisa);
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
