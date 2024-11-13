using System;

namespace ProjetoOdontoPOO.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Observacoes { get; set; }
        public Paciente Paciente { get; set; }
        public Dentista Dentista { get; set; }
    }
}
