
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("----------------");
        Console.WriteLine("Selecione uma opção: ");

        //short res = short.Parse(Console.ReadLine());  para converter para numero, pois o readline retornar string
        string res = Console.ReadLine(); //Para evitar a quebra quando o usuario digitar qualquer letra, o switch recebe string

        switch (res)
        {
            case "0": Sair(); break;
            case "1": Soma(); break;
            case "2": Subtracao(); break;
            case "3": Divisao(); break;
            case "4": Multiplicacao(); break;
            default:
                Console.WriteLine("Valor inválido, tecle qualquer tecla para continuar...!");
                Console.ReadKey();
                Menu(); break;

        }

    }
    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 + v2;

        // Console.WriteLine("O Resultado da soma é " + resultado);
        Console.WriteLine($"O Resultado da soma é {resultado}");
        // Console.WriteLine($"O Resultado da soma é {v1 + v2}");
        Console.ReadKey();
        Menu();

    }

    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;

        Console.WriteLine($"O Resultado da subtração é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;

        Console.WriteLine($"O Resultado da divisão é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;

        Console.WriteLine($"O Resultado da multipicação é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Sair()
    {
        Console.Clear();
        Console.WriteLine("Deseja realmente sair? ");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");

        string sair = Console.ReadLine();

        switch (sair)
        {

            case "1": System.Environment.Exit(0); break;
            case "2": Menu(); break;
            default:
                Console.WriteLine("Valor inválido, tecle qualquer tecla para continuar...!");
                Console.ReadKey();
                Sair(); break;

        }


    }

}