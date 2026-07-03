
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Agenda.ConexionDB
{
    internal class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection(
            "Server=localhost;Database=AgendaDB;Trusted_Connection=True;"
            );

            return cn;
        }

    }
}
