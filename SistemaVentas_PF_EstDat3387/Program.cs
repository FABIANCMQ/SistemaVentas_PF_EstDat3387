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
            Console.WriteLine("=== SISTEMA DE VENTAS DE STREAMING ===");
            Console.WriteLine("=== PRUEBA DE LISTA SIMPLE ===\n");

            Listas lsInventario=new Listas();

            Cuenta cuenta1 = new Cuenta(1, "Netflix", "user1@mail.com", "pass123", 15.00);
            Cuenta cuenta2 = new Cuenta(2, "Disney+", "user2@mail.com", "pass456", 12.00);
            Cuenta cuenta3 = new Cuenta(3, "HBO Max", "user3@mail.com", "pass789", 14.00);
            Cuenta cuenta4 = new Cuenta(4, "Spotify", "user4@mail.com", "pass321", 10.00);

            Console.WriteLine("Agregando cuentas...");
            lsInventario.Insertar(cuenta1);
            lsInventario.Insertar(cuenta2);
            lsInventario.Insertar(cuenta3);
            lsInventario.Insertar(cuenta4);

            Console.WriteLine("=== INVENTARIO COMPLETO ===");
            lsInventario.Mostrar();

            Console.WriteLine("Ingrese código de plataforma a Buscar: ");
            int codigo = int.Parse(Console.ReadLine());
            lsInventario.Buscar(codigo);

            Console.WriteLine("Ingrese código de plataforma a eliminar: ");
            int eliminar = int.Parse(Console.ReadLine());
            lsInventario.Eliminar(eliminar);

            Console.WriteLine("Plataforma eliminada");
            lsInventario.Mostrar();

            Console.ReadKey();
        }
    }
}
