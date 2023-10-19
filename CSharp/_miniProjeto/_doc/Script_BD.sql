create database t14_estoque
use t14_estoque

create table usuario
(
	id_usuario int not null identity primary key,
	nome_usuario varchar(50) not null  ,
	login_usuario varchar(30) not null unique ,
	senha_usuario varchar(30) not null  ,
	data_usuario smalldatetime not null default getdate() ,
	obs_usuario varchar(255) null  ,
	status_usuario varchar(20) not null default 'ATIVO' 
)

insert into usuario
	(nome_usuario,login_usuario,senha_usuario,obs_usuario)
values
	('Administrador','admin','123','Usuário adm padrão')

select * from usuario

insert into usuario
	(nome_usuario,login_usuario,senha_usuario,obs_usuario)
values
	('Judith','juju','123456','vai curinthia')

delete from usuario where id_usuario = 4

update usuario set 	nome_usuario = '',	login_usuario = '',	senha_usuario = '',	obs_usuario = '',	status_usuario = '' where id_usuario = 

create table funcionario
(
ID_Funcionario	int	not null	identity	primary key,
nome_Funcionario	varchar(50)	not null		,
nasc_Funcionario	date	not null		,
data_Funcionario	smalldatetime	not null	default getdate()	,
cpf_Funcionario	char(14)	not null	unique	,
logradouro_Funcionario	varchar(50)	not null		,
numero_Funcionario	int	not null		,
comp_funcionario	varchar(20)	null		,
cep_Funcionario	char(9)	not null		,
bairro_Funcionario	varchar(50)	not null		,
cidade_Funcionario	varchar(50)	not null		,
uf_Funcionario	char(2)	not null		,
telefone1_Funcionario	char(16)	not null		,
telefone2_Funcionario	char(16)	null		,
telefone3_Funcionario	char(16)	null		,
telefone4_Funcionario	char(16)	null		,
obs_Funcionario	varchar(200)	null		,
status_Funcionario	varchar(20)	not null	default 'ATIVO'	

)

create table produto
(
ID_Produto	int	not null	identity	primary key,
nome_Produto	varchar(30)	not null	unique	,
data_Produto	smalldatetime	not null	default getdate()	,
qtde_Produto	int	not null		,
Vcusto_Produto	decimal(10,2)	not null		,
Vvenda_Produto	decimal(10,2)	not null		,
obs_Produto	varchar(200)	null		,
status_Produto	varchar(20)	not null	default 'ATIVO'
)


select * from produto


create table fornecedor
(
ID_Fornecedor	int	not null	identity	primary key,
nome_Fornecedor	varchar(50)	not null		,
nasc_Fornecedor	date	not null		,
data_Fornecedor	smalldatetime	not null	default getdate()	,
cnpj_Fornecedor	char(14)	not null	unique	,
logradouro_Fornecedor	varchar(50)	not null		,
numero_Fornecedor	int	not null		,
cep_Fornecedor	varchar(20)	null		,
bairro_Fornecedor	char(9)	not null		,
cidade_Fornecedor	varchar(50)	not null		,
uf_Fornecedor	varchar(50)	not null		,
telefone1_Fornecedor	char(2)	not null		,
telefone2_Fornecedor	char(16)	not null		,
telefone3_Fornecedor	char(16)	null		,
telefone4_Fornecedor	char(16)	null		,
contato_Fornecedor	char(16)	null		,
obs_Fornecedor	varchar(200)	null		,
status_Fornecedor	varchar(20)	not null	default 'ATIVO'	

)

create table localestoque
(
id_LocalEstoque	int	not null	identity	primary key,
nome_LocalEstoque	varchar(50)	not null		,
data_LocalEstoque	smalldatetime	not null	default getdate()	,
obs_os	varchar(200)	null		,
status_os	varchar(20)	not null	default 'ATIVO'	

)

create table os
(
id_os	int	not null	identity	primary key,
id_produto_os	int	not null		,
data_os	smalldatetime	not null	default getdate()	,
qtde_os	int	not null		,
obs_os	varchar(200)	null		,
status_os	varchar(20)	not null	default 'ATIVO'	

constraint FK_id_produto_os  foreign key (id_produto_os) references produto (id_produto)
)

create table itemestoque
(
id_ItemEstoque	int	not null	identity	primary key,
id_produto_ItemEstoque	int	not null		,
id_localEstoque_ItemEstoque	int	not null		,
data_ItemEstoque	smalldatetime	not null	default getdate()	,
obs_os	varchar(200)	null		,
status_os	varchar(20)	not null	default 'ATIVO'	

constraint FK_id_produto_ItemEstoque  foreign key (id_produto_ItemEstoque) references produto (id_produto),
constraint FK_id_localEstoque_ItemEstoque  foreign key (id_localEstoque_ItemEstoque) references localEstoque (id_localEstoque)
)


create table movimentacao
(
id_mov	int	not null	identity	primary key,
id_Produto_mov	int	not null		,
id_funcionario_mov	int	not null		,
qtde_mov	int	not null		,
data_mov	smalldatetime	not null	default getdate()	,
tipo_mov	varchar(30)	not null		,
obs_mov	varchar(200)	null		,
status_mov	varchar(20)	not null	default 'ATIVO'	

constraint FK_id_Produto_mov  foreign key (id_Produto_mov) references produto (id_produto),
constraint FK_id_funcionario_mov  foreign key (id_funcionario_mov) references funcionario (id_funcionario)

)