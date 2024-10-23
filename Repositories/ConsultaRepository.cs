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
    public class ConsultaRepository
    {
        private readonly DataBaseSqlServerService _dbService;

        public ConsultaRepository()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public Consulta ObterDadosConsultaPorId(int consultaId)
        {
            Consulta consulta = null;

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"SELECT Cons_ID, Cons_DataConsulta, Cons_Observacoes, Cons_PacienteID_FK, Cons_DentistaID_FK
                                 FROM Consulta
                                 WHERE Cons_ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", consultaId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            consulta = new Consulta
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Cons_ID")),
                                DataConsulta = reader.GetDateTime(reader.GetOrdinal("Cons_DataConsulta")),
                                Observacoes = reader.GetString(reader.GetOrdinal("Cons_Observacoes")),
                                Paciente = new Paciente
                                {
                                    Nome = reader.GetString(reader.GetOrdinal("Pac_Nome")),
                                },
                                Dentista = new Dentista
                                {
                                    Nome = reader.GetString(reader.GetOrdinal("Den_Nome")),
                                },
                            };
                        }
                    }
                }
            }

            return consulta;
        }

        public DataTable ObterDadosConsultas()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"
            SELECT Cons_ID AS ID,
                   Cons_DataConsulta AS Data,
                   Cons_Observacoes AS [Observações],
                   Cons_PacienteID_FK AS Paciente,
                   Cons_DentistaID_FK AS Dentista
            FROM Consulta";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                adaptador.Fill(tabela);
            }

            return tabela;
        }

        public void InserirConsulta(Consulta consulta)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = "INSERT INTO Consulta (Cons_DataConsulta, Cons_Observacoes, Cons_PacienteID_FK, Cons_DentistaID_FK) " +
                                            "VALUES (@DataConsulta, @Observacoes, @PacienteId, @DentistaId)";
                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@DataConsulta", consulta.DataConsulta);
                        cmd.Parameters.AddWithValue("@Observacoes", consulta.Observacoes);
                        cmd.Parameters.AddWithValue("@PacienteId", consulta.Paciente.Id);
                        cmd.Parameters.AddWithValue("@DentistaId", consulta.Dentista.Id);

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
