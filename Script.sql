create database t14_ferragens
use t14_ferragens

create table Produto
(
	id_produto int not null identity primary key,
	nome_produto varchar(30) not null unique,
	data_produto smalldatetime not null default getdate(),
	qtde_produto int not null,
	vcusto_produto decimal(10,2) not null,
	vvenda_produto decimal(10,2) not null,
	obs_produto varchar(200) null,
	status_produto varchar(20) not null default 'ATIVO'
) 
select * from produto
--comentário
/*
	bloco de comentários
*/

create table Funcionario
(
	ID_Funcionario int not null identity primary key ,
	nome_Funcionario varchar(50) not null  ,
	nasc_Funcionario date not null  ,
	data_Funcionario smalldatetime not null default getdate() ,
	cpf_Funcionario char(14) not null unique ,
	logradouro_Funcionario varchar(50) not null  ,
	numero_Funcionario int not null  ,
	comp_funcionario varchar(20) null  ,
	cep_Funcionario char(9) not null  ,
	bairro_Funcionario varchar(50) not null  ,
	cidade_Funcionario varchar(50) not null  ,
	uf_Funcionario char(2) not null  ,
	telefone1_Funcionario char(16) not null  ,
	telefone2_Funcionario char(16) null  ,
	telefone3_Funcionario char(16) null  ,
	telefone4_Funcionario char(16) null  ,
	obs_Funcionario varchar(200) null  ,
	status_Funcionario varchar(20) not null default 'ATIVO' 
)

select * from Funcionario
drop table funcionario

-- drop excluir
-- drop table ____ exclui uma tabela
-- drop database _____ exclui uma base de dados (BD)

create table movimentacao
(
	id_mov int not null identity primary key,
	id_Produto_mov int not null  ,
	id_funcionario_mov int not null  ,
	qtde_mov int not null  ,
	data_mov smalldatetime not null default getdate() ,
	tipo_mov varchar(30) not null  ,
	obs_mov varchar(200) null  ,
	status_mov varchar(20) not null default 'ATIVO' 

	constraint FK_id_Produto_mov FOREIGN KEY (id_Produto_mov) references produto (id_produto),
	constraint FK_id_funcionario_mov foreign key (id_funcionario_mov) references funcionario (ID_Funcionario)
)

select * from movimentacao