create database scout;
use scout;

create table pessoa(
id char(36) primary key not null,
login varchar(20) not null,
senha varchar(20) not null,
email varchar(50) not null,
imagem longblob null,
descricao varchar(400) null
)engine=innodb;

create table post(
id char(36) primary key not null,
imagem longblob null,
descricao varchar(400) null,
idPessoa char(36) not null,
FOREIGN KEY (idPessoa) REFERENCES pessoa(id)
)engine=innodb;

insert into pessoa (id,login,senha,email,imagem,descricao) values("0f8fad5b-d9cb-469f-a165-70867728950e","seila","123456","monaxbr32@gmail.com",null,null);
insert into post (id,imagem,descricao,idPessoa) values("7c9e6679-7425-40de-944b-e07fc1f90ae7",null,null,"0f8fad5b-d9cb-469f-a165-70867728950e");

select * from pessoa;
select * from post;
