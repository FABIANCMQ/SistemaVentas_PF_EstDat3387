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
                Console.WriteLine("2. Mostrar Plataformas");
                Console.WriteLine("3. Registrar Clientes");
                Console.WriteLine("4. Mostrar Clientes");
                Console.WriteLine("5. Realizar Venta a Clientes");
                Console.WriteLine("6. Mostrar Plataformas según categorías");
                Console.WriteLine("7. Mostrar Clientes por DNI");
                Console.WriteLine("8. Eliminar Cliente");
                Console.WriteLine("0. Salir");
                Console.WriteLine("========================================");

                Console.WriteLine("Ingrese una opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("===Registro Plataformas===\n");

                        Console.WriteLine("Seleccione Plataforma: ");
                        Console.WriteLine("1. Netflix");
                        Console.WriteLine("2. Disney+");
                        Console.WriteLine("3. HBO Max");
                        Console.WriteLine("4. Spotify");
                        Console.WriteLine("Opción: ");
                        int opPlataforma = int.Parse(Console.ReadLine());
                        string plataforma;

                        switch (opPlataforma)
                        {
                            case 1:
                                plataforma = "Netflix";
                                break;
                            case 2:
                                plataforma = "Disney+";
                                break;
                            case 3:
                                plataforma = "HBO Max";
                                break;
                            case 4:
                                plataforma = "Spotify";
                                break;
                            default: 
                                Console.WriteLine("Opción invalida");
                                Console.ReadKey();
                                return;

                        }
                        break;
                }
            } while (op != 3);
        }
    }
}
