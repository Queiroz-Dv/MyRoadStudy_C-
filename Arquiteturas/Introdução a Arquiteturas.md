# Breve introdução a arquiteturas

## Arquitetura de três camadas

A arquitetura de camadas visa a criação de aplicativos modulares, onde cada camada possui uma responsabilidade.
A organização estrutura é que a camada superior se comunique com a camada inferior, fazendo assim com que cada camada seja dependente da camada imediatamente inferior.

A mais conhecida é a arquitetura de três camadas:

- Camada de Interface
- Camada de Lógica de Negócios
- Camada de Acesso a Dados

------

Na arquitetura de software, a camada de domínio é uma camada de um aplicativo que contém a lógica de negócios e os modelos de domínio do sistema. A camada de domínio em C# geralmente consiste nos seguintes componentes:

1. Modelos de Domínio: São os objetos que representam as entidades e os objetos de valor do sistema. Eles contêm o estado e o comportamento dos conceitos de domínio.
2. Serviços: São as classes que encapsulam a lógica de negócios do sistema. Eles usam modelos de domínio para executar operações e fornecer funcionalidade aos controladores do aplicativo ou interfaces de usuário.
3. Repositórios: São as classes que fornecem acesso aos dados para os modelos de domínio. Eles encapsulam as operações de recuperação e persistência de objetos de domínio em um armazenamento de dados.

Aqui está um exemplo de um modelo de domínio simples e serviço em C#:

```c#
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.", nameof(amount));
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.", nameof(amount));
        }

        if (Balance < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;
    }
}

public class CustomerService
{
    private readonly IRepository<Customer> _repository;

    public CustomerService(IRepository<Customer> repository)
    {
        _repository = repository;
    }

    public void Deposit(int customerId, decimal amount)
    {
        var customer = _repository.GetById(customerId);

        if (customer == null)
        {
            throw new InvalidOperationException($"Customer with ID {customerId} not found.");
        }

        customer.Deposit(amount);
        _repository.Update(customer);
    }

    public void Withdraw(int customerId, decimal amount)
    {
        var customer = _repository.GetById(customerId);

        if (customer == null)
        {
            throw new InvalidOperationException($"Customer with ID {customerId} not found.");
        }

        customer.Withdraw(amount);
        _repository.Update(customer);
    }
}
```

Neste exemplo, a `Customer`classe é um modelo de domínio que representa uma entidade cliente no sistema. Ele contém o estado e o comportamento de um cliente, como nome do cliente, data de nascimento, saldo e métodos de depósito e retirada de fundos.

A `CustomerService`classe é um serviço que encapsula a lógica de negócios do sistema. Ele usa a `IRepository<Customer>`interface para acessar os dados do cliente, recupera um cliente por ID e chama o método apropriado no cliente para realizar um depósito ou retirada. Por fim, o `CustomerService`atualiza os dados do cliente no repositório.

Este exemplo demonstra o uso da camada de domínio para encapsular a lógica de negócios do sistema e mantê-la separada das camadas de apresentação e acesso a dados. Os modelos de domínio contêm o estado e o comportamento do sistema, enquanto os serviços fornecem a funcionalidade e operam nos modelos de domínio para atender aos requisitos de negócios.

------



## Arquitetura Cebola

Esta baseada no princípio da inversão de controle e é composta por várias camadas concêntricas que se interconectam em direção ao núcleo que representa o domínio.
Além disso, ela não depende da camada de dados como nas arquiteturas em várias camadas, mas dos modelos de domínios reais.
E por fim, resolve o problema do acoplamento entre camadas definindo camadas a partir do núcleo para a infraestrutura.

- O aplicativo é construído em torno de um modelo de objeto independente(o domínio)

- Camadas internas definem  interfaces. As camadas externas implementam interfaces.

- A direção do acoplamento é em direção ao centro.

- Todo código principal pode ser compilado e executado separadamente da infraestrutura.

------



In C#, you can use events and delegates to implement notification patterns. Here is an example of how to implement a notification pattern using events and delegates:

1. Define a delegate that specifies the signature of the event handler method:

```c#
public delegate void NotificationEventHandler(object sender, NotificationEventArgs e);
```

1. Define a class to hold any data you want to send with the notification:

```c#
public class NotificationEventArgs : EventArgs
{
    public string Message { get; set; }
}
```

1. Define a class that will raise the notification event:

