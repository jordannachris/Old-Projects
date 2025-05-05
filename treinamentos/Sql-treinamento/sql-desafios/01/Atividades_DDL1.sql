/*
1 - Crie um banco de dados CHAMADO DECOLA
2 - Crie duas tabelas com as seguintes colunas:
	2.1 Clientes: Id, Nome, Sobrenome, Idade, E-mail, Endereco, Numero e CEP
	2.2 Carros: Id, Modelo e Marca
3 - Altere a coluna Nome para nvarchar(2000)
4 - Destrua a tabela Carro (DROP)
5 - Recrie a tabela Carro, agora adicionando a coluna tamb�m Ano.
6 - Adicione a coluna versao na tabela carro (sem recriar a tabela).
	6.1 - Crie a coluna KM de rodagem como inteiro
7 - Altere a coluna KM de rodagem para Numeric (18,2)
*/

CREATE TABLE CLIENTES
    ( 
     id int identity(1,1) primary key,
	 nome varchar(255),
	 sobrenome varchar(255),
	 idade int,
	 email varchar(200),
	 endereco varchar(255),
	 numero int,
	 cep varchar(60)
    )  
;

CREATE TABLE CARROS
    ( 
     id int identity(1,1) primary key,
	 modelo varchar(255),
	 marca varchar(255)
    )  
;

alter table CLIENTES alter column nome nvarchar(2000);

drop table CARROS;

CREATE TABLE CARROS
    ( 
     id int identity(1,1) primary key,
	 modelo varchar(255),
	 marca varchar(255),
	 ano int
    )  
;

alter table CARROS add versao varchar(255);

alter table CARROS add KM_de_rodagem int;

alter table CARROS alter column KM_de_rodagem numeric (18,2);
