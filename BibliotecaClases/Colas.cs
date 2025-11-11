using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Colas
    {
        public NodoCola frente = null;
        public NodoCola final = null;

        public void Encolar(Clientes cliente)
        {
            NodoCola nuevo = new NodoCola();
            nuevo.datos = cliente;

            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.sig = nuevo;
                final = nuevo;
            }
        }
        public Clientes Desencolar()
        {
            if (frente != null)
            {
                Clientes cliente = frente.datos;
                frente = frente.sig;
                return cliente;
            }
            else
            {
                return null;
            }
        }
    }
}
