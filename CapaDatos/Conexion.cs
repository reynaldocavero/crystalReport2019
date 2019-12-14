using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {

            MySqlConnection conexion = null;

            public MySqlConnection conectar()
            {
                conexion = new MySqlConnection("Server=localhost;Database=logistica;Uid=root;Pwd=;");
                return conexion;
            }
        
    }
}
