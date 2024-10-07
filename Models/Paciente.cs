﻿using System;

namespace ProjetoOdontoPOO.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Ativo_Inativo { get; set; }
        public Convenio Convenio { get; set; }
        public Responsavel Responsavel { get; set; }
    }
}
