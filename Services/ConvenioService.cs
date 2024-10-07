using ProjetoOdontoPOO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Services
{
    public class ConvenioService
    {
        private readonly DataBaseSqlServerService _dbService;

        public ConvenioService()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public List<Convenio> ObterConvenios()
        {
            var convenios = new List<Convenio>();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = "SELECT Conv_Id, Conv_Nome FROM Convenio";
                using (SqlCommand cmd = new SqlCommand(query, conexao))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        convenios.Add(new Convenio
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1)
                        });
                    }
                }
            }
            return convenios;
        }

        public void InserirConvenio(Convenio convenio)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string queryConvenio = "INSERT INTO Convenio (Conv_Nome, Conv_CNPJ, Conv_Telefone, Conv_Endereco, Conv_Email, Conv_DataCriacao) " +
                                            "VALUES (@Nome, @CNPJ, @Telefone, @Endereco, @Email, @DataCriacao)";
                    using (SqlCommand cmd = new SqlCommand(queryConvenio, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", convenio.Nome);
                        cmd.Parameters.AddWithValue("@CNPJ", convenio.CNPJ);
                        cmd.Parameters.AddWithValue("@Telefone", convenio.Telefone);
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
