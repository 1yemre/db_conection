using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Veri_cekme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetsqlConnection();
            GetMYSQLConnection();
        }

        static void GetsqlConnection()
        {

            /*

            //mssql 
            string connectionString = @"Data Source=DESKTOP-E2US0\SQL;Initial Catalog=DBNotKayit;Integrated Security=SSPI;";
            // driver provider 
                                                    
            using(var connection = new SqlConnection(connectionString))
            {
                try
                {
                     connection.Open();
                    Console.WriteLine("Bağlantı sağlandı");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                { 
                    connection.Close();
                }

            }
            */
            Console.ReadLine();

        }

        static void GetMYSQLConnection()
        {
            string connectionString = @"Server=localhost;port=3306;database=northwind;user=root;password=;";


            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Bağlantı sağlandı");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
            Console.ReadLine();

        }

    }
}
