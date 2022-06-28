# 🔮CSharp RoadStudy

### 🐱‍💻 Objetivos e Metas
Cada pasta trata-se de um resumo e estudo de caso feito na linguagem CSharp. O repositório estará em fase de desenvolvimento enquanto houver conteúdos a serem tratados. Meu intuito é compartilhar com a comunidade informações de forma simplificada e também reforçar meu aprendizado em programação com a linguagem CSharp.

Fique a vontade para explorar cada pastinha e projetos que já fiz por aqui! 😍

<details>
    <summary>Projetos Realizados</summary>
  
### ✔ Projetos de Baixa Complexidade
- [Projeto de Calculadora](https://github.com/Queiroz-Dv/ProjectCalculator) 
- [Projeto de Cronômetro](https://github.com/Queiroz-Dv/ProjectStopWatch_CSharp)
- [Projeto de Editor de Texto](https://github.com/Queiroz-Dv/TextEditor)
- [Projeto de Editor HTML](https://github.com/Queiroz-Dv/EditorHTML)
- [Programação Orientada a Objetos-Eng](https://github.com/Queiroz-Dv/OakAcademyStudy)
- [Programação Orientada a Objetos-Pt-BR](https://github.com/Queiroz-Dv/ProjectPooSharp)
  
</details>

## Linguagens de Programação

É a forma como dizemos para o computador executar algo. Computadores usam apenas a linguagem binária.

O processo de tradução se chama compilação. Cada linguagem tem seu compilador, um intérprete.

## Baixo e Alto Nível

Ao enviar uma instrução para o computador estamos falando em nível de máquina, ou seja, uma linguagem de baixo nível. As linguagens mais modernas são consideradas de alto nível.

As linguagens de Alto Nível estão mais próximas dos programadores do que dos dispositivos, devido à facilidade de entedimento.

Já as linguages de Baixo Nível é mais voltada os dispositovos pois envolve números e letras que são instruções diretas ao dispositivo. 

|                    Linguagens Compiladas                     |                   Linguagens Interpretadas                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| Consiste em receber um arquivo de texto e convertê-lo para binário. | Lidos e interpretados por um intérprete. Feito em tempo de execução. |

## Tipos  de  Dados

Algumas linguagens são chamadas de **"fortemente tipadas"**, pois obrigam a especificar o tipo de dado da informação. Tem uma menor liberdade por outro lado tem maior otimização.  Além disso, um tipo de dado define o formato dele.

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
- Focada em POO(Base da programação)
- POO te dá a base para aprender coisas novas
- Quanto mais tempo na base, mais fácil aprender coisas novas

## Como funciona?

Código Gerenciado: significa que a sua execução depende de um gerenciador. Também é conhecido como **Runtime**. Neste caso, o Runtime  do C# se chama CLR(Common Language Runtime).

## Tipos de Projeto

- *Class Library*: O resultado final é uma DLL - não possui interface

- *Console Application*: O resultado final é uma aplicação que roda no terminal do windows(DOS)

- *Projeto Web*: ASP.NET WEB, ASP.NET MVC, ASP.NET WebAPI

- *Projetos Testes*: Microsoft Tests, xUnit

## Principais comandos .NET

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

- Desenvolvimento
- Homologação
- Produção

De acordo com isso, cada ambiente possui suas próprias configurações
