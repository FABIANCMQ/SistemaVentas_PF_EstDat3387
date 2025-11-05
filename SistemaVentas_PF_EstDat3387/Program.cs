using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace SistemaVentas_PF_EstDat3387
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listas lsInventario = new Listas();
            Pilas plNetflix = new Pilas();
            Pilas plHBO = new Pilas();
            Pilas plDisney = new Pilas();
            Pilas plSpotify = new Pilas();

            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("  SISTEMA DE VENTAS DE STREAMING");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Registrar Plataforma");
                Console.WriteLine("2. Registrar Cliente");
                Console.WriteLine("3. Salir");

                Console.WriteLine("Ingrese una opción: ");
                op = int.Parse(Console.ReadLine());
            } while (op != 3);
        }
    }
}