```c#
public class Notifier
{
    public event NotificationEventHandler Notification;

    public void RaiseNotification(string message)
    {
        Notification?.Invoke(this, new NotificationEventArgs { Message = message });
    }
}
```

1. Subscribe to the notification event in your application code:

```c#
Notifier notifier = new Notifier();
notifier.Notification += OnNotification;

private void OnNotification(object sender, NotificationEventArgs e)
{
    // Handle the notification
}
```

1. Raise the notification from the Notifier class:

```c#
notifier.RaiseNotification("Notification message");
```

This is just one example of how to implement a notification pattern in C# using events and delegates. There are many variations and approaches to implementing this pattern, depending on the specific requirements of your application.



------

Em C#, a camada de serviço é uma parte da arquitetura de software que fica entre a camada de apresentação (como uma interface do usuário da web ou aplicativo móvel) e a camada de acesso a dados (como um banco de dados ou sistema de arquivos). A camada de serviço é responsável por implementar a lógica de negócios e coordenar a comunicação entre a camada de apresentação e a camada de acesso a dados.

Aqui estão os principais recursos de uma camada de serviço em C#:

1. Separação de interesses: A camada de serviço fornece uma separação limpa de interesses entre a camada de apresentação e a camada de acesso a dados. A camada de apresentação é responsável por exibir os dados para o usuário, enquanto a camada de acesso a dados é responsável por armazenar e recuperar os dados. A camada de serviço atua como um mediador entre essas camadas e implementa a lógica de negócios.
2. Encapsulamento da lógica de negócios: A camada de serviço encapsula a lógica de negócios do aplicativo. Isso facilita a alteração da implementação da lógica de negócios sem afetar a camada de apresentação ou a camada de acesso a dados.
3. Reutilização: A camada de serviço fornece um conjunto de serviços reutilizáveis que podem ser usados por várias camadas de apresentação. Isso reduz a duplicação de código e facilita a manutenção do aplicativo.
4. Injeção de dependência: A camada de serviço pode ser implementada usando injeção de dependência. Isso facilita o teste de unidade do aplicativo, pois as dependências podem ser simuladas ou substituídas por implementações de teste.
5. Tratamento de exceções: A camada de serviço é responsável por tratar as exceções que ocorrem durante a execução da lógica de negócios. Isso inclui registrar a exceção, fornecer uma mensagem de erro ao usuário e reverter todas as transações que foram iniciadas.

No geral, a camada de serviço é uma parte importante de uma arquitetura de software bem projetada em C#. Ele fornece uma separação clara de preocupações, encapsula a lógica de negócios e fornece um conjunto de serviços reutilizáveis que podem ser usados por várias camadas de apresentação.

------



O padrão Repository é um padrão de design popular em C# usado para abstrair a camada de persistência de dados de um aplicativo. Ele fornece uma maneira de desacoplar a lógica do aplicativo da camada de acesso a dados, facilitando o gerenciamento e a manutenção de ambas as camadas de forma independente.

Em poucas palavras, o padrão Repository define um conjunto de interfaces e classes que representam as entidades de dados no aplicativo, bem como as operações que podem ser executadas nessas entidades. Essas operações incluem operações CRUD (Criar, Ler, Atualizar, Excluir) e consultas que recuperam dados específicos.

Aqui está um exemplo de implementação do padrão Repository em C#:

```c#
public interface IRepository<T>
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
}

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public Repository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }
}

```



Neste exemplo, a `IRepository`interface define as operações básicas que podem ser executadas em uma entidade de dados. A `Repository`classe então implementa essa interface e fornece a implementação real dessas operações usando o Entity Framework.

Usando o padrão Repository, você pode trocar facilmente a implementação da camada de persistência de dados sem afetar a lógica do aplicativo. Isso facilita o teste de unidade do aplicativo, pois você pode substituir facilmente a camada de dados real por uma implementação simulada durante o teste.

No geral, o padrão Repository é um padrão de design útil em C# que pode ajudar a simplificar o gerenciamento e a manutenção de aplicativos complexos ao desacoplar a lógica do aplicativo da camada de acesso a dados.

------

Um padrão de serviço em C# é um padrão de design comum usado para encapsular a lógica de negócios e o acesso a dados em uma camada separada de um aplicativo. A camada de serviço é responsável por executar operações e fornecer funcionalidade aos controladores do aplicativo ou interfaces de usuário.

O padrão de serviço geralmente consiste em três componentes:

