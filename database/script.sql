-- Para o teste foi criada uma base de dados com nome CTSCompass
USE CTSCompass
GO

-- Criação da tabela de Produtos com os campos seguindo a descrição do teste
CREATE TABLE Produtos (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(50),
	Preco DECIMAL(15, 2),
	Quantidade INT
)

-- Inserção de registros seguindo a descrição do teste
INSERT INTO Produtos VALUES
	('Produto A', 10.50, 100),
	('Produto B', 20, 200),
	('Produto C', 30.75, 300)
