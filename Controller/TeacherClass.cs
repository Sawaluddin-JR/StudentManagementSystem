using MySqlConnector;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controller
{
    internal class TeacherClass : Model.Connection
    {
        Connection koneksi = new Connection();
        public void insertTeacher(string nip,string firstname, string lastname, DateTime bisthdate, string gender, string phone, string address,string lastEducation)
        { 
            string add = "INSERT INTO teacher VALUES (" + "@NIP,@FirstName,@LastName,@Birthdate,@Gender,@Phone,@Address,@LastEducation)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@NIP", MySqlConnector.MySqlDbType.VarChar).Value = nip;
                cmd.Parameters.Add("@FirstName", MySqlConnector.MySqlDbType.VarChar).Value = firstname;
                cmd.Parameters.Add("@LastName", MySqlConnector.MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@Birthdate", MySqlConnector.MySqlDbType.Date).Value = bisthdate;
                cmd.Parameters.Add("@Gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@Phone", MySqlConnector.MySqlDbType.VarChar).Value = phone;
                cmd.Parameters.Add("@Address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@LastEducation", MySqlConnector.MySqlDbType.VarChar).Value = lastEducation;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Date Failed!! " + ex.Message);
            }
        }
        public DataTable selectTeacher(MySqlCommand command)
        {
            DataTable date = new DataTable();
            try
            {
                string show = "SELECT * FROM teacher";
                da = new MySqlDataAdapter(show, GetConn());
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
        public string totalTeacher()
        {
            return exeCount("SELECT COUNT(*) FROM teacher");
        }
        public string manTeacher()
        {
            return exeCount("SELECT COUNT(*) FROM teacher WHERE Gender='Man'");
        }
        public string womanTeacher()
        {
            return exeCount("SELECT COUNT(*) FROM teacher WHERE Gender='Woman'");
        }
        public DataTable searchTeacher(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM teacher WHERE CONCAT(NIP,FirstName,LastName,Birthdate,Gender,Phone,Address,LastEducation)LIKE '%" + search + "%'", koneksi.GetConn());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
        public void deleteTeacher(string NIP)
        {
            string delete = "DELETE FROM teacher WHERE NIP=" + NIP;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@NIP", MySqlConnector.MySqlDbType.VarChar).Value = NIP;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!!" + ex.Message);
            }
        }
        public void updateTeacher(string nip,string firstname, string lastname, DateTime bisthdate, string gender, string phone, string address, string lastEducation)
        {
            string update = "UPDATE teacher SET " + "NIP=@NIP,FirstName=@FirstName,LastName=@LastName,Birthdate=@Birthdate,Gender=@Gender,Phone=@Phone,Address=@Address,LastEducation=@LastEducation " +
                "WHERE NIP= " + nip;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@NIP", MySqlConnector.MySqlDbType.VarChar).Value = nip;
                cmd.Parameters.Add("@FirstName", MySqlConnector.MySqlDbType.VarChar).Value = firstname;
                cmd.Parameters.Add("@LastName", MySqlConnector.MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@Birthdate", MySqlConnector.MySqlDbType.Date).Value = bisthdate;
                cmd.Parameters.Add("@Gender", MySqlConnector.MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@Phone", MySqlConnector.MySqlDbType.VarChar).Value = phone;
                cmd.Parameters.Add("@Address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@LastEducation", MySqlConnector.MySqlDbType.VarChar).Value = lastEducation;
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
