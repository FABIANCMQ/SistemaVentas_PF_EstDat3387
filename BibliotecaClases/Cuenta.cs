using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cuenta
    {
        public int Codigo;
        public string Plataforma;
        public string Usuario;
        public string Contraseña;
        public double Precio;

        public Cuenta() { }
        public Cuenta(int codigo, string plataforma, string usuario, string contraseña, double precio)
        {
            Codigo = codigo;
            Plataforma = plataforma;
            Usuario = usuario;
            Contraseña = contraseña;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}\n| Plataforma: {Plataforma}\n| Usuario: {Usuario}\n| Contraseña: {Contraseña}\n| Precio: S/{Precio}";
        }
    }
}