1. Interface de Serviço: Esta interface define o contrato do serviço e as operações que podem ser executadas pelo serviço.
2. Implementação de serviço: essa classe implementa a interface de serviço e fornece a implementação real das operações de serviço.
3. Service Factory: Esta classe é responsável por criar instâncias da implementação do serviço e fornecê-las aos demais componentes da aplicação que precisam utilizar o serviço.

Aqui está um exemplo de interface de serviço simples e implementação em C#:

```c#
public interface ICustomerService
{
    List<Customer> GetCustomers();
    Customer GetCustomerById(int id);
    void AddCustomer(Customer customer);
}

public class CustomerService : ICustomerService
{
    private readonly IRepository<Customer> _repository;

    public CustomerService(IRepository<Customer> repository)
    {
        _repository = repository;
    }

    public List<Customer> GetCustomers()
    {
        return _repository.GetAll().ToList();
    }

    public Customer GetCustomerById(int id)
    {
        return _repository.GetById(id);
    }

    public void AddCustomer(Customer customer)
    {
        _repository.Add(customer);
    }
}
```

Neste exemplo, a `ICustomerService`interface define três operações que podem ser executadas pelo serviço: `GetCustomers()`, `GetCustomerById(int id)`e `AddCustomer(Customer customer)`.

A `CustomerService`classe implementa a `ICustomerService`interface e fornece a implementação real das operações de serviço. Ele usa uma instância da `IRepository<Customer>`interface para acessar os dados do cliente.

A `CustomerService`classe pode ser instanciada por uma fábrica de serviços, que é responsável por criar a instância da `CustomerService`classe e fornecê-la aos demais componentes da aplicação que precisam utilizar o serviço.

------

O padrão de especificação é um padrão de design que permite definir regras ou condições de negócios complexas de maneira reutilizável e fácil de manter. É frequentemente usado em sistemas de software onde você precisa filtrar ou pesquisar dados com base em um conjunto de regras.

Em C#, você pode implementar o padrão de especificação usando interfaces e classes. Aqui está um exemplo de implementação:

```c#
public interface ISpecification<T>
{
    bool IsSatisfiedBy(T entity);
}

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _spec1;
    private readonly ISpecification<T> _spec2;

    public AndSpecification(ISpecification<T> spec1, ISpecification<T> spec2)
    {
        _spec1 = spec1;
        _spec2 = spec2;
    }

    public bool IsSatisfiedBy(T entity)
    {
        return _spec1.IsSatisfiedBy(entity) && _spec2.IsSatisfiedBy(entity);
    }
}

public class OrSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _spec1;
    private readonly ISpecification<T> _spec2;

    public OrSpecification(ISpecification<T> spec1, ISpecification<T> spec2)
    {
        _spec1 = spec1;
        _spec2 = spec2;
    }

    public bool IsSatisfiedBy(T entity)
    {
        return _spec1.IsSatisfiedBy(entity) || _spec2.IsSatisfiedBy(entity);
    }
}

public class NotSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _spec;

    public NotSpecification(ISpecification<T> spec)
    {
        _spec = spec;
    }

    public bool IsSatisfiedBy(T entity)
    {
        return !_spec.IsSatisfiedBy(entity);
    }
}

```

Nesta implementação, `ISpecification`é uma interface que define um método `IsSatisfiedBy`que retorna um valor booleano indicando se uma entidade atende à condição definida pela especificação.

`AndSpecification`, `OrSpecification`, e `NotSpecification`são classes de especificação concretas que implementam a `ISpecification`interface. `AndSpecification`e `OrSpecification`permite combinar várias especificações usando operações lógicas AND e OR, respectivamente. `NotSpecification`nega uma determinada especificação.

```c#
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsInStock { get; set; }
}

public class ProductNameSpecification : ISpecification<Product>
{
    private readonly string _name;

    public ProductNameSpecification(string name)
    {
        _name = name;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return product.Name == _name;
    }
}

public class ProductPriceSpecification : ISpecification<Product>
{
    private readonly decimal _price;

    public ProductPriceSpecification(decimal price)
    {
        _price = price;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return product.Price == _price;
    }
}

public class ProductInStockSpecification : ISpecification<Product>
{
    public bool IsSatisfiedBy(Product product)
    {
        return product.IsInStock;
    }
}

var spec1 = new ProductNameSpecification("Apple");
var spec2 = new ProductPriceSpecification(2.99m);
var spec3 = new ProductInStockSpecification();

var andSpec = new AndSpecification<Product>(spec1, spec2);
var orSpec = new OrSpecification<Product>(spec2, spec3);
var not

```

