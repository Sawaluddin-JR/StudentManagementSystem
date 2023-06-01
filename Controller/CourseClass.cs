using MySqlConnector;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDevHtmlRenderer.Adapters;

namespace StudentManagementSystem.Controller
{
    internal class CourseClass :Model.Connection
    {
        Connection koneksi = new Connection();

        public void insertCompetency(string codeComp, string compName, string expertiseProg)
        {           
            string add = "INSERT INTO competency VALUES (" + "@CodeCompetency,@CompetencyName,@ExpertiseProgram)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@CodeCompetency", MySqlConnector.MySqlDbType.VarChar).Value = codeComp;
                cmd.Parameters.Add("@CompetencyName", MySqlConnector.MySqlDbType.VarChar).Value = compName;
                cmd.Parameters.Add("@ExpertiseProgram", MySqlConnector.MySqlDbType.VarChar).Value = expertiseProg;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Date Failed!! " + ex.Message);
            }
        }
        public DataTable selectCompetency(MySqlCommand command)
        {
            command.Connection = koneksi.GetConn();
            DataTable date = new DataTable();
            try
            { 
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return date;
        }
        public DataTable getCompetency(MySqlCommand command)
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
        public void updateCompetency(string code,string competencyName, string expertiseProg)
        { 
            string update = "UPDATE competency SET " + "CodeCompetency=@CodeCompetency,CompetencyName=@CompetencyName,ExpertiseProgram=@ExpertiseProgram " +
                "WHERE CodeCompetency= " + code;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@CodeCompetency", MySqlConnector.MySqlDbType.VarChar).Value = code;
                cmd.Parameters.Add("@CompetencyName", MySqlConnector.MySqlDbType.VarChar).Value = competencyName;
                cmd.Parameters.Add("@ExpertiseProgram", MySqlConnector.MySqlDbType.VarChar).Value = expertiseProg;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Date Failed!! " + ex.Message);
            }
        }
        public void deleteCompetency(string Code)
        {
            string delete = "DELETE FROM competency WHERE CodeCompetency=" + Code;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@CodeCompetency", MySqlConnector.MySqlDbType.VarChar).Value = Code;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed!!" + ex.Message);
            }
        }
        public DataTable searchCompetency(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM competency WHERE CONCAT(CodeCompetency,CompetencyName,ExpertiseProgram)LIKE '%" + search + "%'", koneksi.GetConn());
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
