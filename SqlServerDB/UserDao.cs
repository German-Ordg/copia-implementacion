using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Pantallas_proyecto.SqlServerDB
{
    public class UserDao : ClsConexionBD
    {
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where nombre_usuario=@user or correo_electronico=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(3);
                        string accountPassword = reader.GetString(2);
                        var mailService = new EmailServices.SystemSupportMail();
                        mailService.sendMail(
                          subject: "SISTEMA: Peticion de recuperacion de contraseña",
                          body: "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                          "Tu contraseña es: " + accountPassword +
                          "\nComo motivo de seguridad, te pedimos que cambies tu contraseña inmediatamente al entrar al sistema.",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\n Solicitaste recuperar tu contraseña.\n" +
                          "Porfavor Revisa tu Correo: " + userMail +
                          "\n Como motivo de seguridad, te pedimos que cambies tu contraseña inmediatamente al entrar al sistema.";
                    }
                    else
                        return "Lo sentimos, tu no tienes una cuenta con ese correo o usuario";
                }
            }
        }

    }
}
