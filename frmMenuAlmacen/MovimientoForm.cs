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
    public partial class MovimientoFrorm : Form
    {
        List<Movimiento> listaMovimientos = new List<Movimiento>();

        public MovimientoFrorm()
        {
            InitializeComponent();
        }

        private void MovimientoForm_Load(object sender, EventArgs e)
        {
            // Configuración ComboBox
            cmbTipoMovimiento.Items.AddRange(new string[] { "Entrada", "Salida", "Ajuste" });
            cmbTipoMovimiento.SelectedIndex = 0;

            // Configuración DataGridView
            dgvMovimientos.Columns.Add("Tipo", "Tipo");
            dgvMovimientos.Columns.Add("Nombre", "Nombre");
            dgvMovimientos.Columns.Add("Modelo", "Modelo");
            dgvMovimientos.Columns.Add("Cantidad", "Cantidad");
            dgvMovimientos.Columns.Add("Fecha", "Fecha");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Por favor completa los campos de nombre y modelo.");
                return;
            }

            Movimiento nuevo = new Movimiento
            {
                Tipo = cmbTipoMovimiento.SelectedItem.ToString(),
                Nombre = txtNombre.Text,
                Modelo = txtModelo.Text,
                Cantidad = (int)nudCantidad.Value,
                Fecha = dtpFecha.Value
            };

            // Agrega a la lista
            listaMovimientos.Add(nuevo);

            // Muestra en el DataGridView
            dgvMovimientos.Rows.Add(nuevo.Tipo, nuevo.Nombre, nuevo.Modelo, nuevo.Cantidad, nuevo.Fecha.ToShortDateString());

            // Limpia campos
            txtNombre.Clear();
            txtModelo.Clear();
            nudCantidad.Value = 0;
            cmbTipoMovimiento.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 ventanaMovimientos = new Form1 ();
            ventanaMovimientos.Show();
        }
    }
}
