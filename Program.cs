using ProjetoOdontoPOO.Services;
using ProjetoOdontoPOO.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOdontoPOO
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Criar instância do serviço de conexão
            var dataBaseService = new DataBaseSqlServerService();

            // Tentar conectar ao banco de dados
            var conexao = dataBaseService.CriarConexao();

            // Se a conexão falhar, a aplicação será encerrada no CriarConexao()
            if (conexao == null) return; // Não deve chegar aqui, pois Application.Exit() já finalizou o programa

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
