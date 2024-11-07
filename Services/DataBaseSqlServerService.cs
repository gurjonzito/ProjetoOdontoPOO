//Importar bibliotecas de banco
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoOdontoPOO.Services
{
    public class DataBaseSqlServerService
    {
        //Método para conectar com o banco de dados
        public SqlConnection CriarConexao()
        {
            SqlConnection conexao = new SqlConnection();

            //Os dados para conectar no banco
            conexao.ConnectionString = "Data Source=MTZNOTFS061604\\SQLEXPRESS;" + //Servidor
                "Initial Catalog=ProjetoOdonto;" +  //Nome do banco
                "Integrated Security=SSPI;" + //Autenticação do Windows (usuário logado)
                "User Instance=false;"; //Usar o usuário da máquina

            conexao.Open(); //Abrir a conexão com o banco
            return conexao;
        }
    }
}
