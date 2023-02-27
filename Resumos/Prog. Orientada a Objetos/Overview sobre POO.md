# 🐱‍💻 Programação Orientada a Objetos

------

POO ou Programação Orientada a objetos é um **paradigma da programação**, que neste caso, é como <i>estruturamos o nosso código</i>.
A ideia maio da orientação a objetos é dividir os problemas em partes menores. Ela é a melhor solução para representar o mundo real em termos de escrita em linguagem de programação.

## Programação Estrutural - Modelo Procedural

------

Nesse paradigma de programação o código era repetido muitas vezes , diferente da POO onde é implementado um conjunto de classes que definem os objetos.

------

## Os  Pilares  da  Programação Orientada a Objetos

### A Classe

A classe acaba sendo um molde para o objeto. Diferente das *structs* que **guardam o valor em si**, as *classes* **guardam o endereço das informações**. As variáveis constituem as propriedades e os métodos constituem as funções. Se for seguido da palavra reservada **void** ela não terá nenhum retorno.

```c#
class Car
{
    public string Make;
    public string Model;
    public int Year;
    
    public void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }
    
    public void Drive()
    {
        Console.WriteLine("Driving...");
    }
}
```

Neste exemplo, criamos uma classe chamada "Car" que possui três propriedades públicas: "Make", "Model" e "Year". Ele também possui dois métodos públicos: "StartEngine" e "Drive". Esses métodos simplesmente enviam texto para o console. Podemos criar objetos desta classe assim:

```c#
Car myCar = new Car();
myCar.Make = "Toyota";
myCar.Model = "Camry";
myCar.Year = 2020;

myCar.StartEngine();
myCar.Drive();
```

### A Classe Estática

As classes estáticas não podem ser instanciadas, além disso ela sempre estará disponível na memória da aplicação.
Assim como a classe os métodos devemos ser também estáticos.

```c#
public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}
```

### Classes Seladas

Em C#, uma classe selada é uma classe que não pode ser herdada por outras classes. Isso significa que você não pode criar uma subclasse que estenda uma classe selada. Você pode usar a palavra-chave **sealed** para marcar uma classe como lacrada.

```c#
sealed class MyClass
{
    // Class implementation
}
```

Neste exemplo, `MyClass`é uma classe selada, o que significa que não pode ser herdada por nenhuma outra classe.

Método selado:

```c#
class MyBaseClass
{
    public virtual void MyMethod()
    {
        // Method implementation
    }
}

class MyDerivedClass : MyBaseClass
{
    public sealed override void MyMethod()
    {
        // Method implementation
    }
}
```



#### A Abstração

A abstração na programação orientada a objetos (OOP) é um conceito que permite aos desenvolvedores criar classes incompletas e ocultar seus detalhes de implementação do mundo externo, enquanto ainda fornece uma interface clara e bem definida para interagir com elas.

Em C#, a abstração é obtida usando classes e interfaces abstratas.

Aulas abstratas:

Uma classe abstrata é uma classe que não pode ser instanciada e destina-se a ser subclasse de classes concretas (não abstratas). As classes abstratas são marcadas com a palavra-chave "abstract" e podem conter métodos abstratos e não abstratos. Um método abstrato é um método que é declarado sem uma implementação e sua implementação é adiada para a subclasse.

Exemplo de classe abstrata:

```c#
public abstract class Shape
{
    public abstract double Area();
}
```

**Interfaces**:

Uma interface é um contrato que especifica um conjunto de métodos e propriedades que uma classe deve implementar. Uma interface contém apenas assinaturas de método, propriedades, eventos e indexadores. Não contém detalhes de implementação. Em C#, as interfaces são declaradas usando a palavra-chave "interface".

Exemplo de interface:

```c#
public interface IShape
{
    double Area();
}
```

As classes abstratas e as interfaces fornecem uma maneira de obter abstração em C#, mas servem a propósitos diferentes. As classes abstratas são usadas quando queremos fornecer uma implementação parcial de uma classe, enquanto as interfaces são usadas quando queremos definir um contrato que uma classe deve implementar.

Em geral, ao projetar uma hierarquia de classes, é uma boa prática usar classes abstratas para classes base que fornecem algum comportamento padrão e interfaces para definir contratos que as classes devem implementar.

#### O Encapsulamento

É um mecanismo que permite proteger métodos e atributos de uma classe. A proteção oferecida no encapsulamento é baseada nos **modificadores de acesso**.

|                      Atributos Públicos                      |                    Atributos Privados                    |
| :----------------------------------------------------------: | :------------------------------------------------------: |
| Pode ser acessado ou modificados por todo objeto que instancia uma classe que contém tais atributos. | Só pode ser acessado pelo objeto que instância a classe. |

