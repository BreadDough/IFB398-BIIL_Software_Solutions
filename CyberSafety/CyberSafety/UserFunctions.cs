using System;
using System.Data.SqlClient;

class UserFunctions
{
    //right click data connect, go to properties, copy and paste the connection string
    private string connectionString = "Data Source=DESKTOP-78ECCHH;Initial Catalog=csc_Public;Integrated Security=True";

    public bool UserExists(string loginname)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string sqlQuery = "SELECT LoginName FROM tUser WHERE LoginName = @Name";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Name";
                parameter.Value = loginname;

                command.Parameters.Add(parameter);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }

    public bool Register(PVTUserInformation PVTuser, PublicUserInformation PublicUser)
    {
        Console.WriteLine(PublicUser.loginname);

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                //query for private table values
                string PVTsqlQuery = "INSERT INTO tUser (LoginName, UserType, NameFirst, NameLast, OrganisationUserCode) " +
                    "VALUES (@LoginName, @UserType, @NameFirst, @NameLast, @OrganisationUserCode);";

                //query for the public table values
                string PublicsqlQuery = "INSERT INTO Access (LoginName, Password) " +
                    "VALUES (@LoginName, @Password);";

                using (SqlCommand command = new SqlCommand(PVTsqlQuery, connection))
                {
                    command.Parameters.Clear();

                    //command.Parameters.AddWithValue("@UserID", PVTuser.userID);
                    command.Parameters.AddWithValue("@LoginName", PublicUser.loginname);
                    command.Parameters.AddWithValue("@UserType", PVTuser.userType);
                    command.Parameters.AddWithValue("@NameFirst", PVTuser.nameFirst);
                    command.Parameters.AddWithValue("@NameLast", PVTuser.nameLast);
                    command.Parameters.AddWithValue("@OrganisationUserCode", PVTuser.organisationUserCode);

                    int result = command.ExecuteNonQuery();

                    if (result < 0) { return false; }
                }

                using (SqlCommand command = new SqlCommand(PublicsqlQuery, connection))
                {
                    command.Parameters.Clear();

                    //command.Parameters.AddWithValue("@UserID", PublicUser.userID);
                    command.Parameters.AddWithValue("@LoginName", PublicUser.loginname.ToString());
                    command.Parameters.AddWithValue("@Password", PublicUser.password.ToString());

                    int result = command.ExecuteNonQuery();

                    if (result < 0) { return false; }
                }

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
