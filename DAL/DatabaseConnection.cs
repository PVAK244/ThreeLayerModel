using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DatabaseConnection
    {
        protected string connectString= "Data Source=localhost;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True";
        protected SqlConnection? conn;
        public void OpenConnection()
        {
            if (conn == null) conn = new SqlConnection(connectString);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }

    }
}
