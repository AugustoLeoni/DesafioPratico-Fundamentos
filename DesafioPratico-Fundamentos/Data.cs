using System.Globalization;

namespace DesafioPratico_Fundamentos;

public class Data
{
    public void Atual()
    {
        DateTime DataAtual = DateTime.Now;

        Console.WriteLine("\n" + DataAtual.ToString("dddd MM/dd/yyyy HH:mm:ss t", new CultureInfo("pt-BR")));

        Console.WriteLine(DataAtual.ToString("dd/MM/yyyy", new CultureInfo("pt-BR")));

        Console.WriteLine(DataAtual.ToString("HH:mm:ss t", new CultureInfo("pt-BR")));

        Console.WriteLine(DataAtual.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR")) + "\n");
    }
}
