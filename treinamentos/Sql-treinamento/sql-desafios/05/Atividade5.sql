/*
1 - Gere as datas de nascimento dos clientes, adicionando uma coluna para na tabela clientes e assumindo que:
	- o Dia de nascimento é o módulo do ID dele menos o dia atual
	- o Mês de nascimento é o ID
2 - Gere um select com o primeiro dia do mês seguinte ao nascimento de cada cliente
3 - Gere 3 selects com a diferença entre a data de nascimento e a data atual para os clientes 1 e 2 em:
	- dias, 
	- meses 
	- e anos (TEM função pra isso =) )
4 - Gere uma query que altera o tipo de veiculo para:
	1 - Carro
	2 - Moto
	3 - Caminhão
5 - Retorne os clientes com anuncio de ford com preço maior de que 250.000 e gere um result set com:
	1 - Nome do cliente
	2 - Modelo do carro
	3 - Preço
	4 - Nome + Descricao + Preço - concatenado e "bunitinhuu***"
6 - Crie uma coluna na tabela veículos com as descrições acima com o nome "Descricao Tipo Veiculo"
*/

--------------------------
SELECT * FROM ANUNCIOS;
SELECT * FROM CLIENTES;
SELECT * FROM VEICULOS;
--------------------------

/*1 - Gere as datas de nascimento dos clientes, adicionando uma coluna para na tabela clientes e assumindo que:
	- o Dia de nascimento é o módulo do ID dele menos o dia atual
	- o Mês de nascimento é o ID
*/

-- Dia de Nascimento
SELECT ABS(ID - DATEPART(DAY, GETDATE())) FROM CLIENTES;

-- Mes de Nascimento 
SELECT ID FROM CLIENTES;

-- Ano de nascimento
SELECT (DATEPART(YEAR, GETDATE()) - IDADE) FROM CLIENTES;


-- Adicionando as colunas de DIA, MES e ANO de nascimento
ALTER TABLE CLIENTES 
ADD dia varchar(5);

ALTER TABLE CLIENTES 
ADD mes varchar(5);

ALTER TABLE CLIENTES 
ADD ano varchar(5);

---------------------------------------------
alter table CLIENTES drop column dia;
alter table CLIENTES drop column mes;
alter table CLIENTES drop column ano;
---------------------------------------------

-- Preenchendo as colunas do DIA de nascimento
UPDATE CLIENTES
SET dia = ABS(ID - DATEPART(DAY, GETDATE()))
WHERE ID IS NOT NULL;

-- Preenchendo as colunas do MES de nascimento
UPDATE CLIENTES
SET mes = Id
WHERE ID IS NOT NULL;

-- Preenchendo as colunas do ANO de nascimento para pessoas que já fizeram aniversário este ano
UPDATE CLIENTES
SET ano = DATEPART(YEAR, GETDATE()) - IDADE
WHERE 
	ID IS NOT NULL
	AND 
	DATEPART(MONTH, GETDATE()) >= mes;

-- Preenchendo as colunas do ANO de nascimento para pessoas que ainda NÃO fizeram aniversário este ano
UPDATE CLIENTES
SET ano = DATEPART(YEAR, GETDATE()) - IDADE - 1
WHERE 
	ID IS NOT NULL
	AND 
	DATEPART(MONTH, GETDATE()) < mes;

-- Mostrando a tabela CLIENTES com uma coluna para as DATAS DE NASCIMENTO
SELECT id, nome, sobrenome, idade, email, endereco, numero, cep, ano + '-' + mes + '-' + dia AS "Data de Nascimento"
FROM CLIENTES;


/*================= DESCOBRI UMA MANEIRA MAIS FÁCIL DE FAZER O EXERCÍCIO 1 =================*/

/*1 - Gere as datas de nascimento dos clientes, adicionando uma coluna para na tabela clientes e assumindo que:
	- o Dia de nascimento é o módulo do ID dele menos o dia atual
	- o Mês de nascimento é o ID
*/

-- Adicionando a coluna DATA_DE_NASCIMENTO
ALTER TABLE CLIENTES 
ADD data_de_nascimento DATE;


