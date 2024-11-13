using ProjetoOdontoPOO.Controllers;
using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System.Data;
using System.Data.SqlClient;

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
                            int pacienteId = reader.GetInt32(reader.GetOrdinal("Cons_PacienteID_FK"));
                            int dentistaId = reader.GetInt32(reader.GetOrdinal("Cons_DentistaID_FK"));

                            PacienteController pacienteController = new PacienteController();
                            Paciente paciente = pacienteController.ObterPacientePorId(pacienteId);

                            DentistaController dentistaController = new DentistaController();
                            Dentista dentista = dentistaController.ObterDentistaPorId(dentistaId);

                            consulta = new Consulta
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Cons_ID")),
                                DataConsulta = reader.GetDateTime(reader.GetOrdinal("Cons_DataConsulta")),
                                Observacoes = reader.GetString(reader.GetOrdinal("Cons_Observacoes")),
                                Paciente = paciente,
                                Dentista = dentista
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
            SELECT Cons.Cons_ID AS ID,
                   Cons.Cons_DataConsulta AS Data,
                   Cons.Cons_Observacoes AS [Observações],
                   COALESCE(Pac.Pac_Nome, 'Sem Paciente') AS Paciente,
                   COALESCE(Den.Den_Nome, 'Sem Dentista') AS Dentista
            FROM Consulta AS Cons
            LEFT JOIN Paciente AS Pac ON Cons.Cons_PacienteID_FK = Pac.Pac_ID
            LEFT JOIN Dentista AS Den ON Cons.Cons_DentistaID_FK = Den.Den_ID";

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

        public bool AtualizarConsulta(int consultaId, Consulta consulta)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = @"UPDATE Consulta
                             SET Cons_DataConsulta = @Data,
                                 Cons_Observacoes = @Observacoes,
                                 Cons_PacienteID_FK = @PacienteId,
                                 Cons_DentistaID_FK = @DentistaId
                             WHERE Cons_ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@ID", consultaId);
                        cmd.Parameters.AddWithValue("@Data", consulta.DataConsulta);
                        cmd.Parameters.AddWithValue("@Observacoes", consulta.Observacoes);
                        cmd.Parameters.AddWithValue("@PacienteId", consulta.Paciente.Id);
                        cmd.Parameters.AddWithValue("@DentistaId", consulta.Dentista.Id);

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
