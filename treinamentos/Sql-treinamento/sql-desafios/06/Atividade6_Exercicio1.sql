/*	1 - Gere o script de criação com todas as tabelas e colunas, com tipos de dados corretos, 
	o que pode e o que não pode ser nulo, chaves primaria e secundaria e indices. 
*/

USE [DECOLA_DESAFIOS]
-----------------------------------------------------------------
-----------------------------------------------------------------
CREATE TABLE [Veiculo](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_tipo_veiculo] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[id_condicoes_veiculo] [int] NOT NULL,
	[id_opcionais_veiculo] [int] NOT NULL,
	[placa][varchar](8) NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](150) NULL,
	[versao] [varchar](255) NULL,
	[ano_fabricacao] [int] NULL,
	[ano_modelo] [int] NULL,
	[combustivel] [varchar](255) NULL,
	[cambio] [varchar](255) NULL,
	[quilometragem] [int] NULL,
	[qtde_portas] [tinyint] NULL,
	[cor] [varchar] (100) NULL,
	[cilindradas] [int] NULL,
	[refrigeração] [varchar] (100) NULL,
	[motor] [varchar] (255) NULL,
	[sistema_freios] [varchar] (255) NULL,
	[numero_marchas][tinyint] NULL,
	[alimentacao] [varchar] (100) NULL,
	[partida] [varchar] (100) NULL
);
-----------------------------------------------------------------
-----------------------------------------------------------------
CREATE TABLE [Tipo_Veiculo](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[descricao][varchar](255) NOT NULL
);
-----------------------------------------------------------------
-----------------------------------------------------------------
CREATE TABLE [Categoria](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_tipo_veiculo] [int] NOT NULL,
	[descricao][varchar](255) NOT NULL
);
-----------------------------------------------------------------
-----------------------------------------------------------------
CREATE TABLE [Condicoes](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[descricao][varchar](500) NULL
);
-----------------------------------------------------------------
CREATE TABLE [Condicoes_Veiculo](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_veiculo] [int] NOT NULL,
	[id_condicoes] [int] NOT NULL
);
-----------------------------------------------------------------
-----------------------------------------------------------------
CREATE TABLE [Opcionais](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_tipo_veiculo] [int] NOT NULL,
	[descricao][varchar](500) NULL
);
-----------------------------------------------------------------
CREATE TABLE [Opcionais_Veiculo](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_veiculo] [int] NOT NULL,
	[id_opcionais] [int] NOT NULL
);
-----------------------------------------------------------------
-----------------------------------------------------------------
CREATE TABLE [Anunciante](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_tipo_anunciante] [int] NOT NULL,
	[nome_completo] [nvarchar](2000) NULL,
	[cep] [varchar](10) NULL,
	[telefone] [varchar](15) NULL,
	[email] [nvarchar](100) NULL,
	[endereço] [varchar](151) NULL,
	[numero_complemento] [varchar](151) NULL,
	[bairro] [varchar](151) NULL,
	[cidade] [varchar](100) NULL,
	[estado] [char](2) NULL,
	[nascimento] [date] NULL,
	[cpf] [varchar](12) NULL
);
-----------------------------------------------------------------
-----------------------------------------------------------------loja, concessionária ou particular
CREATE TABLE [Tipo_Anunciante](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[descricao][varchar](255) NOT NULL
);
-----------------------------------------------------------------
-----------------------------------------------------------------
CREATE TABLE [Anuncio](
	[id] [int] IDENTITY(1,1) PRIMARY KEY,
	[id_veiculo] [int] NOT NULL,
	[id_tipo_veiculo] [int] NOT NULL,
	[id_anunciante] [int] NOT NULL,
	[id_tipo_anunciante] [int] NOT NULL,
	[preco_veiculo] [numeric](20, 2) NOT NULL,
	[mensagem_anuncio] [nvarchar](500) NULL,
	[observacoes] [nvarchar](2000) NULL,
);
-----------------------------------------------------------------
-----------------------------------------------------------------