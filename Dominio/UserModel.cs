using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pantallas_proyecto.SqlServerDB;

namespace Pantallas_proyecto.Dominio
{
    public class UserModel 
    {
        UserDao userDao = new UserDao();

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

    }
}
