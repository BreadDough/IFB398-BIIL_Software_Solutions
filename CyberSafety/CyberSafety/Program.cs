using System;
using System.Reflection.Metadata;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        UserFunctions functions = new UserFunctions();

        PVTUserInformation PVTUser = new PVTUserInformation(1234, "1234", "Org", "Brendan", "Dougherty", "QUT");
        PublicUserInformation PublicUser = new PublicUserInformation(1234, "Brendan_from_QUT", "1234");

        functions.Register(PVTUser, PublicUser);

        ////right click data connect, go to properties, copy and paste the connection string
        //string connectionString = "Data Source=DESKTOP-78ECCHH;Initial Catalog=csc_Public;Integrated Security=True";

        //using (SqlConnection connection = new SqlConnection(connectionString))
        //{
        //    try
        //    {
        //        connection.Open();
        //        Console.WriteLine("Connected to Server");

        //        string sqlQuery = "SELECT LoginName FROM tUser";

        //        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    string loginname = reader["LoginName"].ToString();

        //                    Console.WriteLine(loginname);
        //                }
        //            }
        //        }

        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //}
    }
}