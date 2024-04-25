namespace ExemploConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo construtor");

            Cliente cliente = new Cliente("Enzo", 12345);

           //cliente.Nome = "Enzo Caetano";
            //cliente.Email = "email@email.com";
            //cliente.Senha = 1234;

            cliente.MostraDados();
        }
    }
}