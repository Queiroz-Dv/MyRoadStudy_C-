using System.Reflection.Metadata;

Console.WriteLine("-- Queiroz Dv -- ");
Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você já é maior de 18!");
    Console.ReadKey();
}
else if (idade >= 65)
{
    Console.WriteLine("Você é maior de 65!");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Você não tem idade suficiente.");
    Console.ReadKey();
}

const int JUNIOR = 1;
const int PLENO = 2;
const int SENIOR = 3;
Console.WriteLine("Escolha sua categoria na programação:");
Console.WriteLine("1 - Júnior");
Console.WriteLine("2 - Pleno");
Console.WriteLine("3 - Sênior");
int categoria = int.Parse(Console.ReadLine());
switch (categoria)
{
    case JUNIOR:
        Console.WriteLine("Você está no ínicio da jornada! Prossiga estudando! :D");
        Console.ReadKey();
        break;
    case PLENO:
        Console.WriteLine("Você está no meio da jornada! Estude um pouco mais! :D");
        Console.ReadKey();
        break;
    case SENIOR:
        Console.WriteLine("Você está no topo da jornada! Mesmo assim continue estudando :D");
        Console.ReadKey();
        break;

    default:
        Console.WriteLine("Você poderia aprender a programar, volte novamente em breve! :(");
        Console.ReadKey();
        break;
}
