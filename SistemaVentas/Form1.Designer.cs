namespace SistemaVentas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlataformas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRegistrarPlataforma = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPlataformas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btVenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btRegistrarCliente = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvListaCuentas = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btArbolClientes = new System.Windows.Forms.Button();
            this.tvClientes = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlataformas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCuentas)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvPlataformas);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(501, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de Plataformas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuentas: ";
            // 
            // dgvPlataformas
            // 
            this.dgvPlataformas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlataformas.Location = new System.Drawing.Point(5, 55);
            this.dgvPlataformas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPlataformas.Name = "dgvPlataformas";
            this.dgvPlataformas.RowHeadersWidth = 51;
            this.dgvPlataformas.RowTemplate.Height = 24;
            this.dgvPlataformas.Size = new System.Drawing.Size(472, 150);
            this.dgvPlataformas.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRegistrarPlataforma);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtContrasena);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbPlataformas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(520, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(288, 267);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de Plataformas";
            // 
            // btRegistrarPlataforma
            // 
            this.btRegistrarPlataforma.Location = new System.Drawing.Point(105, 202);
            this.btRegistrarPlataforma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegistrarPlataforma.Name = "btRegistrarPlataforma";
            this.btRegistrarPlataforma.Size = new System.Drawing.Size(155, 31);
            this.btRegistrarPlataforma.TabIndex = 8;
            this.btRegistrarPlataforma.Text = "Registrar Plataforma";
            this.btRegistrarPlataforma.UseVisualStyleBackColor = true;
            this.btRegistrarPlataforma.Click += new System.EventHandler(this.btRegistrarPlataforma_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(92, 159);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio: ";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(92, 126);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(180, 22);
            this.txtContrasena.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(92, 90);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario: ";
            // 
            // cbPlataformas
            // 
            this.cbPlataformas.FormattingEnabled = true;
            this.cbPlataformas.Items.AddRange(new object[] {
            "Netflix",
            "HBO",
            "Disney",
            "Prime Video"});
            this.cbPlataformas.Location = new System.Drawing.Point(92, 33);
            this.cbPlataformas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPlataformas.Name = "cbPlataformas";
            this.cbPlataformas.Size = new System.Drawing.Size(180, 24);
            this.cbPlataformas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plataforma: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btVenta);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dgvClientes);
            this.groupBox3.Location = new System.Drawing.Point(301, 298);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(491, 267);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cola de Clientes";
            // 
            // btVenta
            // 
            this.btVenta.Location = new System.Drawing.Point(347, 218);
            this.btVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(135, 28);
            this.btVenta.TabIndex = 9;
            this.btVenta.Text = "Realizar Venta";
            this.btVenta.UseVisualStyleBackColor = true;
            this.btVenta.Click += new System.EventHandler(this.btVenta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Clientes:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(11, 46);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(471, 150);
            this.dgvClientes.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btRegistrarCliente);
            this.groupBox4.Controls.Add(this.txtTelefono);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDNI);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(13, 298);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(271, 267);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registro de Clientes: ";
            // 
            // btRegistrarCliente
            // 
            this.btRegistrarCliente.Location = new System.Drawing.Point(64, 204);
            this.btRegistrarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegistrarCliente.Name = "btRegistrarCliente";
            this.btRegistrarCliente.Size = new System.Drawing.Size(135, 28);
            this.btRegistrarCliente.TabIndex = 8;
            this.btRegistrarCliente.Text = "Registrar Cliente";
            this.btRegistrarCliente.UseVisualStyleBackColor = true;
            this.btRegistrarCliente.Click += new System.EventHandler(this.btRegistrarCliente_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(92, 144);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(163, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teléfono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre: ";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(92, 75);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(163, 22);
            this.txtDNI.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "DNI: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.dgvListaCuentas);
            this.groupBox5.Location = new System.Drawing.Point(814, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(519, 261);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Historial de Cuentas - Lista";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cuentas: ";
            // 
            // dgvListaCuentas
            // 
            this.dgvListaCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCuentas.Location = new System.Drawing.Point(11, 55);
            this.dgvListaCuentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListaCuentas.Name = "dgvListaCuentas";
            this.dgvListaCuentas.RowHeadersWidth = 51;
            this.dgvListaCuentas.RowTemplate.Height = 24;
            this.dgvListaCuentas.Size = new System.Drawing.Size(496, 159);
            this.dgvListaCuentas.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btArbolClientes);
            this.groupBox6.Controls.Add(this.tvClientes);
            this.groupBox6.Location = new System.Drawing.Point(814, 298);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(287, 267);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Árbol de Clientes";
            // 
            // btArbolClientes
            // 
            this.btArbolClientes.Location = new System.Drawing.Point(73, 236);
            this.btArbolClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btArbolClientes.Name = "btArbolClientes";
            this.btArbolClientes.Size = new System.Drawing.Size(135, 28);
            this.btArbolClientes.TabIndex = 10;
            this.btArbolClientes.Text = "Mostrar Árbol";
            this.btArbolClientes.UseVisualStyleBackColor = true;
            this.btArbolClientes.Click += new System.EventHandler(this.btArbolClientes_Click);
            // 
            // tvClientes
            // 
            this.tvClientes.Location = new System.Drawing.Point(8, 20);
            this.tvClientes.Name = "tvClientes";
            this.tvClientes.Size = new System.Drawing.Size(273, 199);
            this.tvClientes.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 579);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlataformas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCuentas)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPlataformas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPlataformas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRegistrarPlataforma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btRegistrarCliente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvListaCuentas;
        private System.Windows.Forms.Button btVenta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TreeView tvClientes;
        private System.Windows.Forms.Button btArbolClientes;
    }
}

