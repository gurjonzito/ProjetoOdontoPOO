using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class PacienteService
{
    private readonly DataBaseSqlServerService _dbService;

    public PacienteService()
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
            SELECT Pac.Pac_ID AS ID,
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
                // Inicia a transação
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    // Insere o paciente e captura o ID gerado
                    string queryPaciente = "INSERT INTO Paciente (Pac_Nome, Pac_DataNascimento, Pac_Idade, Pac_CPF, Pac_Sexo, Pac_Telefone, Pac_Email, Pac_ConvenioID_FK, Pac_ResponsavelID_FK) " +
                                            "OUTPUT INSERTED.Pac_Id VALUES (@Nome, @DataNascimento, @Idade, @CPF, @Sexo, @Telefone, @Email, @ConvenioID, @ResponsavelID)";
                    using (SqlCommand cmdPaciente = new SqlCommand(queryPaciente, conexao, transacao))
                    {
                        cmdPaciente.Parameters.AddWithValue("@Nome", paciente.Nome);
                        cmdPaciente.Parameters.AddWithValue("@DataNascimento", paciente.DataNascimento);
                        cmdPaciente.Parameters.AddWithValue("@Idade", paciente.Idade);
                        cmdPaciente.Parameters.AddWithValue("@CPF", paciente.CPF);
                        cmdPaciente.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                        cmdPaciente.Parameters.AddWithValue("@Telefone", paciente.Telefone);
                        cmdPaciente.Parameters.AddWithValue("@Email", paciente.Email);
                        // Se Convenio for null, usa DBNull.Value, caso contrário, pega o Id
                        cmdPaciente.Parameters.AddWithValue("@ConvenioID", paciente.Convenio != null ? (object)paciente.Convenio.Id : DBNull.Value);
                        // Se Responsavel for null, usa DBNull.Value, caso contrário, pega o Id
                        cmdPaciente.Parameters.AddWithValue("@ResponsavelID", paciente.Responsavel != null ? (object)paciente.Responsavel.Id : DBNull.Value);

                        int pacienteId = (int)cmdPaciente.ExecuteScalar();

                        // Insere o endereço usando o ID do paciente
                        string queryEndereco = "INSERT INTO Endereco (End_Logradouro, End_Numero, End_Cidade, End_Estado, End_CEP, End_Complemento, End_PacienteID_FK) " +
                                                "VALUES (@Logradouro, @Numero, @Cidade, @Estado, @CEP, @Complemento, @PacienteID)";
                        using (SqlCommand cmdEndereco = new SqlCommand(queryEndereco, conexao, transacao))
                        {
                            cmdEndereco.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                            cmdEndereco.Parameters.AddWithValue("@Numero", endereco.Numero);
                            cmdEndereco.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                            cmdEndereco.Parameters.AddWithValue("@Estado", endereco.Estado);
                            cmdEndereco.Parameters.AddWithValue("@CEP", endereco.CEP);
                            cmdEndereco.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                            cmdEndereco.Parameters.AddWithValue("@PacienteID", pacienteId);

                            cmdEndereco.ExecuteNonQuery();
                        }
                    }

                    // Confirma a transação
                    transacao.Commit();
                }
                catch
                {
                    // Reverte a transação em caso de erro
                    transacao.Rollback();
                    throw;
                }
            }
        }

        public bool AtualizarPaciente(int pacienteId, string nome, DateTime dataNascimento, string cpf, string telefone, string email)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"UPDATE Paciente
                                     SET Pac_Nome = @Nome,
                                         Pac_DataNascimento = @DataNascimento,
                                         Pac_CPF = @CPF,
                                         Pac_Telefone = @Telefone,
                                         Pac_Email = @Email
                                     WHERE Pac_ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@ID", pacienteId);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true se a atualização foi bem-sucedida
                }
            }
        }
    }
