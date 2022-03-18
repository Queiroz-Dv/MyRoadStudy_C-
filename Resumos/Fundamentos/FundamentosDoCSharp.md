# 🔮 Fundamentos do CSharp

Este markdown trata-se sobre meus resumos de estudos sobre a linguagem CSharp. cada markdown descreverá uma particularidade do CSharp

## Namespaces

Enquanto as pastas são as divisões físicas, os namespaces são as divisões lógicas. O ideal é que tenha apenas um namespace e uma classe por arquivo.
Um namespace pode ser reutilizado e pode estar presente em diversos arquivos.

Exemplo:

```c#
namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
}

```

## Usings

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

## Tipos Primitivos

São conhecidos como _built-in types_, são tipos base cujo outros tipos irão derivar. Além disso são chamados de _Tipos de Valor_, pois armazenam o valor e não a referência para um item na memória.
São classificados em:

- Tipos Simples
- Enumeradores
- Estruturas
- Tipos Nulos

#### Byte

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
