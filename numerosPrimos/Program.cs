int numeroUser = 0;
int divisibles = 0;

Console.WriteLine("Favor ingresar numero");
numeroUser = Int32.Parse(Console.ReadLine());

for (int i = 1; i < numeroUser; i++)
{
    divisibles = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            divisibles++;
        }
    }
    if (divisibles <= 2)
    {
        Console.WriteLine($"{i} Es primo");
    }
}