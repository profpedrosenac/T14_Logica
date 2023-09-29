create table t14_estoque
use t14_estoque

select * from funcionario

create table funcionario
(
	ID_Funcionario int not null auto_increment primary key,
	nome_Funcionario varchar(50) not null  ,
	nasc_Funcionario date not null  ,
	data_Funcionario timestamp not null  ,
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

select * from produto

create table produto
(
	ID_Produto int not null auto_increment primary key,
	nome_Produto varchar(30) not null unique ,
	data_Produto timestamp not null  ,
	qtde_Produto int not null  ,
	Vcusto_Produto decimal(10,2) not null  ,
	Vvenda_Produto decimal(10,2) not null  ,
	obs_Produto varchar(200) null  ,
	status_Produto varchar(20) not null default 'ATIVO' 
)

drop table produto

select * from movimentacao

create table movimentacao
(
	id_mov int not null auto_increment primary key,
	id_Produto_mov int not null  ,
	id_funcionario_mov int not null  ,
	qtde_mov int not null  ,
	data_mov timestamp not null  ,
	tipo_mov varchar(30) not null  ,
	obs_mov varchar(200) null  ,
	status_mov varchar(20) not null default 'ATIVO',
    
    constraint FK_id_Produto_mov foreign key (id_Produto_mov) references produto (id_Produto),
    constraint FK_id_funcionario_mov foreign key (id_funcionario_mov) references funcionario (id_funcionario)
)


-- CRUD (DML)
-- Create - insert
-- Read - select
-- Update - update
-- Delete - delete

insert into produto 
	(nome_Produto,qtde_Produto,Vcusto_Produto,Vvenda_Produto,obs_Produto)
    values
    ('Parafuso',30,0.30,1.85,'')

select * from produto

update produto set qtde_produto = 250 where id_produto = 1


insert into produto 
	(nome_Produto,qtde_Produto,Vcusto_Produto,Vvenda_Produto,obs_Produto)
    values
	('Prego',500,0.20,1.80,''),
    ('Porca',230,0.10,1.30,''),
	('Enforca Gato',30,0.05,3.50,'')

select * from produto
select * from produto where id_produto = 2




