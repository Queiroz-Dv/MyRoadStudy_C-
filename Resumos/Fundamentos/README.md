# 🔮 Fundamentos do CSharp

# Bases Estruturais

### Namespaces

Enquanto as pastas são as divisões físicas, os namespaces são as divisões lógicas. O ideal é que tenha apenas um namespace e uma classe por arquivo.
Um namespace pode ser reutilizado e pode estar presente em diversos arquivos.

Exemplo:

```c#
namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
}

```

### Usings

As importações definem as bibliotecas que nposso programa irá utilizar.
Para isso utilizamos a palavra reservada _using_.
Ele serve para organizar nosso código em pastas e namespaces o que é fundamental.

### Variáveis

Uma variável é algo que utilizamos para armazenar uma informação.
Significa que seu valor pode ser alterado a qualquer momento. Sempre que criamos uma variável, dizemos que estamos inicializando elas.

- Podemos usar um tipo ou a palavra reservada _var_ para criar uma variável.

- No CSharp o tipo vem sempre antes do nome da variável.

- Se não informado o valor padrão será aplicado.

Exemplo:

```c#
int idade; // Correto inicia com zero
int idade = 25; // Correto
var idade = 25; // Correto
var idade; // Errado

```

### Constantes

Diferente das variáveis as constantes não podem ser alteradas. Uma vez criadas somos obrigados a atribuir um valor para elas.
A definição das constantes é dada pela palavra reservada _const_ antes do tipo

Exemplo:

```c#
const int IDADE_MINIMA; // Correto inicia com zero
const int IDADE_MINIMA = 25; // Correto
const var IDADE_MINIMA = 25; // Correto
const var IDADE_MINIMA; // Errado

```

- É comum o uso de constantes com letras maiúsculas.

# Tipos Primitivos

São conhecidos como _built-in types_, são tipos base cujo outros tipos irão derivar. Além disso são chamados de _Tipos de Valor_, pois armazenam o valor e não a referência para um item na memória.
São classificados em:

- Tipos Simples
- Enumeradores
- Estruturas
- Tipos Nulos

### Byte

O typo byte é utilizado para representar um byte de fato. Em diversos casos precisamos da cadeia de bytes de um arquivo por exemplo que neste caso são chamados de _byte array_.

### Números Inteiros

Numeros inteiros, ou sejam sem pontuação podem ser definidos pelos tipos:

- short / ushort
- int / uint
- long / ulong

### Números Reais

São números que exigem uma maior precisão, ou seja, com pontuação.

- float
- double
- decimal

### Boolean

 O tipo booliano armazena apenas true ou false e definido pela palavra reservada _bool_. É composto por 8 bit.

### Char

 Utilizado apara aramzenar apenas um caractere no formato Unicode É definido pela palavra reservada _char_. A sua atribuição é dada por aspas simples. É composto por 16 bit.

### String

É utilizado para armazenar uma cadeia de caraceteres, podemos abstrari/pensar nele como uma lista de char. É definidido pela palavra reservada _string_ e sua atribuição é dada por aspas duplas.

### Var

Substitui o nome de um tipo. Será do tipo do primeiro valor em que ocorre sua atribuição. Só podemos usar o _var_ quando já dominamos os tipos primitivos.

### Object

Tipo genérico que recebe qualquer valor ou objeto. Ele não possui ajuda do intelisense(Ajuda dos editores) por ser um tipo desconhecido. Recomenda-se evitar usá-.

### Nullabes Types

Significa vazio, nada. Além disso é diferente de zero ou uma string vazia. Todo tipo primitivo ou complexo pode receber o valor null.

# Conversões

É comum precisarmos transformar um dado de tipo X para tipo Y. Neste caso, existem dois tipos de conversões que são as implícitas e as explícitas.

### Conversão Implicita

As implícitas são conversões que podem ser executadas com passagem de dados.

Exemplo:

```c#
float valor = 25.8f;
int outro = 25;

valor = outro; // Conversão implícita 

```

A conversão só ocorre se os tipos forem compatíveis.

### Conversão Explícita

Ocorre quando os tipos não são compatíveis.

```c#
int inteiro = 100
uint inteiroSemSinal = (uint) inteiro; // Conversão explícita 

```

### Parse

Método presente em todo tipo primitivo. É usado para converter um caractere ou string para um tipo qualquer.
O parse neste caso sempre espera uma string..

```c#
int inteiro = int.Parse("100");

```

### Convert

Similar ao parse porém permite converter vários tipos de valor, e não se limita apenas a string.

```c#
int inteiro = Convert.ToInt32("100");

```

# Operadores

### Operadores Aritméticos

São utilizados os sinais de aritmética para executar operações matemáticas como: soma, subtração, multiplicação e divisão.

### Operadores de Atribuição

Utilizamdos igual para atribuir um valor, porém podemos utilizar igual junto a um operador aritmético.

```c#
int x = 0;
x += 5;
x *= 10;
x/=2;
```

### Operadores de Comparação

Podemos comparar qualquer tipo de dado, a comparação se,pre retorna _verdadeiro_ ou _falso_.

== Igual
!= Diferente
">" Maior
"<" Menor
">=" Maior ou igual  a
"<=" Menorr ou igual a

### Operadores Lógicos

É utilizado para operações condicionais onde retorna sempre verdadeiro ou falso.

- && deve atender todas as condições
- || se atender uma condição já retorna verdadeiro
- ! negação que inverte os valores.
