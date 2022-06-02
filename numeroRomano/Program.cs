string getUnidad(int unidad)
{
    switch (unidad)
    {
        case 1:
            return "I";
        case 2:
            return "II";
        case 3:
            return "III";
        case 4:
            return "IV";
        case 5:
            return "V";
        case 6:
            return "VI";
        case 7:
            return "VII";
        case 8:
            return "VIII";
        case 9:
            return "IX";

        default:
            return "";

    }
}
string getDecena(int decena)
{
    switch (decena)
    {
        case 1:
            return "X";
        case 2:
            return "XX";
        case 3:
            return "XXX";
        case 4:
            return "XL";
        case 5:
            return "L";
        case 6:
            return "LX";
        case 7:
            return "LXX";
        case 8:
            return "LXXX";
        case 9:
            return "XC";

        default:
            return "";

    }
}
string getCentena(int centena)
{
    switch (centena)
    {
        case 1:
            return "C";
        case 2:
            return "CC";
        case 3:
            return "CCC";
        case 4:
            return "CD";
        case 5:
            return "D";
        case 6:
            return "DC";
        case 7:
            return "DCC";
        case 8:
            return "DCCC";
        case 9:
            return "CM";
        default:
            return "";
    }
}

int numero = 0;
int unidad = 0;
int decena = 0;
int centena =0;

Console.WriteLine("Favor introduzca el numero");
numero = Int32.Parse(Console.ReadLine());

centena = (numero / 100) * 100;
decena = numero - centena;
unidad = numero -centena;
centena = centena / 100;
decena = decena / 10;
unidad = unidad - decena * 10;


Console.WriteLine($"{getCentena(centena)}{getDecena(decena)}{getUnidad(unidad)}");