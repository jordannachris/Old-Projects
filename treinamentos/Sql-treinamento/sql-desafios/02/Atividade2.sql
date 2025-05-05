/*
0 - RODEM O SETUP Atividades 2.sql
1 - Selecione todos os veiculos da Audi do tipo 1
2 - Selecione os veiculos com cod_fipe final "-3"
3 - Selecione os veiculos com cod_fipe final "-2" que sejam Honda ou Toyota e tipo_veiculo 1 por ordem de marca crescente
4 - Selecione veiculos tipo 3 de marcas que começam com "A" ou veiculos tipo 1 da volkswagen por ordem de cod_fipe crescente
5 - Descubra quais codigos possuem alguma coluna nulo
6 - Selecione os 5 primeiros veiculos em ordem descrecente de modelo da volkswagem dos tipos 2 e 3
7 - Selecione todas as marcas distintas que não tenham cod_fipe nulo
*/

SELECT * FROM [dbo].[Fipe2];

-- 1 - Selecione todos os veiculos da Audi do tipo 1
SELECT *
FROM [dbo].[Fipe2]
WHERE des_marca = 'Audi' AND tipo_veiculo = 1;


-- 2 - Selecione os veiculos com cod_fipe final "-3"
SELECT *
FROM [dbo].[Fipe2]
WHERE cod_fipe LIKE '%-3';

-- 3 - Selecione os veiculos com cod_fipe final "-2" que sejam Honda ou Toyota e tipo_veiculo 1 por ordem de marca crescente
SELECT *
FROM [dbo].[Fipe2]
WHERE cod_fipe LIKE '%-2'
AND (des_marca ='Honda' OR des_marca = 'Toyota')
AND tipo_veiculo = 1
ORDER BY des_marca;

-- 4 - Selecione veiculos tipo 3 de marcas que começam com "A" ou veiculos tipo 1 da volkswagen por ordem de cod_fipe crescente
SELECT *
FROM [dbo].[Fipe2]
WHERE (tipo_veiculo = 3
AND des_marca LIKE 'A%')
OR 
(tipo_veiculo = 1
AND des_marca = 'VolksWagen')
ORDER BY cod_fipe;

-- 5 - Descubra quais codigos possuem alguma coluna nulo
SELECT *
FROM [dbo].[Fipe2]
WHERE cod_fipe IS NULL;


-- 6 - Selecione os 5 primeiros veiculos em ordem descrecente de modelo da volkswagem dos tipos 2 e 3
SELECT top 5 *
FROM [dbo].[Fipe2]
WHERE 
	tipo_veiculo in (1,2)
	AND
	des_marca = 'VolksWagen'
ORDER BY des_modelo DESC;


-- 7 - Selecione todas as marcas distintas que não tenham cod_fipe nulo
SELECT DISTINCT des_marca
FROM [dbo].[Fipe2]
WHERE cod_fipe IS NOT NULL;


