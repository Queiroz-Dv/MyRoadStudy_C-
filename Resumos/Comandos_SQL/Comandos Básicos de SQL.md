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

```sql
-- Cria o banco de dados
CREATE DATABASE [TargetSQL]
GO

 --Deleta o banco
DROP DATABASE [TargetSQL]
GO

-- Cria a tabela do banco (TargetSQL)
CREATE TABLE [Aluno](
    [Id] INT,
    [Nome] NVARCHAR(50),
    [Nascimento] DATETIME,
    [Active] BIT,
)
GO

-- Criação de tabela para relacionamento de um-para-muitos
CREATE TABLE [Curso](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
            REFERENCES [Categoria]([Id])
)
GO

CREATE TABLE [Categoria](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id])
)
-- Para alterar a tabela (incluir campos, remover, renomear etc)
ALTER TABLE [Aluno] 
    ADD [Documento] NVARCHAR(11)
GO

ALTER TABLE [Aluno] 
    ALTER COLUMN [Documento] NVARCHAR(12)
GO

ALTER TABLE [Aluno] 
    DROP [Documento]
GO

-- Cria a tabela do banco com limitações (constraints)
CREATE TABLE [Escola](
    [Id] INT NOT NULL UNIQUE, -- O Unique não permite que algo seja igual a outro
    [Nome] NVARCHAR(150) NOT NULL,
    [Endereco] NVARCHAR(100) NULL,
    [CNPJ] INT NOT NULL,
)
GO

-- Criando a tabela do banco com PK
CREATE TABLE [Departamentos](
    [Id] INT NOT NULL, -- O Unique não permite que algo seja igual a outro
    [Nome] NVARCHAR(50) NOT NULL,
    [Cargo] NVARCHAR(50) NOT NULL,

    CONSTRAINT [PK_Departamento] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Departamento_Cargo] UNIQUE([Cargo]), 
)
GO

-- Alterando a tabela para adicionar a PK
ALTER TABLE [Departamentos] 
    ADD PRIMARY KEY ([Id])
GO

-- Tabela associativa de aluno e curso - relacionamento de muitos-para-muitos
CREATE TABLE[ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT PK_ProgressoCurso PRIMARY KEY([AlunoId], [CursoId]),
)
GO

-- Definindo um Index
-- O índex ajuda na organização da busca dos dados, ams tende a ser
-- lento no insert de dados.
CREATE INDEX [IX_Aluno_Email] ON [Aluno]([Email])
DROP INDEX [IX_Aluno_Email] ON [Aluno]
GO

-- Criando tabela com auto-incremento
CREATE TABLE[Professores](
    [Id] INT NOT NULL IDENTITY(1, 1), -- Irá se auto-incrementar de um em um
    [Nome] NVARCHAR(80) NOT NULL,
    [CPF] CHAR(11) NOT NULL,

    CONSTRAINT [PK_Professor] PRIMARY KEY ([Id], [CPF]), -- Criação de chave composta para Id e CPF
    CONSTRAINT [UQ_Professor_CPF] UNIQUE ([CPF]) -- Ciração de uma unique para que o CPF seja de uma única pessoa
)
GO


-- Inserindo dados em uma tabela
INSERT INTO [Categoria]([Nome]) VALUES('Backend')
INSERT INTO [Categoria]([Nome]) VALUES('Frontend')
INSERT INTO [Categoria]([Nome]) VALUES('Mobile')

INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos De C#', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos De OOP', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos de Angular', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Flutter', 3)
GO


-- Criando Seletores otimizados
-- Seletor que traz dois campos
SELECT TOP 2
    [Id], [Nome]
    FROM 
        [Curso]

-- Seletor que traz apenas os campos distintos um do outro
SELECT DISTINCT TOP 100
    [Nome]
    FROM 
        [Categoria]
GO

-- Construção de Queries
-- Seletor que busca uma categora que seja igual a 1 e o Id seja um também (AND)
SELECT TOP 2
    [Id], [Nome], [CategoriaId]
    FROM 
        [Curso]
    WHERE
        [Id] = 1 AND
        [CategoriaId] = 1
GO

-- Seletor que busca uma categora que seja igual a 1 ou o Id seja um também (OR)
SELECT TOP 2
    [Id], [Nome], [CategoriaId]
    FROM 
        [Curso]
    WHERE
        [Id] = 1 OR
        [CategoriaId] = 1
GO

-- Seletor com ordenação
SELECT TOP 2
    [Id], [Nome], [CategoriaId]
    FROM 
        [Curso]
    -- WHERE
    --     [CategoriaId] = 1
    ORDER BY
        [Nome] ASC -- Ordenação Ascedente (ppode-se colocar DESC para descendente)
GO

-- Atualizando um campo da tabela / Deletando um campo da tabela
BEGIN TRANSACTION --Inicia uma transação ao invés de atualizar todas as linhas
        UPDATE 
            [Categoria]
        SET
            [Nome] = 'FullStack'
        WHERE 
            [Id] = 1
COMMIT -- Comita as alterações para o banco mas pode se usar o ROLLBACK para cancelar as alterações
GO
```

