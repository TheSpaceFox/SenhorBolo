CREATE DATABASE SrBolo
DROP DATABASE SrBolo
USE SrBolo
USE SrBolor


ALTER TABLE tblFuncionarios
ADD salario FLOAT;

CREATE TABLE tblFuncionarios(
	idFuncionario INT PRIMARY KEY,
	nomeFunc VARCHAR(50) NOT NULL,
	senhaFunc VARCHAR(50),
	RG VARCHAR(12),
	salario FLOAT,
	email VARCHAR(50),
	telefone VARCHAR(14),
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

CREATE TABLE tblDetalheVenda(
	idVenda INT FOREIGN KEY REFERENCES tblVenda (idVenda),
	idProduto INT FOREIGN KEY REFERENCES tblProduto (idProduto),
	quantidade INT,
	valorTotal NUMERIC (6,2)
)

CREATE TABLE tblAdministrador (
	idAdministrador INT PRIMARY KEY,
	nomeADM VARCHAR(50),
	senhaADM VARCHAR(50)
)

CREATE TABLE tblFornecedor(
	CNPJ VARCHAR(18) PRIMARY KEY,
	descFor VARCHAR(30),
	contatoFor CHAR(30),
	enderecoFor VARCHAR(50),
	cidade VARCHAR(25)
)


insert into tblProduto values
(1, 'Abacaxi', 20.00, 8.00),
(2, 'Ameixa', 20.00, 8.00),
(3, 'Banana com Canela', 20.00, 8.00),
(4, 'Banana com Passas', 20.00, 8.00),
(5, 'Cenoura', 20.00, 8.00),
(6, 'Cenoura Mesclado', 20.00, 8.00),
(7, 'Chocolate', 20.00, 8.00),
(8, 'Coco', 20.00, 8.00),
(9, 'Formigueiro', 20.00, 8.00),
(10, 'Fubá', 20.00, 8.00),
(11, 'Fubá com Erva Doce', 20.00, 8.00),
(12, 'Fubá com Goiabada', 20.00, 8.00),
(13, 'Laranja', 20.00, 8.00),
(14, 'Limão', 20.00, 8.00),
(15, 'Maçã com Canela', 20.00, 8.00),
(16, 'Mandioca com Coco', 20.00, 8.00),
(17, 'Mesclado', 20.00, 8.00),
(18, 'Milho', 20.00, 8.00),
(19, 'Paçoca', 20.00, 8.00),
(20, 'Brigadeiro', 110.00, 60.00),
(21, 'Cocolate com Morango', 120.00, 65.00),
(22, 'Prestígio', 110.00, 60.00),
(23, 'Toalha Felpuda', 110.00, 60.00),
(24, 'Calabresa', 32.00, 15.00),
(25, 'Escarola com Bacon', 32.00, 15.00),
(26, 'Pão de Queijo', 32.00, 15.00),
(27, 'Queijo com Bacon', 32.00, 15.00),
(28, 'Brigadeiro de Colher', 3.00, 2.50)


insert into tblFuncionarios values
(1, 'Edson Bolsonaro', 'Lolicon01203', '40.661.702-8', 1200.00, 'edson.koiti@etec.sp.gov.br', '(11)95178-5329', '58428-500'),
(2, 'Edson Teruel', 'BaroesDaPisadinhaHD', '16.691.104-5', 1450.00, 'victor.shu@etec.sp.gov.br', '(11)93811-6566', '88359-325'),
(3, 'Edson Advogado', 'Ed029348504', '44.708.213-9', 1120.00, 'jotacir.barros@etec.sp.gov.br', '(11)91021-7155', '69039-641'),
(4, 'Edson Sandubinha', 'KiderOvo45', '44.342.046-4', 1200.00, 'cristina.moris@etec.sp.gov.br', '(11)96245-8316', '59620-752'),
(5, 'Edson Habbibs', 'Estanaoeminhasenhakkk', '50.003.556-8', 1450.00, 'arthus.val@etec.sp.gov.br', '(11)92940-6934', '69314-635')

insert into tblAdministrador values
(1, 'Sueli White', '221175'),
(2, 'Marisa Gouveia', 'Nicole87'),
(3, 'Mazete Ribeiro', 'Santos80'),
(4, 'Alessandra Gouveia', 'Nicole89'),
(5, 'Felipe', 'SandroSlayer21'),
(6, 'Ribas', '1234')

insert into tblFornecedor values
('90.918.875/0001-60', 'Senhor Suíno', '12835-9112', 'Rua Magno Lopes', 'João Pessoa'),
('69.962.574/0001-47', 'Açucar União', '35742-0416', 'Rua Floriano Peixoto', 'Boa Vista'),
('65.952.287/0001-03', 'Itambé', '10316-0599', 'Avenida Fernando Baggi', 'Salvador'),
('28.707.298/0001-93', 'Petrobras', '14676-8498', '2ª Travessa Sudão', 'Feira de Santana'),
('48.661.629/0001-09', 'Renner', '31914-8238', 'Travessa Menino Marcelo', 'Maceió')

-- Procedimentos

-- Login
CREATE PROC AcessoSistema
	@userType INT,
	@login INT,
	@senha VARCHAR(50)
AS
BEGIN
	IF @userType = 0
		SELECT * FROM tblAdministrador WHERE idAdministrador = @login and senhaADM = @senha
	ELSE 
		SELECT * FROM tblFuncionarios WHERE idFuncionario = @login and senhaFunc = @senha
END

exec AcessoSistema 0, 6, 1234

-- Listar Funcionarios

create proc ListarFuncionarios
as
Select * from tblFuncionarios 
go

-- Listar Funcionário

CREATE PROC ListarFuncionario
	@idFuncionario INT
	AS
		SELECT * FROM tblFuncionarios WHERE idFuncionario = @idFuncionario
	GO

exec ListarFuncionario 1

-- Cadastrar Funcionarios
CREATE PROC CadastrarFuncionarios
	@idFuncionario INT,
	@nomeFunc VARCHAR(50),
	@senhaFunc VARCHAR(50),
	@RG VARCHAR(8),
	@salario NUMERIC(6,2),
	@email VARCHAR(50),
	@telefone VARCHAR(10),
	@CEP VARCHAR (9)
AS 
INSERT INTO tblFuncionarios VALUES (@idFuncionario, @nomeFunc, @senhaFunc, @RG, @SALARIO, @EMAIL, @TELEFONE, @CEP)
GO

-- Listar Fornecedores

CREATE PROC ListarFornecedores
as
Select * from tblFornecedor
go

-- Cadastrar Fornecedores

Create proc CadastrarFornecedores
    @cnpj varchar(18),
    @descFor varchar(30),
    @contato varchar(30),
    @endereco varchar(50),
    @cidade varchar(25)
as 
insert into tblFornecedor values (@cnpj, @descFor, @contato, @endereco, @cidade)
go

-- Listar Produtos 

CREATE PROC ListarProdutos
as
Select * from tblProduto
go

-- Cadastrar Produtos

CREATE PROC CadastrarProdutos
    @idProd int,
    @descProd varchar(30),
    @preco numeric(5,2),
    @maisvalia numeric (5,2)
as
insert into tblProduto values (@idProd, @descProd, @preco, @maisValia)
go

CREATE PROC EditarFuncionario
	@id INT,
	@nome VARCHAR(50),
	@senha VARCHAR(50),
	@RG VARCHAR(8),
	@salario NUMERIC(6,2),
	@email VARCHAR(50),
	@telefone VARCHAR(10),
	@CEP VARCHAR (9)
	AS
		UPDATE tblFuncionarios SET nomeFunc = @nome, senhaFunc = @senha, RG = @RG, salario = @salario, email = @email, telefone = @telefone, cep = @CEP WHERE idFuncionario = @id
	GO

exec EditarFuncionario 3, 'Edson Caminhoneiro', 'Ed029348504', '44.708.213-9',1120, 'jotacir.barros@etec.sp.gov.br', '(11)91021-7155', '69039-641'
1