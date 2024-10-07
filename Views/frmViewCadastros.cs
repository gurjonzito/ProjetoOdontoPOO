using ProjetoOdontoPOO.Services;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmViewCadastros : Form
    {
        private readonly DataBaseSqlServerService _dbService;

        public frmViewCadastros()
        {
            InitializeComponent();

            _dbService = new DataBaseSqlServerService();
            CarregarDadosPaciente();
            CarregarDadosResponsavel();
            CarregarDadosConvenio();
        }

        private void btnBuscarCPFPaciente_Click(object sender, EventArgs e)
        {
            string cpfProcurado = txtBuscarCPFPac.Text;

            if (string.IsNullOrWhiteSpace(cpfProcurado))
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Itera pelas linhas do DataGridView para encontrar o CPF
            foreach (DataGridViewRow row in dgvPaciente.Rows)
            {
                // Verifica se o valor da célula de CPF corresponde ao CPF procurado
                if (row.Cells["CPF"].Value != null && row.Cells["CPF"].Value.ToString() == cpfProcurado)
                {
                    row.Selected = true;
                    dgvPaciente.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }

            // Exibe mensagem se não encontrar o CPF
            MessageBox.Show("CPF não encontrado.", "Resultado da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarCPFResponsavel_Click(object sender, EventArgs e)
        {
            string cpfProcurado = txtBuscarCPFRes.Text;

            if (string.IsNullOrWhiteSpace(cpfProcurado))
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Itera pelas linhas do DataGridView para encontrar o CPF
            foreach (DataGridViewRow row in dgvResponsavel.Rows)
            {
                // Verifica se o valor da célula de CPF corresponde ao CPF procurado
                if (row.Cells["CPF"].Value != null && row.Cells["CPF"].Value.ToString() == cpfProcurado)
                {
                    row.Selected = true;
                    dgvResponsavel.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }

            // Exibe mensagem se não encontrar o CPF
            MessageBox.Show("CPF não encontrado.", "Resultado da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarCNPJ_Click(object sender, EventArgs e)
        {
            string cnpjProcurado = txtBuscarCNPJ.Text;

            if (string.IsNullOrWhiteSpace(cnpjProcurado))
            {
                MessageBox.Show("Por favor, insira um CNPJ para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Itera pelas linhas do DataGridView para encontrar o CPF
            foreach (DataGridViewRow row in dgvConvenio.Rows)
            {
                // Verifica se o valor da célula de CPF corresponde ao CPF procurado
                if (row.Cells["CNPJ"].Value != null && row.Cells["CNPJ"].Value.ToString() == cnpjProcurado)
                {
                    row.Selected = true;
                    dgvConvenio.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }

            // Exibe mensagem se não encontrar o CPF
            MessageBox.Show("CNPJ não encontrado.", "Resultado da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CarregarDadosPaciente()
        {
            try
            {
                using (SqlConnection conexao = _dbService.CriarConexao())
                {
                    // Consulta SQL para obter os dados
                    string query = @"
                                SELECT Pac.Pac_ID AS ID,
                                       Pac.Pac_Nome AS Nome,
                                       Pac.Pac_DataNascimento AS [Data de Nascimento],
                                       Pac.Pac_Idade as Idade,
                                       Pac.Pac_CPF as CPF,
                                       Pac.Pac_Sexo as Sexo,
                                       Pac.Pac_Telefone AS Telefone,
                                       Pac.Pac_Email AS [E-mail],
                                       COALESCE(Conv.Conv_Nome, 'Sem Convênio') AS Convênio,
                                       COALESCE(Resp.Res_Nome, 'Sem Responsável') AS Responsável
                                FROM Paciente AS Pac
                                LEFT JOIN Convenio AS Conv ON Pac.Pac_ConvenioID_FK = Conv.Conv_ID
                                LEFT JOIN Responsavel AS Resp ON Pac.Pac_ResponsavelID_FK = Resp.Res_ID";

                    // Adaptador para executar a consulta e preencher o DataTable
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    // Define o DataTable como fonte de dados para o DataGridView
                    dgvPaciente.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CarregarDadosResponsavel()
        {
            try
            {
                using (SqlConnection conexao = _dbService.CriarConexao())
                {
                    // Consulta SQL para obter os dados
                    string query = @"
                                SELECT Res_ID AS ID,
                                       Res_Nome AS Nome,
                                       Res_DataNascimento AS [Data de Nascimento],
                                       Res_Idade as Idade,
                                       Res_CPF as CPF,
                                       Res_Sexo as Sexo,
                                       Res_Telefone AS Telefone,
                                       Res_Parentesco AS Parentesco
                                FROM Responsavel";

                    // Adaptador para executar a consulta e preencher o DataTable
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    // Define o DataTable como fonte de dados para o DataGridView
                    dgvResponsavel.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CarregarDadosConvenio()
        {
            try
            {
                using (SqlConnection conexao = _dbService.CriarConexao())
                {
                    // Consulta SQL para obter os dados
                    string query = @"
                                SELECT Conv_ID AS ID,
                                       Conv_Nome AS Nome,
                                       Conv_CNPJ AS CNPJ,
                                       Conv_Telefone AS Telefone,
                                       Conv_Endereco AS Endereço,
                                       Conv_Email AS [E-mail],
                                       Conv_DataCriacao AS [Data de Criação],
                                       Ativo_Inativo AS Ativo_Inativo
                                FROM Convenio";

                    // Adaptador para executar a consulta e preencher o DataTable
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    // Define o DataTable como fonte de dados para o DataGridView
                    dgvConvenio.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
    }
}
