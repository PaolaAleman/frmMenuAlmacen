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
    public partial class frmRegistroProducto : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
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
            nuevoRegistro();
        }

        private void frmRegistroProducto_Load(object sender, EventArgs e)
        {
            loadBase();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 ventanaMovimientos = new Form1();
            ventanaMovimientos.Show();

            this.Close();
        }

        private void loadBase()
        {
            string query = "SELECT TOP 10 * FROM Inventario_2024 WHERE fecha is NOT null  ORDER BY fecha";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStock.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void nuevoRegistro()
        {
            string query = "INSERT INTO Inventario_2024 (modelo,especificacion,marca,precio,cantidad,fecha)VALUES (@modelo, @especificacion, @marca, @precio, @cantidad, @fecha)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@modelo", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@especificacion", txtProducto.Text);
                    cmd.Parameters.AddWithValue("@marca", txtProveedor.Text);
                    cmd.Parameters.AddWithValue("@precio", nudPrecio.Value);
                    cmd.Parameters.AddWithValue("@cantidad", nudCantidad.Value);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("✔️ Material registrado exitosamente.", "Registro completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadBase();
                        // Limpiar campos
                        txtCodigo.Clear();
                        txtProducto.Clear();
                        txtProveedor.Clear();
                        nudPrecio.Value = 0;
                        nudCantidad.Value = 0;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            

        }
    }
}

