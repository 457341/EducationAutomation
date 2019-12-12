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
                    MessageBox.Show("Ok");
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
