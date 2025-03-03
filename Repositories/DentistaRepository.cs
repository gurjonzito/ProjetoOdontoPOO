﻿using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace ProjetoOdontoPOO.Repositories
{
    public class DentistaRepository
    {
        private readonly DataBaseSqlServerService _dbService;

        public DentistaRepository()
        {
            _dbService = new DataBaseSqlServerService();
        }

        public Dentista ObterDadosDentistaPorId(int dentistaId)
        {
            Dentista dentista = null;

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"SELECT Den_ID, Den_Nome, Den_CRM, Den_Estado, Den_Especialidade, Den_Telefone, Ativo_Inativo
                                 FROM Dentista
                                 WHERE Den_ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", dentistaId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dentista = new Dentista
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Den_ID")),
                                Nome = reader.GetString(reader.GetOrdinal("Den_Nome")),
                                CRM = reader.GetString(reader.GetOrdinal("Den_CRM")),
                                Estado = reader.GetString(reader.GetOrdinal("Den_Estado")),
                                Especialidade = reader.GetString(reader.GetOrdinal("Den_Especialidade")),
                                Telefone = reader.GetString(reader.GetOrdinal("Den_Telefone")),
                                Ativo_Inativo = reader.GetInt32(reader.GetOrdinal("Ativo_Inativo"))
                            };
                        }
                    }
                }
            }

            return dentista;
        }

        public DataTable ObterDadosDentistas()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                string query = @"
            SELECT Den_ID AS ID,
                   Den_Nome AS Nome,
                   Den_CRM AS CRM,
                   Den_Estado AS Estado,
                   Den_Especialidade as Especialidade,
                   Den_Telefone AS Telefone,
                   Ativo_Inativo AS Ativo_Inativo
            FROM Dentista";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                adaptador.Fill(tabela);
            }

            return tabela;
        }

        public void InserirDentista(Dentista dentista)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = "INSERT INTO Dentista (Den_Nome, Den_CRM, Den_Estado, Den_Especialidade, Den_Telefone) " +
                                            "VALUES (@Nome, @CRM, @Estado, @Especialidade, @Telefone)";
                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        string telefoneLimpo = dentista.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                        cmd.Parameters.AddWithValue("@Nome", dentista.Nome);
                        cmd.Parameters.AddWithValue("@CRM", dentista.CRM);
                        cmd.Parameters.AddWithValue("@Estado", dentista.Estado);
                        cmd.Parameters.AddWithValue("@Especialidade", dentista.Especialidade);
                        cmd.Parameters.AddWithValue("@Telefone", telefoneLimpo);

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

        public bool AtualizarDentista(int dentistaId, Dentista dentista)
        {
            using (SqlConnection conexao = _dbService.CriarConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string query = @"UPDATE Dentista
                             SET Den_Nome = @Nome,
                                 Den_CRM = @CRM,
                                 Den_Estado = @Estado,
                                 Den_Especialidade = @Especialidade,
                                 Den_Telefone = @Telefone,
                                 Ativo_Inativo = @AtivoInativo
                             WHERE Den_ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conexao, transacao))
                    {
                        string telefoneLimpo = dentista.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                        cmd.Parameters.AddWithValue("@ID", dentistaId);
                        cmd.Parameters.AddWithValue("@Nome", dentista.Nome);
                        cmd.Parameters.AddWithValue("@CRM", dentista.CRM);
                        cmd.Parameters.AddWithValue("@Estado", dentista.Estado);
                        cmd.Parameters.AddWithValue("@Especialidade", dentista.Especialidade);
                        cmd.Parameters.AddWithValue("@Telefone", telefoneLimpo);
                        cmd.Parameters.AddWithValue("@AtivoInativo", dentista.Ativo_Inativo);

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
