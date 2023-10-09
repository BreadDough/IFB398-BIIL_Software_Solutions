using System;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

class PublicUserInformation
{
	public long UserID { get; set; }
	public string Loginname { get; set; }
	public string Password { get; set; }
	public bool MFA { get; set; }

    public PublicUserInformation(long userID, string loginname, string password, bool mfa)
    {
        UserID = userID;
		Loginname = loginname;
		Password = password;
		MFA = mfa;
    }
    public PublicUserInformation(long userID, string loginname, string password)
	{
		UserID = userID;
		Loginname = loginname;
		Password = password;
	}
    public PublicUserInformation(long userID, string loginname)
    {
        UserID = userID; Loginname = loginname;
    }

}

class RequestedLock
{
    public string RequestedLockID { get; set; }
    public string RequestID { get; set; }
    public string UserCodeR { get; set; }
    public string UserCodeI { get; set; }
    public DateTime DateExpire { get; set; }
    public int UseCount { get; set; }
    public int UseCountLimit { get; set; }

    public RequestedLock(string requestedLockID, string requestID, string userCodeR, string userCodeI, DateTime dateExpire, int useCount, int useCountLimit)
    {
        RequestedLockID = requestedLockID;
        RequestID = requestID;
        UserCodeR = userCodeR;
        UserCodeI = userCodeI;
        DateExpire = dateExpire;
        UseCount = useCount;
        UseCountLimit = useCountLimit;
    }	
}

class DocUpload
{
    public string DocUploadID { get; set; }
    public string UserCode { get; set; }
    public string DocType { get; set; }
    public string DocumentExt { get; set; }
    public string DocHashCode { get; set; }

    public DocUpload(string docUploadID, string userCode, string docType, string documentExt, string docHashCode)
    {
        DocUploadID = docUploadID;
        UserCode = userCode;
        DocType = docType;
        DocumentExt = documentExt;
        DocHashCode = docHashCode;
    }
}
