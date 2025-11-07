using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Listas
    {
        public Nodo primero = null;

        public void Insertar(Cuenta cuenta)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = cuenta;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }

        public void Mostrar()
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(temp.dato.ToString());
                temp = temp.sig;
            }
        }
        public void Buscar(int buscar)
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.dato.Codigo == buscar)
                {
                    Console.WriteLine("Dato encontrado");
                    Console.WriteLine(temp.dato.ToString());
                    return;
                }
                temp = temp.sig;
            }
        }
        public void Eliminar(int borrar)
        {
            Nodo temp = primero;
            Nodo ant = null;
            while (temp != null)
            {
                if (temp.dato.Codigo == borrar)
                {
                    if (temp == primero)
                    {
                        primero = primero.sig;
                    }
                    else
                    {
                        ant.sig = temp.sig;
                    }
                    return;
                }
                ant = temp;
                temp = temp.sig;
            }
            Console.WriteLine("Dato no encontrado");
        }
    }
}
