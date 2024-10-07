using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Data;
using System.Windows.Forms;

public class EnderecoController
{
    private readonly EnderecoService _enderecoService;

    public EnderecoController()
    {
        _enderecoService = new EnderecoService();
    }

    public Endereco ObterDadosEnderecoPorId(int enderecoId)
    {
        return _enderecoService.ObterDadosEnderecoPorId(enderecoId);
    }

    //public void AtualizarEndereco(int pacienteId, string nome, DateTime dataNascimento, string cpf, string telefone, string email)
    //{
    //    try
    //    {
    //        bool sucesso = _pacienteService.AtualizarPaciente(pacienteId, nome, dataNascimento, cpf, telefone, email);
    //        if (sucesso)
    //        {
    //            MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        }
    //        else
    //        {
    //            MessageBox.Show("Nenhum registro foi atualizado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show($"Erro ao atualizar paciente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}
}
