ALTER TABLE consulta
ADD CONSTRAINT fk_situacao
FOREIGN KEY (situacao)
REFERENCES situacao(id)


SELECT        consulta.DATA_CONSULTA AS dataconsulta, consulta.NUMERO_PRONTUARIO AS numeroprontuario, paciente.ID AS idpaciente, paciente.Nome AS nomepaciente, medico.ID AS idmedico, 
                         medico.Nome AS nomemedico, diagnostico.ID AS iddiagnostico, diagnostico.Informacoes AS diagnostico, situacao.situacao AS situacaoconsulta, receita.NUMERO AS numeroreceita
FROM            consulta INNER JOIN
                         situacao ON consulta.situacao = situacao.id INNER JOIN
                         paciente ON consulta.PACIENTE = paciente.ID INNER JOIN
                         medico ON consulta.MEDICO = medico.ID INNER JOIN
                         diagnostico ON consulta.diagnostico = diagnostico.ID INNER JOIN
                         receita ON consulta.numero_receita = receita.NUMERO AND paciente.ID = receita.ID_PACIENTE AND medico.ID = receita.ID_MEDICO

SELECT        consulta.NUMERO_PRONTUARIO, paciente.ID, paciente.Nome, medico.Nome AS Expr1, receita.NUMERO
FROM            consulta INNER JOIN
                         medico ON consulta.MEDICO = medico.ID INNER JOIN
                         paciente ON consulta.PACIENTE = paciente.ID INNER JOIN
                         receita ON consulta.numero_receita = receita.NUMERO AND medico.ID = receita.ID_MEDICO AND paciente.ID = receita.ID_PACIENTE
						 
SELECT        paciente.ID, paciente.Nome, consulta.NUMERO_PRONTUARIO, consulta.DATA_CONSULTA, medico.ID AS Expr1, medico.Nome AS Expr2, receita.NUMERO
FROM            paciente INNER JOIN
                         consulta ON paciente.ID = consulta.PACIENTE INNER JOIN
                         medico ON consulta.MEDICO = medico.ID INNER JOIN
                         receita ON paciente.ID = receita.ID_PACIENTE AND consulta.numero_receita = receita.NUMERO AND medico.ID = receita.ID_MEDICO


--select incluindo situacao
SELECT consulta.DATA_CONSULTA as dataconsulta, consulta.NUMERO_PRONTUARIO AS numeroprontuario, 
                                                        paciente.Nome AS nomepaciente, medico.Nome AS nomemedico, consulta.OBSERVACOES AS obstriagem, diagnostico.Informacoes AS diagnostico,
														situacao.situacao
                                                        FROM consulta 
                                                        INNER JOIN medico ON consulta.MEDICO = medico.ID 
                                                        INNER JOIN paciente ON consulta.PACIENTE = paciente.ID 
                                                        INNER JOIN diagnostico ON consulta.diagnostico = diagnostico.ID
														inner join situacao on consulta.situacao = situacao.id

--select incluindo receita?
SELECT consulta.DATA_CONSULTA as dataconsulta, consulta.NUMERO_PRONTUARIO AS numeroprontuario, 
                                                        paciente.Nome AS nomepaciente, medico.Nome AS nomemedico, consulta.OBSERVACOES AS obstriagem, diagnostico.Informacoes AS diagnostico,
														situacao.situacao as situacaoconsulta, receita.NUMERO as numeroreceita
                                                        FROM consulta 
                                                        INNER JOIN medico ON consulta.MEDICO = medico.ID 
                                                        INNER JOIN paciente ON consulta.PACIENTE = paciente.ID 
                                                        left JOIN diagnostico ON consulta.diagnostico = diagnostico.ID
														inner join situacao on consulta.situacao = situacao.id
														left join receita on consulta.numero_receita = receita.NUMERO


select * from consulta

