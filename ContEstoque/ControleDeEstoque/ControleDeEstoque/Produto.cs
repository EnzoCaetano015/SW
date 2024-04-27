using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    public class Produto
    {
        private int code {  get; set; }
        private string? nome { get; set; }

        private int estoque { get; set; }
        private double preco { get; set; }

        public void entrada(int quant)
        {
            estoque += quant;
            Console.WriteLine("Entrada: " + quant);
        }

        public void venda(int quant)
        {
            estoque -= quant;
            Console.WriteLine("Venda: " + quant);
        }

        public void saida()
        {
            Console.WriteLine("Informações do Produto");
            Console.WriteLine("Código: " + code);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Estoque: " + estoque);
            Console.WriteLine("Preço: " + preco);
        }

        public Produto(int codigo, string nomeCons, int estoqueCons, double precoCons)
        {
            code = codigo;
            nome = nomeCons;
            estoque = estoqueCons;
            preco = precoCons;

        }

    }
}
