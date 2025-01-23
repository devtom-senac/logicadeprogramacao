/* 
*/

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Qual o sua idade?");
double idade = double.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine($" {nome}, você é maior de idade {idade}");
}
else if (idade >= 16)
{
    Console.WriteLine($" {nome}, você pode entrar com autorização {idade}");
}
else
{
    Console.WriteLine($" {nome}, você é menor de idade {idade} ");
}
