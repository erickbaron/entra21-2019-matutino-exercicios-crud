CREATE TABLE tabelaPeixes(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
raca VARCHAR(100),
preco DECIMAL (6,2),
quantidade INT
);

CREATE TABLE colaboradores (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
cpf VARCHAR(14),
salario DECIMAL (8,2),
sexo VARCHAR(15),
cargo VARCHAR (25),
programador BIT
);

