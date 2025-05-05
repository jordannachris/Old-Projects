CREATE DATABASE WebDespensa_BD;

CREATE TABLE CartaoDeCredito
    ( 
     numero varchar(150) primary key,
	 titular varchar(255),
	 validade date,
	 CVC varchar(150)
    )  
;

CREATE TABLE Usuario
    ( 
     id int identity(1,1) primary key,
	 nome varchar(255),
	 senha varchar(255),
	 email varchar(255),
	 numCartao varchar(150)
    )  
;

CREATE TABLE Produto
    ( 
     id int identity(1,1) primary key,
	 idUsuario int,
	 nome varchar(255)
    )  
;

CREATE TABLE InstanciaDeProduto
    ( 
     id int identity(1,1) primary key,
	 idProduto int,
	 quantidade float,
	 unidade varchar(255),
	 validade date
    )  
;

CREATE TABLE ListaDeCompras
    ( 
     id int identity(1,1) primary key,
	 idUsuario int,
	 nome varchar(255)
    )  
;

CREATE TABLE ItemListaDeCompras
    ( 
	 idListaDeCompras int,
	 idInstanciaDeProduto int
    )  
;

CREATE TABLE Receita
    ( 
     id int identity(1,1) primary key,
	 idUsuario int,
	 nome varchar(255)
    )  
;

CREATE TABLE ItemReceita
    ( 
	 idReceita int,
	 idInstanciaDeProduto int
    )  
;

CREATE TABLE ListaUsuario
    ( 
	 idUsuario int,
	 idInstanciaDeProduto int
    )  
;