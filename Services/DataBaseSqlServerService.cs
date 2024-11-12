using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // Usado para MessageBox (Windows Forms)

namespace ProjetoOdontoPOO.Services
{
    public class DataBaseSqlServerService
    {
        //Método para conectar com o banco de dados
        public SqlConnection CriarConexao()
        {
            SqlConnection conexao = new SqlConnection();

            // Dados para conectar ao banco
            conexao.ConnectionString = "Data Source=DESKTOP-SIEUHQJ;" + // Servidor
                                       "Initial Catalog=ProjetoOdonto;" + // Nome do banco
                                       "Integrated Security=SSPI;" + // Autenticação do Windows (usuário logado)
                                       "User Instance=false;"; // Usar o usuário da máquina

            try
            {
                conexao.Open(); // Tenta abrir a conexão com o banco de dados
                return conexao; // Se a conexão for bem-sucedida, retorna a conexão
            }
            catch (SqlException ex) // Captura qualquer erro relacionado ao SQL Server
            {
                // Exibe uma MessageBox com o erro de conexão
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Encerra a aplicação, pois o banco não está disponível
                Application.Exit(); // Finaliza a aplicação sem permitir que o restante seja carregado
                return null; // Não será alcançado, pois a aplicação será encerrada
            }
        }
    }
}
