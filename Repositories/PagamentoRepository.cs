using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoOdontoPOO.Repositories
{
    public class PagamentoRepository
    {
        private readonly DataBaseSqlServerService _dbService;

        public PagamentoRepository()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public Pagamento ObterPagamentoPorId(int pagamentoId)
        {
            Pagamento pagamento = null;

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"SELECT Pag_ID, Pag_DataPagamento, Pag_ValorPago, Pag_MetodoPagamento, Pag_Status
                                 FROM Pagamento
                                 WHERE Pag_ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", pagamentoId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pagamento = new Pagamento
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Pag_ID")),
                                DataPagamento = reader.GetDateTime(reader.GetOrdinal("Pag_DataPagamento")),
                                ValorPago = reader.GetDecimal(reader.GetOrdinal("Pag_ValorPago")),
                                MetodoPagamento = reader.GetString(reader.GetOrdinal("Pag_MetodoPagamento")),
                                PagamentoStatus = reader.GetString(reader.GetOrdinal("Pag_Status"))
                            };
                        }
                    }
                }
            }

            return pagamento;
        }

        public DataTable ObterPagamentos()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"SELECT Pag_ID AS ID,
                                       Pag_DataPagamento AS [Data de Pagamento],
                                       Pag_ValorPago AS [Valor Pago],
                                       Pag_MetodoPagamento AS [Método de Pagamento],
                                       Pag_Status AS [Status]
                                 FROM Pagamento";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                adaptador.Fill(tabela);
            }

            return tabela;
        }

        public void InserirPagamento(Pagamento pagamento)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = @"INSERT INTO Pagamento (Pag_DataPagamento, Pag_ValorPago, Pag_MetodoPagamento, Pag_Status)
                                     VALUES (@DataPagamento, @ValorPago, @MetodoPagamento, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@DataPagamento", pagamento.DataPagamento);
                        cmd.Parameters.AddWithValue("@ValorPago", pagamento.ValorPago);
                        cmd.Parameters.AddWithValue("@MetodoPagamento", pagamento.MetodoPagamento);
                        cmd.Parameters.AddWithValue("@Status", pagamento.PagamentoStatus);

                        pagamento.Id = (int)cmd.ExecuteScalar();
                    }

                    transacao.Commit();
                }
                catch
                {
                    transacao.Rollback();
                    throw;
                }
            }
        }

        public bool AtualizarPagamento(int pagamentoId, Pagamento pagamento)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = @"UPDATE Pagamento
                                     SET Pag_DataPagamento = @DataPagamento,
                                         Pag_ValorPago = @ValorPago,
                                         Pag_MetodoPagamento = @MetodoPagamento,
                                         Pag_Status = @Status
                                     WHERE Pag_ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@ID", pagamentoId);
                        cmd.Parameters.AddWithValue("@DataPagamento", pagamento.DataPagamento);
                        cmd.Parameters.AddWithValue("@ValorPago", pagamento.ValorPago);
                        cmd.Parameters.AddWithValue("@MetodoPagamento", pagamento.MetodoPagamento);
                        cmd.Parameters.AddWithValue("@Status", pagamento.PagamentoStatus);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        transacao.Commit();
                        return rowsAffected > 0;
                    }
                }
                catch
                {
                    transacao.Rollback();
                    throw;
                }
            }
        }
    }
}
