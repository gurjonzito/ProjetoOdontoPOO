using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Repositories;
using System;
using System.Data;

public class PacienteService
{
    private readonly PacienteRepository _pacienteRepository;

    public PacienteService()
    {
        _pacienteRepository = new PacienteRepository();
    }

    public Paciente ObterDadosPacientePorId(int pacienteId)
    {
        if (pacienteId <= 0)
            throw new ArgumentException("ID do paciente inválido.");

        return _pacienteRepository.ObterDadosPacientePorId(pacienteId);
    }

    public DataTable ObterTodosPacientes()
    {
        return _pacienteRepository.ObterDadosPacientes();
    }

    public OperationResult InserirPacienteComEndereco(Paciente paciente, Endereco endereco)
    {
        var resultadoValidacao = ValidarCadastroPaciente(paciente, endereco);
        if (!resultadoValidacao.Sucesso)
            return resultadoValidacao;

        _pacienteRepository.InserirPacienteComEndereco(paciente, endereco);
        return new OperationResult(true, "Paciente cadastrado com sucesso!");
    }

    public bool AtualizarPacienteComEndereco(int pacienteId, Paciente paciente, Endereco endereco)
    {
        var resultadoValidacao = ValidarCadastroPaciente(paciente, endereco);
        if (!resultadoValidacao.Sucesso)
            throw new ArgumentException(resultadoValidacao.Mensagem);

        return _pacienteRepository.AtualizarPacienteComEndereco(pacienteId, paciente, endereco);
    }

    private OperationResult ValidarCadastroPaciente(Paciente paciente, Endereco endereco)
    {
        var resultadoPaciente = ValidarPaciente(paciente);
        if (!resultadoPaciente.Sucesso) return resultadoPaciente;

        return ValidarEndereco(endereco);
    }

    private OperationResult ValidarPaciente(Paciente paciente)
    {
        string cpfLimpo = paciente.CPF.Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");
        Console.WriteLine($"CPF Limpo: {cpfLimpo}");

        string telefoneLimpo = paciente.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
        Console.WriteLine($"Telefone Limpo: {telefoneLimpo}");

        if (string.IsNullOrWhiteSpace(paciente.Nome))
            return new OperationResult(false, "O nome do paciente é obrigatório.");

        if (paciente.DataNascimento == DateTime.MinValue)
            return new OperationResult(false, "Data de nascimento inválida.");

        if (paciente.Idade <= 0)
            return new OperationResult(false, "Idade inválida.");

        if (string.IsNullOrWhiteSpace(cpfLimpo))
            return new OperationResult(false, "O CPF do paciente é obrigatório.");

        if (cpfLimpo.Length != 11)
            return new OperationResult(false, "O CPF do paciente deve conter 11 dígitos.");

        if (string.IsNullOrWhiteSpace(paciente.Sexo))
            return new OperationResult(false, "O sexo do paciente é obrigatório.");

        if (string.IsNullOrWhiteSpace(telefoneLimpo))
            return new OperationResult(false, "O telefone do paciente é obrigatório.");

        if (!string.IsNullOrWhiteSpace(paciente.Email) && (paciente.Email.Contains(" ") || !paciente.Email.Contains("@")))
            return new OperationResult(false, "E-mail inválido.");

        return new OperationResult(true, "Validação bem-sucedida!");
    }

    private OperationResult ValidarEndereco(Endereco endereco)
    {
        string cepLimpo = endereco.CEP.Replace("-", "");

        if (string.IsNullOrWhiteSpace(endereco.Logradouro))
            return new OperationResult(false, "O logradouro do endereço é obrigatório.");

        if (string.IsNullOrWhiteSpace(endereco.Cidade))
            return new OperationResult(false, "A cidade do endereço é obrigatória.");

        if (string.IsNullOrWhiteSpace(endereco.Estado) || endereco.Estado.Length != 2)
            return new OperationResult(false, "O estado do endereço é obrigatório e deve conter 2 caracteres.");

        if (string.IsNullOrWhiteSpace(cepLimpo))
            return new OperationResult(false, "O CEP do endereço é obrigatório.");

        if (cepLimpo.Length != 8)
            return new OperationResult(false, "O CEP do endereço deve conter 8 dígitos.");

        return new OperationResult(true, "Validação bem-sucedida!");
    }
}
