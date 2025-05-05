/*
1 - Qual a quantidade de carros da Ferrari?
2 - Liste a quantidade de carros da Ford e da Toyota ao mesmo tempo
3 - Mostre o valor total (soma) dos preços do Fiesta
4 - Mostre a media dos preços do Gol apenas quando o preço for superior a 50.000
5 - Mostre os 10 modelos mais caros (des_modelo1 - somando se tiver mais de um *modelo*) entre os carros da Volks e da Toyota
6 - Mostre a soma dos precos veiculos agrupados pelo modelo (des_modelo1) com apenas os com soma superior a 500.000 ordenados do maior ao menor
*/

SELECT * FROM [dbo].[Fipe2];

-- 1 - Qual a quantidade de carros da Ferrari?
SELECT COUNT(des_marca) 
FROM [dbo].[Fipe2]
WHERE des_marca = 'Ferrari';

OU

SELECT COUNT(*)
FROM [dbo].[Fipe2]
WHERE des_marca = 'Ferrari';


-- 2 - Liste a quantidade de carros da Ford e da Toyota ao mesmo tempo
SELECT COUNT(des_marca) 
FROM [dbo].[Fipe2]
WHERE des_marca in ('Ford','Toyota');


-- 3 - Mostre o valor total (soma) dos preços do Fiesta
SELECT SUM(preco_medio) 
FROM [dbo].[Fipe2]
WHERE des_modelo1 = 'Fiesta';


-- 4 - Mostre a media dos preços do Gol apenas quando o preço for superior a 50.000
SELECT AVG(preco_medio)
FROM [dbo].[Fipe2]
WHERE
	des_modelo1 = ' l'
	AND
	preco_medio > 50000;


-- 5 - Mostre os 10 modelos mais caros (des_modelo1 - somando se tiver mais de um *modelo*) entre os carros da Volks e da Toyota
SELECT top 10 (des_modelo1), SUM(preco_medio) as preco
FROM [dbo].[Fipe2]
WHERE 
	des_marca in ('VolksWagen', 'Toyota')
GROUP BY des_modelo1
order by sum(preco_medio) desc;


-- 6 - Mostre a soma dos precos veiculos agrupados pelo modelo (des_modelo1) com apenas os com soma superior a 500.000 ordenados do maior ao menor
SELECT SUM(preco_medio) as soma_dos_precos
FROM [dbo].[Fipe2]
GROUP BY des_modelo1
HAVING
	SUM(preco_medio) > 500000
order by sum(preco_medio) desc;


SELECT * FROM [dbo].[Fipe2];