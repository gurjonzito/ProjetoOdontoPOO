using ProjetoOdontoPOO.Services;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;
using ProjetoOdontoPOO.Controllers;

namespace ProjetoOdontoPOO.Views
{
    public partial class frmViewCadastros : Form
    {
        //private readonly DataBaseSqlServerService _dbService;
        private readonly PacienteController _pacienteController;
        private readonly ResponsavelController _responsavelController;
        private readonly ConvenioController _convenioController;
        private readonly DentistaController _dentistaController;
        private readonly ConsultaController _consultaController;
        private readonly PagamentoController _pagamentoController;

        public frmViewCadastros()
        {
            InitializeComponent();

            //_dbService = new DataBaseSqlServerService();
            _pacienteController = new PacienteController();
            _responsavelController = new ResponsavelController();
            _convenioController = new ConvenioController();
            _dentistaController = new DentistaController();
            _consultaController = new ConsultaController();
            _pagamentoController = new PagamentoController();

            CarregarDadosPaciente();
            CarregarDadosResponsavel();
            CarregarDadosConvenio();
            CarregarDadosConsulta();
            CarregarDadosPagamentos();
        }

        private void tabControlVisualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica qual aba está ativa e carrega os dados correspondentes
            if (tabControlVisualizar.SelectedTab == tpPaciente)
            {
                dgvResponsavel.Rows.Clear();
                dgvConvenio.Rows.Clear();
                dgvDentista.Rows.Clear();
                dgvConsulta.Rows.Clear();
                dgvPagamento.Rows.Clear();
                CarregarDadosPaciente();
            }
            else if (tabControlVisualizar.SelectedTab == tpResponsavel)
            {
                dgvPaciente.Rows.Clear();
                dgvConvenio.Rows.Clear();
                dgvDentista.Rows.Clear();
                dgvConsulta.Rows.Clear();
                dgvPagamento.Rows.Clear();
                CarregarDadosResponsavel();
            }
            else if (tabControlVisualizar.SelectedTab == tpConvenio)
            {
                dgvPaciente.Rows.Clear();
                dgvResponsavel.Rows.Clear();
                dgvConvenio.Rows.Clear();
                dgvConsulta.Rows.Clear();
                dgvPagamento.Rows.Clear();
                CarregarDadosConvenio();
            }
            else if (tabControlVisualizar.SelectedTab == tpDentista)
            {
                dgvPaciente.Rows.Clear();
                dgvResponsavel.Rows.Clear();
                dgvConvenio.Rows.Clear();
                dgvConsulta.Rows.Clear();
                dgvPagamento.Rows.Clear();
                CarregarDadosDentista();
            }
            else if (tabControlVisualizar.SelectedTab == tpConsulta)
            {
                dgvPaciente.Rows.Clear();
                dgvResponsavel.Rows.Clear();
                dgvConvenio.Rows.Clear();
                dgvDentista.Rows.Clear();
                dgvPagamento.Rows.Clear();
                CarregarDadosConsulta();
            }
            else if (tabControlVisualizar.SelectedTab == tpPagamento)
            {
                dgvPaciente.Rows.Clear();
                dgvResponsavel.Rows.Clear();
                dgvConvenio.Rows.Clear();
                dgvDentista.Rows.Clear();
                dgvConsulta.Rows.Clear();
                CarregarDadosPagamentos();
            }
        }

