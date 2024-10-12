using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Repositories
{
    public class ConvenioRepository
    {
        private readonly DataBaseSqlServerService _dbService;

        public ConvenioRepository()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public Convenio ObterDadosConvenioPorId(int convenioId)
        {
            Convenio convenio = null;

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"SELECT Conv_ID, Conv_Nome, Conv_CNPJ, Conv_Telefone, Conv_Endereco, Conv_Email, Conv_DataCriacao
                                 FROM Convenio
                                 WHERE Conv_ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", convenioId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            convenio = new Convenio
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Conv_ID")),
                                Nome = reader.GetString(reader.GetOrdinal("Conv_Nome")),
                                CNPJ = reader.GetString(reader.GetOrdinal("Conv_CNPJ")),
                                Telefone = reader.GetString(reader.GetOrdinal("Conv_Telefone")),
                                Endereco = reader.GetString(reader.GetOrdinal("Conv_Endereco")),
                                Email = reader.GetString(reader.GetOrdinal("Conv_Email")),
                                DataCriacao = reader.GetDateTime(reader.GetOrdinal("Conv_DataCriacao"))
                            };
                        }
                    }
                }
            }

            return convenio;
        }

        public DataTable ObterDadosConvenios()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"
            SELECT Conv_ID AS ID,
                   Conv_Nome AS Nome,
                   Conv_CNPJ AS CNPJ,
                   Conv_Telefone AS Telefone,
                   Conv_Endereco AS [Endereço],
                   Conv_Email AS [E-mail],
                   Conv_DataCriacao AS [Data de Criação],
                   Ativo_Inativo AS Ativo_Inativo
            FROM Convenio";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                adaptador.Fill(tabela);
            }

            return tabela;
        }

        public void InserirConvenio(Convenio convenio)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = "INSERT INTO Convenio (Conv_Nome, Conv_CNPJ, Conv_Telefone, Conv_Endereco, Conv_Email, Conv_DataCriacao) " +
                                            "VALUES (@Nome, @CNPJ, @Telefone, @Endereco, @Email, @DataCriacao)";
                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        string cnpjLimpo = convenio.CNPJ.Replace(".", "").Replace("-", "").Replace(",", "");
                        string telefoneLimpo = convenio.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                        cmd.Parameters.AddWithValue("@Nome", convenio.Nome);
                        cmd.Parameters.AddWithValue("@CNPJ", cnpjLimpo);
                        cmd.Parameters.AddWithValue("@Telefone", telefoneLimpo);
                        cmd.Parameters.AddWithValue("@Endereco", convenio.Endereco);
                        cmd.Parameters.AddWithValue("@Email", convenio.Email);
                        cmd.Parameters.AddWithValue("@DataCriacao", convenio.DataCriacao);

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
    }
}
