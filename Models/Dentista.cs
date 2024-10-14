namespace ProjetoOdontoPOO.Models
{
    public class Dentista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Estado { get; set; }
        public string Especialidade { get; set; }
        public string Telefone { get; set; }
        public int Ativo_Inativo { get; set; }
    }
}
