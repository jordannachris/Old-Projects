/* 
	**LEMBRE-SE DE RENOMEAR AS COLUNAS!!

	1 - Quais são os carros anunciados pelo cliente 1?
	2 - Qual a quantidade de anuncios por cliente?
	3 - Qual o valor dos carros anunciados pelo cliente 3? 
	4 - Existe algum cliente sem anuncios? Liste os clientes pela quantidade de valor em ordem, inclusive se não tiver
	5 - Quantos carros estão anunciados por montadora?
	6 - Existem anuncios sem descrição? Liste os clientes e carros envolvidos
	7 - Existem anuncios sem preço? Se sim, preencha com o valor medio da tabela de Carros

*/

-- RENOMEANDO AS COLUNAS
EXEC sp_rename 'Anuncios.Id Cliente', 'cliente_id', 'COLUMN';

EXEC sp_rename 'Anuncios.Id Carro', 'carro_id', 'COLUMN';

EXEC sp_rename 'Clientes.CEP da residencia', 'cep', 'COLUMN';

EXEC sp_rename 'Clientes.Endereço', 'endereco', 'COLUMN';


-- 1 - Quais são os carros anunciados pelo cliente 1?
SELECT V.DES_MODELO AS "CARRO ANUNCIADO"
FROM 
	CLIENTES C 
	INNER JOIN ANUNCIOS A
	ON C.ID = A.CLIENTE_ID
	INNER JOIN VEICULOS V
	ON A.CARRO_ID = V.COD
WHERE C.ID = 1;


-- 2 - Qual a quantidade de anuncios por cliente?
SELECT C.ID AS "COD DO CLIENTE", COUNT(A.CLIENTE_ID) AS "QTD DE ANUNCIOS"
FROM 
	ANUNCIOS A
	RIGHT JOIN 
	CLIENTES C
	ON A.CLIENTE_ID = C.ID
GROUP BY C.ID;

OU

SELECT C.ID AS "COD DO CLIENTE", COUNT(A.CLIENTE_ID) AS "QTD DE ANUNCIOS"
FROM 
	CLIENTES C
	LEFT JOIN 
	ANUNCIOS A
	ON A.CLIENTE_ID = C.ID
GROUP BY C.ID;


-- 3 - Qual o valor dos carros anunciados pelo cliente 3? 
SELECT C.ID AS "COD CLIENTE", SUM(A.PRECO) AS "SOMA DOS PRECOS"
FROM
	CLIENTES C
	LEFT JOIN
	ANUNCIOS A
	ON C.ID = A.CLIENTE_ID
WHERE C.ID = 3
GROUP BY C.ID;


-- 4 - Existe algum cliente sem anuncios? Liste os clientes pela quantidade de valor em ordem, inclusive se não tiver
SELECT C.NOME AS "NOME DO CLIENTE", SUM(A.PRECO) AS "PRECO TOTAL GASTO EM ANUNCIOS"
FROM
	CLIENTES C
	LEFT JOIN
	ANUNCIOS A
	ON C.ID = A.CLIENTE_ID
GROUP BY C.NOME
ORDER BY SUM(A.PRECO);

-- 5 - Quantos carros estão anunciados por montadora?
SELECT V.DES_MARCA AS "MONTADORA", COUNT(A.CARRO_ID) AS "QUANTIDADE DE CARROS ANUNCIADOS"
FROM
	ANUNCIOS A
	RIGHT JOIN
	VEICULOS V
	ON A.CARRO_ID = V.COD
GROUP BY V.DES_MARCA;

-- 6 - Existem anuncios sem descrição? Liste os clientes e carros envolvidos
SELECT C.NOME AS "NOME DO CLIENTE", V.COD AS "COD DO VEICULO", A.DESCRICAO AS "DESCRICAO DO ANUNCIO"
FROM 
	ANUNCIOS A
	LEFT JOIN
	CLIENTES C
	ON A.CLIENTE_ID = C.ID
	LEFT JOIN 
	VEICULOS V
	ON A.CARRO_ID = V.COD
WHERE A.DESCRICAO IS NULL;

-- 7 - Existem anuncios sem preço? Se sim, preencha com o valor medio da tabela de Carros
SELECT A.ID, A.CLIENTE_ID, A.CARRO_ID, A.DESCRICAO, V.PRECO_MEDIO
FROM 
	ANUNCIOS A
	LEFT JOIN
	VEICULOS V
	ON A.CARRO_ID = V.COD
WHERE A.PRECO IS NULL;

--------------------------
SELECT * FROM ANUNCIOS;
SELECT * FROM CLIENTES;
SELECT * FROM VEICULOS;

EXEC SP_HELP ANUNCIOS;
EXEC SP_HELP CLIENTES;
EXEC SP_HELP VEICULOS;
--------------------------


/*
	EXERCÍCIO EXTRA DE AGRUPAMENTOS
	1- Liste APENAS os registros duplicados e a quantidade de linhas duplicadas SEM USAR DISTINCT
*/

USE [DECOLA_DESAFIOS]
GO

CREATE TABLE Duplicados (
	[Nome] varchar(50)
	, [Idade] int
)

INSERT INTO Duplicados VALUES('Rafael',28)
INSERT INTO Duplicados VALUES('Rafael',28)
INSERT INTO Duplicados VALUES('Douglas',29)
INSERT INTO Duplicados VALUES('Douglas',29)
INSERT INTO Duplicados VALUES('Douglas',29)
INSERT INTO Duplicados VALUES('Douglas',29)
INSERT INTO Duplicados VALUES('Douglas',29)
INSERT INTO Duplicados VALUES('Rocha',30)
INSERT INTO Duplicados VALUES('Ivan',35)
INSERT INTO Duplicados VALUES('Ivan',35)
INSERT INTO Duplicados VALUES('Ivan',35)
INSERT INTO Duplicados VALUES('Marlon',31)

SELECT * FROM DUPLICADOS;

-- 1- Liste APENAS os registros duplicados e a quantidade de linhas duplicadas SEM USAR DISTINCT
SELECT NOME, COUNT(*) AS "QUANTIDADE DE VEZES QUE O NOME REPETE"
FROM 
	DUPLICADOS 
GROUP BY NOME 
HAVING COUNT(*) > 1;
