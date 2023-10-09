using System;
using System.Reflection.Metadata;
using System.Data.SqlClient;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        UserFunctions functions = new UserFunctions();

        functions.Login();

        PVTUserInformation PVTUser = new PVTUserInformation(1234, "1234", "Org", "Brendan", "Dougherty", "QUT");
        PublicUserInformation PublicUser = new PublicUserInformation(1234, "Brendan_from_QUT", "1234");
        //AddressTable Address = new AddressTable();

        //functions.RegisterUserInformation(PVTUser, PublicUser);

        UserContact userContact = new UserContact(1, 1, "Phone", "12345678", "test");
        //functions.RegisterUserContact(userContact);

        DateTime testtime = new DateTime(2024, 01, 01);
        Documentation document = new Documentation(1234, 1, "idk", "test", "idk", testtime);
        //functions.RegisterDocument(document);

        
        
    }
}