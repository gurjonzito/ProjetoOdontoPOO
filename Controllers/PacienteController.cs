using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Data;
using System.Windows.Forms;

public class PacienteController
{
    private readonly PacienteService _pacienteService;

    public PacienteController()
    {
        _pacienteService = new PacienteService();
    }

    public Paciente ObterDadosPacientePorId(int pacienteId)
    {
        return _pacienteService.ObterDadosPacientePorId(pacienteId);
    }

    public DataTable ObterDadosPacientes()
    {
        return _pacienteService.ObterDadosPacientes();
    }

    public void InserirPacienteComEndereco(Paciente paciente, Endereco endereco)
    {
        try
        {
            _pacienteService.InserirPacienteComEndereco(paciente, endereco);
            MessageBox.Show("Paciente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao adicionar paciente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public bool AtualizarPacienteComEndereco(int pacienteId, string nome, DateTime dataNascimento, int idade, string cpf, string sexo, string telefone, string email, int? convenioId, int? responsavelId, Endereco endereco)
    {
        return _pacienteService.AtualizarPacienteComEndereco(pacienteId, nome, dataNascimento, idade, cpf, sexo, telefone, email, convenioId, responsavelId, endereco);
    }
}
