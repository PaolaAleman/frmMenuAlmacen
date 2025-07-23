using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuAlmacen
{
    public partial class frmRegistroProducto : Form
    {
        public frmRegistroProducto()
        {
            InitializeComponent();
        }
        
            private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                MessageBox.Show("Por favor completa los campos de Código, Producto y Proveedor.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudPrecio.Value <= 0 || nudCantidad.Value <= 0)
            {
                MessageBox.Show("El precio y la cantidad deben ser mayores a cero.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto nuevo = new Producto
            {
                Codigo = txtCodigo.Text,
                Nombre = txtProducto.Text,
                Proveedor = txtProveedor.Text,
                Precio = nudPrecio.Value,
                Cantidad = (int)nudCantidad.Value
            };


            // Mostrar en el DataGridView
            dgvStock.Rows.Add(nuevo.Codigo, nuevo.Nombre, nuevo.Proveedor, nuevo.Precio.ToString("C"), nuevo.Cantidad);

            MessageBox.Show("✔️ Material registrado exitosamente.", "Registro completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txtCodigo.Clear();
            txtProducto.Clear();
            txtProveedor.Clear();
            nudPrecio.Value = 0;
            nudCantidad.Value = 0;

            dgvStock.Rows.Add(nuevo.Codigo, nuevo.Nombre, nuevo.Proveedor, nuevo.Precio.ToString("C"), nuevo.Cantidad);

        }

        private void frmRegistroProducto_Load(object sender, EventArgs e)
        {
            dgvStock.Columns.Add("Codigo", "Código");
            dgvStock.Columns.Add("Nombre", "Producto");
            dgvStock.Columns.Add("Proveedor", "Proveedor");
            dgvStock.Columns.Add("Precio", "Precio");
            dgvStock.Columns.Add("Cantidad", "Cantidad");

            // Mostrar los productos existentes si hay alguno
            dgvStock.Rows.Clear();

            /* foreach (var p in listaProductos)
            {
                dgvStock.Rows.Add(p.Codigo, p.Nombre, p.Proveedor, p.Precio.ToString("C"), p.Cantidad);
            }*/
        }

        
    }
}

