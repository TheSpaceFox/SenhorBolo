CREATE DATABASE SrBolo
USE SrBolo
DROP DATABASE SrBolo

CREATE TABLE tblFuncionarios(
	idFuncionario INT PRIMARY KEY,
	nomeFunc VARCHAR(50) NOT NULL,
	senhaFunc VARCHAR(50),
	RG VARCHAR(8),
	salario NUMERIC(5,2),
	email VARCHAR(50),
	telefone VARCHAR(11),
	CEP VARCHAR (9)
)

CREATE TABLE tblVenda(
	idVenda INT PRIMARY KEY,
	dataVenda DATE,
	idFuncionario INT FOREIGN KEY
	REFERENCES tblFuncionarios (idFuncionario)
)

CREATE TABLE tblProduto(
	idProduto INT PRIMARY KEY,
	descProduto VARCHAR (30),
	precoProduto NUMERIC (5,2),
	maisValia NUMERIC(5,2)
)

CREATE TABLE tblDetalheVendas (
	idCategoria INT PRIMARY KEY,
	nome VARCHAR(50)
)

CREATE TABLE tblAdministrador (
	idAdministrador INT PRIMARY KEY,
	nomeADM VARCHAR(50),
	senhaADM VARCHAR(50)
)

CREATE TABLE tblFornecedor(
	CNPJ VARCHAR(14),
	descFor VARCHAR(30),
	contatoFor CHAR(30),
	enderecoFor VARCHAR(50),
	cidade VARCHAR(25)
)
