using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Arbol
    {
        public NodoArbol raiz_principal = null;

        private void insertar(ref NodoArbol raiz, Clientes clientes)
        {
            if (raiz == null)
            {
                NodoArbol nuevo = new NodoArbol();
                nuevo.dato = clientes;
                raiz = nuevo;
                Console.WriteLine($"Cliente con DNI: {clientes.DNI} registrado correctamente.");
            }
            else
            {
                if (clientes.DNI < raiz.dato.DNI)
                {
                    insertar(ref raiz.izq, clientes);
                }
                else if (clientes.DNI >raiz.dato.DNI)
                {
                    insertar(ref raiz.der, clientes);
                }
                else
                {
                    Console.WriteLine("Cliente ya registrado");
                }
            }
        }
        public void Insertar(Clientes c)
        {
            insertar(ref raiz_principal, c);
        }
    }
}
