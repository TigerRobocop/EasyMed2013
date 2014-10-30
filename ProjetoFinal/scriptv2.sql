drop table consulta
drop table diagnostico


CREATE TABLE consulta (
	[NUMERO_PRONTUARIO] [int] IDENTITY(1,1)  CONSTRAINT [PK_NUMERO_PRONTUARIO] primary key,
	[MEDICO] [int]  constraint fk_id_medico_consulta references medico(id),
	[ENFERMEIRO] [int] constraint fk_id_enfermeiro_consulta references enfermeiro(id),
	[PACIENTE] [int] constraint fk_id_paciente_consulta references paciente(id),
	[DADOS_VITAIS] [int] constraint fk_id_dados_vitais_consulta references dados_vitais(id),
	diagnostico int constraint fk_id_diagnostico_consulta references diagnostico(id),
	[DATA_CONSULTA] [date] NOT NULL,
	[OBSERVACOES] [varchar](500) NOT NULL,
	[Situacao] [varchar](50) NULL);


CREATE TABLE diagnostico (
	[ID] [int] IDENTITY(1,1) CONSTRAINT pk_id_diagnostico primary key,
	[Informacoes] [varchar](500) NOT NULL,
	[Data] [date] NOT NULL,
	[Nome] [varchar](300) NULL);