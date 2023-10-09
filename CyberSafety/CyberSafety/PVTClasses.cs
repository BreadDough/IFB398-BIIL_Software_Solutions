using System;

class PVTUserInformation
{
    public int UserID { get; set; }
    public string UserCode_P { get; set; }
    public string UserCode_C { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }
    public string NameFirst { get; set; }
    public string NameLast { get; set; }
    public string NameOrganisation { get; set; }
    public string OrganisationUserCode { get; set; }
    public string PublicKey { get; set; }
    public bool MFA { get; set; }

    public PVTUserInformation(int userID, string userCode_P, 
        string userCode_C, string password, 
        string userType, string nameFirst, 
        string nameLast,
        string nameOrganisation, 
        string organisationUserCode, 
        string publicKey, bool mfa)
    {
        UserID = userID;
        UserCode_P = userCode_P;
        UserCode_C = userCode_C;
        Password = password;
        UserType = userType;
        NameFirst = nameFirst;
        NameLast = nameLast;
        NameOrganisation = nameOrganisation;
        NameOrganisation = organisationUserCode;
        PublicKey = publicKey;
        MFA = mfa;
    }
    public PVTUserInformation(int userID, string password,
        string userType, string nameFirst,
        string nameLast,
        string organisationUserCode)
    {
        UserID = userID;
        Password = password;
        UserType = userType;
        NameFirst = nameFirst;
        NameLast = nameLast;
        OrganisationUserCode = organisationUserCode;
    }
}


class AddressTable
{
    public string AddressID { get; set; }
    public string UserID { get; set; }
    public string AddressType { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string City { get; set; }
    public int PostCode { get; set; }
    public string RegionalCouncil { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public DateTime PostDate { get; set; }

    public AddressTable(string addressID, string userID, 
        string addressType, string address1, string? address2,
        string? address3, string city, string? regionalCouncil, 
        int postCode, string state, 
        string country, DateTime postDate)
    {
        AddressID = addressID;
        UserID = userID;
        AddressType = addressType;
        Address1 = address1;
        Address2 = address2;
        Address3 = address3;
        City = city;
        PostCode = postCode;
        RegionalCouncil = regionalCouncil;
        State = state;
        Country = country;
        PostDate = postDate;
    }
}

class UserContact
{
    public int ContactID { get; set; }
    public int UserID { get; set; }
    public string ContactType { get; set; }
    public string ContactDetail { get; set; }
    public string Notes { get; set; }

    public UserContact(int contactID, int userID, string contactType, string? contactDetail, string? notes)
    {
        ContactID = contactID;
        UserID = userID;
        ContactType = contactType;
        ContactDetail = contactDetail;
        Notes = notes;
    }

    public UserContact(int userID, string contactType, string contactDetail, string? notes)
    {
        UserID = userID;
        ContactType = contactType;
        ContactDetail = contactDetail;
        Notes = notes;
    }
}

class eMailAddresses
{
    public int EMailID { get; set; }
    public string UserCode { get; set; }
    public string EMailType { get; set; }
    public string EMailAddress { get; set; }
    public bool Verified { get; set; }

    public eMailAddresses(int eMailID, string userCode, string eMailType, 
        string eMailAddress, bool verified)
    {
        EMailID = eMailID;
        UserCode = userCode;
        EMailType = eMailType;
        EMailAddress = eMailAddress;
        Verified = verified;
    }
}

class Documentation
{
    public int DocumentID { get; set; }
    public int UserID { get; set; }
    public int DocType { get; set; }
    public string DocExt { get; set; }
    public string DocHashCode { get; set; }
    public string DocBin { get; set; }
    public DateTime AuditDate { get; set; }
    public string Key001 { get; set; }
    public string Key002 { get; set; }
    public string Key003 { get; set; }
    public string Key004 { get; set; }

    public Documentation(int documentID, int userID,
        int docType, string docExt, string docHashCode, string docBin,
        DateTime auditDate, string key001, string key002, string key003, string key004)
    {
        DocumentID = documentID;
        UserID = userID;
        DocType = docType;
        DocExt = docExt;
        DocHashCode = docHashCode;
        DocBin = docBin;
        AuditDate = auditDate;
        Key001 = key001;
        Key002 = key002;
        Key003 = key003;
        Key004 = key004;
    }

    public Documentation(int userID, int docType, string docExt, 
        string docHashCode, string docBin, DateTime auditDate)
    {
        UserID = userID;
        DocType = docType;
        DocExt = docExt;
        DocHashCode = docHashCode;
        DocBin = docBin;
        AuditDate = auditDate;
    }
}

class Requests
{
    public int RequestID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }

    public Requests(int requestID, string userCode, string docType)
    {
        RequestID = requestID;
        UserCode = userCode;
        DocType = docType;
    }
}

class DocSandBoxE
{
    public int DocSandBoxID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }
    public string DocumentExt { get; set; }
    public string DocHashCode { get; set; }

    public DocSandBoxE(int docSandBoxID, string userCode, string docType, string documentExt, string docHashCode)
    {
        DocSandBoxID = docSandBoxID;
        UserCode = userCode;
        DocType = docType;
        DocumentExt = documentExt;
        DocHashCode = docHashCode;
    }
}

class DocSandBoxD
{
    public int DocSandBoxID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }
    public string DocumentExt { get; set; }
    public string DocHashCode { get; set; }

    public DocSandBoxD(int docSandBoxID, string userCode, string docType, string documentExt, string docHashCode)
    {
        DocSandBoxID = docSandBoxID;
        UserCode = userCode;
        DocType = docType;
        DocumentExt = documentExt;
        DocHashCode = docHashCode;
    }
}
