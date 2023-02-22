# 📐Arquitetura de Softwares

> Para entender melhor a arquitetura de software, temos que voltar às origens da palavra arquiteto: vem da antiga palavra grega arkitekton, ἀρχι- [(](https://en.wiktionary.org/wiki/ἀρχι-#Ancient_Greek) arkhi-, “chefe”) + [‎ τέκτων](https://en.wiktionary.org/wiki/τέκτων#Ancient_Greek) (téktōn, “construtor ”). A arquitetura é criada por pessoas que constroem coisas. Esse sentido se perdeu no trabalho de arquitetos de construção, muitos dos quais nunca lançaram uma fundação, emolduraram um edifício ou instalaram encanamentos ou canos de aquecimento. Projeto e construção tornaram-se separados. Não é assim no software, onde a forma como algo é construído influencia o que é construído e vice-versa.

A arquitetura de software de um sistema representa as decisões de projeto relacionadas à estrutura e ao comportamento geral do sistema.
Neste caso arquitetura de software se refere a como organizamos as coisas no processo de criação de software como:

- Estrutura de pastas do repositório 
- Renderização do lado do servidor ou do lado do cliente? Banco de dados relacionais ou não-relacionais?
- As tecnologias e linguagens que serão utilizadas(REST ou GraphQl para API / Python com Django ou Node com Express para o back-end)
- O sistema está monólito ou microsserviços?
- É hospedado localmente ou um provedor de nuvem?

> Saber por que alguém fez algo é tão importante quanto saber o que fez.

------



## 🧪 Conceitos importantes de Arqui. de Software

### Cliente-servidor

É um modelo que estrutura as tarefas de um aplicativo entre um provedor e um solicitante. Em resumo, cliente é o aplicativo que solicita alguma informação/dado, e o servidor é o programa que envia as informações.
Os clientes são normalmente aplicativos de front-end e os servidores geralmente são aplicativos de back-end.

### API(Interface de programação de aplicativos)

É um conjunto de regras definidas que estabelecem como uma aplicação pode ser comunicar com outra. O modos de como podemos implementar são diversos, os mais usados são: REST, SOAP, e GraphQl.
As APIs se comunicam, na maioria das vezes, com o protocolo HTTP e o conteúdo trocado é no formato JSON ou XML.

### Modularidade

Quando se fala em modularidade na arquitetura isso se refere a dividir coisas grandes em partes menores
As vantagens são:

- Bom para dividir funcionalidades.
- Tende a ser mais fácil manter e menos sujeitos a erros no projeto.
- Cada peça pode ser trabalha ou modificada separadamente de forma independente.

------

## 🧱 Infraestrutura 

Este tópico trata sobre as diversas maneiras sobre como organizamos um aplicativo de software, ou seja, pela infraestrutura por detrás do projeto.

### Arquitetura monolítica

Esta arquitetura é quando há um único aplicativo de servidor para todos os recursos do sistema. O principal benefício de um design desse tipo é a sua simplicidade. O funcionamento e a configuração dele são simples e fáceis de seguir, e é por isso que a maioria dos aplicativos começam dessa forma.

### Arquitetura de  microsserviços

É um conceito de dividir os recursos do lado do servidor em muitos servidores pequenos que responsáveis por recursos específicos. Toda essa comunicação acontece por meio de APIs como em um servidor monolítico. A diferença é que temos diferentes ações ao invés de um único que faz tudo.

------

## 📁 Estrutura de Pastas

### Estrutura de camadas

Essa arquitetura consiste em dividir responsabilidades em diferentes pastas e arquivos e permitir a comunicação direta apenas entre determinadas pastas e arquivos.

A questão de quantas camadas seu projeto deve ter, quais nomes cada camada deve ter e quais ações ela deve manipular é uma questão de discussão. Abaixo está uma abordagem de exemplo:

- **Camada de aplicação**: Essa camada terá a configuração básica do servidor e a conexão com as rotas
- **Camada de rotas**: Terá a definição de todas as rotas e a conexão com os controladores 
- **Camada de controladores**: Irá conter a lógica real que queremos executar em cada endpoint e a conexão com a camada de modelo
- **Camada de modelo**: Manterá a logica para interagir com o banco de dados
- **Camada de persistência**: É onde estará o banco de dados.

### Estrutura MVC

MVC é um padrão de arquitetura que significa **Model View Controller** . Poderíamos dizer que a arquitetura MVC é como uma simplificação da arquitetura de camadas, incorporando também o front-end (UI) da aplicação. Abaixo esta uma descrição para as três principais camadas.

- **View**: A camada de exibição renderiza a interface do usuário.
- **Controller**: A camada de controladores irá definir as rotas e a lógica de cada uma delas.
- **Model**: A camada de modelo por interagir com o banco de dados.

------

# O que é Arquiteto de Software?

Um desenvolvedor especialista que projeta soluções de software desde o início, tomando decisões de alto nível sobre cada etapa do processo, incluindo padrões técnicos, ferramentas, princípios de design, plataformas a serem usadas etc. Liderando uma equipe de engenheiros para criar o produto final .

------

# Níveis de Arquitetura

A arquitetura pode ser feita em vários “níveis” de abstrações. O nível influencia a importância das habilidades necessárias. Como existem muitas categorizações possíveis, minha segmentação favorita inclui esses 3 níveis:

- **Nível de Aplicação:** O nível mais baixo de arquitetura. Concentre-se em um único aplicativo. Muito detalhado, design de baixo nível. A comunicação geralmente ocorre dentro de uma equipe de desenvolvimento.

- **Nível de solução:** O nível intermediário da arquitetura. Concentre-se em um ou mais aplicativos que atendam a uma necessidade de negócios (solução de negócios). Algum design alto, mas principalmente de baixo nível. A comunicação é entre várias equipes de desenvolvimento.

- **Nível Enterprise:** O nível mais alto de arquitetura. Concentre-se em várias soluções. Design abstrato de alto nível, que precisa ser detalhado por arquitetos de soluções ou aplicativos. A comunicação está em toda a organização.

  

## Sistemas com arquitetura de n-camadas

- Pode-se pensar em uma aplicação web dinâmica, que tem uma interface, lógica de negócios, serviços e um banco de dados.

Geralmente os sistemas são projetados em três camadas ou mais:
 - **Camada de Armazenamento (DS - Data Store)**: Camada onde os dados são armazenados

 - **Camada de Acesso aos Dados (DAL - Data Acess Layer)**: Camada que trata de obter e retornar os dados salvos na camada de armazenamento

 - **Camadade de Lógica de Negócios (BLL - Business Logica Layer)**: Camada que obtém os dados pela DAL e repassa ao cliente de forma mais intuitiva.

 - **Camada de Apresentação (UI - User Interface)** : Camda que define o que será apresentado.