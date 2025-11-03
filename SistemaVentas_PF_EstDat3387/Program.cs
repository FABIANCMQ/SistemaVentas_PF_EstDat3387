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

            Listas lsInventario = new Listas();
            Pilas plCuentas = new Pilas();

            Cuenta cuenta1 = new Cuenta(1, "Netflix", "user1@mail.com", "pass123", 15.00);
            Cuenta cuenta2 = new Cuenta(2, "Disney+", "user2@mail.com", "pass456", 12.00);
            Cuenta cuenta3 = new Cuenta(3, "HBO Max", "user3@mail.com", "pass789", 14.00);
            Cuenta cuenta4 = new Cuenta(4, "Spotify", "user4@mail.com", "pass321", 10.00);

            Console.WriteLine("\nAgregando cuentas...");
            lsInventario.Insertar(cuenta1);
            lsInventario.Insertar(cuenta2);
            lsInventario.Insertar(cuenta3);
            lsInventario.Insertar(cuenta4);

            Console.WriteLine("\n=== INVENTARIO COMPLETO ===");
            lsInventario.Mostrar();

            Console.WriteLine("\nIngrese código de plataforma a Buscar: ");
            int codigo = int.Parse(Console.ReadLine());
            lsInventario.Buscar(codigo);

            Console.WriteLine("\nIngrese código de plataforma a eliminar: ");
            int eliminar = int.Parse(Console.ReadLine());
            lsInventario.Eliminar(eliminar);

            Console.WriteLine("\nPlataforma eliminada\n");
            lsInventario.Mostrar();

            Cuenta cn1 = new Cuenta(101, "Netflix", "netflix1@mail.com", "pass101", 15.00);
            Cuenta cn2 = new Cuenta(102, "Netflix", "netflix2@mail.com", "pass102", 15.00);
            Cuenta cn3 = new Cuenta(103, "Netflix", "netflix3@mail.com", "pass103", 15.00);

            plCuentas.Apilar(cn1);
            plCuentas.Apilar(cn2);
            plCuentas.Apilar(cn3);

            Console.WriteLine("\n---Cuentas de Netflix Disponibles---");
            plCuentas.Mostrar();

            Console.WriteLine("\n---Vendiendo Cuenta---");
            plCuentas.Desapilar();

            Console.WriteLine("\n---Cuentas Restantes---");
            plCuentas.Mostrar();

            Console.WriteLine("\n========== COLA - CLIENTES EN ESPERA ==========\n");

            Colas clClientes = new Colas();
            
            Clientes cl1= new Clientes(1, "987654321", "Juan Perez",0);
            Clientes cl2= new Clientes(2, "987654321", "Carla",0);
            Clientes cl3= new Clientes(3, "987654321", "Juan Perez",0);

            clClientes.Encolar(cl1);
            clClientes.Encolar(cl2);
            clClientes.Encolar(cl3);

            clClientes.Mostrar();

            // Atender un cliente
            Console.WriteLine("\n=== ATENDIENDO CLIENTE ===");
            clClientes.Desencolar();

            Console.WriteLine("\n=== CLIENTES RESTANTES ===");
            clClientes.Mostrar();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            
            Console.ReadKey();
        }
    }
}
