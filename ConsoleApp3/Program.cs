string[] pronombres2 = new string[3];
string[] pronombres = { "tu", "yo", "Nosotros" };
string bus;
for (int i = 0;i < pronombres2.Length;i++)
{ Console.WriteLine(pronombres2[i]); }
foreach (string s in pronombres)
{
    Console.WriteLine(s);
}
Console.WriteLine("¿A quien desea buscar?");
bus=Console.ReadLine();
for (int x = 0; x < pronombres2.Length; x++)
{
    if (pronombres[x]==bus)
    {
        Console.WriteLine($"Es el piso {x + 1}");
    }
}