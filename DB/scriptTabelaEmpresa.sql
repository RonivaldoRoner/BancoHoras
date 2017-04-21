CREATE TABLE Empresas
(
	cnpj VARCHAR(14) NOT NULL PRIMARY KEY,
	nome VARCHAR(50)  NOT NULL,
	endereco VARCHAR(50) NOT NULL,
	numero INT NOT NULL,
	end_comp VARCHAR(20),
	bairro VARCHAR(20) NOT NULL,
	cidade VARCHAR(20) NOT NULL,
	estado VARCHAR(2) NOT NULL,
	cep VARCHAR(9) NOT NULL,
	telefone VARCHAR(11) NOT NULL
);