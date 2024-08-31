namespace Desafio1;

public class Exercicio2
{
    public static void Desafio()
    {
        Console.WriteLine("Digite seu primeiro nome");
        string firstName = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome");
        string lastName = Console.ReadLine();
        string fullName = $"{firstName} {lastName}";
        Console.WriteLine(fullName);
    }
}