namespace Pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FPagamento pagamento = new FPagamento();

            Console.WriteLine(pagamento.Pag());
        }
    }
}