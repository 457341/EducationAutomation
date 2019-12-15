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
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TUser WHERE idNo=@idNo and password = @password", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@idNo", user.getIdNo());
                sqlCommand.Parameters.AddWithValue("@password", user.getPassword());

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

        public static DataSet listStaff(string staffID = "", string staffName = "", string staffSurname = "")
        {
            DataSet dataSet = new DataSet();
            SqlConnection sqlConnection = openConnection();

            string sqlCommandSELECT = "tStaff.ID as 'Identification number',tStaff.name as Name, UPPER(tStaff.surname) as Surname ,tStaff.startDate as 'Start Date',tDepartments.name as 'Deparment Name',tTasks.name 'Task Name',tEducationLevel.name 'Education' ";
            string sqlCommandFROM = "tStaff,tStaff_tDepartments,tDepartments,tStaff_tTasks,tTasks,tStaff_tEducationLevel,tEducationLevel ";
            string sqlCommandWHERE = "tStaff.ID = tStaff_tDepartments.ID and tStaff_tDepartments.departmentID = tDepartments.departmentID and " +
                    "tStaff.ID = tStaff_tTasks.ID and tStaff_tTasks.taskID = tTasks.taskID and " +
                    "tStaff.ID = tStaff_tEducationLevel.ID and tStaff_tEducationLevel.EducationLevelID = tEducationLevel.EducationLevelID" +
                     "";
            if (staffID != "")
            {
                sqlCommandWHERE = " tStaff.ID LIKE '%" + staffID + "%' and " + sqlCommandWHERE;
            }
            if (staffName != "")
            {
                sqlCommandWHERE = " tStaff.name LIKE '%" + staffName + "%'and " + sqlCommandWHERE;
            }
            if (staffSurname != "")
            {
                sqlCommandWHERE = " tStaff.surname LIKE '%" + staffSurname + "%'and " + sqlCommandWHERE;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand((" SELECT " + sqlCommandSELECT) + (" FROM " + sqlCommandFROM) + (" WHERE " + sqlCommandWHERE));
                sqlCommand.Connection = sqlConnection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet staffDataSet = new DataSet();
                sqlDataAdapter.Fill(staffDataSet);
                return staffDataSet;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                closeConnection(sqlConnection);
            }

            //return null;
        }

        public static void addStaff(Staff staff)
        {
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand tStaffSqlCommand = new SqlCommand("INSERT INTO tStaff (ID,name,surname) Values(@ID,@name,@surname)", sqlConnection); //Datetime eklenecek
                tStaffSqlCommand.Parameters.AddWithValue("@ID", staff.getID());
                tStaffSqlCommand.Parameters.AddWithValue("@name", staff.getName());
                tStaffSqlCommand.Parameters.AddWithValue("@surname", staff.getSurname());
                //tStaffSqlCommand.Parameters.AddWithValue("@startDate", staff.getDate());
                tStaffSqlCommand.ExecuteNonQuery();
                
                //Her özellik için o ozellik kendi tablosunda varsa sadece ilişki tablosuna ekler eğer tabloda yoksa hem ilişki hemde özellik tablosuna ekler
                if (hasRows("tDepartments", staff.getDepartment()))
                {
                    addToRelationTable("tStaff_tDepartments","departmentID",staff.getDepartment(),staff.getID());
                }
                else
                {
                    addToPropertyTable("tDepartments",staff.getDepartment());
                    addToRelationTable("tStaff_tDepartments", "departmentID", staff.getDepartment(), staff.getID());
                }

                if (hasRows("tTasks", staff.getTask()))
                {
                    addToRelationTable("tStaff_tTasks", "taskID", staff.getTask(), staff.getID());
                }
                else
                {
                    addToPropertyTable("tTasks", staff.getTask());
                    addToRelationTable("tStaff_tTasks", "taskID", staff.getTask(), staff.getID());
                }
                /* Education level da hiç veri yokken okunamıyor hatası alıyorum 
                if (hasRows("tEducationLevel", staff.getEducationLevel()))
                {
                    addToRelationTable("tStaff_tEducationLevel", "EducationLevelID", staff.getEducationLevel(), staff.getID());
                }
                else
                {
                    addToPropertyTable("tEducationLevel", staff.getDepartment());
                    addToRelationTable("tStaff_tEducationLevel", "EducationLevelID", staff.getEducationLevel(), staff.getID());
                }*/


            }
            catch (Exception exceptions)
            {
                MessageBox.Show(exceptions.Message);
                Application.Exit();
                throw;
            }
            finally
            {
                closeConnection(sqlConnection);
            }
        }

        private static bool hasRows(string tableName, string word)
        {
            bool result = false;
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT " + tableName + ".name FROM " + tableName + " WHERE "+tableName+".name = @word", sqlConnection);
                //sqlCommand.Parameters.AddWithValue("@tableName", tableName);
                //sqlCommand.Parameters.AddWithValue("@collumName", collumName);
                sqlCommand.Parameters.AddWithValue("@word", word);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    result = true;
                }
                sqlDataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }

        private static int getPropertyID(string tableName, string collumName,string name)
        {
            SqlConnection sqlConnection = openConnection();
            try
            { 
                SqlCommand sqlCommand = new SqlCommand("SELECT " + tableName + "." + collumName + " FROM " + tableName + " WHERE "+tableName+".name = @propertyName", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@propertyName", name);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                int propertyID = sqlDataReader.GetInt32(0);
                return propertyID;
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
        }

        private static void addToRelationTable(string relationTableName, string collumName,string name, string ID)
        {
            SqlConnection sqlConnection = openConnection();
            try
            {
                string[] tmp = relationTableName.Split('_');
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO " + relationTableName + " (ID," + collumName + ") Values(@ID,@propertyID)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ID", ID);
                sqlCommand.Parameters.AddWithValue("@propertyID", getPropertyID(tmp[1], collumName, name));
                sqlCommand.ExecuteNonQuery();
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
        }

        private static void addToPropertyTable(string tableName, string name)
        {
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO " + tableName + " (name) Values(@name)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.ExecuteNonQuery();
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
        }

        //Alttakiler veritabanına bağlanmakiçin kısa yollar
        private static SqlConnection openConnection()
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
        private static void closeConnection(SqlConnection sqlConnection)
        {
            //MessageBox.Show("Close Connections");
            sqlConnection.Close();
        }

    }
}
