# Dicas e técnicas de implementações para o Driven Domain Design

## Delegates

Os delegates podem ser usados no Domain-Driven Design (DDD) para encapsular o comportamento e habilitar o baixo acoplamento entre os objetos. Em C#, delegados são objetos que se referem a um método ou grupo de métodos com uma assinatura específica. Os delegados podem ser passados como argumentos, retornados como valores ou armazenados em variáveis.

No DDD, os delegados podem ser usados para definir comportamentos específicos de um conceito de domínio. Por exemplo, você pode definir um delegado que representa uma regra de validação para uma entidade de domínio, como a seguir:

```c#
public delegate bool ValidationRule<in T>(T entity);
```

Este delegado representa uma regra de validação que pega uma entidade do tipo T e retorna um valor booleano que indica se a entidade é válida ou não. Você pode definir regras de validação específicas para diferentes entidades em seu domínio e, em seguida, passá-las para um serviço de validação genérico que usa o delegado para realizar a validação.

```c#
public class ValidationService<T>
{
    public bool Validate(T entity, ValidationRule<T> rule)
    {
        return rule(entity);
    }
}
```

Você pode usar o serviço de validação para validar entidades em seu domínio, assim:

```c#
var customer = new Customer { Name = "John", Age = 20 };
var validationService = new ValidationService<Customer>();

var nameIsValid = validationService.Validate(customer, c => !string.IsNullOrEmpty(c.Name));
var ageIsValid = validationService.Validate(customer, c => c.Age >= 18);
```

Neste exemplo, definimos uma entidade cliente e criamos uma instância do serviço de validação para o tipo Cliente. Em seguida, definimos duas regras de validação usando expressões lambda: uma para validar que o nome do cliente não está vazio e outra para validar que a idade do cliente é maior ou igual a 18 anos. Passamos essas regras para o serviço de validação junto com a entidade cliente , e o serviço retorna true ou false dependendo se a entidade passa na validação.

Delegados também podem ser usados para definir manipuladores de eventos, que são usados para lidar com eventos gerados por entidades de domínio. Por exemplo, você pode definir um delegado para representar um manipulador de eventos para um evento criado pelo cliente, como este:

```c#
public delegate void CustomerCreatedEventHandler(Customer customer);
```

Você pode definir um serviço de domínio que gera esse evento quando um novo cliente é criado, assim:

```c#
public class CustomerService
{
    public event CustomerCreatedEventHandler CustomerCreated;

    public void CreateCustomer(Customer customer)
    {
        // save customer to database
        // ...

        // raise the CustomerCreated event
        CustomerCreated?.Invoke(customer);
    }
}
```

Neste exemplo, definimos um atendimento ao cliente que gera o evento CustomerCreated quando um novo cliente é criado. O manipulador de eventos é representado pelo delegado que definimos anteriormente e pode ser assinado por outros objetos no domínio para executar lógica adicional quando o evento é gerado.

```c#
public class CustomerNotificationService
{
    public CustomerNotificationService(CustomerService customerService)
    {
        customerService.CustomerCreated += OnCustomerCreated;
    }

    private void OnCustomerCreated(Customer customer)
    {
        // send notification to customer
        // ...
    }
}
```

Neste exemplo, definimos um serviço de notificação ao cliente que se inscreve no evento CustomerCreated gerado pelo atendimento ao cliente. Quando o evento é gerado, o método OnCustomerCreated é chamado, que envia uma notificação ao cliente.

Em conclusão, os delegados são um recurso poderoso do C# que pode ser usado no DDD para definir o comportamento e permitir o acoplamento flexível entre os objetos. Eles podem ser usados para definir regras de validação, manipuladores de eventos e outros comportamentos específicos para um conceito de domínio e podem ajudar a tornar seu código mais modular e sustentável.

Aqui está um exemplo de como usar este delegado para definir uma regra de validação para uma `Person`classe:

```c#
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public static class PersonValidationRules
{
    public static bool FirstNameIsValid(string firstName)
    {
        return !string.IsNullOrWhiteSpace(firstName);
    }

    public static bool LastNameIsValid(string lastName)
    {
        return !string.IsNullOrWhiteSpace(lastName);
    }

    public static bool AgeIsValid(int age)
    {
        return age > 0 && age < 120;
    }

    public static ValidationRule<Person> IsValid = person =>
        FirstNameIsValid(person.FirstName) &&
        LastNameIsValid(person.LastName) &&
        AgeIsValid(person.Age);
}
```

Neste exemplo, definimos uma `Person`classe com três propriedades: `FirstName`, `LastName`e `Age`. Também definimos uma classe estática `PersonValidationRules`que contém três regras de validação para `Person`: `FirstNameIsValid`, `LastNameIsValid`e `AgeIsValid`.

O `IsValid`campo é um `ValidationRule<Person>`delegado que recebe um `Person`objeto como entrada e retorna um valor booleano. O delegado é definido usando uma expressão lambda que chama as três regras de validação para `Person`.

Para usar esta regra de validação, você pode chamar o `IsValid`delegado com um `Person`objeto:

```c#
var person = new Person { FirstName = "John", LastName = "Doe", Age = 30 };
bool isValid = PersonValidationRules.IsValid(person);
```

A `isValid`variável conterá `true`se o `Person`objeto satisfizer todas as três regras de validação ou `false`caso contrário.

Essa abordagem pode ser estendida para definir regras de validação mais complexas para objetos. Ao encapsular a lógica de validação em delegados, você pode criar regras de validação reutilizáveis e combináveis que podem ser usadas em toda a sua base de código.