using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFightCL
{
 public   class ClEpayOrder:Grid
  {
private int? _EpayOrderID;
public int? EpayOrderID {
get { return _EpayOrderID; }
set { _EpayOrderID = value; }
}
private String _IP;
public String IP {
get { return _IP; }
set { _IP = value; }
}
private String _OS;
public String OS {
get { return _OS; }
set { _OS = value; }
}
private String _Browser;
public String Browser {
get { return _Browser; }
set { _Browser = value; }
}
private int? _Prcie;
public int? Prcie {
get { return _Prcie; }
set { _Prcie = value; }
}
private string _OrderDateStart;
public string OrderDateStart {
get { return _OrderDateStart; }
set { _OrderDateStart = value; }
}
private string _OrderDateEND;
public string OrderDateEND {
get { return _OrderDateEND; }
set { _OrderDateEND = value; }
}
private String _OrderStatus;
public String OrderStatus {
get { return _OrderStatus; }
set { _OrderStatus = value; }
}
private String _RefId;
public String RefId {
get { return _RefId; }
set { _RefId = value; }
}
private String _ResCode;
public String ResCode {
get { return _ResCode; }
set { _ResCode = value; }
}
private String _Comment;
public String Comment {
get { return _Comment; }
set { _Comment = value; }
}
private String _VerifyResult;
public String VerifyResult {
get { return _VerifyResult; }
set { _VerifyResult = value; }
}
private String _FirstName;
public String FirstName {
get { return _FirstName; }
set { _FirstName = value; }
}
private String _LastName;
public String LastName {
get { return _LastName; }
set { _LastName = value; }
}
private String _PhoneNumber;
public String PhoneNumber {
get { return _PhoneNumber; }
set { _PhoneNumber = value; }
}
private String _Mobile;
public String Mobile {
get { return _Mobile; }
set { _Mobile = value; }
}
private String _Email;
public String Email {
get { return _Email; }
set { _Email = value; }
}
private int? _ISUse;
public int? ISUse
{
    get { return _ISUse; }
    set { _ISUse = value; }
}
private String _UseDate;
public String UseDate
{
    get { return _UseDate; }
    set { _UseDate = value; }
}

private String _NationalCode;
public String NationalCode
{
    get { return _NationalCode; }
    set { _NationalCode = value; }
}

}
}
