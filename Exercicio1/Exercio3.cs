namespace Desafio1;

public class Exercicio3
{
    public static void Desafio()
    {
        double primeiroNumero, segundoNumero;
        
        Console.WriteLine("Digite o primeiro numero");
        primeiroNumero = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo numero");
        segundoNumero = double.Parse(Console.ReadLine());

        Console.WriteLine("Resultado das operacoes");
        OperacoesMatematicas(num1: primeiroNumero, num2: segundoNumero);
    }

    static double Somar(double num1, double num2) => num1 + num2;
    static double Subtracao(double num1, double num2) => num1 - num2;
    static double Multiplicacao(double num1, double num2) => num1 * num2;

    static double Divisao(double num1, double num2)
    {
        if (num2 == 0.0)
        {
            Console.WriteLine("Nao foi possivel realizar essa operacao");
            return 0.0;
        }

        return num1 / num2;
    }
    static double Media(double num1, double num2) => (num1 + num2)/2;

    static void OperacoesMatematicas(double num1, double num2)
    {
        var listaResultados = new List<double>();
        listaResultados.Add(Somar(num1, num2));
        listaResultados.Add(Subtracao(num1, num2));
        listaResultados.Add(Multiplicacao(num1, num2));
        listaResultados.Add(Divisao(num1, num2));
        listaResultados.Add(Media(num1, num2));

        foreach (var item in listaResultados)
        {
            Console.WriteLine(item);
        }
        {
            
        }
        
    }

    
}