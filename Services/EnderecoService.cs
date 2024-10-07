using ProjetoOdontoPOO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Services
{
    public class EnderecoService
    {
        private readonly DataBaseSqlServerService _dbService;

        public EnderecoService()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public Endereco ObterDadosEnderecoPorId(int pacienteId)
        {
            Endereco endereco = null;

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                // Consulta para buscar o endereço baseado no ID do paciente
                string query = @"SELECT End_ID, End_Logradouro, End_Numero, End_Cidade, End_Estado, End_CEP, End_Complemento
                          FROM Endereco
                          WHERE End_PacienteID_FK = @PacienteId"; // Busca pelo ID do paciente

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@PacienteId", pacienteId); // Passa o ID do paciente como parâmetro

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            endereco = new Endereco
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("End_ID")),
                                Logradouro = reader.GetString(reader.GetOrdinal("End_Logradouro")),
                                Numero = reader.GetString(reader.GetOrdinal("End_Numero")),
                                Cidade = reader.GetString(reader.GetOrdinal("End_Cidade")),
                                Estado = reader.GetString(reader.GetOrdinal("End_Estado")),
                                CEP = reader.GetString(reader.GetOrdinal("End_CEP")),
                                Complemento = reader.GetString(reader.GetOrdinal("End_Complemento")),
                            };
                        }
                    }
                }
            }

            return endereco; // Retorna o endereço correspondente ao paciente
        }
    }
}
