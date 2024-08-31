namespace Desafio1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o exercicio digitando o numero correspondente: 1, 2, 3, 4, 5, 6");
        
        int exercicio = int.Parse(Console.ReadLine());

        
        switch (exercicio)
        {
            case 1:
            {
                Exercicio1.Desafio();
            }
                break;
            case 2:
            {
                Exercicio2.Desafio();
            }
                break;
            case 3:
            {
                Exercicio3.Desafio();
            }
                break;
            case 4:
            {
                Exercicio4.Desafio();
            }
                break;
            default:
            {
                Console.WriteLine("Numero de desafio desconhecido");
            }
                break;
        }

    }
}

