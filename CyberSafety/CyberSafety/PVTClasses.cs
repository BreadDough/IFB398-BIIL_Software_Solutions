using System;

class PVTUserInformation
{
    public int userID { get; set; }
    public string userCode_P { get; set; }
    public string userCode_C { get; set; }
    public string password { get; set; }
    public string userType { get; set; }
    public string nameFirst { get; set; }
    public string nameLast { get; set; }
    public string nameOrganisation { get; set; }
    public string organisationUserCode { get; set; }
    public string publicKey { get; set; }
    public bool mfa { get; set; }

    public PVTUserInformation(int UserID, string UserCode_P, 
        string UserCode_C, string Password, 
        string UserType, string NameFirst, 
        string NameLast,
        string NameOrganisation, 
        string OrganisationUserCode, 
        string PublicKey, bool MFA)
    {
        this.userID = UserID;
        this.userCode_P = UserCode_P;
        this.userCode_C = UserCode_C;
        this.password = Password;
        this.userType = UserType;
        this.nameFirst = NameFirst;
        this.nameLast = NameLast;
        this.nameOrganisation = NameOrganisation;
        this.organisationUserCode = OrganisationUserCode;
        this.publicKey = PublicKey;
        this.mfa = MFA;
    }
    public PVTUserInformation(int UserID, string Password,
        string UserType, string NameFirst,
        string NameLast,
        string OrganisationUserCode)
    {
        this.userID = UserID;
        this.password = Password;
        this.userType = UserType;
        this.nameFirst = NameFirst;
        this.nameLast = NameLast;
        this.organisationUserCode = OrganisationUserCode;
    }
}


class AddressTable
{
    private string addressID;
    private string userCode;
    private string addressType;
    private string address1;
    private string address2;
    private string city;
    private int postcode;
    private string state;
    private string country;

    public AddressTable(string addressID, string userCode, 
        string addressType, string address1, string address2,
        string city, int postcode, string state, string country)
    {
        string AddressID = addressID;
        string UserCode = userCode;
        string AddressType = addressType;
        string Address1 = address1;
        string Address2 = address2;
        string City = city;
        int Postcode = postcode;
        string State = state;
        string Country = country;
    }

    public string AddressID { get; set; }
    public string UserCode { get; set; }
    public string AddressType { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public int Postcode { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}

class eMailAddresses
{
    private int eMailID;
    private string userCode;
    private string eMailType;
    private string eMailAddress;
    private bool verified;

    public eMailAddresses(int eMailID, string userCode, string eMailType, 
        string eMailAddress, bool verified)
    {
        int EMailID = eMailID;
        string UserCode = userCode;
        string EMailType = eMailType;
        string EMailAddress = eMailAddress;
        bool Verified = verified;
    }

    public int EMailID { get; set; }
    public string UserCode { get; set; }
    public string EMailType { get; set; }
    public string EMailAddress { get; set; }
    public bool Verified { get; set; }
}

class Documentation
{
    private int documentID;
    private string userCode;
    private string docType;
    private string documentExt;
    private string docHashCode;
    private DateTime dateExpire;
    private string key001;
    private string key002;
    private string key003;
    private string key004;

    public Documentation(int documentID, string userCode,
        string docType, string documentExt, string docHashCode, DateTime dateExpire,
        string key001, string key002, string key003, string key004)
    {
        int DocumentID = documentID;
        string UserCode = userCode;
        string DocType = docType;
        string DocumentExt = documentExt;
        string DocumentHashCode = docHashCode;
        DateTime DateExpire = dateExpire;
        string Key001 = key001;
        string Key002 = key002;
        string Key003 = key003;
        string Key004 = key004;
    }

    public int DocumentID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }
    public string DocumentExt { get; set; }
    public string DocumentHashCode { get; set; }
    public DateTime DateExpire { get; set; }
    public string Key001 { get; set; }
    public string Key002 { get; set; }
    public string Key003 { get; set; }
    public string Key004 { get; set; }

}

class Requests
{
    private int requestID;
    private string userCode;
    private string docType;

    public Requests(int requestID, string userCode, string docType)
    {
        int RequestID = requestID;
        string UserCode = userCode;
        string DocType = docType;
    }

    public int RequestID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }
}

class DocSandBoxE
{
    private int docSandBoxID;
    private string userCode;
    private string docType;
    private string documentExt;
    private string docHashCode;

    public DocSandBoxE(int docSandBoxID, string userCode, string docType, string documentExt, string docHashCode)
    {
        int DocSandBoxID = docSandBoxID;
        string UserCode = userCode;
        string DocType = docType;
        string DocumentExt = documentExt;
        string DocHashCode = docHashCode;
    }

    public int DocSandBoxID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }
    public string DocumentExt { get; set; }
    public string DocHashCode { get; set; }
}

class DocSandBoxD
{
    private int docSandBoxID;
    private string userCode;
    private string docType;
    private string documentExt;
    private string docHashCode;

    public DocSandBoxD(int docSandBoxID, string userCode, string docType, string documentExt, string docHashCode)
    {
        int DocSandBoxID = docSandBoxID;
        string UserCode = userCode;
        string DocType = docType;
        string DocumentExt = documentExt;
        string DocHashCode = docHashCode;
    }

    public int DocSandBoxID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }
    public string DocumentExt { get; set; }
    public string DocHashCode { get; set; }
}
