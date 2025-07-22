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
    public partial class ConsultarProducto : Form
    {
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscado = txtBuscarCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigoBuscado))
            {
                MessageBox.Show("Ingresa un código para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = listaProductos.Where(p => p.Codigo.Equals(codigoBuscado, StringComparison.OrdinalIgnoreCase)).ToList();
            //No la tengo definida y tampococ estoy utilizando una local 
            dgvResultado.Rows.Clear();

            if (resultado.Count == 0)
            {
                MessageBox.Show("Producto no encontrado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var p in resultado)
                {
                    dgvResultado.Rows.Add(p.Codigo, p.Nombre, p.Proveedor, p.Precio.ToString("C"), p.Cantidad);
                }
            }
        }

        private void frmConsultarProducto_Load(object sender, DataGridViewCellEventArgs e)
        {
            dgvResultado.Columns.Add("Codigo", "Código");
            dgvResultado.Columns.Add("Nombre", "Producto");
            dgvResultado.Columns.Add("Proveedor", "Proveedor");
            dgvResultado.Columns.Add("Precio", "Precio");
            dgvResultado.Columns.Add("Cantidad", "Cantidad");
        }
    }
}
