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
                Console.WriteLine($"Cliente con ID {clientes.ID} registrado correctamente.");
            }
            else
            {
                if (clientes.ID < raiz.dato.ID)
                {
                    insertar(ref raiz.izq, clientes);
                }
                else if (clientes.ID>raiz.dato.ID)
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

        private void dibujar(NodoArbol raiz, int nivel)
        {
            if (raiz != null)
            {
                dibujar(raiz.der, nivel+1);
                for (int i = 0; i < nivel; i++)
                {
                    Console.WriteLine("\t");
                }
                Console.WriteLine($"ID: {raiz.dato.ID} - {raiz.dato.Nombre}");
                dibujar(raiz.izq, nivel + 1);
            }
        }
        public void Dibujar()
        {
            if (raiz_principal == null)
            {
                Console.WriteLine("No hay clientes registrados");
            }
            else
            {
                Console.WriteLine("=== SISTEMA DE CLIENTES ===");
                dibujar(raiz_principal, 0);
            }
        }

        private void inOrden(NodoArbol raiz)
        {
            if (raiz != null)
            {
                inOrden(raiz.izq);
                Console.WriteLine(raiz.dato);
                Console.WriteLine("----------------------------------");
                inOrden(raiz.der);
            }
        }
        public void InOrden()
        {
            if (raiz_principal == null)
            {
                Console.WriteLine("No Hay clientes");
            }
            else
            {
                Console.WriteLine("=== CLIENTES (InOrden) ===");
                inOrden(raiz_principal);
            }
        }
        private void buscar(NodoArbol raiz,int id)
        {
            if (raiz == null)
            {
                Console.WriteLine("Cliente no existe en los registros");
            }
            else
            {
                if (id < raiz.dato.ID)
                {
                    buscar(raiz.izq, id);
                }
                else if (id > raiz.dato.ID)
                {
                    buscar(raiz.der, id);
                }
                else
                {
                    Console.WriteLine("Cliente encontrado");
                    Console.WriteLine(raiz.dato);
                }
            }
        }
        public void Buscar(int id)
        {
            buscar(raiz_principal, id);
        }
        private void eliminar(ref NodoArbol raiz, int id)
        {
            if (raiz == null)
            {
                Console.WriteLine("Cliente no existente");
            }
            else
            {
                if (id < raiz.dato.ID)
                {
                    eliminar(ref raiz.izq, id);
                }
                else if (id>raiz.dato.ID)
                {
                    eliminar(ref raiz.izq, id);
                }
                else
                {
                    if (raiz.izq==null&&raiz.der==null)
                    {
                        raiz = null;
                    }
                    else
                    {
                        if (raiz.izq != null)
                        {
                            NodoArbol temp = BuscarMayor(raiz.izq);

                            Clientes aux = temp.dato;
                            temp.dato = raiz.dato;
                            raiz.dato = aux;

                            eliminar(ref raiz.izq, id);
                        }
                        else
                        {
                            NodoArbol temp = BuscarMenor(raiz.der);

                            Clientes aux = temp.dato;
                            temp.dato = raiz.dato;
                            raiz.dato = aux;

                            eliminar(ref raiz.der, id);
                        }
                    }
                }
            }
        }
        private NodoArbol BuscarMenor(NodoArbol raiz)
        {
            if (raiz.izq != null)
            {
                return BuscarMenor(raiz.izq);
            }
            else
            {
                return raiz;
            }
        }
        private NodoArbol BuscarMayor(NodoArbol raiz)
        {
            if (raiz.der != null)
            {
                return BuscarMayor(raiz.der);
            }
            else
            {
                return raiz;
            }
        }
    }
}
