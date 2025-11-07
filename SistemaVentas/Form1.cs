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
        public Form1()
        {
            InitializeComponent();
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

            Cuenta nuevaCuenta = new Cuenta(cbPlataformas.Text, txtUsuario.Text, txtContrasena.Text, double.Parse(txtPrecio.Text));
            lsInventario.Insertar(nuevaCuenta);
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtPrecio.Clear();
            MessageBox.Show("Cuenta Agregada", "Éxito");
            mostrarCuentas();
        }
        public void mostrarCuentas()
        {
            dgvPlataformas.Rows.Clear();
            Nodo temp = lsInventario.primero;
            while (temp != null)
            {
                dgvPlataformas.Rows.Add(temp.dato.Plataforma, temp.dato.Usuario, temp.dato.Contraseña, temp.dato.Precio);
                temp = temp.sig;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPlataformas.Columns.Add("Plataform", "Plataforma");
            dgvPlataformas.Columns.Add("User", "Usuario");
            dgvPlataformas.Columns.Add("Password", "Contraseña");
            dgvPlataformas.Columns.Add("Price", "Precio");

            dgvClientes.Columns.Add("DNI","DNI");
            dgvClientes.Columns.Add("Name","Nombre");
            dgvClientes.Columns.Add("Phone","Teléfono");
        }
    }
}
