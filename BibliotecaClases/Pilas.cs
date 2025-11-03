using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Pilas
    {
        public Nodo cima = null;

        public void Apilar(Cuenta cuentas)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = cuentas;

            nuevo.sig = cima;
            cima = nuevo;
        }
        public Cuenta Desapilar()
        {
            if (cima != null)
            {
                Cuenta dato = cima.dato;
                cima = cima.sig;

                return dato;
            }
            else
            {
                return null;
            }
        }
        public void Mostrar()
        {
            if (cima != null)
            {
                Nodo temp = cima;
                Console.WriteLine("---Cuentas Disponibles---");
                while (temp != null)
                {
                    Console.WriteLine(temp.dato.ToString());
                    temp = temp.sig;
                }
            }
            else
            {
                Console.WriteLine("No hay cuentas disponibles---");
            }
        }
    }
}