O padrão de especificação é um padrão de design usado na programação orientada a objetos para encapsular regras de negócios que determinam se um objeto atende a determinados critérios ou não. O padrão é usado para separar a lógica da regra de negócios da implementação da entidade que está sendo avaliada.

Em C#, o padrão Specification pode ser implementado usando interfaces e classes. Aqui está um exemplo de implementação:

```c#
// Specification interface
public interface ISpecification<T>
{
    bool IsSatisfiedBy(T entity);
}

// Concrete specification classes
public class PriceSpecification : ISpecification<Product>
{
    private readonly decimal _maxPrice;

    public PriceSpecification(decimal maxPrice)
    {
        _maxPrice = maxPrice;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return product.Price <= _maxPrice;
    }
}

public class NameSpecification : ISpecification<Product>
{
    private readonly string _name;

    public NameSpecification(string name)
    {
        _name = name;
    }

    public bool IsSatisfiedBy(Product product)
    {
        return product.Name.Equals(_name, StringComparison.InvariantCultureIgnoreCase);
    }
}

// Entity class
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

// Usage example
var products = new List<Product>
{
    new Product { Id = 1, Name = "Product A", Price = 10 },
    new Product { Id = 2, Name = "Product B", Price = 20 },
    new Product { Id = 3, Name = "Product C", Price = 30 },
};

var cheapProducts = products.Where(new PriceSpecification(15).IsSatisfiedBy);
var productB = products.FirstOrDefault(new NameSpecification("Product B").IsSatisfiedBy);
```

Neste exemplo, `ISpecification<T>`é a interface de especificação que define o `IsSatisfiedBy`método, que retorna um Boolean indicando se uma entidade do tipo `T`atende a especificação.

As classes `PriceSpecification`e `NameSpecification`são implementações concretas da `ISpecification<Product>`interface. `PriceSpecification`verifica se o preço de um produto é menor ou igual a um determinado preço máximo, enquanto `NameSpecification`verifica se o nome de um produto corresponde a um determinado nome.

A `Product`classe é a entidade que está sendo avaliada pelas especificações.

O exemplo mostra como as especificações podem ser usadas para filtrar uma lista de produtos por preço e localizar um produto específico por nome. `cheapProducts`contém os produtos com preço de US$ 15 ou menos e `productB`contém o produto com o nome "Produto B".

------

A implementação de uma camada de aplicativo em C# geralmente envolve a criação de um conjunto de classes que representam a lógica de negócios de seu aplicativo. Aqui estão algumas etapas gerais a serem seguidas:

1. Defina as entidades de negócios: comece definindo as entidades que seu aplicativo irá manipular. Por exemplo, se você estiver construindo um aplicativo de comércio eletrônico, suas entidades podem incluir Produto, Cliente, Pedido e assim por diante.
2. Defina os serviços de aplicativo: Identifique os serviços que seu aplicativo fornece. Por exemplo, seus serviços podem incluir ProductService, CustomerService e OrderService. Esses serviços serão responsáveis por executar a lógica de negócios que seu aplicativo requer.
3. Implemente os serviços de aplicativo: implemente cada serviço como uma classe que fornece métodos para executar as operações necessárias. Por exemplo, ProductService pode incluir métodos para adicionar um novo produto, atualizar um produto existente e recuperar uma lista de todos os produtos.
4. Implementar acesso a dados: você provavelmente precisará acessar um banco de dados ou outra fonte de dados para recuperar e manter suas entidades. Implemente uma camada de acesso a dados usando técnicas como Entity Framework ou ADO.NET.
5. Implemente testes de camada de aplicativo: escreva testes para seus serviços de aplicativo para garantir que funcionem corretamente. Você pode usar uma estrutura de teste como NUnit ou MSTest para automatizar seus testes.

Aqui está um trecho de código de exemplo que mostra como definir uma classe simples de ProductService:

```c#
public class ProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public void AddProduct(Product product)
    {
        // Add business logic here
        _repository.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        // Add business logic here
        _repository.Update(product);
    }

    public List<Product> GetAllProducts()
    {
        // Add business logic here
        return _repository.GetAll();
    }
}
```

Neste exemplo, a classe ProductService tem métodos para adicionar, atualizar e recuperar produtos. A classe usa um objeto IProductRepository como uma dependência no construtor, o que permite interagir com a camada de acesso a dados.