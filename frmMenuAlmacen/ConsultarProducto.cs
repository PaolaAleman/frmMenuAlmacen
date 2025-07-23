using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuAlmacen
{
    public partial class ConsultarProducto : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
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
            }string query = "SELECT * FROM Inventario_2024 WHERE marca LIKE @value";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                try
                {
                    cmd.Parameters.AddWithValue("@value","%" + codigoBuscado + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dgvResultado.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 ventanaMovimientos = new Form1();
            ventanaMovimientos.Show();

            this.Close();
        }
    }
}
