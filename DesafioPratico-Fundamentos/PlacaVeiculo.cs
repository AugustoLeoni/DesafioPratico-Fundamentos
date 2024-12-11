namespace DesafioPratico_Fundamentos;

public static class PlacaVeiculo
{
    public static bool Validacao(string placa)
    {
        int numeroCaracters = 7;
        string caracteresLetras;
        string caracteresNumeros;

        if(placa.Length != numeroCaracters)
        {
            Console.WriteLine("Numero de caracteres deve ser 7");
            return false;
        }

        caracteresLetras = placa.Substring(0, 3);

        foreach(char letra in caracteresLetras)
        {
            int i;
            var teste = int.TryParse(letra.ToString(), out i);
            
            if(teste)
            {
                Console.WriteLine("Os 3 primeiros caracteres devem ser letras");
                return false;
            }
        }

        caracteresNumeros = placa.Substring(3);

        foreach (char letra in caracteresNumeros)
        {
            int i;
            var teste = int.TryParse(letra.ToString(), out i);

            if (!teste)
            {
                Console.WriteLine("Os 4 ultimos caracteres devem ser numeros");
                return false;
            }
        }

        return true;
    }
}
