using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Pantallas_proyecto
{
    class Productos
    {

        private String descripcion;
        private int codigo_producto;
        private int cantidad;
        private int categoria;
        private double precio_actual;
        private double descuento;
        private string talla;
        private string des_categoria;

        // encapsulamiento 
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio_actual { get => precio_actual; set => precio_actual = value; }
        public string Talla { get => talla; set => talla = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public string Descripcion_Categoria { get => des_categoria; set => des_categoria = value; }


        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd; // comandos de sql


        public void agregar()
        {
            conect.abrir();
            cmd = new SqlCommand(" SET IDENTITY_INSERT Productos ON Insert into Productos (codigo_producto, codigo_categoria, descripcion_producto," +
                " cantidad_existente, precio_actual, descuento_producto, talla ) values(" + codigo_producto + ", " + categoria + ", '" + descripcion + "'," + cantidad + "," + precio_actual + "," + descuento + ",'" + talla + "') SET IDENTITY_INSERT Productos OFF ", conect.conexion); //Asignacion de valores en la bd
            cmd.ExecuteNonQuery();
            MessageBox.Show("Los datos han sido insertados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conect.cerrar();
        }


        public int buscar(String dgv)
        {

            conect.abrir();


            string query = "Select *from Categoria_Producto where descripcion_categoria =" + "'" + des_categoria + "'";
            SqlCommand command = new SqlCommand(query, conect.conexion);

            int lastId = Convert.ToInt32(command.ExecuteScalar());




            conect.cerrar();
            return lastId;


        }


    }
}