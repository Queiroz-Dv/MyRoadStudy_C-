# 🐱‍💻 Resumos Sobre Strings

## GUIDs

O Guid(_Global Unique Identifier_) serve para identificar elementos e informações com um número identificador. Ele irá gerar um hash de identificação

## Interpolação de Strings

 É uma forma de juntar ou conectar strings o que também é conhecido como concatenação.

 Exemplo:

 ```c#
 var price = 10.2;
 var texto = "O preço do produto é: " + price + "apenas na promoção!";

 ```

Exemplo com string.Format:

```c#
 var price = 10.2;
 var texto = string.Format("O preço do produto é {0} apenas na promoção!", price);

 ```

Exemplo com $ e @ para caracteres especiais:

```c#
 var price = 10.2;
 var texto = $"O preço do produto é {price} apenas na promoção!";

 ```
