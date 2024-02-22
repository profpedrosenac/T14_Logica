create database T14_MiniProjeto

use t14_miniprojeto

create table usuario
(
	id_usuario  int  not null  auto_increment primary key ,
	nome_usuario  varchar(50)  not null    ,
	login_usuario  varchar(30)  not null  unique  ,
	senha_usuario  varchar(30)  not null    ,
	data_usuario  timestamp  not null  ,
	obs_usuario  varchar(255)  null    ,
	status_usuario  varchar(20)  not null  default 'ATIVO' 
)

select * from usuario

insert into usuario
	(nome_usuario,login_usuario,senha_usuario,obs_usuario)
	values
    ('Administrador','admin','123','sem obs')
    
    