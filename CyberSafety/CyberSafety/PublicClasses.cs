using System;

class PublicUserInformation
{
	public int userID { get; set; }
	public string loginname { get; set; }
	public string password { get; set; }
	public bool mfa { get; set; }

    public PublicUserInformation(int UserID, string Loginname, string Password, bool MFA)
    {
        this.userID = UserID;
        this.loginname = Loginname;
        this.password = Password;
		this.mfa = MFA;
    }
    public PublicUserInformation(int UserID, string Loginname, string Password)
	{
		this.userID = UserID;
		this.loginname = Loginname;
		this.password = Password;
	}
}

class RequestedLock
{
	private string requestedLockID; //primary key
	private string requestID;
	private string userCodeR; //foreign key obtained from private db
    private string userCodeI; //foreign key obtained from private db
    private DateTime dateExpire;
	private int useCount;
	private int useCountLimit;

	public RequestedLock(string requestedLockID, string requestID, string userCodeR, string userCodeI, DateTime dateExpire, int useCount, int useCountLimit)
    {
        string RequestedLockID = requestedLockID;
        string RequestID = requestID;
        string UserCodeR = userCodeR;
        string UserCodeI = userCodeI;
        DateTime DateExpire = dateExpire;
        int UseCount = useCount;
        int UseCountLimit = useCountLimit;
    }

	public string RequestedLockID { get; set; }
	public string RequestID { get; set; }
	public string UserCodeR { get; set; }
	public string UserCodeI { get; set; }
	public DateTime DateExpire { get; set; }
	public int UseCount { get; set; }
	public int UseCountLimit { get; set; }
}

class DocUpload
{
	private string docUploadID;
	private string userCode;
	private string docType;
	private string documentExt;
	private string docHashCode;

	public DocUpload(string docUploadID, string userCode, string docType, string documentExt, string docHashCode)
    {
        string DocUploadID = docUploadID;
        string UserCode = userCode;
        string DocType = docType;
        string DocumentExt = documentExt;
        string DocHashCode = docHashCode;
    }

	public string DocUploadID { get; set; }
	public string UserCode { get; set; }
	public string DocType { get; set; }
	public string DocumentExt { get; set; }
	public string DocHashCode { get; set; }
}
