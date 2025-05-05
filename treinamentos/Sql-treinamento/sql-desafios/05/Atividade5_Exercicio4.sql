/*4 - Gere uma query que altera o tipo de veiculo para:
	1 - Carro
	2 - Moto
	3 - Caminhão
*/
EXEC SP_HELP VEICULOS;

ALTER TABLE VEICULOS 
ALTER COLUMN tipo_veiculo VARCHAR(255);

UPDATE VEICULOS
SET tipo_veiculo = '1 - Carro'
WHERE tipo_veiculo = '1';

UPDATE VEICULOS
SET tipo_veiculo = '2 - Moto'
WHERE tipo_veiculo = '2';

UPDATE VEICULOS
SET tipo_veiculo = '3 - Caminhão'
WHERE tipo_veiculo = '3';

--------------------------------
SELECT * FROM VEICULOS;
--------------------------------