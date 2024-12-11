namespace DesafioPratico_Fundamentos;

public class Calculadora
{
    public static (double soma, double sub, double mult, object div, double media) Opearacoes(double valor1, double valor2)
    {
        double soma = valor1 + valor2;

        double sub = valor1 - valor2;

        double mult = valor2 * valor1;

        object div;

        if (valor2 == 0)
        {
            div = "Não divide por 0";
        }
        else
        {
            div = valor1 / valor2;
        }

        double media = (valor1 + valor2) / 2;

        return (soma, sub, mult, div, media);
    }

}
