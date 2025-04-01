USE CTSCompass
GO

CREATE TABLE Produtos (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(50),
	Preco DECIMAL(15, 2),
	Quantidade INT
)

INSERT INTO Produtos VALUES
	('Produto A', 10.50, 100),
	('Produto B', 20, 200),
	('Produto C', 30.75, 300)
