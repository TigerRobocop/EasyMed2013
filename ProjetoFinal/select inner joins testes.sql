
--select da relacao receita paciente
SELECT        receita.NUMERO AS numeroreceita, receita.ID_PACIENTE AS id_paciente, paciente.Nome AS nome_paciente, receita.ID_MEDICO AS id_medico, medico.Nome AS nome_medico
FROM            paciente INNER JOIN
                         receita ON paciente.ID = receita.ID_PACIENTE INNER JOIN
                         medico ON receita.ID_MEDICO = medico.ID INNER JOIN
                         receita_medicamento ON receita.NUMERO = receita_medicamento.NUMERO_RECEITA INNER JOIN
                         medicamento ON receita_medicamento.CODIGO_MEDICAMENTO = medicamento.Codigo

						-- where NUMERO_RECEITA = 3
						 
						 
						 
--select dos medicamentos na receita						 
SELECT        receita.NUMERO AS numero_receita, medicamento.Codigo AS codigo_medicamento, medicamento.Nome_Generico AS med_nome_generico, medicamento.Nome_Comercial AS med_nome_comercial, 
                         receita_medicamento.Instrucoes AS rec_instrucoes, receita_medicamento.QUANTIDADE AS rec_quantidade, receita_medicamento.DOSAGEM AS rec_dosagem, 
                         receita_medicamento.TEMPO_TRATAMENTO AS rec_tempotratamento
FROM            medicamento INNER JOIN
                         receita_medicamento ON medicamento.Codigo = receita_medicamento.CODIGO_MEDICAMENTO INNER JOIN
                         receita ON receita_medicamento.NUMERO_RECEITA = receita.NUMERO
						-- where NUMERO_RECEITA = 3
						 
--select receita completa?						 
SELECT        receita_medicamento.NUMERO_RECEITA, receita_medicamento.CODIGO_MEDICAMENTO, medicamento.Nome_Generico, paciente.ID, medico.ID AS Expr1
FROM            receita INNER JOIN
                         receita_medicamento ON receita.NUMERO = receita_medicamento.NUMERO_RECEITA INNER JOIN
                         medicamento ON receita_medicamento.CODIGO_MEDICAMENTO = medicamento.Codigo INNER JOIN
                         medico ON receita.ID_MEDICO = medico.ID INNER JOIN
                         paciente ON receita.ID_PACIENTE = paciente.ID

SELECT        receita_medicamento.NUMERO_RECEITA, receita_medicamento.CODIGO_MEDICAMENTO, medicamento.Nome_Comercial, medico.ID, medico.Nome, paciente.ID AS Expr1, paciente.Nome AS Expr2
FROM            receita INNER JOIN
                         receita_medicamento ON receita.NUMERO = receita_medicamento.NUMERO_RECEITA INNER JOIN
                         medicamento ON receita_medicamento.CODIGO_MEDICAMENTO = medicamento.Codigo INNER JOIN
                         medico ON receita.ID_MEDICO = medico.ID INNER JOIN
                         paciente ON receita.ID_PACIENTE = paciente.ID


--select consultas anteriores



						 SELECT        consulta.DATA_CONSULTA as dataconsulta, consulta.NUMERO_PRONTUARIO AS numeroprontuario, paciente.Nome AS nomepaciente, medico.Nome AS nomemedico, consulta.OBSERVACOES AS obstriagem, diagnostico.Informacoes AS diagnostico
FROM            consulta INNER JOIN
                         medico ON consulta.MEDICO = medico.ID INNER JOIN
                         paciente ON consulta.PACIENTE = paciente.ID INNER JOIN
                         diagnostico ON consulta.diagnostico = diagnostico.ID
						 where consulta.Situacao = 4


						 SELECT consulta.DATA_CONSULTA as dataconsulta, consulta.NUMERO_PRONTUARIO AS numeroprontuario, 
                                                        paciente.Nome AS nomepaciente, medico.Nome AS nomemedico, consulta.OBSERVACOES AS obstriagem, diagnostico.Informacoes AS diagnostico
                                                        FROM consulta 
                                                        INNER JOIN medico ON consulta.MEDICO = medico.ID 
                                                        INNER JOIN paciente ON consulta.PACIENTE = paciente.ID 
                                                        INNER JOIN diagnostico ON consulta.diagnostico = diagnostico.ID
						                                where paciente.id = 2 and consulta.Situacao = 4