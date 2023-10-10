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