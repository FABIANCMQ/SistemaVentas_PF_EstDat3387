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

        
    }
}
