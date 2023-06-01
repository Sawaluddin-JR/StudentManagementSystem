using MySqlConnector;
using System.Data;

namespace StudentManagementSystem.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection Conn;
        public MySqlDataReader dr;

        //Conn = new MySqlConnector("server=localhost;user=root;database=student_db");

        public MySqlConnection GetConn()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;user=root;database=school_management;AllowUserVariables=true";
            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed!! " + ex.Message);
            }
            return Conn;

            /* get
             {
                 return Conn;
             }*/
        }
        public void openConnect()
        {
            if (Conn.State == System.Data.ConnectionState.Closed) 
                Conn.Open();
        }
        public void closeConnect()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
                Conn.Close();
        }
    }
}
