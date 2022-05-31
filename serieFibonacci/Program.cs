int numero = 0;
int primero = 0;
int segundo = 1;
int tercero = 0;

Console.WriteLine("Digite el valor de numero");
numero = Int32.Parse(Console.ReadLine());

for (int i = 0; i < numero; i++)
{
    if (i <= 1)
    {
        tercero = i;
    }
    else
    {
        tercero = primero + segundo;
        primero = segundo;
        segundo = tercero;
    }
    Console.WriteLine(tercero);
}