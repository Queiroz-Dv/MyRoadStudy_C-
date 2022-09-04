#  🐱‍💻Resumo  Téorico  Sobre  Banco de  Dados  e   SQL  (SQL Server  | PLSQL)

## O que é um  Banco de Dados?

Um banco de dados é um lugar para armazenar informações. As informações são armazenadas em tabelas onde há divisões de linhas e colunas.
É conhecido também como _SCHEMA_ no caso dos bancos de dados relacionais.

## O  que  é  um   Sistema  Gerenciador  de   Banco   de   Dados(SGBD)?

Um SGBD tem como funcionalidade para auxiliar a manipular os dados dentro de um sistema.

**Exemplos de SGBDs**: Oracle, SQL Server, MYSQL entre outros. 

#### Definição de Banco de Dados Relacional:

> Um banco de dados relacional é um conjunto de relações ou tabelas bidimensionais.

#### Modelo Relacional:

1. Conjunto de objetos ou relações;
2. Conjunto de operadores para agir nas relações;
3. Integridade de dados para precisão e consistência

### Tipos de Dados SQL

- <strong>CHAR:</strong> Este tipo guarda o tamanho físico de caracteres. Se tivermos um nome com cinco caracteres e colocarmos um CHAR de sessenta, ele guardará o nome e o resto das posições em branco.
- <strong>VARCHAR2:</strong> Este pode variar para cada tamanho de caracteres inserido no banco.
- <strong>NVARCHAR:</strong> Este suporta diferentes tipos de caracteres e é um dos mais usados.
- <strong>BIT:</strong> Este tipo guarda zero e um pois funciona como falso e verdadeiro.
- NULL: O valor nulo é um valor que é indisponível, não atribuído.

<h2>🎲 Tipos de Linguagem SQL</h2>



## Comandos  Básicos  SQL

### Select

Comando usado para selecionar dados.
Exemplos:

- Sintaxe padrão:

  ```plsql
  SELECT * FROM Aluno
  ```

- Selecionando colunas específicas:

  ```plsql
  SELECT
  	IdAluno,
    Nome
  FROM Aluno    
  ```

- Utilizando Alias(apelido):

  ```plsql
  SELECT 
      idAluno Codigo,
      Nome AS Aluno
  FROM Aluno
  ```

- Eliminando linhas duplicadas(distinct):

  ```plsql
  SELECT DISTINCT 
   	Cidade Cidade
  FROM Aluno
  ```

  

### Where

Cláusula de filtro de dados.
Exemplos:

-  Sintaxe padrão:

  ```plsql
  SELECT
  	IdAluno,
  	Nome,
  	Nascimento
  FROM Aluno WHERE Estado = 'RS'
  ```

- Com operadores de comparação:

  ```plsql
  SELECT 
  	IdContrato, 
  	Data,
  	Total,
  	Desconto + 10
  FROM Contrato WHERE Total <= Desconto + 10
  ```

  

### Create Database |  Table

Este comando serve para criar um novo banco de dados ou tabela

```plsql
CREATE DATABASE [NomeDatabase]
CREATE TABLE NomeTabela
```



## Tabela  Associativa

É um tipo de tabela criada pela união da relação de duas tabelas. Exemplos abaixo

|   Aluno    | Aluno_Curso |      Curso       |
| :--------: | :---------: | :--------------: |
| 1 - Marcos |     1,1     |  1 - SQL Básico  |
|  2 - Ana   |    2, 1     | 2 - SQL Avançado |
| 3 - Júlio  |    3, 2     |  3 - Desen. Web  |
| 4 - Miriam |    4, 3     |                  |

### Index

O index ajuda a organizar os dados, apesar de apresentar a lentidão nos Inserts. Serve para pesquisas massivas em alguma coluna da tabela.

Para um estudo mais detalhado e aprofundado, siga para este outro resumo  com mais conteúdo. [Resumo de Comandos e Prática](https://github.com/Queiroz-Dv/MyRoadStudy_CSharp/tree/master/Resumos/Comandos_SQL)
