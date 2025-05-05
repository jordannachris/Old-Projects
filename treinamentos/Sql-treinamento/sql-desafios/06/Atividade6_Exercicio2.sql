/* 2 - Popule essas tabelas com entre 10 a 50 registros (fake, mas com carinho :) 
	- nada de "asuidhiauiowqjemo" ou "teste123")
*/


SELECT * FROM [Veiculo];
-- SELECT * FROM [Tipo_Veiculo];
-- SELECT * FROM [Categoria];
-- SELECT * FROM [Condicoes];
		SELECT * FROM [Condicoes_Veiculo];
SELECT * FROM [Opcionais];	
		SELECT * FROM [Opcionais_Veiculo];
SELECT * FROM [Anunciante];
SELECT * FROM [Tipo_Anunciante];
SELECT * FROM [Anuncio];


------------------------------------------------------------------------------------------

INSERT INTO [Tipo_Veiculo] ([descricao]) 
VALUES ('Carro');

INSERT INTO [Tipo_Veiculo] ([descricao]) 
VALUES ('Moto');

------------------------------------------------------------------------------------------

INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Hatch');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Sedan');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'SUV');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Picape');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Van/Utilitário');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Perua/SW');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Minivan');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Coupê');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Conversível');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (1,'Esportivo');

INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Street');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Scooter');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Esportiva');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Trail');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Naked');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Custom');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Off-Road');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'SuperMotard');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Quadriciclo');
INSERT INTO [Categoria] ([id_tipo_veiculo],[descricao]) VALUES (2,'Triciclo');

------------------------------------------------------------------------------------------

INSERT INTO [Condicoes] ([descricao]) VALUES ('Aceita troca');
INSERT INTO [Condicoes] ([descricao]) VALUES ('Adaptado para PCD');
INSERT INTO [Condicoes] ([descricao]) VALUES ('Blindados');
INSERT INTO [Condicoes] ([descricao]) VALUES ('De colecionador');
INSERT INTO [Condicoes] ([descricao]) VALUES ('Financiados');
INSERT INTO [Condicoes] ([descricao]) VALUES ('Garantia de Fábrica');
INSERT INTO [Condicoes] ([descricao]) VALUES ('IPVA Pago');
INSERT INTO [Condicoes] ([descricao]) VALUES ('Licenciados');
INSERT INTO [Condicoes] ([descricao]) VALUES ('Único dono');
INSERT INTO [Condicoes] ([descricao]) VALUES ('Revisões feitas em concessionárias');

------------------------------------------------------------------------------------------

INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Air Bag');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Alarme');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Ar Condicionado');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Ar Quente');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Bancos com Ajuste de Altura');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Bancos com Aquecimento');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Bancos em Couro');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Câmera de Ré');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Capota Marítima');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'CD e MP3 Player');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Controle de Tração');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Direção Elétrica');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Direção Hidráulica');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Piloto Automático');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Rádio AM/FM');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Retrovisores Elétricos');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Rodas de Liga Leve');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Teto Solar');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Tração 4x4');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Travas Elétricas');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (1,'Vidros Elétricos');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'ABS');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'Amortecedor de Direção');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'Bolsa/Baú/Bauleto');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'Computador de Bordo');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'Contra Peso no Guidon');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'Escapamento Esportivo');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'Faróis de Neblina');
INSERT INTO [Opcionais] ([id_tipo_veiculo],[descricao]) VALUES (2,'GPS');

------------------------------------------------------------------------------------------

