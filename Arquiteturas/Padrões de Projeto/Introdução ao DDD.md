# Desenvolvimento de Softwares com DDD e  TDD

## O que é a abordagem DDD?

O Domain-Driven Design (DDD) é uma abordagem para desenvolvimento de software que **enfatiza o domínio** do problema e as **regras de negócio**, em vez de apenas se concentrar na implementação técnica. 

## Como funciona a implementação estrutural?

Em C#, o DDD pode ser implementado da seguinte forma:

1. **Defina o domínio do problema (Ubiquitous Language)**: isso envolve identificar as entidades, agregados, valores de objetos, regras de negócio e fluxos de trabalho do seu sistema. O resultado deve ser um modelo de domínio que reflita as necessidades do negócio.
2. **Implemente as entidades do domínio (Entities)**: as entidades representam objetos no domínio do problema. Elas devem ser implementadas como classes C# e possuir identificadores únicos.
3. **Crie os agregados (Aggregates)**: os agregados são grupos de objetos relacionados que são tratados como uma única unidade. Cada agregado deve ser encapsulado dentro de uma classe C#.
4. **Implemente os objetos de valor (Value Objects)**: os objetos de valor representam valores dentro do domínio do problema, como por exemplo, o valor de um preço ou uma data. Eles devem ser imutáveis e serem implementados como classes C#.
5. **Crie os repositórios (Repository Pattern)**: os repositórios são responsáveis por persistir as entidades e agregados no armazenamento de dados. Eles devem ser implementados como interfaces C# e, em seguida, implementados como classes C#.
6. **Implemente as regras de negócio**: as regras de negócio devem ser implementadas como métodos nas entidades e agregados. O objetivo é garantir que o estado do objeto esteja sempre correto e que as operações sejam executadas de acordo com as regras definidas.
7. **Implemente os serviços de aplicação (Services Domain / Application)**: os serviços de aplicação são responsáveis por orquestrar as operações no domínio do problema. Eles devem ser implementados como classes C# e podem ser chamados por meio de APIs ou interfaces de usuário.
8. **Implemente a camada de apresentação (User Interface)**: a camada de apresentação é responsável por fornecer uma interface de usuário para o sistema. Ela pode ser implementada como uma aplicação web, desktop ou mobile.

Ao implementar o DDD em C#, é importante lembrar que *o objetivo é criar um modelo de domínio que reflita as necessidades do negócio* e que seja fácil de entender e manter. O modelo de domínio deve ser a base do sistema e deve ser utilizado para orientar todas as decisões de design e implementação.

------

## Testes e Refatoração em TDD

Test-Driven Development (TDD) é um processo de desenvolvimento de software que envolve escrever testes automatizados antes de escrever o código real. O objetivo é garantir que o código seja de alta qualidade, sustentável e livre de erros. TDD envolve três fases:

1. **Vermelho**: Escreva um teste com falha que descreva o comportamento desejado do código.
2. **Verde**: Escreva o código mais simples possível para fazer o teste passar.
3. **Refatorar**: Melhore o código removendo a duplicação e melhorando o design, sem alterar seu comportamento.

Aqui estão as etapas básicas para executar o TDD em C#:

1. **Escolha uma estrutura de teste**: C# dá suporte a várias estruturas de teste, como MSTest, NUnit e xUnit. Você pode escolher qualquer estrutura que atenda às suas necessidades.
2. **Crie um novo projeto de teste**: No Visual Studio, crie um novo projeto de teste usando a estrutura de teste escolhida. Este projeto conterá todos os testes de unidade para o seu código.
3. **Escreva um teste com falha**: Escreva um teste que descreva o comportamento desejado do código. O teste deve falhar porque o código ainda não foi implementado.
4. **Escreva o código mais simples possível**: Escreva o código mais simples possível para fazer o teste passar. Este código não deve ser perfeito, mas deve ser apenas o suficiente para fazer o teste passar.
5. **Refatorar**: Melhore o código removendo a duplicação e melhorando o design, sem alterar seu comportamento. A refatoração garante que o código permaneça sustentável e fácil de ler.
6. **Repita**: repita as etapas 3 a 5 até que todas as funcionalidades necessárias tenham sido implementadas.
7. **Execute todos os testes**: execute todos os testes para garantir que todas as funcionalidades foram implementadas corretamente e que nenhum novo bug foi introduzido.
8. **Refatore novamente**: Refatore o código para torna-lo mais limpo e de fácil manutenção e execute todos os testes novamente para garantir que tudo ainda funcione.

Ao seguir essas etapas, você pode garantir que seu código seja totalmente testado e funcione conforme o esperado. O TDD é uma técnica valiosa para melhorar a qualidade do seu código e garantir que ele permaneça sustentável ao longo do tempo.

------

## Criando entidades em DDD

