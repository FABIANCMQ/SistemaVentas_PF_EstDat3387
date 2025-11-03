using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Clientes
    {
        public int ID;
        public string Telefono;
        public string Nombre;
        public double Gasto;

        public Clientes() { }
        public Clientes(int id, string telefono, string nombre, double gasto)
        {
            ID = id;
            Telefono = telefono;
            Nombre = nombre;
            Gasto = 0;
        }
        public override string ToString()
        {
            return $"|Nombre: {Nombre}\n|Teléfono: {Telefono} \n|Total Gastado: {Gasto}";
        }
    }
}
