using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace EducationAutomation
{
    class DAO
    {
        public static void personelGuncelle(Personel personel,string oncekiKimlikNo)
        {
        }
        public static void personelSil(Personel personel)
        {
            SqlConnection sqlConnection = openConnection();
            try
            {
                //DELETE FROM tPersonel WHERE tPersonel.kimlikNo = @kimlikNo
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM tPersonel WHERE tPersonel.kimlikNo = @kimlikNo", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@kimlikNo", personel.getKimlikNo());
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        public static bool personelEkle(Personel personel)
        {
            SqlConnection sqlConnection = openConnection();
            try
            {
                // @kimlikNo , @ad , @soyad , @baslamaTarih , @bolumAd , @gorevAd , @egitim
                SqlCommand sqlCommand = new SqlCommand("sp_personelEkle",sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@kimNo", personel.getKimlikNo());
                sqlCommand.Parameters.AddWithValue("@ad",personel.getPersonelAd());
                sqlCommand.Parameters.AddWithValue("@soyad",personel.getPersonelSoyad());
                sqlCommand.Parameters.AddWithValue("@basTarih", personel.getBaslamaTarih());
                sqlCommand.Parameters.AddWithValue("@bolAd", personel.getBolumAd());
                sqlCommand.Parameters.AddWithValue("@gorAd", personel.getGorevAd());
                sqlCommand.Parameters.AddWithValue("@egitAd", personel.getEgitimAd());
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
                MessageBox.Show(e.Message);
                throw;
            }
        }
        public static DataSet personelListele(Personel arananPersonel)
        {
            SqlConnection sqlConnection = openConnection();
            string sqlKomut = "select KimlikNo,personelAd,personelSoyad,baslamaTarih,bolumAd,gorevAd,egitimAd from view_personel ";
            string kosul = " WHERE 1 = 1 ";
            try
            {
                if(arananPersonel.getKimlikNo() != "")
                {
                    kosul = kosul + " and kimlikNo LIKE '%" + arananPersonel.getKimlikNo() +"%'";
                }
                else if (arananPersonel.getPersonelAd() != "")
                {
                    kosul = kosul + " and personelAd LIKE '%" + arananPersonel.getPersonelAd()+"%'";
                }
                else if (arananPersonel.getPersonelSoyad() != "")
                {
                    kosul = kosul + " and personelSoyad LIKE '%" + arananPersonel.getPersonelSoyad()+"%'";
                }
                else if (arananPersonel.getGorevNo() > 0)
                {
                    kosul = kosul + " and gorevNo = " + arananPersonel.getGorevNo();
                }
                else if (arananPersonel.getBolumNo() > 0)
                {
                    kosul = kosul + " and bolumNo = " + arananPersonel.getBolumNo();
                }
                else if (arananPersonel.getEgitimNo() > 0)
                {
                    kosul = kosul + " and egitimNo = " + arananPersonel.getEgitimNo();
                }
                sqlKomut = sqlKomut + kosul;

                SqlCommand sqlCommand = new SqlCommand(sqlKomut,sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                return dataSet;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally 
            {
                sqlConnection.Close();
            }
            
        }
        public static DataSet bolumListele()
        {
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbolum", sqlConnection);
                //sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public static int giris(Kullanici kullanici)
        {
            int sonuc;
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tKullanici WHERE kimlikNo = @kimlikNo and sifre = @sifre", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@kimlikNo", kullanici.getKimlikNo());
                sqlCommand.Parameters.AddWithValue("@sifre", kullanici.getSifte());

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Close();
                    sqlCommand = new SqlCommand("SELECT tPersonel.gorevNo FROM tPersonel WHERE tPersonel.kimlikNo = @kimlikNo", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@kimlikNo", kullanici.getKimlikNo());
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows)
                    {
                        sonuc = sqlDataReader.GetInt32(0);
                        sqlDataReader.Close();
                    }
                    else
                    {
                        sonuc = -1;
                    }
                }
                else
                {
                    sonuc = -1;
                }
                return sonuc;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;

            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //Yardımcı fonksiyonlar
        private void loger()
        {
            string yol = "";
        }
        private static SqlConnection openConnection()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\IHTI\\Desktop\\Odevler-Calısma\\EducationAutomation\\EducationAutomation\\EgitimVeriTabani.mdf;Integrated Security=True");
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            
        }

        /*
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
                    if (sqlDataReader.HasRows)
                    {
                        result = sqlDataReader.GetString(0);
                    }
                    else
                    {
                        result = "error";
                    }

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

        public static void addStaff(Personel personel)
        {
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand tStaffSqlCommand = new SqlCommand("INSERT INTO tStaff (ID,name,surname,startDate) Values(@ID,LOWER( @name ),LOWER( @surname ),@startDate)", sqlConnection); //Datetime eklenecek
                tStaffSqlCommand.Parameters.AddWithValue("@ID", personel.getID());
                tStaffSqlCommand.Parameters.AddWithValue("@name", personel.getName());
                tStaffSqlCommand.Parameters.AddWithValue("@surname", personel.getSurname());
                tStaffSqlCommand.Parameters.AddWithValue("@startDate", personel.getDate());
                tStaffSqlCommand.ExecuteNonQuery();

                //Her özellik için o ozellik kendi tablosunda varsa sadece ilişki tablosuna ekler eğer tabloda yoksa hem ilişki hemde özellik tablosuna ekler
                controlAndAdd(personel);


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

        public static void deleteStaff(Staff staff)
        {
            SqlConnection sqlConnection = openConnection();
            SqlCommand deleteToRelationSqlCommand = null;
            try
            {
                deleteToRelationSqlCommand = new SqlCommand("DELETE FROM tStaff_tDepartments WHERE tStaff_tDepartments.ID = @ID and 1 != (SELECT tStaff_tTasks.taskID FROM tStaff_tTasks WHERE ID = @ID ) ;" +
                                                            "DELETE FROM tStaff_tEducationLevel WHERE tStaff_tEducationLevel.ID = @ID and 1 != (SELECT tStaff_tTasks.taskID FROM tStaff_tTasks WHERE ID = @ID ) ;" +
                                                            "DELETE FROM tStaff_tTasks WHERE tStaff_tTasks.ID = @ID and 1 != (SELECT tStaff_tTasks.taskID FROM tStaff_tTasks WHERE ID = @ID ) ;", sqlConnection);
                deleteToRelationSqlCommand.Parameters.AddWithValue("@ID",staff.getID());
                if (deleteToRelationSqlCommand.ExecuteNonQuery() > 0)
                {
                    SqlCommand deleteToStaffTableSqlCommand = new SqlCommand("DELETE FROM tStaff WHERE tStaff.ID = @ID ", sqlConnection);
                    deleteToStaffTableSqlCommand.Parameters.AddWithValue("@ID", staff.getID());
                    deleteToStaffTableSqlCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("En Yüksek Görevliyi Silemezsiniz.");                }               
                }
            catch (Exception exception)
            {
                deleteToRelationSqlCommand.Cancel();
                MessageBox.Show(exception.Message);
                Application.Exit();
                throw;
            }
            finally
            {
                closeConnection(sqlConnection);
            }
        }

        //Alttaki 5 tanesi Ekleme işlemi için Yazdığım yardımcı fonksiyonlar --Emre ihtiyar
        private static bool hasRows(string tableName, string word)
        {
            bool result = false;
            SqlConnection sqlConnection = openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT " + tableName + ".name FROM " + tableName + " WHERE "+tableName+".name = LOWER( @word ) " , sqlConnection);
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
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO " + relationTableName + " (ID," + collumName + ") Values(@ID,LOWER( @propertyID ))", sqlConnection);
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
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO " + tableName + " (name) Values( LOWER( @name ))", sqlConnection);
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

        private static void controlAndAdd(Staff staff)
        {
            if (hasRows("tDepartments", staff.getDepartment()))
            {
                addToRelationTable("tStaff_tDepartments", "departmentID", staff.getDepartment(), staff.getID());
            }
            else
            {
                addToPropertyTable("tDepartments", staff.getDepartment());
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
            if (hasRows("tEducationLevel", staff.getEducationLevel()))
            {
                addToRelationTable("tStaff_tEducationLevel", "EducationLevelID", staff.getEducationLevel(), staff.getID());
            }
            else
            {
                addToPropertyTable("tEducationLevel", staff.getEducationLevel());
                addToRelationTable("tStaff_tEducationLevel", "EducationLevelID", staff.getEducationLevel(), staff.getID());
            }
        }

        //Alttakiler veritabanına bağlanmakiçin kısa yollar  -Emre ihtiyar
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
        */
    }
}
