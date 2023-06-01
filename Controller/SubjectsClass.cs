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
    internal class SubjectsClass : Model.Connection
    {
        Connection koneksi = new Connection();
        public void insertSubjects(string code, string codeCompt,string nip, string name, string hour, string levelClass,string description)
        {
            string add = "INSERT INTO subjects VALUES (" + "@CodeSubjects,@CodeCompt,@NIP,@SubjectsName,@Hour,@LevelClass,@Description)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@CodeSubjects", MySqlConnector.MySqlDbType.VarChar).Value = code;
                cmd.Parameters.Add("@CodeCompt", MySqlConnector.MySqlDbType.VarChar).Value = codeCompt;
                cmd.Parameters.Add("@NIP", MySqlConnector.MySqlDbType.VarChar).Value = nip;
                cmd.Parameters.Add("@SubjectsName", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Hour", MySqlConnector.MySqlDbType.VarChar).Value = hour;
                cmd.Parameters.Add("@LevelClass", MySqlConnector.MySqlDbType.VarChar).Value = levelClass;
                cmd.Parameters.Add("@Description", MySqlConnector.MySqlDbType.VarChar).Value = description;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Date Failed!! " + ex.Message);
            }
        }
        public DataTable getSubjects(MySqlCommand command)
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
        public void updateSubjects(string code,string codeCompt, string nip, string name, string hour, string levelClass, string description)
        {
            string update = "UPDATE subjects SET CodeSubjects=@CodeSubjects,CodeCompt=@CodeCompt,NIP=@NIP,SubjectsName=@SubjectsName,Hour=@Hour,LevelClass=@LevelClass,Description=@Description " +
                "WHERE CodeSubjects= " + code + " AND CodeCompt= " + codeCompt + " AND NIP= " + nip;                                                                                                                                                                             
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@CodeSubjects", MySqlConnector.MySqlDbType.VarChar).Value = code;
                cmd.Parameters.Add("@CodeCompt", MySqlConnector.MySqlDbType.VarChar).Value = codeCompt;
                cmd.Parameters.Add("@NIP", MySqlConnector.MySqlDbType.VarChar).Value = nip;
                cmd.Parameters.Add("@SubjectsName", MySqlConnector.MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Hour", MySqlConnector.MySqlDbType.VarChar).Value = hour;
                cmd.Parameters.Add("@LevelClass", MySqlConnector.MySqlDbType.VarChar).Value = levelClass;
                cmd.Parameters.Add("@Description", MySqlConnector.MySqlDbType.VarChar).Value = description;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Date Failed!! " + ex.Message);
            }
        }
        public void deleteSubjects(string Code)
        {
            string delete = "DELETE FROM subjects WHERE CodeSubjects=" + Code;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@CodeSubjects", MySqlConnector.MySqlDbType.VarChar).Value = Code;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!!" + ex.Message);
            }
        }
        public DataTable searchSubjects(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT subjects.CodeSubjects,subjects.CodeCompt,competency.CompetencyName,subjects.NIP, teacher.FirstName, teacher.LastName,subjects.SubjectsName,subjects.Hour, " +
                    "subjects.LevelClass,subjects.Description FROM subjects INNER JOIN teacher ON subjects.NIP=teacher.NIP " +
                    "WHERE CONCAT(teacher.FirstName,teacher.LastName,subjects.SubjectsName,subjects.LevelClass,subjects.CodeSubjects)LIKE '%" + search + "%'", koneksi.GetConn());
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
