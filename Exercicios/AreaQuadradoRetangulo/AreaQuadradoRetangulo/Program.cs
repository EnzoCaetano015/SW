namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Calcula Área Quadrado/Retângulo");
            Area area = new Area();

            Console.WriteLine(area.Calcular());
            Console.WriteLine(area.Dados());
        }
    }
}