// calcular 2 numeros e apresenta

Console.WriteLine("Informe o primeiro numero");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero");
double num2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("Soma : " + (num1 + num2));
Console.WriteLine("Subtração : " + (num1 - num2));
Console.WriteLine("Multiplicação : " + (num1 * num2));

if (num2 != 0)
{
    Console.WriteLine("Divisão : " + (num1 / num2));
}
else
{
    Console.WriteLine("Divisão por 0 não é permitida");
}




