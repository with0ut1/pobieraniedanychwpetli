Console.Write("Podaj liczbę ocen: ");
int liczbaOcen = int.Parse(Console.ReadLine());

int[] oceny = new int[liczbaOcen];

for (int i = 0; i < liczbaOcen; i++)
{
    Console.Write($"Podaj ocenę {i + 1}: ");
    oceny[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nWprowadzone oceny:");
for (int i = 0; i < liczbaOcen; i++)
{
    Console.WriteLine($"Ocena {i + 1}: {oceny[i]}");
}