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
            Personalizacion();

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

        private void Personalizacion()
        {
            this.BackColor = Color.FromArgb(15, 23, 42);  // Fondo azul oscuro
            this.Text = "SISTEMA DE VENTAS - Cuentas Premium";

            groupBox1.ForeColor = Color.FromArgb(34, 211, 238);
            groupBox1.BackColor = Color.FromArgb(15, 23, 42);

            groupBox2.ForeColor = Color.FromArgb(147, 197, 253);
            groupBox2.BackColor = Color.FromArgb(15, 23, 42);

            groupBox5.ForeColor = Color.FromArgb(196, 181, 253);
            groupBox5.BackColor = Color.FromArgb(15, 23, 42);


            groupBox4.ForeColor = Color.FromArgb(45, 212, 191);
            groupBox4.BackColor = Color.FromArgb(15, 23, 42);

            groupBox3.ForeColor = Color.FromArgb(96, 165, 250);
            groupBox3.BackColor = Color.FromArgb(15, 23, 42);

            groupBox6.ForeColor = Color.FromArgb(34, 211, 238);
            groupBox6.BackColor = Color.FromArgb(15, 23, 42);

            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is Label)
                        {
                            subControl.ForeColor = Color.White;
                            subControl.BackColor = Color.Transparent;
                        }
                    }
                }
            }

            txtUsuario.BackColor = Color.FromArgb(203, 253, 253);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;

            txtContrasena.BackColor = Color.FromArgb(221, 214, 254);
            txtContrasena.ForeColor = Color.Black;
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;

            txtPrecio.BackColor = Color.FromArgb(203, 253, 253);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;

            txtDNI.BackColor = Color.FromArgb(221, 214, 254);
            txtDNI.ForeColor = Color.Black;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;

            txtNombre.BackColor = Color.FromArgb(203, 253, 253);
            txtNombre.ForeColor = Color.Black;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;

            txtTelefono.BackColor = Color.FromArgb(221, 214, 254);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;

            cbPlataformas.BackColor = Color.FromArgb(165, 180, 252);
            cbPlataformas.ForeColor = Color.Black;
            cbPlataformas.FlatStyle = FlatStyle.Flat;

            clbVentaPlataformas.BackColor = Color.FromArgb(147, 197, 253);
            clbVentaPlataformas.ForeColor = Color.Black;
            clbVentaPlataformas.BorderStyle = BorderStyle.FixedSingle;

            btRegistrarPlataforma.BackColor = Color.FromArgb(139, 92, 246);
            btRegistrarPlataforma.ForeColor = Color.White;
            btRegistrarPlataforma.FlatStyle = FlatStyle.Flat;
            btRegistrarPlataforma.FlatAppearance.BorderSize = 0;
            btRegistrarPlataforma.Font = new Font("Arial", 9, FontStyle.Bold);

            btRegistrarCliente.BackColor = Color.FromArgb(34, 211, 238);
            btRegistrarCliente.ForeColor = Color.Black;
            btRegistrarCliente.FlatStyle = FlatStyle.Flat;
            btRegistrarCliente.FlatAppearance.BorderSize = 0;
            btRegistrarCliente.Font = new Font("Arial", 9, FontStyle.Bold);

            btVenta.BackColor = Color.FromArgb(124, 58, 237);
            btVenta.ForeColor = Color.White;
            btVenta.FlatStyle = FlatStyle.Flat;
            btVenta.FlatAppearance.BorderSize = 0;
            btVenta.Font = new Font("Arial", 9, FontStyle.Bold);

            btArbolClientes.BackColor = Color.FromArgb(6, 182, 212);
            btArbolClientes.ForeColor = Color.White;
            btArbolClientes.FlatStyle = FlatStyle.Flat;
            btArbolClientes.FlatAppearance.BorderSize = 0;
            btArbolClientes.Font = new Font("Arial", 9, FontStyle.Bold);

            dgvPlataformas.BackgroundColor = Color.FromArgb(165, 243, 252);
            dgvPlataformas.ForeColor = Color.Black;
            dgvPlataformas.GridColor = Color.FromArgb(34, 211, 238);
            dgvPlataformas.DefaultCellStyle.BackColor = Color.FromArgb(165, 243, 252);
            dgvPlataformas.DefaultCellStyle.ForeColor = Color.Black;
            dgvPlataformas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 211, 238);
            dgvPlataformas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPlataformas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 145, 178);
            dgvPlataformas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPlataformas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvPlataformas.BorderStyle = BorderStyle.None;
            dgvPlataformas.EnableHeadersVisualStyles = false;

            dgvClientes.BackgroundColor = Color.FromArgb(196, 181, 253);
            dgvClientes.ForeColor = Color.Black;
            dgvClientes.GridColor = Color.FromArgb(139, 92, 246);
            dgvClientes.DefaultCellStyle.BackColor = Color.FromArgb(196, 181, 253);
            dgvClientes.DefaultCellStyle.ForeColor = Color.Black;
            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(139, 92, 246);
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(109, 40, 217);
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.EnableHeadersVisualStyles = false;

            dgvListaCuentas.BackgroundColor = Color.FromArgb(199, 210, 254);
            dgvListaCuentas.ForeColor = Color.Black;
            dgvListaCuentas.GridColor = Color.FromArgb(99, 102, 241);
            dgvListaCuentas.DefaultCellStyle.BackColor = Color.FromArgb(199, 210, 254);
            dgvListaCuentas.DefaultCellStyle.ForeColor = Color.Black;
            dgvListaCuentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dgvListaCuentas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvListaCuentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 56, 202);
            dgvListaCuentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvListaCuentas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvListaCuentas.BorderStyle = BorderStyle.None;
            dgvListaCuentas.EnableHeadersVisualStyles = false;

            tvClientes.BackColor = Color.FromArgb(165, 243, 252);  // Cyan claro
            tvClientes.ForeColor = Color.Black;
            tvClientes.BorderStyle = BorderStyle.FixedSingle;
            tvClientes.Font = new Font("Consolas", 9);

        }
    }
}
