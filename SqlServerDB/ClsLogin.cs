using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Pantallas_proyecto
{
    public class ClsLogin : ClsConexionBD
    {

        ClsConexionBD conex = new ClsConexionBD();
        public bool Login(string user, string pass)
        {

            using (var conexion = GetSqlConnection())
            {

                conexion.Open();
                using (var comando = new SqlCommand())
                {

                    comando.Connection = conexion;
                    comando.CommandText = "select *from dbo.Usuarios where nombre_usuario = @user and contrasena = @pass ";
                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@pass", pass);

                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }

        }
    }
}
