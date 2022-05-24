using RegnvejrsstatistikProjekt;
Console.Write("Antal måleværdier: ");
int _antalMåleværdier;
while (!int.TryParse(Console.ReadLine(), out _antalMåleværdier))
{
    Console.Clear();
    Console.Write("Indtast et tal: ");
}

double[] _måleværdier = new double[_antalMåleværdier];
for (int i = 0; i < _måleværdier.Length; i++)
{
    Console.Write($"Måleværdi for dag [{i + 1}]: ");
    while (!double.TryParse(Console.ReadLine(), out _måleværdier[i]))
    {
        Console.Clear();
        Console.Write("Indtast et tal: ");
    }
}

Menu.RegnMenu(_måleværdier);