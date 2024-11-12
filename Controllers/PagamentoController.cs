using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Data;
using System.Windows.Forms;

public class PagamentoController
{
    private readonly PagamentoService _pagamentoService;

    public PagamentoController()
    {
        _pagamentoService = new PagamentoService();
    }

    // Método para obter um pagamento pelo ID
    public Pagamento ObterPagamentoPorId(int pagamentoId)
    {
        try
        {
            return _pagamentoService.ObterPagamentoPorId(pagamentoId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter pagamento: {ex.Message}");
            throw;
        }
    }

    // Método para obter todos os pagamentos
    public DataTable ObterTodosPagamentos()
    {
        try
        {
            return _pagamentoService.ObterTodosPagamentos();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter lista de pagamentos: {ex.Message}");
            throw;
        }
    }

    // Método para inserir um pagamento
    public string InserirPagamento(Pagamento pagamento)
    {
        try
        {
            var resultado = _pagamentoService.InserirPagamento(pagamento);
            return resultado.Mensagem; // Retorna a mensagem, que pode ser de sucesso ou erro
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao inserir pagamento: {ex.Message}");
            return $"Erro ao inserir pagamento: {ex.Message}";
        }
    }

    // Método para atualizar um pagamento
    public bool AtualizarPagamento(int pagamentoId, Pagamento pagamento)
    {
        try
        {
            return _pagamentoService.AtualizarPagamento(pagamentoId, pagamento);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao atualizar pagamento: {ex.Message}");
            throw;
        }
    }
}
