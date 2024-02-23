namespace lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //INSTANCIA DE UM OBJETO
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            //Acessando um atributo publico
            lampada1.ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "vermelha";

            lampada2.ligada = false;
            lampada2.Potencia = 100;
            lampada2.Cor = "azul";

            //VISUALIZANDO OS VALORES DE ATRIBUTOS
            Console.WriteLine("A Lâmpada está ligada?" + lampada1.ligada);
            Console.WriteLine("A Potencia da Lampada é " + lampada1.Potencia);
            Console.WriteLine("A cor da lampada é " + lampada1.Cor);
            Console.WriteLine("****************************");
            Console.WriteLine("Essa é a lampada2 ");
            Console.WriteLine("A Lâmpada está ligada?" + lampada2.ligada);
            Console.WriteLine("A Potencia da Lampada é " + lampada2.Potencia);
            Console.WriteLine("A cor da lampada é " + lampada2.Cor);



        }
    }
}