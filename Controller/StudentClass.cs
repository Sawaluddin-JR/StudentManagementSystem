using MySqlConnector;
using StudentManagementSystem.Model;
using System.Data;

namespace StudentManagementSystem
{
    internal class StudentClass : Model.Connection
    {
        Connection koneksi = new Connection();

        public void insertStudent(string nis, string KodeComp, string firstname, string lastname, DateTime bisthdate, string gender, string phone, string address, byte[] img)
        {
            string add = "INSERT INTO student VALUES (" + "@NIS,@CodCompt,@FirstName,@LastName,@Birthdate,@Gender,@Phone,@Address,@Photo)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@NIS", MySqlConnector.MySqlDbType.VarChar).Value = nis;
                cmd.Parameters.Add("@CodCompt", MySqlConnector.MySqlDbType.VarChar).Value = KodeComp;
                cmd.Parameters.Add("@FirstName", MySqlConnector.MySqlDbType.VarChar).Value = firstname;
                cmd.Parameters.Add("@LastName", MySqlConnector.MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@Birthdate", MySqlConnector.MySqlDbType.Date).Value = bisthdate;
                cmd.Parameters.Add("@Gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@Phone", MySqlConnector.MySqlDbType.VarChar).Value = phone;
                cmd.Parameters.Add("@Address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@Photo", MySqlConnector.MySqlDbType.Blob).Value = img;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Date Failed!! " + ex.Message);
            }
        }
        public DataTable selectStudent(MySqlCommand command)
        {
            DataTable date = new DataTable();
            try
            {
                string show = "SELECT * FROM student";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return date;
        }
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, koneksi.GetConn());
            koneksi.openConnect();
            string count = command.ExecuteScalar().ToString();
            koneksi.closeConnect();
            return count;
        }
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }
        public string manStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender='Male'");
        }
        public string womanStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender='Female'");
        }

        // Untuk mencari data di murid
        public DataTable searchStudent(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM student WHERE CONCAT(NIS,CodCompt,FirstName,LastName,Birthdate,Gender,Phone,Address)LIKE '%" + search + "%'", koneksi.GetConn());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
        public void deleteStudent(string NIS)
        {
            string delete = "DELETE FROM student WHERE NIS=" + NIS;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@NIS", MySqlConnector.MySqlDbType.VarChar).Value = NIS;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!!" + ex.Message);
            }
        }
        public void updateStudent(string nis, string codeCompt, string firstname, string lastname, DateTime bisthdate, string gender, string phone, string address, byte[] img)
        {
            string update = "UPDATE student SET " + "NIS=@NIS,CodCompt=@CodCompt,FirstName=@FirstName,LastName=@LastName,Birthdate=@Birthdate,Gender=@Gender,Phone=@Phone,Address=@Address,Photo=@Photo " +
                "WHERE NIS= " + nis;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@NIS", MySqlConnector.MySqlDbType.VarChar).Value = nis;
                cmd.Parameters.Add("@CodCompt", MySqlConnector.MySqlDbType.VarChar).Value = codeCompt;
                cmd.Parameters.Add("@FirstName", MySqlConnector.MySqlDbType.VarChar).Value = firstname;
                cmd.Parameters.Add("@LastName", MySqlConnector.MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@Birthdate", MySqlConnector.MySqlDbType.Date).Value = bisthdate;
                cmd.Parameters.Add("@Gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@Phone", MySqlConnector.MySqlDbType.VarChar).Value = phone;
                cmd.Parameters.Add("@Address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@Photo", MySqlConnector.MySqlDbType.Blob).Value = img;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Date Failed!! " + ex.Message);
            }
        }
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = koneksi.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}