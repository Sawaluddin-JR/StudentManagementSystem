using Guna.UI2.WinForms.Suite;
using MySqlConnector;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;
using System.Windows.Forms;

namespace StudentManagementSystem.Controller
{
    internal class ScoreClass : Model.Connection
    {
        Connection koneksi = new Connection();
        public void insertScore(string nis, string subCode, string Score, string Semester,string schoolYear,string Description)
        {            
            string add = "INSERT INTO score VALUES (" + "@NIS,@SubjCode,@Score,@Semester,@SchoolYear,@Description)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@NIS", MySqlConnector.MySqlDbType.VarChar).Value = nis;
                cmd.Parameters.Add("@SubjCode", MySqlConnector.MySqlDbType.VarChar).Value = subCode;
                cmd.Parameters.Add("@Score", MySqlConnector.MySqlDbType.VarChar).Value = Score;
                cmd.Parameters.Add("@Semester", MySqlConnector.MySqlDbType.VarChar).Value = Semester;
                cmd.Parameters.Add("@schoolYear", MySqlConnector.MySqlDbType.VarChar).Value = schoolYear;
                cmd.Parameters.Add("@Description", MySqlConnector.MySqlDbType.VarChar).Value = Description;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Date Failed!! " + ex.Message);
            } 
        }
        public DataTable getScore(MySqlCommand command)
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
        public bool checkScore(string nis,string subjectCode)
        {
            DataTable table = getScore(new MySqlCommand("SELECT * FROM score WHERE NIS= '"+ nis + "' AND SubjCode= '" + subjectCode + "'"));
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public void updateScore(string nis,string subjectCode, string score, string semester,string schoolYear,string description)
        {           
            string update = "UPDATE score SET Score=@Score,Semester=@Semester,SchoolYear=@SchoolYear,Description=@Description WHERE NIS= " + nis + " AND SubjCode= " + subjectCode; 
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@NIS", MySqlConnector.MySqlDbType.VarChar).Value = subjectCode;
                cmd.Parameters.Add("@SubjCode", MySqlConnector.MySqlDbType.VarChar).Value = subjectCode;
                cmd.Parameters.Add("@Score", MySqlConnector.MySqlDbType.VarChar).Value = score;
                cmd.Parameters.Add("@Semester", MySqlConnector.MySqlDbType.VarChar).Value = semester;
                cmd.Parameters.Add("@SchoolYear", MySqlConnector.MySqlDbType.VarChar).Value = schoolYear;
                cmd.Parameters.Add("@Description", MySqlConnector.MySqlDbType.VarChar).Value = description;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Date Failed!! " + ex.Message);
            }
        }
        public void deleteScore(string NIS)
        {
            string delete = "DELETE FROM score WHERE NIS=" + NIS;
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
        public DataTable searchScore(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT student.NIS,student.FirstName,score,score.Description,subjects.SubjectsName " +
                    "FROM student INNER JOIN score ON score.NIS=student.NIS INNER JOIN subjects ON score.SubjCode=subjects.CodeSubjects " +
                    "WHERE CONCAT(score.NIS,student.FirstName,subjects.SubjectsName,score.Description)LIKE '%" + search + "%'", koneksi.GetConn());
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
