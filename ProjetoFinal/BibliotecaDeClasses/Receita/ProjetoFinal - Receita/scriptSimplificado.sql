CREATE TABLE administrador (
id int identity(1,1) constraint pk_admin primary key,
nome varchar(200) not null);

CREATE TABLE endereco (
	id int IDENTITY(1,1) constraint pk_endereco primary key,
	[LOGRADOURO] [varchar](100) NOT NULL,
	[NUMERO] [varchar](20) NOT NULL,
	[COMPLEMENTO] [varchar](50) NOT NULL,
	[BAIRRO] [varchar](60) NOT NULL,
	[CIDADE] [varchar](80) NOT NULL,
	[UF] [char](2) NOT NULL,
	[PAIS] [varchar](20) NOT NULL);

--create table analista_estoque
--create table atendente
--create table atendente_paciente

CREATE TABLE dados_vitais (
	[ID] [int] IDENTITY(1,1) constraint pk_dados_vitais primary key,
	[DATA_CONSULTA] [date] NOT NULL,
	[PRESSAO] [varchar](6) NOT NULL,
	[PULSO] [varchar](6) NOT NULL,
	[TEMPERATURA] [varchar](5) NOT NULL,
	[RESPIRACAO] [varchar](6) NOT NULL);

CREATE TABLE enfermeiro (
	[ID] [int] IDENTITY(1,1) constraint pk_enfermeiro primary key,
	[ENDERECO] int constraint fk_endereco_enfermeiro references endereco(id),
	[COREN] [int] NOT NULL,
	[DATA_NASCIMENTO] [date] NOT NULL,
	[Rg] [varchar](9) NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[USUARIO] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL);

CREATE TABLE farmaceutico (
	[ID] [int] IDENTITY(1,1) constraint pk_id_farmaceutico primary key,
	[ENDERECO] int constraint fk_endereco_farmaceutico references endereco(id),
	[CFF] [varchar](10) NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
	[Rg] [varchar](9) NOT NULL,
	[DATA_NASCIMENTO] [date] NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[USUARIO] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL);

CREATE TABLE medico (
	[ID] [int] IDENTITY(1,1) constraint pk_id_medico primary key,
	[ENDERECO] int constraint fk_endereco_medico references endereco(id),
	[Especializacao] [varchar](20) NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
	[DATA_NASCIMENTO] [date] NOT NULL,
	[Rg] [varchar](9) NOT NULL,
	[CRM] [varchar](10) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[USUARIO] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL);

CREATE TABLE paciente (
	[ID] [int] IDENTITY(1,1) constraint pk_id_paciente primary key,
	[ENDERECO] int constraint fk_endereco_paciente references endereco(id),
	[CPF] [varchar](14) NOT NULL,	
	[Nome] [varchar](200) NOT NULL,
	[Rg] [varchar](9) NOT NULL,
	[DATA_NASCIMENTO] [date] NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
	[NOME_MAE] [varchar](200) NOT NULL,
	[NOME_PAI] [varchar](200),
	[NOME_RESPONSAVEL] [varchar](200));

CREATE TABLE medicamento (
	[Codigo] [int] IDENTITY(1,1) constraint pk_codigo_medicamento primary key,
	[Nome_Generico] [varchar](50) NOT NULL,
	[Nome_Comercial] [varchar](50) NOT NULL,
	[Composicao] [varchar](200) NOT NULL,
	[Contra_Ind] [varchar](200) NOT NULL,
	[Dosagem] [varchar](100) NOT NULL,
	[Indicações] [varchar](100) NOT NULL,
	[Fabricante] [varchar](50) NOT NULL);

CREATE TABLE receita (
	[NUMERO] [int] IDENTITY(1,1) constraint pk_numero_receita primary key,
	[ID_PACIENTE] int constraint fk_id_paciente_receita references paciente(id),
	[ID_MEDICO] int constraint fk_id_medico_receita references medico(id));

CREATE TABLE receita_medicamento (
	[CODIGO_MEDICAMENTO] int constraint fk_codigo_medicamento references medicamento(codigo),
	[NUMERO_RECEITA] int constraint fk_numero_receita references receita(numero),
	[Instrucoes] [varchar](500) NOT NULL,
	[QUANTIDADE] [varchar](20) NOT NULL,
	[DOSAGEM] [varchar](20) NOT NULL,
	[TEMPO_TRATAMENTO] [varchar](20) NOT NULL);

CREATE TABLE consulta (
	[NUMERO_PRONTUARIO] [int] IDENTITY(1,1)  CONSTRAINT [PK_NUMERO_PRONTUARIO] primary key,
	[MEDICO] [int]  constraint fk_id_medico_consulta references medico(id),
	[ENFERMEIRO] [int] constraint fk_id_enfermeiro_consulta references enfermeiro(id),
	[PACIENTE] [int] constraint fk_id_paciente_consulta references paciente(id),
	[DADOS_VITAIS] [int] constraint fk_id_dados_vitais_consulta references dados_vitais(id),
	[DATA_CONSULTA] [date] NOT NULL,
	[OBSERVACOES] [varchar](500) NOT NULL,
	[Situacao] [varchar](50) NULL);


CREATE TABLE diagnostico (
	[ID] [int] IDENTITY(1,1) CONSTRAINT pk_id_diagnostico primary key,
	[MEDICO] int constraint fk_id_medico_diagnostico references Medico(id), --maybe nao precisa dessa fk
	[Informacoes] [varchar](500) NOT NULL,
	[Data] [date] NOT NULL,
	[Nome] [varchar](300) NULL);

--drop database easymed

--create database easymed

--drop table administrador;
--drop table dados_vitais;
--drop table endereco;
--drop table enfermeiro;