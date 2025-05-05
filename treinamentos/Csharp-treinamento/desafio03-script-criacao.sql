CREATE TABLE [Responsavel]
    ( 
     id int identity(1,1) primary key,
	 nome varchar(255) NOT NULL
    )
;

CREATE TABLE [Categoria]
    ( 
     id int identity(1,1) primary key,
	 nome varchar(255) NOT NULL
    )
;

CREATE TABLE [Video]
    ( 
     id int identity(1,1) primary key,
	 nome varchar(255) NOT NULL
    )
;