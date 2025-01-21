// 14. Soma de números: programa que permita ao usuario inserir numeros inteiros. 0 programa deve continuar até que o usuario digite 0. ao final o pragrama deve exibir e calcular todos os numeros inseridos (exeto o zero). Utilize um laço while para esta tarefa

int numero;
int soma = 0;

Console.WriteLine("Digite números inteiros para somar. Digite 0 para sair.");

numero = int.Parse(Console.ReadLine());


while (numero != 0)
{
    soma += numero;
    numero = int.Parse(Console.ReadLine());
}
Console.WriteLine("Soma total: " + soma);