-- Preenchendo a coluna DATA_DE_NASCIMENTO para pessoas que já fizeram aniversário este ano
UPDATE CLIENTES
SET data_de_nascimento = DATEFROMPARTS(DATEPART(YEAR, GETDATE()) - IDADE,ID,ABS(ID - DATEPART(DAY, GETDATE())))
WHERE 
	DATEPART(MONTH, GETDATE()) >= ID;



-- Preenchendo a coluna DATA_DE_NASCIMENTO para pessoas que ainda NÃO fizeram aniversário este ano
UPDATE CLIENTES
SET data_de_nascimento = DATEFROMPARTS(DATEPART(YEAR, GETDATE()) - IDADE,ID,ABS(ID - DATEPART(DAY, GETDATE())))
WHERE 
	DATEPART(MONTH, GETDATE()) < ID;

SELECT * FROM CLIENTES;

/* ================================ FIM DO EXERCÍCIO 1 ================================*/

-- 2 - Gere um select com o primeiro dia do mês seguinte ao nascimento de cada cliente
SELECT 
	nome, data_de_nascimento, 
	DATEFROMPARTS(DATEPART(YEAR, GETDATE()) - IDADE,ID+1,01) AS "Primeiro Dia do Mês Seguinte ao Nascimento"
FROM CLIENTES;

OU

SELECT 
	nome, data_de_nascimento, 
	DATEFROMPARTS(DATEPART(YEAR,data_de_nascimento),ID+1,01) AS "Primeiro Dia do Mês Seguinte ao Nascimento"
FROM CLIENTES;


/* 3 - Gere 3 selects com a diferença entre a data de nascimento e a data atual para os clientes 1 e 2 em:
	- dias, 
	- meses 
	- e anos (TEM função pra isso =) ) 
*/

SELECT id, nome, idade, data_de_nascimento,
DATEDIFF (DAY, data_de_nascimento, GETDATE()) AS "Diferença em Dias"
FROM 
	CLIENTES
WHERE ID IN(1,2);


SELECT id, nome, idade, data_de_nascimento,
DATEDIFF (MONTH, data_de_nascimento, GETDATE()) AS "Diferença em Meses"
FROM 
	CLIENTES
WHERE ID IN(1,2);


SELECT id, nome, idade, data_de_nascimento,
DATEDIFF (YEAR, data_de_nascimento, GETDATE()) AS "Diferença em Anos"
FROM 
	CLIENTES
WHERE ID IN(1,2);

/*4 - Gere uma query que altera o tipo de veiculo para:
	1 - Carro
	2 - Moto
	3 - Caminhão
*/
-----------------------------------------------------------------------------------------
--------- A resposta do exercício 4 está no arquivo "Atividade5_Exercicio4.sql" ---------
-----------------------------------------------------------------------------------------


/*5 - Retorne os clientes com anuncio de ford com preço maior de que 250.000 e gere um result set com:
	1 - Nome do cliente
	2 - Modelo do carro
	3 - Preço
	4 - Nome + Descricao + Preço - concatenado e "bunitinhuu***"
*/
SELECT C.nome + ' ' + C.sobrenome AS "Nome do cliente", V.des_modelo AS "Modelo do carro", A.preco AS "Preço",
	   'Nome da Marca: ' + V.des_marca + ', Descrição do Modelo: ' + V.des_modelo + ', Preço do Anúncio: R$ ' + CAST(A.preco as varchar(20)) + ', é bunitinhuu***' AS "Anúncio"
FROM 
	CLIENTES C
	LEFT JOIN
	ANUNCIOS A
	ON C.Id = A.cliente_id
	LEFT JOIN
	VEICULOS V
	ON A.carro_id = V.cod
WHERE 
	V.des_marca = 'Ford'
	AND
	A.preco > 250.000;


-- 6 - Crie uma coluna na tabela veículos com as descrições acima com o nome "Descricao Tipo Veiculo"

ALTER TABLE VEICULOS
ADD descricao_tipo_veiculo varchar(255);

alter table veiculos drop column descricao_tipo_veiculo;


UPDATE VEICULOS
SET descricao_tipo_veiculo =  CONCAT('Nome da marca: ', des_marca,', Descrição do Modelo: ',des_modelo,', Preço médio: R$ ', preco_medio)
FROM 
	VEICULOS;

------------------------------
SELECT descricao_tipo_veiculo 
FROM veiculos;
------------------------------