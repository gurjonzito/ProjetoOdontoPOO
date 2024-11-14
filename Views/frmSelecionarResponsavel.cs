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
    public partial class frmSelecionarResponsavel : Form
    {
        private readonly ResponsavelController _responsavelController;
        public Responsavel responsavelSelecao;
        public frmSelecionarResponsavel(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();

            _responsavelController = new ResponsavelController();

            CarregarDadosResponsavel();

            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        private void CarregarDadosResponsavel(string termoPesquisa = "")
        {
            try
            {
                DataTable tabela = _responsavelController.ObterTodosResponsaveis();

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
                        string cpf = row["CPF"].ToString().ToLower();

                        if (!nome.Contains(termoPesquisa.ToLower()) && !cpf.Contains(termoPesquisa.ToLower()))
                        {
                            MessageBox.Show("Nenhum responsável encontrado com o nome ou CPF fornecido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    Responsavel responsavel = new Responsavel
                    {
                        Id = (int)row["ID"],
                        Nome = (string)row["Nome"],
                        CPF = (string)row["CPF"],
                        Telefone = (string)row["Telefone"],
                        Parentesco = (string)row["Parentesco"],
                        Ativo_Inativo = (int)row["Ativo_Inativo"]
                    };

                    int index = dgvRegistros.Rows.Add(
                        responsavel.Id,
                        responsavel.Nome,
                        responsavel.CPF,
                        responsavel.Telefone,
                        responsavel.Parentesco,
                        responsavel.Ativo_Inativo
                    );

                    dgvRegistros.Rows[index].Tag = responsavel;
                }

                if (dgvRegistros.Rows.Count > 0)
                {
                    dgvRegistros.Rows[0].Selected = true; 
                                                          
                    responsavelSelecao = dgvRegistros.Rows[0].Tag as Responsavel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do responsável: " + ex.Message);
            }
        }
            private Responsavel RecuperarResponsavel()
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
                    return dgvRegistros.SelectedRows[0].Tag as Responsavel;
                }
            }

            private void btnSelecionar_Click(object sender, EventArgs e)
            {
                Selecionar();
            }

            private void Selecionar()
            {
                responsavelSelecao = RecuperarResponsavel();
                if (responsavelSelecao != null)
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
                        responsavelSelecao = row.Tag as Responsavel;

                        if (responsavelSelecao != null)
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

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida
            if (e.RowIndex >= 0 && e.RowIndex < dgvRegistros.Rows.Count)
            {
                var row = dgvRegistros.Rows[e.RowIndex];
                if (row.Cells[0].Value != null) // Verifica se a célula contém dados (ID)
                {
                    // Se a célula contém dados, seleciona o responsável
                    responsavelSelecao = row.Tag as Responsavel;

                    // Marca a linha como selecionada visualmente (opcional)
                    dgvRegistros.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (responsavelSelecao != null)
            {
                // Cria uma nova instância de frmEditarResponsavel em modo visualização
                frmEditarResponsavel frmEditar = new frmEditarResponsavel(responsavelSelecao.Id, modoVisualizacao: true);

                // Exibe o formulário de edição
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum responsável selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisar.Text.Trim().ToLower(); // Converte para minúsculas para facilitar a busca

            // Carrega os pacientes filtrados com o termo de pesquisa
            CarregarDadosResponsavel(termoPesquisa);
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