| Private                       | Protected                      | Internal                             | Public                |
| ----------------------------- | ------------------------------ | ------------------------------------ | --------------------- |
| Visível apenas na  classe pai | Visível para as classes filhos | Disponível apenas no mesmo namespace | Disponível para todos |

Outro ponto que vale a pena citar é o termo de **modularização** que é um mecanismo que permite que o sistema seja dividido em partes entre si.

#### O Polimorfismo

O polimorfismo é outro conceito fundamental da Programação Orientada a Objetos (OOP) que permite que os objetos assumam múltiplas formas. Em C#, o polimorfismo pode ser alcançado por meio do uso de herança, interfaces e substituição de métodos.

1. Polimorfismo de herança: a herança permite que uma classe herde propriedades e comportamento de uma classe pai e, em seguida, modifique ou estenda esse comportamento na classe filho. Isso permite que a classe filha assuma formas diferentes enquanto mantém o comportamento principal da classe pai. Por exemplo:

```c#
public class Animal
{
   public virtual void MakeSound()
   {
      Console.WriteLine("The animal makes a sound");
   }
}

public class Dog : Animal
{
   public override void MakeSound()
   {
      Console.WriteLine("The dog barks");
   }
}

public class Cat : Animal
{
   public override void MakeSound()
   {
      Console.WriteLine("The cat meows");
   }
}
```

No exemplo acima, a `Animal`classe é a classe pai e as classes `Dog`e `Cat`são classes filhas que herdam de `Animal`. Cada classe filha substitui o `MakeSound`método da classe pai para fornecer uma implementação exclusiva do método.

2. Polimorfismo de interface: As interfaces definem um contrato para o comportamento que as classes podem implementar. Isso permite que várias classes implementem a mesma interface e forneçam diferentes implementações dos métodos da interface. Por exemplo:

   ```c#
   public interface IShape
   {
      double GetArea();
   }
   
   public class Circle : IShape
   {
      private double _radius;
   
      public Circle(double radius)
      {
         _radius = radius;
      }
   
      public double GetArea()
      {
         return Math.PI * _radius * _radius;
      }
   }
   
   public class Square : IShape
   {
      private double _sideLength;
   
      public Square(double sideLength)
      {
         _sideLength = sideLength;
      }
   
      public double GetArea()
      {
         return _sideLength * _sideLength;
      }
   }
   ```

   No exemplo acima, a `IShape`interface define um contrato para as classes que a implementam para fornecer um `GetArea`método. As classes `Circle`e `Square`implementam a `IShape`interface e fornecem diferentes implementações do `GetArea`método.

   3. Substituição de método: A substituição de método permite que uma classe filha forneça uma implementação diferente de um método que já está definido na classe pai. Por exemplo:

      ```c#
      public class Vehicle
      {
         public virtual void Drive()
         {
            Console.WriteLine("The vehicle is driving");
         }
      }
      
      public class Car : Vehicle
      {
         public override void Drive()
         {
            Console.WriteLine("The car is driving");
         }
      }
      
      public class Motorcycle : Vehicle
      {
         public override void Drive()
         {
            Console.WriteLine("The motorcycle is driving");
         }
      }
      ```

      No exemplo acima, a `Vehicle`classe define um `Drive`método e as classes `Car`e `Motorcycle`substituem esse método para fornecer uma implementação exclusiva do método.

#### A Herança

A herança é um mecanismo que possibilita a criação de novas classes por meio de uma hierarquia entre elas.

##### Tipos de Herança

- **Simples**: É quando há herança entre duas classes;
- **Múltipla**: É quando uma classe herda características de duas ou mais classes-pai.

##### Definições

- **Classe-Mãe**: A classe principal é chamada de *superclasse* ou *classe-mãe*.
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

### Instância

Instância é o ato de transformar à classe em um objeto.

### Interfaces

 Elas trabalham com contratos, ou seja, todas as regras ficam dentro delas. Outro ponto é que as interfaces não precisam dos operadores de acesso. As interfaces só carregam as definições; aquilo que precisa ser feito e não o que tem que fazer.

### Classes Abstratas

Esse tipo de classe não pode ser instanciada. Funciona como uma classe genérica para ser herdada.

------

Cada classe determina os **métodos** e os **atributos** de seus objetos. Neste ponto entendemos que *as características* que descrevem  o objeto são também os valores do objeto, logo o reconhecemos como atributo.
Além disso as ações que o objeto é capaz de executar é chamado de **método**. Já a **interface** é o conjunto de métodos que o objeto possui.

#### O Objeto

O objeto é considerado como algo físico, porém podemos ter outros que são abstratos como pagamentos, marcação de consultas etc. Ele é a instância de sua classe com atributos próprios. Outra definição de objeto que podemos descrever é:

> "O objeto é qualquer estrutura modular que faz parte de algo. Podendo ser algo físico ou um conceito."

Todo objeto tem em comum:

- Propriedades
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