using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========");
            Console.WriteLine("Calcular Área do Terreno");
            Console.WriteLine("==========");
            
            Console.WriteLine("Informe a largura: ");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o comprimento:");
            int comprimento = Convert.ToInt32(Console.ReadLine());

            CalculaArea(largura, comprimento);
        }

        static void CalculaArea(int largura, int comprimento)
        {
            int area = largura * comprimento;
            Console.WriteLine($@"Área = {area} m²");
            //Console.WriteLine("Bom dia :D");
        }
    }
}
