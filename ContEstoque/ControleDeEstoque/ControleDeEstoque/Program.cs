namespace ControleDeEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(336,"Geladeira",0,4500);
            produto.saida();
            produto.entrada(10);
            produto.venda(8);
            produto.saida();
        }
    }
}
