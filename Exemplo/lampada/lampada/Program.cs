namespace lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //INSTANCIA DE UM OBJETO
            Lampada lampada1 = new Lampada();
            

            lampada1.ligar();
            lampada1.Cores();
            lampada1.Pot();

            Console.WriteLine("A lampada esta ligada?  " + lampada1.estaLigada());
            Console.WriteLine("Qual a cor da lampadaa  " + lampada1.qualCor());
            Console.WriteLine("Qual a potencia  " + lampada1.qualPot());




        }
    }
}