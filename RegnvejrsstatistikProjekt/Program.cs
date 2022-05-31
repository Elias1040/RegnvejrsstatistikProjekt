using RegnvejrsstatistikProjekt;
Console.Write("Antal måleværdier: ");
int _antalMåleværdier;

// Validere om det kan konverteres til int med TryParse
while (!int.TryParse(Console.ReadLine(), out _antalMåleværdier))
{
    Console.Clear();
    Console.Write("Indtast et tal: ");
}

double[] _måleværdier = new double[_antalMåleværdier];
for (int i = 0; i < _måleværdier.Length; i++)
{
    Console.Write($"Måleværdi for dag [{i + 1}]: ");
    // Validere om det kan konverteres til double med TryParse
    while (!double.TryParse(Console.ReadLine(), out _måleværdier[i]))
    {
        Console.Clear();
        Console.Write("Indtast et tal: ");
    }
}

// Kalder en switch-case menu
Menu.RegnMenu(_måleværdier);