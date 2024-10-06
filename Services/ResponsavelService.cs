using ProjetoOdontoPOO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Services
{
    public class ResponsavelService
    {
        private readonly DataBaseSqlServerService _dbService;

        public ResponsavelService()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public List<Responsavel> ObterResponsaveis()
        {
            var responsaveis = new List<Responsavel>();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = "SELECT Res_Id, Res_Nome FROM Responsavel";
                using (SqlCommand cmd = new SqlCommand(query, conexao))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        responsaveis.Add(new Responsavel
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1)
                        });
                    }
                }
            }
            return responsaveis;
        }
    }
}
