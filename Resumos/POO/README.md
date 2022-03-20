# 🐱‍💻 Programação Orientada a Objetos

------

POO ou Programação Orientada a objetos é um paradigma da programação, que neste caso, é como estruturamos o nosso código.
A ideia maio da orientação a objetos é dividir os problemas em partes menores. Ela é a melhor solução para representar p mundo real em termos de escrita em linguagem de programação. 

## Programação Estrutura - Modelo Procedural

------

Nesse paradigma de programação o código era repetido muitas vezes , diferente da POO onde é implementado um conjunto de classes que definem os objetos.

Cada classe determina os **métodos** e os **atributos** de seus objetos. Neste ponto entendemos que *as características* que descrevem  o objeto são também os valores do objeto, logo o reconhecemos como atributo.
Além disso as ações que o objeto é capaz de executar é chamado de **método**. Já a **interface** é o conjunto de métodos que o objeto possui.

### O objeto

O objeto é considerado como algo físico, porém podemos ter outros que são abstratos como pagamentos, marcação de consultas etc. Ele é a instância de sua classe com atributos próprios. Outra definição de objeto que podemos descrever é: 

> "O objeto é qualquer estrutura modular que faz parte de algo. Podendo ser algo físico ou um conceito."

Todo objeto tem em comum:

- Atributos
- Métodos
- Estado

Exemplo de objeto:

| Classe Caneta(Tipos Primitivos) | Atributos | Métodos       |
| ------------------------------- | --------- | ------------- |
| string                          | Modelo    | AbrirCaneta() |
| string                          | Cor       | Escrever()    |
| float                           | Ponta     | Recarregar()  |
| int                             | Carga     | Rabiscar()    |
| bool                            | Tampada   | Tampar()      |

Isso quer dizer que são os dados/informações que descrevem aquele objeto em específico. Um objeto é sempre um tipo de referência, pois ele armazena só o endereço dos dados.

Também temos o **estado** de um objeto que é um conjunto de valores dos atributos em um dado momento.

## Os  Pilares  da  POO

------



#### Abstração

É a habilidade de contextualizar problemas e características do mundo real, transformando-os para o domínio de sistemas de softwares.

#### Encapsulamento

É um mecanismo que permite proteger métodos e atributos de uma classe. A proteção oferecida no encapsulamento é baseada nos **modificadores de acesso**.

|                      Atributos Públicos                      |                    Atributos Privados                    |
| :----------------------------------------------------------: | :------------------------------------------------------: |
| Pode ser acessado ou modificados por todo objeto que instancia uma classe que contém tais atributos. | Só pode ser acessado pelo objeto que instância a classe. |

Outro ponto que vale a pena citar é o termo de **modularização** que é um mecanismo que permite que o sistema seja dividido em partes entre si. 

#### Polimorfismo

O polimorfismo quer dizer várias formas(de refazer nossos códigos, sistemas, etc) e também complementa pelos conceitos de herança e sobrecarga.

#### Herança

A herança é um mecanismo que possibilita a criação de novas classes por meio de uma hierarquia entre elas.

##### Tipos de Herança

- **Simples**: É quando há herança entre duas classes;
- **Múltipla**: É quando uma classe herda características de duas ou mais classes-pai.

##### Definições

- **Classe-Mãe**: A classe principal é chamada de *superclasse* ou classe-mãe.
- **Classe-Filha**: A classe herdada é chamada de classe filha ou *sub-classe*.

##### Generalização

Segundo o conceito de generalização, a classe filha pode estender ou repassar seus métodos e atributos para outra classe. A especialização vem a partir da generalização de uma classe.

##### Especialização

Segundo o conceito de especialização, a classe deve ser o mais detalhada possível; com relação ao objeto que ela classifica, identificando as diferenças da mesma classe.  Nesse ponto, **extensão** é a especialização de uma classe.

Exemplos:

**Veículo** seria uma **generalização** de um classe que se compõem com métodos e atributos em comum entre carro e moto.

**Carro** é uma **especialização** de Veículo, pois além de herdar os componentes ainda especifica novas funções e atributos.

Generalização seria uma **abstração** entre classes que exercem funções parecidas.

------

## A classe

A classe acaba sendo um molde para o objeto. Diferente das _structs_ que guardam o valor em si, as classes guardam o endereço das informações. As variáveis constituem as propriedades e os métodos constituem as funções. Se for seguido da palavra reservada **void** ela não terá nenhum retorno. 

### Instância

Instância é o ato de transformar à classe em um objeto.

### Classes Estáticas

As classes estáticas não podem ser instanciadas, além disso ela sempre estará disponível na memória da aplicação.
Assim como a classe os métodos devemos ser também estáticos.

### Classes Seladas

Este tipo de classe impede que a mesma seja selada garantindo a proteção da classe.

### Interfaces

 Elas trabalham com contratos, ou seja, todas as regras ficam dentro delas. Outro ponto é que as interfaces não precisam dos operadores de acesso. As interfaces só carregam as definições; aquilo que precisa ser feito e não o que tem que fazer.

### Classes Abstratas

Esse tipo de classe não pode ser instaciada. Funciona como uma classe genérica para ser herdada.

### IEquatable

Serve para comparar objetos.

Em fase de estudos...