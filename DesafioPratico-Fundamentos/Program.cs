using DesafioPratico_Fundamentos;

class Program
{ 
    static void Main()
    {
        string opcaoMenu;
        do
        {
            Console.Clear();
            opcaoMenu = Menu.Show();

            switch (opcaoMenu)
            {
                case "1":
                    {
                        Console.Write("Qual o seu nome? ");
                        string nome = Console.ReadLine();
                        string mensagem = MensagemPersonalizadeBoasVindas.MensagemBoasVindas(nome);
                        Console.WriteLine(mensagem);
                    }
                    break;
                case "2":
                    {
                        Console.Write("Qual o seu nome? ");
                        string nome = Console.ReadLine();
                        Console.Write("Qual o seu sobrenome? ");
                        string sobrenome = Console.ReadLine();

                        string mensagem = ConcatenarNomes.NomeSobrenome(nome, sobrenome);
                        Console.WriteLine(mensagem);
                    }
                    break;
                case "3":
                    {
                        Console.Write("Digite o Primeiro Numero: ");
                        double valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o Segundo Numero: ");
                        double valor2 = Convert.ToDouble(Console.ReadLine());

                        var result = Calculadora.Opearacoes(valor1, valor2);

                        Console.WriteLine("Resultado da soma: " + result.soma);
                        Console.WriteLine("Resultado da subtração: " + result.sub);
                        Console.WriteLine("Resultado da multiplicação: " + result.mult);
                        Console.WriteLine("Resultado da divisão: " + result.div);
                        Console.WriteLine("Resultado da media: " + result.media);
                    }
                    break;
                case "4":
                    {
                        Console.Write("Digite um texto para saber a quantidade de caracteres: ");
                        string frase = Console.ReadLine();

                        int result = Caracter.Contator(frase);

                        Console.WriteLine(result);
                    }
                    break;
                case "5":
                    Console.Write("Digite a Placa para validar: ");
                    string texto = Console.ReadLine();

                    bool resultado = PlacaVeiculo.Validacao(texto);

                    Console.WriteLine(resultado);
                    break;
                case "6":
                    {
                        Data data = new Data();

                        data.Atual();
                    }
                    break;
                case "7":
                    Console.WriteLine("Obrigado por utilizar o programa, tchauu!!!");
                    break;
                default:
                    Console.WriteLine("Opção não existe :(");
                    break;
            }

            if(opcaoMenu != "7")
            {
                Console.Write("Deseja continuar (S/N)? ");
                string continuar = Console.ReadLine();

                if(continuar.ToUpper() == "N")
                {
                    opcaoMenu = "7";
                }
            }

        } while (opcaoMenu != "7");


    }
}