Componentes utilizados:
    .NET Core 3.1
    Angular 8.1.0
    SQL Server
    EntityFrameworkCore 3.0    
    NUnit 3.12.0

Deve-se criar o banco de dados SQL Server e executar os scripts abaixo:

--Criação da tabela
CREATE TABLE tblAuthor (  
    AuthorID int IDENTITY(1,1) NOT NULL PRIMARY KEY,  
    Name varchar(50) NOT NULL   
);

--Inserção dos dados para visualizar na tela
insert into tblAuthor values('João Silva');
insert into tblAuthor values('Paulo Coelho');
insert into tblAuthor values('Celso de Araujo');
insert into tblAuthor values('Guimarães');
insert into tblAuthor values('joao silva neto');
insert into tblAuthor values('Machado de Assis');
insert into tblAuthor values('MONTEIRO LOBATO');
insert into tblAuthor values('jOSe DE alencar');
insert into tblAuthor values('cecília meireles');
insert into tblAuthor values('Carlos drummond de andrade');
insert into tblAuthor values('marcelo da silva ribeiro filho');


No arquivo appsettings.json deve-se alterar a string de conexão para a string do banco criado.
