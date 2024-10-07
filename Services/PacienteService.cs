using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Data.SqlClient;

public class PacienteService
{
    private readonly DataBaseSqlServerService _dbService;

    public PacienteService()
    {
        _dbService = new DataBaseSqlServerService();
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
}
