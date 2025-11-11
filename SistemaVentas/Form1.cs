using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace SistemaVentas
{

    public partial class Form1 : Form
    {
        public Listas lsInventario = new Listas();

        public Pilas plNetflix = new Pilas();
        public Pilas plHBO = new Pilas();
        public Pilas plDisney = new Pilas();
        public Pilas plPrime = new Pilas();
        public Pilas plCanva = new Pilas();
        public Pilas plCrunchy = new Pilas();

        public Colas clClientes = new Colas();

        public Arbol arNetflix = new Arbol();
        public Arbol arHBO = new Arbol();
        public Arbol arDisney = new Arbol();
        public Arbol arPrime = new Arbol();
        public Arbol arCanva = new Arbol();
        public Arbol arCrunchy = new Arbol();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //DataGriedView para las Plataformas
            dgvPlataformas.Columns.Add("Codigo", "Código");
            dgvPlataformas.Columns.Add("Plataforma", "Plataforma");
            dgvPlataformas.Columns.Add("Precio", "Precio");

            //DataGriedView para los Clientes
            dgvClientes.Columns.Add("DNI", "DNI");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Telefono", "Teléfono");

            dgvListaCuentas.Columns.Add("Codigo", "Código");
            dgvListaCuentas.Columns.Add("Plataforma", "Plataforma");
            dgvListaCuentas.Columns.Add("Usuario", "Usuario");
            dgvListaCuentas.Columns.Add("Contraseña", "Contraseña");
        }


        private void btRegistrarPlataforma_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContrasena.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Aviso");
                return;
            }

            double precio;
            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio valido.", "Error");
                return;
            }

            string plataforma = cbPlataformas.Text;

            Cuenta nuevaCuenta = new Cuenta(plataforma, txtUsuario.Text, txtContrasena.Text, precio);
            lsInventario.Insertar(nuevaCuenta);

            if (plataforma == "Netflix")
                plNetflix.Apilar(nuevaCuenta);
            else if (plataforma == "HBO")
                plHBO.Apilar(nuevaCuenta);
            else if (plataforma=="Disney")
                plDisney.Apilar(nuevaCuenta);
            else if (plataforma=="Prime Video")
                plPrime.Apilar(nuevaCuenta);
            else if (plataforma == "Canva")
                plCanva.Apilar(nuevaCuenta);
            else if (plataforma == "Crunchyroll")
                plCrunchy.Apilar(nuevaCuenta);
            MessageBox.Show("Cuenta Agregada", "Éxito");

            txtUsuario.Clear();
            txtContrasena.Clear();
            txtPrecio.Clear();

            mostrarCuentas();
            mostrarLista();
        }
        public void mostrarCuentas()
        {
            dgvPlataformas.Rows.Clear();
            if (plNetflix.cima != null)
            {
                Nodo temp = plNetflix.cima;
                while (temp != null)
                {
                    dgvPlataformas.Rows.Add(temp.dato.Codigo, temp.dato.Plataforma, temp.dato.Precio);
                    temp = temp.sig;
                }

            }
            if (plHBO.cima != null)
            {
                Nodo temp = plHBO.cima;
                while (temp != null)
                {
                    dgvPlataformas.Rows.Add(temp.dato.Codigo, temp.dato.Plataforma, temp.dato.Precio);
                    temp = temp.sig;
                }

            }
            if (plDisney.cima != null)
            {
                Nodo temp = plDisney.cima;
                while (temp != null)
                {
                    dgvPlataformas.Rows.Add(temp.dato.Codigo, temp.dato.Plataforma, temp.dato.Precio);
                    temp = temp.sig;
                }

            }
            if (plPrime.cima != null)
            {
                Nodo temp = plPrime.cima;
                while (temp != null)
                {
                    dgvPlataformas.Rows.Add(temp.dato.Codigo, temp.dato.Plataforma, temp.dato.Precio);
                    temp = temp.sig;
                }
            }
            if (plCanva.cima != null)
            {
                Nodo temp = plCanva.cima;
                while (temp != null)
                {
                    dgvPlataformas.Rows.Add(temp.dato.Codigo, temp.dato.Plataforma, temp.dato.Precio);
                    temp = temp.sig;
                }
            }
            if (plCrunchy.cima != null)
            {
                Nodo temp = plCrunchy.cima;
                while (temp != null)
                {
                    dgvPlataformas.Rows.Add(temp.dato.Codigo, temp.dato.Plataforma, temp.dato.Precio);
                    temp = temp.sig;
                }
            }
            
        }
        public void mostrarLista()
        {
            dgvListaCuentas.Rows.Clear();
            Nodo temp = lsInventario.primero;
            while (temp != null)
            {
                dgvListaCuentas.Rows.Add(temp.dato.Codigo, temp.dato.Plataforma, temp.dato.Usuario, temp.dato.Contraseña);
                temp = temp.sig;
            }
        }

        private void btRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos.", "Aviso");
                return;
            }

            int dni=0;
            if (!int.TryParse(txtDNI.Text, out dni))
            {
                MessageBox.Show("El DNI debe ser valido.", "Error");
                return;
            }
            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos","Error");
                return;
            }

            Clientes clienteNuevo = new Clientes(dni,txtTelefono.Text,txtNombre.Text,0);
            clClientes.Encolar(clienteNuevo);
            MessageBox.Show("Cliente agendado en la Cola", "Éxito");

            txtDNI.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

            mostrarClientes();
        }

        public void mostrarClientes()
        {
            dgvClientes.Rows.Clear();
            NodoCola temp = clClientes.frente;
            while(temp != null)
            {
                dgvClientes.Rows.Add(temp.datos.DNI,temp.datos.Nombre,temp.datos.Telefono);
                temp = temp.sig;
            }
            
        }
        private void btVenta_Click(object sender, EventArgs e)
        {
            if (clClientes.frente == null)
            {
                MessageBox.Show("No hay clientes en espera");
                return;
            }
            if (clbVentaPlataformas.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar al menos una opción", "Error");
                return;
            }

            Clientes clienteAtendido = clClientes.Desencolar();

            string detalleVenta = "";
            double totalVenta = 0;
            int cuentasVendidas = 0;
            string plataformasCompradas = "";

            for (int i = 0; i < clbVentaPlataformas.CheckedItems.Count; i++)
            {
                string plataforma = clbVentaPlataformas.CheckedItems[i].ToString();

                

                Pilas plSeleccionada = null;
                Arbol arSeleccionado = null;

                if (plataforma == "Netflix")
                {
                    plSeleccionada = plNetflix;
                    arSeleccionado = arNetflix;
                }
                    
                else if (plataforma == "HBO")
                {
                    plSeleccionada = plHBO;
                    arSeleccionado= arHBO;
                }
                    
                else if (plataforma == "Disney")
                {
                    plSeleccionada = plDisney;
                    arSeleccionado = arDisney;
                }
                    
                else if (plataforma == "Prime Video")
                {
                    plSeleccionada = plPrime;
                    arSeleccionado = arPrime;
                }
                    
                else if (plataforma == "Canva")
                {
                    plSeleccionada = plCanva;
                    arSeleccionado = arCanva;
                }
                    
                else if (plataforma == "Prime Video")
                {
                    plSeleccionada = plCrunchy;
                    arSeleccionado = arCrunchy;
                }
                    


                Cuenta cuentaVendida = plSeleccionada.Desapilar();

                if (cuentaVendida == null)
                {
                    detalleVenta = $"{detalleVenta} + X + {plataforma} + : Sin Stock\n\n";
                }
                else
                {
                    clienteAtendido.Gasto = clienteAtendido.Gasto + cuentaVendida.Precio;
                    totalVenta = totalVenta + cuentaVendida.Precio;
                    cuentasVendidas = cuentasVendidas + 1;

                    detalleVenta = detalleVenta + $"{plataforma} : \n ";
                    detalleVenta = detalleVenta + $"Usuario: {cuentaVendida.Usuario}\n";
                    detalleVenta = detalleVenta + $"Contraseña: {cuentaVendida.Contraseña}\n";
                    detalleVenta = detalleVenta + $"Precio: S/ {cuentaVendida.Precio}\n\n";

                    if (plataformasCompradas == "")
                    {
                        plataformasCompradas = plataforma;
                    }
                    else
                    {
                        plataformasCompradas += $", {plataforma}";
                    }
                    Clientes clienteCopia = new Clientes(clienteAtendido.DNI, clienteAtendido.Telefono, clienteAtendido.Nombre, 0);
                    clienteCopia.Plataforma = plataforma;
                    clienteCopia.Gasto = cuentaVendida.Precio;

                    arSeleccionado.Insertar(clienteCopia);
                }
            }

            if (cuentasVendidas == 0)
            {
                MessageBox.Show("No se pudo realizar la venta. Sin Stock", "Error");
                clClientes.Encolar(clienteAtendido);
                for (int i = 0; i < clbVentaPlataformas.Items.Count; i++)
                {
                    clbVentaPlataformas.SetItemChecked(i, false);
                }
                return;
            }

            string resumen = $"VENTA REALIZADA\n\nCliente: {clienteAtendido.Nombre}\nDNI: {clienteAtendido.DNI}\nPlataformas: {plataformasCompradas}\nDetalles de Venta: \n{detalleVenta}\n--------------------------\nTotal Venta: {totalVenta}\nTotal Acumulado: {clienteAtendido.Gasto}";
            MessageBox.Show(resumen,"Venta Exitosa");

            for(int i = 0; i < clbVentaPlataformas.Items.Count; i++)
            {
                clbVentaPlataformas.SetItemChecked(i, false);
            }
            mostrarClientes();
            mostrarCuentas();
        }

        private void btArbolClientes_Click(object sender, EventArgs e)
        {
            tvClientes.Nodes.Clear();

            TreeNode raizPrincipal = new TreeNode("CLIENTES REGISTRADOS");
            tvClientes.Nodes.Add(raizPrincipal);

            TreeNode ndNetflix = new TreeNode("NETFLIX");
            raizPrincipal.Nodes.Add(ndNetflix);
            if (arNetflix.raiz_principal != null)
            {
                double totalNetflix = 0;
                int clientesNetflix = 0;
                LlenarArbolconGasto(arNetflix.raiz_principal, ndNetflix, ref totalNetflix, ref clientesNetflix);
                ndNetflix.Text = "NETFLIX (" + clientesNetflix + " clientes | Total: S/ " + totalNetflix + ")";
            }
            else
            {
                ndNetflix.Nodes.Add(new TreeNode("(Sin clientes)"));
            }

            TreeNode ndHBO = new TreeNode("HBO");
            raizPrincipal.Nodes.Add(ndHBO);
            if (arHBO.raiz_principal != null)
            {
                double totalHBO = 0;
                int clientesHBO = 0;
                LlenarArbolconGasto(arHBO.raiz_principal, ndHBO, ref totalHBO, ref clientesHBO);
                ndHBO.Text = "HBO (" + clientesHBO + " clientes | Total: S/ " + totalHBO + ")";
            }
            else
            {
                ndHBO.Nodes.Add(new TreeNode("(Sin clientes)"));
            }

            TreeNode ndDisney = new TreeNode("Disney");
            raizPrincipal.Nodes.Add(ndDisney);
            if (arDisney.raiz_principal != null)
            {
                double totalDisney = 0;
                int clientesDisney = 0;
                LlenarArbolconGasto(arDisney.raiz_principal, ndDisney, ref totalDisney, ref clientesDisney);
                ndDisney.Text = "Disney (" + clientesDisney + " clientes | Total: S/ " + totalDisney + ")";
            }
            else
            {
                ndDisney.Nodes.Add(new TreeNode("(Sin clientes)"));
            }

            TreeNode ndPrime = new TreeNode("Prime Video");
            raizPrincipal.Nodes.Add(ndPrime);
            if (arPrime.raiz_principal != null)
            {
                double totalPrime = 0;
                int clientesPrime = 0;
                LlenarArbolconGasto(arPrime.raiz_principal, ndPrime, ref totalPrime, ref clientesPrime);
                ndPrime.Text = "Prime Video (" + clientesPrime + " clientes | Total: S/ " + totalPrime + ")";
            }
            else
            {
                ndPrime.Nodes.Add(new TreeNode("(Sin clientes)"));
            }

            TreeNode ndCanva = new TreeNode("Canva");
            raizPrincipal.Nodes.Add(ndCanva);
            if (arCanva.raiz_principal != null)
            {
                double totalCanva = 0;
                int clientesCanva = 0;
                LlenarArbolconGasto(arCanva.raiz_principal, ndCanva, ref totalCanva, ref clientesCanva);
                ndCanva.Text = "Canva (" + clientesCanva + " clientes | Total: S/ " + totalCanva + ")";
            }
            else
            {
                ndCanva.Nodes.Add(new TreeNode("(Sin clientes)"));
            }

            TreeNode ndCrunchy = new TreeNode("Crunchyroll");
            raizPrincipal.Nodes.Add(ndCrunchy);
            if (arCrunchy.raiz_principal != null)
            {
                double totalCrunchy = 0;
                int clientesCrunchy = 0;
                LlenarArbolconGasto(arCrunchy.raiz_principal, ndCrunchy, ref totalCrunchy, ref clientesCrunchy);
                ndCrunchy.Text = "Crunchyroll (" + clientesCrunchy + " clientes | Total: S/ " + totalCrunchy + ")";
            }
            else
            {
                ndCrunchy.Nodes.Add(new TreeNode("(Sin clientes)"));
            }
            tvClientes.ExpandAll();
        }
        

        public void LlenarArbolconGasto(NodoArbol nodo,TreeNode nodoVisual, ref double totalGasto, ref int contador)
        {
            if (nodo != null)
            {
                if (nodo.izq != null)
                {
                    LlenarArbolconGasto(nodo.izq, nodoVisual, ref totalGasto, ref contador);
                }
                string texto = $"DNI: { nodo.dato.DNI} | {nodo.dato.Nombre} | Gastó: S/ {nodo.dato.Gasto}";

                TreeNode nuevoNodo = new TreeNode(texto);
                nodoVisual.Nodes.Add(nuevoNodo);

                totalGasto = totalGasto + nodo.dato.Gasto;
                contador = contador + 1;

                if (nodo.der != null)
                {
                    LlenarArbolconGasto(nodo.der, nodoVisual, ref totalGasto, ref contador);
                }
            }
        }

    }
}
