using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMenuAlmacen
{
    
        public class Producto
        {
            // Propiedades del producto
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Proveedor { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }

            // Constructor vacío
            public Producto() { }

            // Constructor con parámetros
            public Producto(string codigo, string nombre, string proveedor, decimal precio, int cantidad)
            {
                Codigo = codigo;
                Nombre = nombre;
                Proveedor = proveedor;
                Precio = precio;
                Cantidad = cantidad;
            }

            // Método opcional para mostrar información como texto
            public string ObtenerResumen()
            {
                return $"Código: {Codigo}\nProducto: {Nombre}\nProveedor: {Proveedor}\nPrecio: {Precio:C}\nCantidad: {Cantidad}";
            }

            // Método opcional para verificar si el producto está disponible
            public bool EstaDisponible()
            {
                return Cantidad > 0;
            }
        }
    }

