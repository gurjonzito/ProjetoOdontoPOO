using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Repositories;
using System;
using System.Data;

public class PagamentoService
{
    private readonly PagamentoRepository _pagamentoRepository;

    public PagamentoService()
    {
        _pagamentoRepository = new PagamentoRepository();
    }

    public Pagamento ObterPagamentoPorId(int pagamentoId)
    {
        if (pagamentoId <= 0)
            throw new ArgumentException("ID do pagamento inválido.");

        return _pagamentoRepository.ObterPagamentoPorId(pagamentoId);
    }

    public DataTable ObterTodosPagamentos()
    {
        return _pagamentoRepository.ObterPagamentos();
    }

    public OperationResult InserirPagamento(Pagamento pagamento)
    {
        var resultadoValidacao = ValidarPagamento(pagamento);
        if (!resultadoValidacao.Sucesso)
            return resultadoValidacao;

        _pagamentoRepository.InserirPagamento(pagamento);
        return new OperationResult(true, "Pagamento registrado com sucesso!");
    }

    public bool AtualizarPagamento(int pagamentoId, Pagamento pagamento)
    {
        var resultadoValidacao = ValidarPagamento(pagamento);
        if (!resultadoValidacao.Sucesso)
            throw new ArgumentException(resultadoValidacao.Mensagem);

        return _pagamentoRepository.AtualizarPagamento(pagamentoId, pagamento);
    }

    private OperationResult ValidarPagamento(Pagamento pagamento)
    {
        if (pagamento.ValorPago <= 0)
            return new OperationResult(false, "O valor pago deve ser maior que zero.");

        var metodosValidos = new[] { "Débito", "Crédito", "Dinheiro", "Pix", "Transferência" };
        if (Array.IndexOf(metodosValidos, pagamento.MetodoPagamento) == -1)
            return new OperationResult(false, "Método de pagamento inválido. Os métodos válidos são: Débito, Crédito, Dinheiro, Pix, Transferência.");

        var statusValidos = new[] { "Em Aberto", "Pendente", "Pago" };
        if (Array.IndexOf(statusValidos, pagamento.PagamentoStatus) == -1)
            return new OperationResult(false, "Status inválido. Os status válidos são: Em Aberto, Pendente, Pago.");

        if (pagamento.Paciente == null || pagamento.Paciente.Id <= 0)
            return new OperationResult(false, "Paciente inválido.");

        return new OperationResult(true, "Validação bem-sucedida!");
    }
}
