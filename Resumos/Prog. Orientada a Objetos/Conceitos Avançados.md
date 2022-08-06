<h1> 🗡 Conceitos avançados </h1>



<h2>Delegates</h2>

<p>É uma forma de delegar uma função para ser executada em outra classe.</p>

Exemplo:

1. Declaramos uma função/método com a palavra reservada <em>"delegate"</em>:

```c#
public class Pagamento
{
	public delegate void Pagar(double valor);
}
```

2. Depois criamos uma outra função com a mesma assinatura e retorno do delegate:

```c#
static void RealizarPagamento(double valor)
{
    Console.WriteLine($"Pago o valor de {valor}");
}
```

3. E por final passamos a função para o delegate

```c#
var pagar = new Pagamento.Pagar(RealizarPagamento);
pagar(25);
```