        private void btnBuscarCPFPaciente_Click(object sender, EventArgs e)
        {
            if (!btnBuscarCPFPaciente.Focused) return;

            // Remove a formatação do CPF de busca inserido pelo usuário
            string cpfProcurado = txtBuscarCPFPac.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");

            if (string.IsNullOrWhiteSpace(cpfProcurado))
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Itera pelas linhas do DataGridView para encontrar o CPF
            foreach (DataGridViewRow row in dgvPaciente.Rows)
            {
                // Remove a formatação do CPF exibido no DataGridView para compará-lo
                if (row.Cells["CPF"].Value != null)
                {
                    string cpfDataGrid = row.Cells["CPF"].Value.ToString().Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");

                    if (cpfDataGrid == cpfProcurado)
                    {
                        row.Selected = true;
                        dgvPaciente.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }

            // Exibe mensagem se não encontrar o CPF
            MessageBox.Show("CPF não encontrado.", "Resultado da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarCPFResponsavel_Click(object sender, EventArgs e)
        {
            if (!btnBuscarCPFResponsavel.Focused) return;

            string cpfProcurado = txtBuscarCPFRes.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");

            if (string.IsNullOrWhiteSpace(cpfProcurado))
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvResponsavel.Rows)
            {
                if (row.Cells["CPF"].Value != null)
                {
                    string cpfDataGrid = row.Cells["CPF"].Value.ToString().Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");

                    if (cpfDataGrid == cpfProcurado)
                    {
                        row.Selected = true;
                        dgvResponsavel.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }

            MessageBox.Show("CPF não encontrado.", "Resultado da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarCNPJ_Click(object sender, EventArgs e)
        {
            if (!btnBuscarCNPJ.Focused) return;

            string cnpjProcurado = txtBuscarCNPJ.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");

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
                // Obtém os dados da tabela
                DataTable tabela = _pacienteController.ObterTodosPacientes();

                // Desativa a geração automática de colunas
                dgvPaciente.AutoGenerateColumns = false;

                // Limpa as linhas atuais do DataGridView
                dgvPaciente.Rows.Clear();

                // Adiciona os dados linha por linha no DataGridView
                foreach (DataRow row in tabela.Rows)
                {
                    dgvPaciente.Rows.Add(
                        row["ID"],
                        row["Nome"],
                        row["Idade"],
                        row["CPF"],
                        row["Sexo"],
                        row["Convênio"],
                        row["Responsável"],
                        row["Ativo_Inativo"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do paciente: " + ex.Message);
            }
        }

        private void CarregarDadosResponsavel()
        {
            try
            {
                DataTable tabela = _responsavelController.ObterTodosResponsaveis();

                dgvResponsavel.AutoGenerateColumns = false;

                dgvResponsavel.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    dgvResponsavel.Rows.Add(
                        row["ID"],
                        row["Nome"],
                        row["Idade"],
                        row["CPF"],
                        row["Sexo"],
                        row["Ativo_Inativo"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do responsável: " + ex.Message);
            }
        }

        private void CarregarDadosConvenio()
        {
            try
            {
                DataTable tabela = _convenioController.ObterTodosConvenios();

                dgvConvenio.AutoGenerateColumns = false;

                dgvConvenio.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    dgvConvenio.Rows.Add(
                        row["ID"],
                        row["Nome"],
                        row["CNPJ"],
                        row["Ativo_Inativo"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do convênio: " + ex.Message);
            }
        }

        private void CarregarDadosDentista()
        {
            try
            {
                DataTable tabela = _dentistaController.ObterTodosDentistas();

                dgvDentista.AutoGenerateColumns = false;

                dgvDentista.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    dgvDentista.Rows.Add(
                        row["ID"],
                        row["Nome"],
                        row["CRM"],
                        row["Ativo_Inativo"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do dentista: " + ex.Message);
            }
        }

        private void CarregarDadosConsulta()
        {
            try
            {
                DataTable tabela = _consultaController.ObterTodasConsultas();

                dgvConsulta.AutoGenerateColumns = false;

                dgvConsulta.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    dgvConsulta.Rows.Add(
                        row["ID"],
                        row["Data"],
                        row["Paciente"],
                        row["Dentista"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da consulta: " + ex.Message);
            }
        }

        private void CarregarDadosPagamentos()
        {
            try
            {
                DataTable tabela = _pagamentoController.ObterTodosPagamentos();

                dgvPagamento.AutoGenerateColumns = false;

                dgvPagamento.Rows.Clear();

                foreach (DataRow row in tabela.Rows)
                {
                    dgvPagamento.Rows.Add(
                        row["ID"],
                        row["Data"],
                        row["Paciente"],
                        row["Valor Pago"],
                        row["Método de Pagamento"],
                        row["Status"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do pagamento: " + ex.Message);
            }
        }

        private void dgvPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a linha clicada é válida
            if (e.RowIndex >= 0)
            {
                // Captura os dados da linha selecionada no DataGridView
                int pacienteId = Convert.ToInt32(dgvPaciente.Rows[e.RowIndex].Cells["ID"].Value); // ou o nome da coluna correspondente

                // Cria uma nova instância do formulário de edição
                frmEditarPaciente frm = new frmEditarPaciente(pacienteId);
                frm.ShowDialog();

                // Opcional: atualizar o DataGridView após a edição
                CarregarDadosPaciente();
            }
        }

        private void dgvResponsavel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int responsavelId = Convert.ToInt32(dgvResponsavel.Rows[e.RowIndex].Cells["IDRes"].Value);

                frmEditarResponsavel frm = new frmEditarResponsavel(responsavelId);
                frm.ShowDialog();

                CarregarDadosResponsavel();
            }
        }

        private void dgvDentista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dentistaId = Convert.ToInt32(dgvDentista.Rows[e.RowIndex].Cells["IDDen"].Value);

                frmEditarDentista frm = new frmEditarDentista(dentistaId);
                frm.ShowDialog();

                CarregarDadosDentista();
            }
        }

        private void dgvConvenio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int convenioId = Convert.ToInt32(dgvConvenio.Rows[e.RowIndex].Cells["IDConv"].Value);

                frmEditarConvenio frm = new frmEditarConvenio(convenioId);
                frm.ShowDialog();

                CarregarDadosConvenio();
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int consultaId = Convert.ToInt32(dgvConsulta.Rows[e.RowIndex].Cells["IDCons"].Value);

                frmEditarConsulta frm = new frmEditarConsulta(consultaId);
                frm.ShowDialog();

                CarregarDadosConsulta();
            }
        }

        private void dgvPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int pagamentoId = Convert.ToInt32(dgvPagamento.Rows[e.RowIndex].Cells["IDPag"].Value);

                frmEditarPagamento frm = new frmEditarPagamento(pagamentoId);
                frm.ShowDialog();

                CarregarDadosPagamentos();
            }
        }
    }
}
