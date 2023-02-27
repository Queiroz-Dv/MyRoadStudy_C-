# 👋🏾 Padrão de Notificação - Notification Pattern

O padrão Notification é um padrão comum usado no Domain-Driven Design (DDD) para lidar com erros e validação em aplicativos C#. Envolve a criação de uma classe Notification que pode ser usada para acumular erros ou mensagens de validação durante a execução de uma operação de domínio.

Aqui estão as etapas básicas para implementar o padrão Notification com DDD em C#:

1. **Crie uma classe de notificação**: essa classe deve conter uma lista de mensagens de erro ou validação. Você pode definir métodos para adicionar ou remover mensagens da lista.

```c#
public class Notification
{
    private readonly List<string> _messages = new List<string>();

    public IReadOnlyCollection<string> Messages => _messages;

    public void AddMessage(string message)
    {
        _messages.Add(message);
    }

    public void AddMessages(IEnumerable<string> messages)
    {
        _messages.AddRange(messages);
    }

    public bool HasMessages()
    {
        return _messages.Any();
    }
}
```

2. **Implemente a classe Notification no domínio**: Você pode usar a classe Notification em suas entidades ou serviços de domínio para acumular mensagens de erro ou validação.

```c#
public class Order
{
    private readonly Notification _notification = new Notification();
    
    public decimal TotalAmount { get; private set; }

    public void AddProduct(Product product, int quantity)
    {
        if (product == null)
        {
            _notification.AddMessage("Product cannot be null.");
            return;
        }

        if (quantity <= 0)
        {
            _notification.AddMessage("Quantity must be greater than 0.");
            return;
        }

        TotalAmount += product.Price * quantity;
    }

    public Notification GetNotification()
    {
        return _notification;
    }
}
```

3. **Verifique se há notificações na camada de aplicativo**: Após executar uma operação de domínio, você pode verificar se alguma notificação foi adicionada ao objeto Notificação. Se houver alguma notificação, você poderá tratá-la adequadamente.

   ```c#
   public class OrderService
   {
       private readonly IOrderRepository _orderRepository;
   
       public OrderService(IOrderRepository orderRepository)
       {
           _orderRepository = orderRepository;
       }
   
       public void AddProductToOrder(Order order, Product product, int quantity)
       {
           order.AddProduct(product, quantity);
   
           if (order.GetNotification().HasMessages())
           {
               // Handle notifications here.
               // For example, return an error message to the user.
           }
           else
           {
               _orderRepository.Save(order);
           }
       }
   }
   ```

   

Ao usar o padrão de notificação em seu aplicativo DDD, você pode lidar com erros e mensagens de validação com mais eficiência e manter uma base de código limpa e modular.

------

## Outras formas de usar o Notification Pattern

1. **Crie uma classe para suas notificações**: Crie uma classe para representar suas notificações. Essa classe deve conter uma coleção de erros, avisos e outras mensagens.
2. **Definir uma interface de notificação**: Defina uma interface para suas notificações que descreva as propriedades e métodos de sua classe de notificação.

```c#
public interface INotification
{
    bool HasErrors { get; }
    bool HasWarnings { get; }
    bool HasMessages { get; }
    void AddError(string error);
    void AddWarning(string warning);
    void AddMessage(string message);
    IEnumerable<string> GetErrors();
    IEnumerable<string> GetWarnings();
    IEnumerable<string> GetMessages();
}
```

3. Implemente a classe de notificação: implemente a classe de notificação e os métodos definidos na interface de notificação.

```c#
public class Notification : INotification
{
    private readonly List<string> _errors = new List<string>();
    private readonly List<string> _warnings = new List<string>();
    private readonly List<string> _messages = new List<string>();

    public bool HasErrors => _errors.Any();
    public bool HasWarnings => _warnings.Any();
    public bool HasMessages => _messages.Any();

    public void AddError(string error)
    {
        _errors.Add(error);
    }

    public void AddWarning(string warning)
    {
        _warnings.Add(warning);
    }

    public void AddMessage(string message)
    {
        _messages.Add(message);
    }

    public IEnumerable<string> GetErrors()
    {
        return _errors.AsReadOnly();
    }

    public IEnumerable<string> GetWarnings()
    {
        return _warnings.AsReadOnly();
    }

    public IEnumerable<string> GetMessages()
    {
        return _messages.AsReadOnly();
    }
}
```

4. **Use a classe de notificação em seu domínio**: Use a classe de notificação para lidar com erros de validação e outros erros específicos de domínio em seu domínio.

Por exemplo, no construtor de uma entidade de domínio, você pode verificar se os parâmetros de entrada são válidos e, caso contrário, adicionar o erro correspondente ao objeto de notificação.

```c#
public class Order : Entity
{
    public Order(Customer customer, Product product, int quantity, INotification notification)
    {
        if (customer == null)
        {
            notification.AddError("Customer cannot be null.");
        }

        if (product == null)
        {
            notification.AddError("Product cannot be null.");
        }

        if (quantity <= 0)
        {
            notification.AddError("Quantity must be greater than zero.");
        }

        if (notification.HasErrors)
        {
            throw new ArgumentException("Invalid input parameters.");
        }

        // ...
    }

    // ...
}
```

Ao usar o padrão de notificação em DDD, você pode lidar com erros de validação e outros erros específicos do domínio de maneira estruturada e consistente, tornando seu código mais sustentável e fácil de entender.