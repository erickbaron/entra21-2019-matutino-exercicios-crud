CREATE TABLE tabelaPeixes(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
raca VARCHAR(100),
preco DECIMAL (6,2),
quantidade INT
);
DROP TABLE colaboradores;
CREATE TABLE colaboradores (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
cpf VARCHAR(14),
salario DECIMAL (8,2),
sexo VARCHAR(15),
cargo VARCHAR (25),
programador BIT
);

CREATE TABLE clientes (
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
saldo decimal(8,2),
telefone VARCHAR(14),
estado VARCHAR (2),
cidade VARCHAR(50),
bairro VARCHAR(50),
CEP VARCHAR(9),
logradouro VARCHAR(50),
numero INT,
complemento VARCHAR (100),
nome_Sujo BIT,
altura DECIMAL(4,2),
peso DECIMAL (5,2)
);

SELECT nome FROM clientes;
