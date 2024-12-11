namespace DesafioPratico_Fundamentos;

public static class Menu
{
    public static string Show()
    {
        Console.WriteLine("--------------- Exercícios práticos ---------------");
        Console.WriteLine("1 - Mensagem de boas vindas");
        Console.WriteLine("2 - Concatenação de nomes");
        Console.WriteLine("3 - Calculadora");
        Console.WriteLine("4 - Contador de caracteres");
        Console.WriteLine("5 - Verificar placa");
        Console.WriteLine("6 - Data atual");
        Console.WriteLine("7 - Sair");

        Console.Write("Opção: ");
        return Console.ReadLine();
    }
}
