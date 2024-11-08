USE master;
GO

DROP DATABASE IF EXISTS ProjetoOdontov2;
GO

CREATE DATABASE ProjetoOdontov2;
GO

USE ProjetoOdontov2;
GO

CREATE TABLE Convenio(
	Conv_ID INT NOT NULL IDENTITY(1,1),
	Conv_Nome VARCHAR(100) NOT NULL,
	Conv_CNPJ VARCHAR(14) NOT NULL UNIQUE,
	Conv_Telefone VARCHAR(11) NOT NULL,
	Conv_Endereco VARCHAR(255) NOT NULL,
	Conv_Email VARCHAR(100) NOT NULL,
	Conv_DataCriacao DATETIME NOT NULL DEFAULT GETDATE(),
	Ativo_Inativo INT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Convenio PRIMARY KEY (Conv_ID)
);
GO

CREATE TABLE Dentista(
	Den_ID INT NOT NULL IDENTITY(1,1),
	Den_Nome VARCHAR(100) NOT NULL,
	Den_CRM VARCHAR(6) NOT NULL UNIQUE,
	Den_Estado CHAR(2) NOT NULL,
	Den_Especialidade VARCHAR(100) NOT NULL,
	Den_Telefone VARCHAR(11) NOT NULL,
	Ativo_Inativo INT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Dentista PRIMARY KEY (Den_ID),
	CONSTRAINT CK_Dentista_Estado CHECK (Den_Estado IN ('AC', 'AL', 'AP', 'AM', 'BA', 'CE', 'DF', 'ES', 'GO', 'MA', 'MT', 'MS', 'MG', 'PA', 'PB', 'PR', 'PE', 'PI', 'RJ', 'RN', 'RS', 'RO', 'RR', 'SC', 'SP', 'SE', 'TO'))

);
GO

CREATE TABLE Responsavel(
	Res_ID INT NOT NULL IDENTITY(1,1),
	Res_Nome VARCHAR(100) NOT NULL,
	Res_DataNascimento DATE NOT NULL,
	Res_Idade INT NOT NULL,
	Res_CPF VARCHAR(11) NOT NULL UNIQUE,
	Res_Sexo VARCHAR(30) NOT NULL,
	Res_Telefone VARCHAR(11) NOT NULL,
	Res_Parentesco VARCHAR(50) NOT NULL,
	Ativo_Inativo INT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Responsavel PRIMARY KEY (Res_ID),
	CONSTRAINT CK_Responsavel_Sexo CHECK(Res_Sexo IN('Masculino', 'Feminino', 'Outro'))
);
GO

CREATE TABLE Paciente(
	Pac_ID INT NOT NULL IDENTITY(1,1),
	Pac_Nome VARCHAR(100) NOT NULL,
	Pac_DataNascimento DATE NOT NULL,
	Pac_Idade INT NOT NULL,
	Pac_CPF VARCHAR(11) NOT NULL UNIQUE,
	Pac_Sexo VARCHAR(30) NOT NULL,
	Pac_Telefone VARCHAR(11) NOT NULL,
	Pac_Email VARCHAR(100),
	Ativo_Inativo INT NOT NULL DEFAULT 1,
	Pac_ConvenioID_FK INT,
	Pac_ResponsavelID_FK INT,
	CONSTRAINT PK_Paciente PRIMARY KEY (Pac_ID),
	CONSTRAINT FK_Paciente_Convenio FOREIGN KEY (Pac_ConvenioID_FK)
	REFERENCES Convenio(Conv_ID),
	CONSTRAINT FK_Paciente_Responsavel FOREIGN KEY (Pac_ResponsavelID_FK)
	REFERENCES Responsavel(Res_ID),
	CONSTRAINT CK_Paciente_Sexo CHECK(Pac_Sexo IN('Masculino', 'Feminino', 'Outro'))
);
GO

CREATE TABLE Consulta(
	Cons_ID INT NOT NULL IDENTITY(1,1),
	Cons_DataConsulta DATETIME NOT NULL,
	Cons_Observacoes TEXT,
	Cons_PacienteID_FK INT NOT NULL,
	Cons_DentistaID_FK INT NOT NULL,
	CONSTRAINT PK_Consulta PRIMARY KEY (Cons_ID),
	CONSTRAINT FK_Consulta_Paciente FOREIGN KEY (Cons_PacienteID_FK)
	REFERENCES Paciente(Pac_ID),
	CONSTRAINT FK_Consulta_Dentista FOREIGN KEY (Cons_DentistaID_FK)
	REFERENCES Dentista(Den_ID)
);
GO

CREATE TABLE Endereco(
	End_ID INT NOT NULL IDENTITY(1,1),
	End_Logradouro VARCHAR(100) NOT NULL,
	End_Numero VARCHAR(10),
	End_Cidade VARCHAR(70) NOT NULL,
	End_Estado CHAR(2) NOT NULL,
	End_CEP VARCHAR(8) NOT NULL,
	End_Complemento VARCHAR(50),
	End_PacienteID_FK INT NOT NULL,
	CONSTRAINT PK_Endereco PRIMARY KEY (End_ID),
	CONSTRAINT FK_Endereco_Paciente FOREIGN KEY (End_PacienteID_FK)
	REFERENCES Paciente(Pac_ID),
	CONSTRAINT CK_Endereco_Estado CHECK (End_Estado IN ('AC', 'AL', 'AP', 'AM', 'BA', 'CE', 'DF', 'ES', 'GO', 'MA', 'MT', 'MS', 'MG', 'PA', 'PB', 'PR', 'PE', 'PI', 'RJ', 'RN', 'RS', 'RO', 'RR', 'SC', 'SP', 'SE', 'TO'))
);
GO

CREATE TABLE Pagamento(
    Pag_ID INT NOT NULL IDENTITY(1,1),
    Pag_DataPagamento DATE NOT NULL,
    Pag_ValorPago DECIMAL(10,2) NOT NULL,
    Pag_MetodoPagamento VARCHAR(50) NOT NULL,
    Pag_Status VARCHAR(20) NOT NULL DEFAULT 'Em Aberto',
    Pag_PacienteID_FK INT NOT NULL,
    CONSTRAINT PK_Pagamento PRIMARY KEY (Pag_ID),
    CONSTRAINT CK_Pagamento_Metodo CHECK(Pag_MetodoPagamento IN ('Cartão', 'Dinheiro', 'Pix')),
    CONSTRAINT CK_Pagamento_Status CHECK(Pag_Status IN ('Em Aberto', 'Pendente', 'Pago')),
    CONSTRAINT FK_Pagamento_Paciente FOREIGN KEY (Pag_PacienteID_FK) REFERENCES Paciente(Pac_ID)
);
GO