--teste
SELECT consulta.DATA_CONSULTA as dataconsulta, consulta.NUMERO_PRONTUARIO AS numeroprontuario, 
                                                        paciente.ID as pacienteid, paciente.Nome AS nomepaciente, medico.Nome AS nomemedico, consulta.OBSERVACOES AS obstriagem, diagnostico.Informacoes AS diagnostico,
														situacao.situacao as situacaoconsulta, receita.NUMERO as numeroreceita
                                                        FROM consulta 
                                                        INNER JOIN medico ON consulta.MEDICO = medico.ID 
                                                        INNER JOIN paciente ON consulta.PACIENTE = paciente.ID 
                                                        left JOIN diagnostico ON consulta.diagnostico = diagnostico.ID
														inner join situacao on consulta.situacao = situacao.id
														left join receita on consulta.numero_receita = receita.NUMERO
						                                where consulta.paciente = 3


SELECT        receita_medicamento.NUMERO_RECEITA, receita.ID_PACIENTE, receita_medicamento.CODIGO_MEDICAMENTO, medicamento.Nome_Generico, 
			medicamento.Nome_Comercial, medicamento.Composicao, 
                         medicamento.Contra_Ind, medicamento.Dosagem, medicamento.Indicações, medicamento.Fabricante
FROM            receita_medicamento INNER JOIN
                         medicamento ON receita_medicamento.CODIGO_MEDICAMENTO = medicamento.Codigo INNER JOIN
                         receita ON receita_medicamento.NUMERO_RECEITA = receita.NUMERO
						 where receita.ID_PACIENTE = 3 --numero prontuario = 4


SELECT        receita_medicamento.NUMERO_RECEITA AS numeroreceita, receita.ID_PACIENTE AS idpaciente, receita_medicamento.CODIGO_MEDICAMENTO AS codmedicamento, 
                         medicamento.Nome_Generico AS nomegenerico, medicamento.Nome_Comercial AS nomecomercial, medicamento.Composicao AS composicao, medicamento.Contra_Ind AS contraindicacao, 
                         medicamento.Dosagem AS dosagem, medicamento.Indicações AS indicacoes, medicamento.Fabricante AS fabricante, consulta.NUMERO_PRONTUARIO AS numeroprontuario
FROM            receita_medicamento INNER JOIN
                         medicamento ON receita_medicamento.CODIGO_MEDICAMENTO = medicamento.Codigo INNER JOIN
                         receita ON receita_medicamento.NUMERO_RECEITA = receita.NUMERO INNER JOIN
                         consulta ON receita.NUMERO = consulta.numero_receita
						 where receita.ID_PACIENTE  = 3 and consulta.NUMERO_PRONTUARIO = 4
						 
SELECT        receita_medicamento.NUMERO_RECEITA AS numeroreceita, receita.ID_PACIENTE AS idpaciente, receita_medicamento.CODIGO_MEDICAMENTO AS codigomedicamento, 
                         medicamento.Nome_Comercial AS mednomecomercial, medicamento.Composicao AS medcomposicao, medicamento.Contra_Ind AS medcontraindicacao, medicamento.Dosagem AS meddosagem, 
                         medicamento.Indicações AS medindicacoes, medicamento.Fabricante AS medfabricante, receita_medicamento.Instrucoes AS recinstrucoes, receita_medicamento.QUANTIDADE AS recquantidade, 
                         receita_medicamento.DOSAGEM AS recdosagem, receita_medicamento.TEMPO_TRATAMENTO AS rectempotratamento, consulta.NUMERO_PRONTUARIO AS consulta_numeroprontuario
FROM            receita_medicamento INNER JOIN
                         receita ON receita_medicamento.NUMERO_RECEITA = receita.NUMERO INNER JOIN
                         medicamento ON receita_medicamento.CODIGO_MEDICAMENTO = medicamento.Codigo INNER JOIN
                         consulta ON receita.NUMERO = consulta.numero_receita