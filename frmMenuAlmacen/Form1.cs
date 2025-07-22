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

            this.Close(); // Cierra el formulario principal (Form1)
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
         

            frmRegistroProducto registro = new frmRegistroProducto();
            registro.Show();

            this.Close(); // Cierra el formulario principal (Form1)
        }

        private void btnConsultaProductos_Click(object sender, EventArgs e)
        {
            frmRegistroProducto ConsultarProducto = new frmRegistroProducto();
            ConsultarProducto.Show();

            this.Close(); // Cierra el formulario principal (Form1)
        }

        
    }
}
