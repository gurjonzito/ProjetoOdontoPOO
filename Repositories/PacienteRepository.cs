using ProjetoOdontoPOO.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoOdontoPOO.Services;

namespace ProjetoOdontoPOO.Repositories
{
    public class PacienteRepository
    {
        private readonly DataBaseSqlServerService _dbService;

        public PacienteRepository()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public Paciente ObterDadosPacientePorId(int pacienteId)
        {
            Paciente paciente = null;

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"SELECT Pac_ID, Pac_Nome, Pac_DataNascimento, Pac_Idade, Pac_CPF, Pac_Sexo, Pac_Telefone, Pac_Email, Ativo_Inativo, Pac_ConvenioID_FK, Pac_ResponsavelID_FK
                                 FROM Paciente
                                 WHERE Pac_ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", pacienteId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            paciente = new Paciente
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Pac_ID")),
                                Nome = reader.GetString(reader.GetOrdinal("Pac_Nome")),
                                DataNascimento = reader.GetDateTime(reader.GetOrdinal("Pac_DataNascimento")),
                                Idade = reader.GetInt32(reader.GetOrdinal("Pac_Idade")),
                                CPF = reader.GetString(reader.GetOrdinal("Pac_CPF")),
                                Sexo = reader.GetString(reader.GetOrdinal("Pac_Sexo")),
                                Telefone = reader.GetString(reader.GetOrdinal("Pac_Telefone")),
                                Email = reader.GetString(reader.GetOrdinal("Pac_Email")),
                                Convenio = reader.IsDBNull(reader.GetOrdinal("Pac_ConvenioID_FK"))
                                ? null
                                : new Convenio { Id = reader.GetInt32(reader.GetOrdinal("Pac_ConvenioID_FK")) },
                                Responsavel = reader.IsDBNull(reader.GetOrdinal("Pac_ResponsavelID_FK"))
                                ? null
                                : new Responsavel { Id = reader.GetInt32(reader.GetOrdinal("Pac_ResponsavelID_FK")) }
                            };
                        }
                    }
                }
            }

            return paciente;
        }

        public DataTable ObterDadosPacientes()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"
            SELECT Pac.Pac_ID as ID,
                   Pac.Pac_Nome AS Nome,
                   Pac.Pac_DataNascimento AS [Data de Nascimento],
                   Pac.Pac_Idade AS Idade,
                   Pac.Pac_CPF AS CPF,
                   Pac.Pac_Sexo AS Sexo,
                   Pac.Pac_Telefone AS Telefone,
                   Pac.Pac_Email AS [E-mail],
                   Pac.Ativo_Inativo AS Ativo_Inativo,
                   COALESCE(Conv.Conv_Nome, 'Sem Convênio') AS Convênio,
                   COALESCE(Resp.Res_Nome, 'Sem Responsável') AS Responsável
            FROM Paciente AS Pac
            LEFT JOIN Convenio AS Conv ON Pac.Pac_ConvenioID_FK = Conv.Conv_ID
            LEFT JOIN Responsavel AS Resp ON Pac.Pac_ResponsavelID_FK = Resp.Res_ID";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                adaptador.Fill(tabela);
            }

            return tabela;
        }

        public void InserirPacienteComEndereco(Paciente paciente, Endereco endereco)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string queryPaciente = "INSERT INTO Paciente (Pac_Nome, Pac_DataNascimento, Pac_Idade, Pac_CPF, Pac_Sexo, Pac_Telefone, Pac_Email, Pac_ConvenioID_FK, Pac_ResponsavelID_FK) " +
                                            "OUTPUT INSERTED.Pac_Id VALUES (@Nome, @DataNascimento, @Idade, @CPF, @Sexo, @Telefone, @Email, @ConvenioID, @ResponsavelID)";
                    using (SqlCommand cmdPaciente = new SqlCommand(queryPaciente, conexao, transacao))
                    {
                        cmdPaciente.Parameters.AddWithValue("@Nome", paciente.Nome);
                        cmdPaciente.Parameters.AddWithValue("@DataNascimento", paciente.DataNascimento);
                        cmdPaciente.Parameters.AddWithValue("@Idade", paciente.Idade);
                        string cpfLimpo = paciente.CPF.Replace(".", "").Replace("-", "").Replace(",", "");
                        cmdPaciente.Parameters.AddWithValue("@CPF", cpfLimpo);
                        cmdPaciente.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                        string telefoneLimpo = paciente.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                        cmdPaciente.Parameters.AddWithValue("@Telefone", telefoneLimpo);
                        cmdPaciente.Parameters.AddWithValue("@Email", paciente.Email);
                        cmdPaciente.Parameters.AddWithValue("@ConvenioID", paciente.Convenio != null ? (object)paciente.Convenio.Id : DBNull.Value);
                        cmdPaciente.Parameters.AddWithValue("@ResponsavelID", paciente.Responsavel != null ? (object)paciente.Responsavel.Id : DBNull.Value);

                        int pacienteId = (int)cmdPaciente.ExecuteScalar();

                        string queryEndereco = "INSERT INTO Endereco (End_Logradouro, End_Numero, End_Cidade, End_Estado, End_CEP, End_Complemento, End_PacienteID_FK) " +
                                                "VALUES (@Logradouro, @Numero, @Cidade, @Estado, @CEP, @Complemento, @PacienteID)";
                        using (SqlCommand cmdEndereco = new SqlCommand(queryEndereco, conexao, transacao))
                        {
                            cmdEndereco.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                            cmdEndereco.Parameters.AddWithValue("@Numero", endereco.Numero);
                            cmdEndereco.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                            cmdEndereco.Parameters.AddWithValue("@Estado", endereco.Estado);
                            string cepLimpo = endereco.CEP.Replace("-", "");
                            cmdEndereco.Parameters.AddWithValue("@CEP", cepLimpo);
                            cmdEndereco.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                            cmdEndereco.Parameters.AddWithValue("@PacienteID", pacienteId);

                            cmdEndereco.ExecuteNonQuery();
                        }
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

        public bool AtualizarPacienteComEndereco(int pacienteId, Paciente paciente, Endereco endereco)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string queryPaciente = @"UPDATE Paciente
                             SET Pac_Nome = @Nome,
                                 Pac_DataNascimento = @DataNascimento,
                                 Pac_Idade = @Idade,
                                 Pac_CPF = @CPF,
                                 Pac_Sexo = @Sexo,
                                 Pac_Telefone = @Telefone,
                                 Pac_Email = @Email,
                                 Pac_ConvenioID_FK = @ConvenioID,
                                 Pac_ResponsavelID_FK = @ResponsavelID
                             WHERE Pac_ID = @ID";

                    using (SqlCommand cmdPaciente = new SqlCommand(queryPaciente, conexao, transacao))
                    {
                        cmdPaciente.Parameters.AddWithValue("@ID", pacienteId);
                        cmdPaciente.Parameters.AddWithValue("@Nome", paciente.Nome);
                        cmdPaciente.Parameters.AddWithValue("@DataNascimento", paciente.DataNascimento);
                        cmdPaciente.Parameters.AddWithValue("@Idade", paciente.Idade);
                        cmdPaciente.Parameters.AddWithValue("@CPF", paciente.CPF);
                        cmdPaciente.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                        cmdPaciente.Parameters.AddWithValue("@Telefone", paciente.Telefone);
                        cmdPaciente.Parameters.AddWithValue("@Email", paciente.Email);
                        cmdPaciente.Parameters.AddWithValue("@ConvenioID", paciente.Convenio?.Id ?? (object)DBNull.Value);
                        cmdPaciente.Parameters.AddWithValue("@ResponsavelID", paciente.Responsavel?.Id ?? (object)DBNull.Value);

                        cmdPaciente.ExecuteNonQuery();
                    }

                    string queryEndereco = @"UPDATE Endereco
                             SET End_Logradouro = @Logradouro,
                                 End_Numero = @Numero,
                                 End_Cidade = @Cidade,
                                 End_Estado = @Estado,
                                 End_CEP = @CEP,
                                 End_Complemento = @Complemento
                             WHERE End_PacienteID_FK = @PacienteID";

                    using (SqlCommand cmdEndereco = new SqlCommand(queryEndereco, conexao, transacao))
                    {
                        cmdEndereco.Parameters.AddWithValue("@PacienteID", pacienteId);
                        cmdEndereco.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                        cmdEndereco.Parameters.AddWithValue("@Numero", endereco.Numero);
                        cmdEndereco.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                        cmdEndereco.Parameters.AddWithValue("@Estado", endereco.Estado);
                        cmdEndereco.Parameters.AddWithValue("@CEP", endereco.CEP);
                        cmdEndereco.Parameters.AddWithValue("@Complemento", endereco.Complemento);

                        cmdEndereco.ExecuteNonQuery();
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
