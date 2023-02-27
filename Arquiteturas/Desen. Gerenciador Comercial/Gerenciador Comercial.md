# Desenvolvimento de um Gerenciador Comercial 

## Criando as tabelas de Departamento e Posições

Em uma estrutura organizacional típica, um departamento é uma unidade da empresa que agrupa indivíduos que desempenham funções semelhantes ou trabalham em prol de um objetivo comum. Uma posição refere-se a uma função específica ou cargo que um funcionário ocupa dentro da organização.

No SQL, esses dois conceitos podem ser relacionados por meio do uso de tabelas. Uma maneira comum de representar departamentos é criar uma tabela chamada "departamentos" que contém colunas para o ID do departamento, nome do departamento e qualquer outra informação relevante. Da mesma forma, uma tabela chamada "cargos" pode ser criada para representar os cargos, com colunas para ID do cargo, nome do cargo e outras informações relevantes.

Para estabelecer um relacionamento entre essas duas tabelas, uma chave estrangeira pode ser adicionada à tabela "posições" que faz referência ao ID do departamento na tabela "departamentos". Essa restrição de chave estrangeira garante que cada posição seja associada a um departamento válido.

Aqui está um exemplo de código SQL para criar essas duas tabelas e estabelecer um relacionamento entre elas

```sql
CREATE TABLE departments (
  department_id INT PRIMARY KEY,
  department_name VARCHAR(50)
);

CREATE TABLE positions (
  position_id INT PRIMARY KEY,
  position_name VARCHAR(50),
  department_id INT,
  FOREIGN KEY (department_id) REFERENCES departments(department_id)
);
```

Neste exemplo, a tabela "positions" inclui uma restrição de chave estrangeira que faz referência à tabela "departments" na coluna "department_id". Isso garante que cada posição seja associada a um departamento válido e permite que você consulte posições com base em seu departamento.