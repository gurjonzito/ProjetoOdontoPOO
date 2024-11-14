using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoOdontoPOO.Repositories
{
    public class ResponsavelRepository
    {
        private readonly DataBaseSqlServerService _dbService;

        public ResponsavelRepository()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public Responsavel ObterDadosResponsavelPorId(int responsavelId)
        {
            Responsavel responsavel = null;

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"SELECT Res_ID, Res_Nome, Res_DataNascimento, Res_Idade, Res_CPF, Res_Sexo, Res_Telefone, Res_Parentesco, Ativo_Inativo
                                 FROM Responsavel
                                 WHERE Res_ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", responsavelId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            responsavel = new Responsavel
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Res_ID")),
                                Nome = reader.GetString(reader.GetOrdinal("Res_Nome")),
                                DataNascimento = reader.GetDateTime(reader.GetOrdinal("Res_DataNascimento")),
                                Idade = reader.GetInt32(reader.GetOrdinal("Res_Idade")),
                                CPF = reader.GetString(reader.GetOrdinal("Res_CPF")),
                                Sexo = reader.GetString(reader.GetOrdinal("Res_Sexo")),
                                Telefone = reader.GetString(reader.GetOrdinal("Res_Telefone")),
                                Parentesco = reader.GetString(reader.GetOrdinal("Res_Parentesco")),
                                Ativo_Inativo = reader.GetInt32(reader.GetOrdinal("Ativo_Inativo"))
                            };
                        }
                    }
                }
            }

            return responsavel;
        }

        public DataTable ObterDadosResponsaveis()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"
            SELECT Res_ID AS ID,
                   Res_Nome AS Nome,
                   Res_DataNascimento AS [Data de Nascimento],
                   Res_Idade AS Idade,
                   Res_CPF AS CPF,
                   Res_Sexo AS Sexo,
                   Res_Telefone AS Telefone,
                   Res_Parentesco AS Parentesco,
                   Ativo_Inativo AS Ativo_Inativo
            FROM Responsavel";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                adaptador.Fill(tabela);
            }

            return tabela;
        }

        public void InserirResponsavel(Responsavel responsavel)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = "INSERT INTO Responsavel (Res_Nome, Res_DataNascimento, Res_Idade, Res_CPF, Res_Sexo, Res_Telefone, Res_Parentesco) " +
                                            "VALUES (@Nome, @DataNascimento, @Idade, @CPF, @Sexo, @Telefone, @Parentesco)";
                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", responsavel.Nome);
                        cmd.Parameters.AddWithValue("@DataNascimento", responsavel.DataNascimento);
                        cmd.Parameters.AddWithValue("@Idade", responsavel.Idade);
                        string cpfLimpo = responsavel.CPF.Replace(".", "").Replace("-", "").Replace(",", "");
                        cmd.Parameters.AddWithValue("@CPF", cpfLimpo);
                        cmd.Parameters.AddWithValue("@Sexo", responsavel.Sexo);
                        string telefoneLimpo = responsavel.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                        cmd.Parameters.AddWithValue("@Telefone", telefoneLimpo);
                        cmd.Parameters.AddWithValue("@Parentesco", responsavel.Parentesco);

                        cmd.ExecuteNonQuery();
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

        public bool AtualizarResponsavel(int responsavelId, Responsavel responsavel)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = @"UPDATE Responsavel
                             SET Res_Nome = @Nome,
                                 Res_DataNascimento = @DataNascimento,
                                 Res_Idade = @Idade,
                                 Res_CPF = @CPF,
                                 Res_Sexo = @Sexo,
                                 Res_Telefone = @Telefone,
                                 Res_Parentesco = @Parentesco,
                                 Ativo_Inativo = @AtivoInativo
                             WHERE Res_ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        string cpfLimpo = responsavel.CPF.Replace(".", "").Replace("-", "").Replace(",", "");
                        string telefoneLimpo = responsavel.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                        cmd.Parameters.AddWithValue("@ID", responsavelId);
                        cmd.Parameters.AddWithValue("@Nome", responsavel.Nome);
                        cmd.Parameters.AddWithValue("@DataNascimento", responsavel.DataNascimento);
                        cmd.Parameters.AddWithValue("@Idade", responsavel.Idade);
                        cmd.Parameters.AddWithValue("@CPF", cpfLimpo);
                        cmd.Parameters.AddWithValue("@Sexo", responsavel.Sexo);
                        cmd.Parameters.AddWithValue("@Telefone", telefoneLimpo);
                        cmd.Parameters.AddWithValue("@Parentesco", responsavel.Parentesco);
                        cmd.Parameters.AddWithValue("@AtivoInativo", responsavel.Ativo_Inativo);

                        cmd.ExecuteNonQuery();
                    }

                    transacao.Commit();
                    return true;
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
