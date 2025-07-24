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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMovimientoInventario_Click(object sender, EventArgs e)
        {
            MovimientoFrorm movimiento = new MovimientoFrorm();
            movimiento.Show();

            this.Hide(); // Cierra el formulario principal (Form1)
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
         

            frmRegistroProducto registro = new frmRegistroProducto();
            registro.Show();

            this.Hide(); // Cierra el formulario principal (Form1)
        }

        private void btnConsultaProductos_Click(object sender, EventArgs e)
        {
            ConsultarProducto ConsultarProducto = new ConsultarProducto();
            ConsultarProducto.Show();

            this.Hide(); // Cierra el formulario principal (Form1)
        }

    }
}
