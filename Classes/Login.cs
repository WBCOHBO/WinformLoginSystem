using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Login.Classes
{
    internal class Login
    {
        public void createAccount(string Name, string PWD)
        {
            //Connect to "App.Config"
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            try
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                sqlConnect.Open();

                //SQL Parameters are safer than putting the values into the string
                //Use SQL Stored Procedure
                SqlCommand cmd = new SqlCommand("SaveAccount", sqlConnect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@textName", Name));
                cmd.Parameters.Add(new SqlParameter("@textPWD", PWD));


                cmd.ExecuteNonQuery();
                sqlConnect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error account !");
            }
        }

        public bool checkAccount(string name)
        {
            //Connect to "App.Config"
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            //讀出資料庫的使用者帳號
            string sqlQuery = "select AccountName from Account where AccountName = " + "'" + name + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnect);
            SqlDataReader readData = cmd.ExecuteReader();

            if(readData.HasRows)
            {
                readData.Close();
                cmd.ExecuteNonQuery();
                sqlConnect.Close();
                return true;

            }
            else
            {
                readData.Close();
                cmd.ExecuteNonQuery();
                sqlConnect.Close();
                return false;
            }

        }

        public bool checkAccount(string name ,string pwd)
        {
            //Connect to "App.Config"
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            //讀出資料庫的使用者帳號
            string sqlQuery = "select AccountName from Account where AccountName = " + "'" + name + "'" + "AND AccountPWD = " + "'" + pwd + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnect);
            SqlDataReader readData = cmd.ExecuteReader();

            if (readData.HasRows)
            {
                readData.Close();
                cmd.ExecuteNonQuery();
                sqlConnect.Close();
                return true;

            }
            else
            {
                readData.Close();
                cmd.ExecuteNonQuery();
                sqlConnect.Close();
                return false;
            }

        }
    }
}
