
CREATE DATABASE dbrestaurant;

use dbrestaurant;

CREATE TABLE tbfuncoes (
	id int auto_increment NOT NULL,
	cargo varchar(40) NOT NULL,
	CONSTRAINT tbfuncoes_pk PRIMARY KEY (id)
);

CREATE TABLE tbfuncionarios (
	id INT auto_increment NOT NULL,
	nome varchar(50) NOT NULL,
	senha varchar(50) NOT NULL,
	funcao INT NOT NULL,
	CONSTRAINT tbfuncionarios_pk PRIMARY KEY (id),
	CONSTRAINT tbfuncionarios_FK FOREIGN KEY (funcao) REFERENCES dbrestaurant.tbfuncoes(id)
);

CREATE TABLE tbmesas (
	id INT auto_increment NOT NULL,
	numero CHAR(4) NOT NULL,
	qrcode LONGBLOB NOT NULL,
	CONSTRAINT tbmesas_pk PRIMARY KEY (id)
);

CREATE TABLE tbprodutos (
	id int auto_increment NOT NULL,
	nome varchar(50) NOT NULL,
	descricao varchar(200) NULL,
	valor decimal(9,2) NOT NULL,
	imagem longblob NOT NULL,
	CONSTRAINT tbprodutos_pk PRIMARY KEY (id)
);

CREATE TABLE tbusuarios (
	id int auto_increment NOT NULL,
	nome varchar(50) NOT NULL,
	senha varchar(50) NOT NULL,
	CONSTRAINT tbusuarios_pk PRIMARY KEY (id)
);


CREATE TABLE tbvendas (
	id int auto_increment NOT NULL,
	idproduto int NOT NULL,
	quantidade int DEFAULT 1 NOT NULL,
	valor decimal(9,2) NOT NULL,
	data date NOT NULL,
	idfunc int NOT NULL,
	CONSTRAINT tbvendas_pk PRIMARY KEY (id),
	CONSTRAINT tbvendas_FK FOREIGN KEY (idproduto) REFERENCES tbprodutos(id),
	CONSTRAINT tbvendas_FK_1 FOREIGN KEY (idfunc) REFERENCES tbfuncionarios(id)
);

CREATE TABLE tbusuario_vendas (
	idusuario int NOT NULL,
	idvenda int NOT NULL,
	idmesa int NOT NULL,
	data date NOT NULL,
	CONSTRAINT tbusuario_vendas_FK FOREIGN KEY (idmesa) REFERENCES tbmesas(id),
	CONSTRAINT tbusuario_vendas_FK_1 FOREIGN KEY (idvenda) REFERENCES tbvendas(id),
	CONSTRAINT tbusuario_vendas_FK_2 FOREIGN KEY (idusuario) REFERENCES tbusuarios(id)
);


