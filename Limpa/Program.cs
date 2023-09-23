using Limpa.Domain.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = new User("Lucas", 18);
        Console.WriteLine(user);
    }
}
