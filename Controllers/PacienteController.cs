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

    public Paciente ObterPacientePorId(int pacienteId)
    {
        try
        {
            return _pacienteService.ObterDadosPacientePorId(pacienteId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter paciente: {ex.Message}");
            throw;
        }
    }

    public DataTable ObterTodosPacientes()
    {
        try
        {
            return _pacienteService.ObterTodosPacientes();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter lista de pacientes: {ex.Message}");
            throw;
        }
    }

    public string InserirPacienteComEndereco(Paciente paciente, Endereco endereco)
    {
        var resultado = _pacienteService.InserirPacienteComEndereco(paciente, endereco);

        return resultado.Mensagem; // Retorna a mensagem, que pode ser de sucesso ou de erro
    }

    public bool AtualizarPacienteComEndereco(int pacienteId, Paciente paciente, Endereco endereco)
    {
        try
        {
            return _pacienteService.AtualizarPacienteComEndereco(pacienteId, paciente, endereco);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao atualizar paciente: {ex.Message}");
            throw;
        }
    }
}
