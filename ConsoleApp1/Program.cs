string[] pronombres2 = new string[3];
string[] pronombres = { "tu", "yo", "Nosotros" };
for (int i = 0; i < pronombres2.Length; i++)
{
    Console.WriteLine($"Ingrese el nombre {i+1}");
    pronombres2[i] = Console.ReadLine();
}
for (int i = 0;i < pronombres2.Length;i++)
{ Console.WriteLine(pronombres2[i]); }
foreach (string s in pronombres)
{
    Console.WriteLine(s);
}
