int valor1 = 0;
int valor2 = 1;

Console.WriteLine("Introducir la cantidad de numeros primos");
valor1 = Int32.Parse(Console.ReadLine());

for (int i = 0; valor2 <= valor1; i++)
{
    if (i % 2 !=0 )
    {
        Console.WriteLine($"La posicion "+valor2+" es un numero primo " + i);
        valor2++;
    }
}