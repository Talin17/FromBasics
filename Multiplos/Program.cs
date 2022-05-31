int valor1 = 0;
int valor2 = 0;

Console.WriteLine("Favor introducir un valor");
valor1 = Int32.Parse(Console.ReadLine());

for (int i = 0; i < valor1; i++)
{
    valor2 = valor1 * i;
    Console.WriteLine(valor1 + $"x" + i + $"=" +valor2);
}