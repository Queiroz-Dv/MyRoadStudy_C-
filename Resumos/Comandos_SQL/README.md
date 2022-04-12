# 🐱‍💻 Resumo  de   Comandos   SQL

Abaixo está a lista dos comandos e exemplos em SQL que já estudei.
Aqui está o link de queries para fonte de estudos e testes: [Repositório SQL](https://github.com/Queiroz-Dv/ProjectStudy_SQL)

#### Criar Database

```sql
CREATE DATABASE DatabaseName
```



#### Criar Tabela com limites(Constraints)

```sql
CREATE TABLE [Student]
(	[Id] INT NOT NULL,
    [Name] VARCHAR(80) NOT NULL, -- Não pode ser nulo
    [Email] VARCHAR(100) NOT NULL,
    [Birthday] DATETIME NULL, -- Pode ser nulo
    [Active] BIT NOT NULL DEFAULT(0), -- Valor padrão para evitar erros nas alterações
)
```



#### Alterar Tabela ou tipo

```sql
ALTER TABLE [Student] -- Nome da tabela
	ADD [Document] VARCHAR(11) -- Coluna que deseja adicionar
	------
ALTER TABLE [Student]	
	ALTER COLUMN [Document] CHAR(11) -- Coluna que deseja alterar
```



#### Remover Coluna

```sql
ALTER TABLE [Student]
	DROP COLUMN [Document] -- Coluna que deseja remover
```



#### Adicionando Chave Primária(Primary Key)

```sql
ALTER TABLE [Student] PRIMARY KEY([Id], [Email])
-- Nomeando chave e unique
CONSTRAINT [PK_Student] PRIMARY KEY([Id]) 
CONSTRAINT [UQ_Student_Email] UNIQUE([Email])
```

#### Criação de Tabela Associativa

```sql
-- Tabela de Aluno e Curso
CREATE TABLE [StudentCourse] 
(
    -- Chave Primária de Aluno
    [StudentId] INT NOT NULL, 
    -- Chave Primária de Curso
    [CourseId] INT NOT NULL,
    
    [Progress] INT NOT NULL,
    [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),

    -- Relacionamento de Chave Composta
    CONSTRAINT PK_StudentCourse
    	PRIMARY KEY([StudentId], [CursoId]))
```



#### Criando Tabela com Chave Estrangeira(Foreign Key)

```sql
CREATE TABLE[Course]
(
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] VARCHAR(88) NOT NULL,
    [CategoryId] INT NOT NULL,

    CONSTRAINT [PK_Course] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Course_Category]
        FOREIGN KEY([CategoryId])
            REFERENCES [Category]([Id])
)
```

#### Criando Index(para pesquisas massivas)

```sql
CREATE INDEX [IX_Student_Email] ON [Student]([Email])
```

#### Inserindo valores

```sql
INSERT INTO [Category]([Name]) VALUES('Backend')
INSERT INTO [Category]([Name]) VALUES('Frontend')
INSERT INTO [Category]([Name]) VALUES('Mobile')
INSERT INTO [Category]([Name]) VALUES('FullStack')
```

