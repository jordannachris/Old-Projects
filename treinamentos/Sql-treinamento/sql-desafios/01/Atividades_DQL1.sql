/*
1 - Selecione todos os registros das duas tabelas
2 - Selecione apenas os clientes com menos de 30 anos
3 - Selecione os clientes que não moram na Rua A
4 - Selecione todos os carros com Ano entre 2000 e 2010
5 - Selecione os carros da Ferrari, Chevrolet, Ford e Fiat
6 - Selecione todos os modelos de Palio
*/

SELECT * FROM CLIENTES;
SELECT * FROM CARROS;

SELECT *
FROM CLIENTES
WHERE idade < 30;

SELECT *
FROM CLIENTES
WHERE endereco <> 'Rua A';


SELECT *
FROM CARROS
WHERE ano BETWEEN 2000 AND 2010;


SELECT *
FROM CARROS
WHERE marca IN ('Ferrari', 'Chevrolet', 'Ford', 'Fiat');


SELECT *
FROM CARROS
WHERE modelo LIKE '%Palio%';
