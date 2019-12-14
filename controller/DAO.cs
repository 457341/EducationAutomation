using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EducationAutomation
{
    class DAO
    {
        public static string login(User user)
        {
            string result;
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TUser WHERE idNo=@idNo and password = @password",sqlConnection);
                sqlCommand.Parameters.AddWithValue("@idNo",user.getIdNo());
                sqlCommand.Parameters.AddWithValue("@password",user.getPassword());

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                //
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Close();
                    sqlCommand = new SqlCommand("SELECT tTasks.name FROM tTasks WHERE tTasks.taskID = (SELECT tStaff_tTasks.taskID FROM tStaff_tTasks WHERE tStaff_tTasks.ID =@ID)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@ID", user.getIdNo());
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    result = sqlDataReader.GetString(0);
                    return result;
                }
                else
                {
                    MessageBox.Show("Hoop Hemşerim nereye");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
                throw;
            }
            finally
            {
                closeConnection(sqlConnection);
            }

            return null;
        }

        public static DataSet listStaff()
        {
            DataSet dataSet = new DataSet();
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("" +
                    "SELECT tStaff.ID,(tStaff.name+' '+tStaff.surname) as 'name surname',tStaff.startDate,tDepartments.name,tTasks.name,tEducationLevel.name " +
                    "FROM tStaff,tStaff_tDepartments,tDepartments,tStaff_tTasks,tTasks,tStaff_tEducationLevel,tEducationLevel " +
                    "WHERE tStaff.ID = tStaff_tDepartments.ID and tStaff_tDepartments.departmentID = tDepartments.departmentID and " +
                    "tStaff.ID = tStaff_tTasks.ID and tStaff_tTasks.taskID = tTasks.taskID and " +
                    "tStaff.ID = tStaff_tEducationLevel.ID and tStaff_tEducationLevel.EducationLevelID = tEducationLevel.EducationLevelID" +
                    "");
                sqlCommand.Connection = sqlConnection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataSet);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }

            return dataSet;
        }

        //Alttakiler veritabanına bağlanmakiçin kısa yollar
        public static SqlConnection openConnection()
        {
            SqlConnection sqlConnection = null;
            try
            {
                //Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\IHTI\\Desktop\\Odevler-Calısma\\EducationAutomation\\EducationAutomation\\EducationDatebase.mdf;Integrated Security=True

                //Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=cd ..\\EducationDatebase.mdf;Integrated Security=True

                string path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\IHTI\\Desktop\\Odevler-Calısma\\EducationAutomation\\EducationAutomation\\EducationDatebase.mdf;Integrated Security=True";
                sqlConnection = new SqlConnection(path);
                sqlConnection.Open();
                //MessageBox.Show("Open Connections");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
            return sqlConnection;
        }
        public static void closeConnection(SqlConnection sqlConnection)
        {
            //MessageBox.Show("Close Connections");
            sqlConnection.Close();
        }

    }
}
