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
    }
}
