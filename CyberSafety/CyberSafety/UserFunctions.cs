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

    public bool RegisterUserInformation(PVTUserInformation PVTuser, PublicUserInformation PublicUser)
    {
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
                    //command.Parameters.AddWithValue("@UserID", PVTuser.userID);
                    command.Parameters.AddWithValue("@LoginName", PublicUser.Loginname);
                    command.Parameters.AddWithValue("@UserType", PVTuser.UserType);
                    command.Parameters.AddWithValue("@NameFirst", PVTuser.NameFirst);
                    command.Parameters.AddWithValue("@NameLast", PVTuser.NameLast);
                    command.Parameters.AddWithValue("@OrganisationUserCode", PVTuser.OrganisationUserCode);

                    int result = command.ExecuteNonQuery();

                    if (result < 0) { return false; }
                }

                using (SqlCommand command = new SqlCommand(PublicsqlQuery, connection))
                {
                    command.Parameters.Clear();

                    //command.Parameters.AddWithValue("@UserID", PublicUser.userID);
                    command.Parameters.AddWithValue("@LoginName", PublicUser.Loginname.ToString());
                    command.Parameters.AddWithValue("@Password", PublicUser.Password.ToString());

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

    public bool RegisterUserAddress(PublicUserInformation PublicUser, AddressTable AddressDetails)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                //query for address table values
                string sqlQuery = "INSERT INTO tAddress (AddressID, UserID, AddressType, Address1, Address2, Address3, " +
                    "City, PostCode, RegionalCouncil, State, Country, PostDate) " +
                    "VALUES (@AddressID, @UserID, @AddressType, @Address1, @Address2, @Address3, " +
                    "@City, @PostCode, @RegionalCouncil, @State, @Country, @PostDate);";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@AddressID", AddressDetails.AddressID);
                    command.Parameters.AddWithValue("@UserID", AddressDetails.UserID);
                    command.Parameters.AddWithValue("@AddressType", AddressDetails.AddressType);
                    command.Parameters.AddWithValue("@Address1", AddressDetails.Address1);
                    command.Parameters.AddWithValue("@Address2", AddressDetails.Address2);
                    command.Parameters.AddWithValue("@Address3", AddressDetails.Address3);
                    command.Parameters.AddWithValue("@City", AddressDetails.City);
                    command.Parameters.AddWithValue("@PostCode", AddressDetails.PostCode);
                    command.Parameters.AddWithValue("@RegionalCouncil", AddressDetails.RegionalCouncil);
                    command.Parameters.AddWithValue("@State", AddressDetails.State);
                    command.Parameters.AddWithValue("@Country", AddressDetails.Country);

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

    public bool RegisterUserContact(UserContact userContact)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                //query for address table values
                string sqlQuery = "INSERT INTO UserContact (ContactID, UserID, ContactType, ContactDetail, Notes) " +
                    "VALUES (@ContactID, @UserID, @ContactType, @ContactDetail, @Notes);";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@ContactID", userContact.ContactID);
                    command.Parameters.AddWithValue("@UserID", userContact.UserID);
                    command.Parameters.AddWithValue("@ContactType", userContact.ContactType);
                    command.Parameters.AddWithValue("@ContactDetail", userContact.ContactDetail);
                    command.Parameters.AddWithValue("@Notes", userContact.Notes);

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

    public bool RegisterDocument(Documentation document)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                //query for address table values
                string sqlQuery = "INSERT INTO tDocUpload (UserID, DocType, DocumentExt, DocHashCode, " +
                    "DocBin, AuditDate) " +
                    "VALUES (@UserID, @DocType, @DocumentExt, @DocHashCode, @DocBin, @AuditDate);";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", document.UserID);
                    command.Parameters.AddWithValue("@DocType", document.DocType);
                    command.Parameters.AddWithValue("@DocumentExt", document.DocExt);
                    command.Parameters.AddWithValue("@DocHashCode", document.DocHashCode);
                    command.Parameters.AddWithValue("@DocBin", document.DocBin);
                    command.Parameters.AddWithValue("@AuditDate", document.AuditDate);

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
