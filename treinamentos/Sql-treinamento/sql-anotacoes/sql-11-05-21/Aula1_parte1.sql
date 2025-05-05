SELECT department_name FROM departments;

drop table pessoa_fisica;

CREATE TABLE pessoa_fisica
(id int identity(1,1) primary key
, nome varchar(255)
, cpf NUMERIC(11)
, nascimento date);

SELECT * FROM pessoa_fisica;

insert into pessoa_fisica (nome, cpf, nascimento)
values ('carlos', 123456789, '2021-05-11');

insert into pessoa_fisica (nome, cpf, nascimento)
values ('joana', 123402548, '2021-05-05');

insert into pessoa_fisica (nome, cpf, nascimento)
values ('fulano', 2525252525, '2021-05-10');

alter table pessoa_fisica add endereco varchar(255);

alter table pessoa_fisica drop column endereco;

alter table pessoa_fisica alter column nome varchar(255) not null;

UPDATE pessoa_fisica
SET cpf = 252525252
WHERE id = 3;

UPDATE pessoa_fisica
SET endereco = 'rua tal'
WHERE id < 3;

delete from pessoa_fisica
where id = 2;