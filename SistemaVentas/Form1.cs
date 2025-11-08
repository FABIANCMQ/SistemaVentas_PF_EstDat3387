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

        public Colas clClientes = new Colas();

        public Arbol arClientes=new Arbol();
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

            Clientes clienteAtendido = clClientes.Desencolar();

            string plataforma = cbPlataformas.Text;

            Pilas plSeleccionada = null;
            if (plataforma == "Netflix")
                plSeleccionada = plNetflix;
            else if (plataforma == "HBO")
                plSeleccionada = plHBO;
            else if (plataforma == "Disney")
                plSeleccionada = plDisney;
            else if (plataforma == "Prime Video")
                plSeleccionada = plPrime;

            Cuenta cuentaVendida = plSeleccionada.Desapilar();

            if (cuentaVendida == null)
            {
                MessageBox.Show($"No hay cuentas de {plataforma} disponibles");
                clClientes.Encolar(clienteAtendido);
                return;
            }

            clienteAtendido.Gasto += cuentaVendida.Precio;

            arClientes.Insertar(clienteAtendido);

            string mensaje = $"Venta Realizada: \nCliente: {clienteAtendido.Nombre}\nPlataforma: {cuentaVendida.Plataforma}\nUsuario: {cuentaVendida.Usuario}\nContraseña: {cuentaVendida.Contraseña}\nPrecio: S/{cuentaVendida.Precio}";
            MessageBox.Show(mensaje);

            mostrarCuentas();
            mostrarClientes();
        }
    }
}
