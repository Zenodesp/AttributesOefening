using AttributesOefening;

string getal;



Console.WriteLine("Geef uw getal in. Letters in uw input zullen verwijderd worden.");
getal = Console.ReadLine();

if (getal.Any(char.IsDigit))
{
    GetalString Teste = new GetalString(getal);
    Console.WriteLine(Teste.ToString());
}