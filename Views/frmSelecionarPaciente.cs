using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmSelecionarPaciente : Form
    {
        private readonly PacienteController _pacienteController;
        private readonly ResponsavelController _responsavelController;
        private readonly ConvenioController _convenioController;
        public Paciente pacienteSelecao;

        public frmSelecionarPaciente(bool ExibirBotaoSelecionar = false)
        {
            InitializeComponent();

            _pacienteController = new PacienteController();

            CarregarDadosPaciente();

            btnSelecionar.Visible = ExibirBotaoSelecionar;
        }

        private void CarregarDadosPaciente(string termoPesquisa = "")
        {
            try
            {
                // Obtém os dados da tabela através do método atualizado
                DataTable tabela = _pacienteController.ObterTodosPacientes();

                // Limpa as linhas atuais do DataGridView
                dgvRegistros.Rows.Clear();

                // Adiciona os dados linha por linha no DataGridView
                foreach (DataRow row in tabela.Rows)
                {
                    // Verifica se o paciente está ativo (Ativo_Inativo == 1)
                    if ((int)row["Ativo_Inativo"] != 1)
                    {
                        continue;  // Se o paciente não estiver ativo, pula para o próximo
                    }

                    // Se houver um termo de pesquisa, verifica se está no nome ou CPF
                    if (!string.IsNullOrEmpty(termoPesquisa))
                    {
                        string nome = row["Nome"].ToString().ToLower();
                        string cpf = row["CPF"].ToString().ToLower();

                        // Se o termo não for encontrado no nome ou CPF, ignora esse paciente
                        if (!nome.Contains(termoPesquisa.ToLower()) && !cpf.Contains(termoPesquisa.ToLower()))
                        {
                            MessageBox.Show("Nenhum paciente encontrado com o nome ou CPF fornecido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Cria um objeto Paciente com os dados dessa linha
                    Paciente paciente = new Paciente
                    {
                        Id = (int)row["ID"],
                        Nome = (string)row["Nome"],
                        CPF = (string)row["CPF"],
                        Telefone = (string)row["Telefone"],
                        Responsavel = null,  // ou altere para um objeto Responsável, se necessário
                        Convenio = null,      // ou altere para um objeto Convênio, se necessário
                        Ativo_Inativo = (int)row["Ativo_Inativo"]
                    };

                    // Adiciona os dados no DataGridView
                    int index = dgvRegistros.Rows.Add(
                        paciente.Id,               // ID do paciente
                        paciente.Nome,             // Nome do paciente
                        paciente.CPF,              // CPF do paciente
                        paciente.Telefone,         // Telefone do paciente
                        row["Responsável"],        // Responsável (como string ou objeto)
                        row["Convênio"],           // Convênio (como string ou objeto)
                        paciente.Ativo_Inativo
                    );

                    // Associar o objeto Paciente à linha
                    dgvRegistros.Rows[index].Tag = paciente;
                }

                // Seleciona a primeira linha automaticamente, se houver registros
                if (dgvRegistros.Rows.Count > 0)
                {
                    dgvRegistros.Rows[0].Selected = true;
                    pacienteSelecao = dgvRegistros.Rows[0].Tag as Paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do paciente: " + ex.Message);
            }
        }


        private Paciente RecuperarPaciente()
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
                // Acessa o Paciente diretamente do Tag da linha selecionada
                return dgvRegistros.SelectedRows[0].Tag as Paciente;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            pacienteSelecao = RecuperarPaciente();
            if (pacienteSelecao != null)
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
                    // Se a célula contiver dados, seleciona o paciente
                    pacienteSelecao = row.Tag as Paciente;

                    if (pacienteSelecao != null)
                    {
                        this.DialogResult = DialogResult.OK; // Fecha o formulário e retorna o paciente selecionado
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
                    // Se a célula contém dados, seleciona o paciente
                    pacienteSelecao = row.Tag as Paciente;

                    // Marca a linha como selecionada visualmente (opcional)
                    dgvRegistros.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (pacienteSelecao != null)
            {
                // Cria uma nova instância de frmEditarPaciente em modo visualização
                frmEditarPaciente frmEditar = new frmEditarPaciente(pacienteSelecao.Id, modoVisualizacao: true);

                // Exibe o formulário de edição
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum paciente selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisar.Text.Trim().ToLower(); // Converte para minúsculas para facilitar a busca

            // Carrega os pacientes filtrados com o termo de pesquisa
            CarregarDadosPaciente(termoPesquisa);
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
