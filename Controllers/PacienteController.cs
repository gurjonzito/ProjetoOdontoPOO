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

    public void AtualizarPaciente(int pacienteId, string nome, DateTime dataNascimento, string cpf, string telefone, string email)
    {
        try
        {
            bool sucesso = _pacienteService.AtualizarPaciente(pacienteId, nome, dataNascimento, cpf, telefone, email);
            if (sucesso)
            {
                MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum registro foi atualizado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar paciente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
