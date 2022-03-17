# 🔮 My CSharp RoadStudy

## Linguagens de Programação

É a forma como dizemos para o computador executar algo. Computadores usam apenas a linguagem binária.

O processo de tradução se chama compilação. Cada linguagem tem seu compilador, um intérprete.

## Baixo e Alto Nível

Ao enviar uma instrução para o computador estamos falando em nível de máquina, ou seja, uma linguagem de baixo nível. As linguagens mais modernas são consideradas de alto nível.

|                    Linguagens Compiladas                     |                   Linguagens Interpretadas                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| Consiste em receber um arquivo de texto e convertê-lo para binário. | Lidos e interpretados por um intérprete. Feito em tempo de execução. |

## Tipagem de Dados

Também chamadas de fortemente tipadas, pois obrigam a especificar o tipo de dado da informação. Tem uma menor liberdade por outro lado tem maior otimização.  Um tipo de dado define o formato dele.

```c#
int age = 18; // Ok
int age = 18.2; // Erro
int age = "18"; // Erro
```

## Sobre CSharp

- Linguagem de Programação
- Tipada, compilada e gerenciada
- Criada por Anders Hejlsberg em meados de 2001
- Principal linguagem da Microsoft

### CSharp  Como Primeira Linguagem

- Não é a mais fácil
- Focada em OOP(Base da programação)
- OOP te dá a base para aprender coisas novas
- Quanto mais tempo na base, mais fácil aprender coisas novas

## Como funciona?

Código Gerenciado: significa que a sua execução depende de um gerenciador. Também é conhecido como **Runtime**. Neste caso, o Runtime  do C# se chama CLR(Common Language Runtime).

## Tipos de Projeto

- *Class Library*: O resultado final é uma DLL - não possui interface

- *Console Application*: O reusltado final é uma aplicação que roda no terminal.

- *Projeto Web*: ASP.NET WEB, ASP.NET MVC, ASP.NET WebAPI

- *Projetos Testes*: Microsoft Tests

## Comandos principais dotnet

- Para criar um novo projeto console:

```powershell
dotnet new console -o MeuApp
```

- Comando que busca todos os pacotes que a aplicação precisa para executar:

```powershell
dotnet restore
```

- Comando que compila:

```powershell
dotnet build
```

- Comando que limpa o cache:

```powershell
dotnet clean
```

- Comando que roda a aplicação:

```powershell
dotnet run
```

## Variáveis de Ambiente

É comum termos vários ambientes para nossas aplicações como:

- Desenvvolvimento
- Homologação
- Produção

De acordo com isso, cada ambiente possui suas próprias configurações
