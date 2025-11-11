using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Clientes
    {
        public int DNI;
        public string Telefono;
        public string Nombre;
        public double Gasto;
        public string Plataforma;

        public Clientes() { }

        public Clientes(int dNI, string telefono, string nombre, double gasto)
        {
            DNI = dNI;
            Telefono = telefono;
            Nombre = nombre;
            Gasto = 0;
            Plataforma = "";
        }

        public override string ToString()
        {
            return $"DNI: {DNI}\n|Nombre: {Nombre}\n|Teléfono: {Telefono} \n|Plataforma: {Plataforma}\n|Total Gastado: {Gasto}";
        }
    }
}
