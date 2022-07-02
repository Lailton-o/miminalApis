# miminalApis
Hello, this is a project for study and base of knowledge.

Learning for the project using https://macoratti.net/21/10/net6_minapidapp1.htm from Macoratti.

I am using Sql Server
If u don`t wanna to create the database in your mode, can try this:
CREATE TABLE Tarefa (
    Id INT PRIMARY KEY IDENTITY, 
    Atividade nvarchar(500) NOT NULL,
    [Status] nvarchar(250) NOT NULL,
	IdTipoTarefa INT NOT NULL
);

CREATE TABLE TipoTarefa (
    Id INT PRIMARY KEY IDENTITY, 
    Descricao nvarchar(50) NOT NULL
);

ALTER TABLE Tarefa
ADD CONSTRAINT Tarefa_TipoTarefa_FK FOREIGN KEY (IdTipoTarefa) REFERENCES TipoTarefa (Id);
