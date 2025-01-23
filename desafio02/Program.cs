// Adapte o programa abaixo para solicitar a idade do usuario. Se usuario +18 exibir a mensagem "maior de idade" se não , exibira mensagem "menor de idade"

Console.WriteLine("Digite sua idade: ");

int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("maior de idade");
} else if (idade >= 16)
{
    Console.WriteLine("Você pode entrar com autorização");
} else
{
    Console.WriteLine("menor de idade");
}

