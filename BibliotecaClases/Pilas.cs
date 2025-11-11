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
    }
}
