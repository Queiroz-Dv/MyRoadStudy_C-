# Desenvolvimento de um sistema multiplataforma com CSharp

------

## Introdução

Ao iniciar na programação me deparei com diversos entraves que me impediam de prosseguir como desenvolvedor de softwares. Seja pelos erros ao concatenar uma string ou entender a organização e estrutura do código, entre outros.

Foi a partir disso que decidi criar esse pequeno manual para ajudar outros, que assim como eu, se viram enrolados por pensamentos confusos ao solucionar um problema ou até mesmo terem uma base de estudo linear.

Tentarei cobrir o máximo de conteúdo possível e sintetizar outros de forma dinâmica e compreensível. Juntos iremos desenvolver uma aplicação robusta em multiplataforma (desktop e web) com uma API orquestrando todo o nosso processamento. 

Para isso espero apenas que tenha conhecimentos prévios em programação e na linguagem CSharp mas para segurança de outros deixarei cada código documentado o máximo que puder como suporte.

Espero que se divirta ao longo dessa jornada, afinal programar é arte de construir coisas inovadoras.

------

## **Tópicos** 

### A Base

- Conceitos iniciais sobre CSharp
- Estrutura de código CSharp

------

#### Conceitos iniciais sobre CSharp

Antes de adentrarmos ao desenvolvimento do sistema, gostaria de tratar sobre a linguagem CSharp. Linguagem essa que iremos utilizar ao longo desse livro. 

A linguagem CSharp não é a mais fácil de se aprender, no entanto, com **prática regular e força de vontade** poderá ser dominada em pouco tempo. Além disso ela é *fortemente tipada, compilada e gerenciada*, diferente do Javascript por exemplo onde seu sistema de tipagem é fraco.

Com essa linguagem podemos desenvolver aplicações desktop, console (DOS), web e mobile além de jogos e muito mais. A Microsoft é quem mantém e distribui as ferramentas e atualizações para o CSharp (ou para o ambiente .NET).

Para que você possa desenvolver e prosseguir recomendo baixar o Visual Studio 2017 ou 2019. Não recomendarei a versão 2022 pois exige mais recurso do computador e com isso não poderá atender a todos que estão lendo este livro.

Além disso precisaremos do .NET Core e .NET Framework com eles iremos trabalhar em versões distintas para que você tenha conhecimentos entre cada versão do .NET e do CSharp.

------

#### Estrutura do projeto 

O projeto que iremos fazer seguirá a arquitetura em N-Camadas, isso que dizer que cada camada será responsável por fazer alguma coisa. Pense que seu código fonte é um prédio. Cada sala é correspondente a um módulo ou a uma funcionalidade, isso quer dizer que, todos são interdependentes entre si.

###### Arquitetura de N-Camadas

A arquitetura de camadas visa a criação de aplicativos modulares, onde cada camada possui uma responsabilidade. A organização estrutural é que a camada superior se comunique com a camada inferior, fazendo assim com que cada camada seja dependente da camada imediatamente inferior.

- Camada de Apresentação
- Camada de Lógica de Negócios
- Camada de Acesso a Dados

------

**Camada de Apresentação** : É a camada que interage com o usuário, seu objetivo central é coletar e exibir informações de maneira amigável.

**Camada de Lógica de Negócios**: É a camada que processa as informações onde é responsável pelas regras de negócios do sistema. Tem o controle na tomada de decisões e manipulação dos dados.

**Camada de Acesso a Dados**:  É a camada responsável pelo acesso e manipulação dos dados armazenados . Ela interage diretamente com a fonte de dados e fornece as informações para a camada da lógica de negócios.

------

Para o nosso projeto as camadas de apresentação serão separadas em outros projetos dentro de uma única solution, já a camada de negócios e acesso a dados estarão no projeto de API pois serão responsáveis por processar nossos dados. 

#### Estrutura do Projeto de API

Para o projeto de API utilizei o  template do .NET 5, ao nomear e inicializar o seu projeto deverá estar da seguinte forma:
![Template Api](D:\temp\Projetos De Estudo\StudyNotes\MyRoadStudy_CSharp\Image_Exemplos\TemplateAPI.png)

Como padrão esse projeto utiliza o Swagger para documentação da API, algo que será útil para testar nossos módulos. Abaixo deixarei a estrutura de pastas para o nosso projeto.