1. **Defina o modelo de domínio**: Comece definindo o modelo de domínio e identificando as entidades, suas propriedades e comportamento. Uma entidade é um objeto que possui uma identidade única e se distingue de outros objetos com base nessa identidade. Por exemplo, se você estiver modelando uma livraria, um livro pode ser uma entidade.
2. **Crie a classe Entity**: Crie uma classe para sua entidade em C#. Esta classe deve possuir uma propriedade identificadora única, que é utilizada para diferenciá-la de outras entidades do mesmo tipo. Essa propriedade do identificador deve ser imutável e definida apenas uma vez, preferencialmente no momento da criação.

```c#
public class Book
{
    public Guid Id { get; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(Guid id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }
}
```

3. **Implementar classes de objeto de valor**: em alguns casos, as entidades podem conter propriedades que podem ser decompostas em partes menores. Por exemplo, a propriedade "Endereço" de uma entidade "Cliente" pode ser decomposta em rua, cidade, estado e CEP. Nesses casos, você pode criar classes separadas para essas partes menores, chamadas de "Objetos de valor".

4. **Implemente a lógica de negócios na classe Entity**: Entidades podem conter comportamento que pode ser usado para modificar seu estado ou interagir com outras entidades. Você pode implementar esse comportamento como métodos na classe Entity. Por exemplo, uma entidade de livro pode ter um método "Emprestado" para indicar que o livro foi emprestado por alguém.

   ```c#
   public class Book
   {
       public Guid Id { get; }
       public string Title { get; set; }
       public string Author { get; set; }
       public bool IsBorrowed { get; private set; }
   
       public Book(Guid id, string title, string author)
       {
           Id = id;
           Title = title;
           Author = author;
       }
   
       public void Borrow()
       {
           if (IsBorrowed)
           {
               throw new InvalidOperationException("Book is already borrowed.");
           }
   
           IsBorrowed = true;
       }
   }
   ```

   **Use a entidade em seu aplicativo**: agora você pode usar a entidade em seu aplicativo criando uma instância da classe Entity e definindo suas propriedades. Você também pode chamar métodos na entidade para modificar seu estado.

   ```c#
   // Create a new book entity
   var book = new Book(Guid.NewGuid(), "Domain-Driven Design", "Eric Evans");
   
   // Borrow the book
   book.Borrow();
   ```

   Seguindo estas etapas, você pode implementar uma entidade simples em DDD usando C#. Lembre-se de que os princípios-chave do DDD são focar no modelo de domínio e criar uma linguagem onipresente que seja compartilhada por todas as partes interessadas. Portanto, é importante reservar um tempo para entender o domínio que você está modelando e criar um modelo de domínio que reflita com precisão esse domínio.

   ------

   ## Como implementar um Value Object

   - **Defina o objeto de valor**: um objeto de valor representa um conceito ou dados que são importantes para o domínio, mas não possuem uma identidade própria. Por exemplo, um valor em dinheiro pode ser representado como um objeto de valor. Defina as propriedades do Value Object que representam seus atributos.

     ```c#
     public class Money
     {
         public decimal Amount { get; private set; }
         public string Currency { get; private set; }
     
         public Money(decimal amount, string currency)
         {
             Amount = amount;
             Currency = currency;
         }
     }
     ```

   - **Substitua os métodos Equals e GetHashCode**: Como os Value Objects não possuem uma identidade própria, eles são comparados com base em seus atributos. Substitua os métodos Equals e GetHashCode para comparar os atributos do Value Object.

     ```c#
     public override bool Equals(object obj)
     {
         if (obj == null || GetType() != obj.GetType())
         {
             return false;
         }
     
         var other = (Money)obj;
         return Amount == other.Amount && Currency == other.Currency;
     }
     
     public override int GetHashCode()
     {
         return HashCode.Combine(Amount, Currency);
     }
     ```

   - **Tornar o objeto de valor imutável**: para garantir que os atributos do objeto de valor não sejam alterados acidentalmente, torne a classe imutável tornando suas propriedades somente leitura.

     ```c#
     public class Money
     {
         public decimal Amount { get; }
         public string Currency { get; }
     
         public Money(decimal amount, string currency)
         {
             Amount = amount;
             Currency = currency;
         }
     }
     ```

   - **Use o objeto de valor no domínio**: use o objeto de valor como uma propriedade ou parâmetro em outras classes de domínio. Por exemplo, se você tiver uma classe de domínio chamada "Payment" que tenha uma propriedade "Amount", use o objeto Money Value como o tipo da propriedade.

     ```c#
     public class Payment
     {
         public Money Amount { get; }
     
         public Payment(Money amount)
         {
             Amount = amount;
         }
     }
     ```

Com essas etapas, você implementou um Value Object em DDD usando C#. Lembre-se de seguir os princípios do DDD e manter seu modelo de domínio limpo e compreensível.