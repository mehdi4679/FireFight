using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFightCL
{
 public   class ClAttach:Grid
  {
private int? _AttachID;
public int? AttachID {
get { return _AttachID; }
set { _AttachID = value; }
}
private String _AttachName;
public String AttachName {
get { return _AttachName; }
set { _AttachName = value; }
}
private int? _PersonalID;
public int? PersonalID {
get { return _PersonalID; }
set { _PersonalID = value; }
}
private int? _ForCatalogType;
public int? ForCatalogType {
get { return _ForCatalogType; }
set { _ForCatalogType = value; }
}
private int? _ForCatalogValue;
public int? ForCatalogValue {
get { return _ForCatalogValue; }
set { _ForCatalogValue = value; }
}
private int? _CreateUser;
public int? CreateUser {
get { return _CreateUser; }
set { _CreateUser = value; }
}
private string _createDate;
public string createDate
{
get { return _createDate; }
set { _createDate = value; }
}
private int? _Compelete;
public int? Compelete {
get { return _Compelete; }
set { _Compelete = value; }
}
private string _FileBinery;
public string FileBinery
{
get { return _FileBinery; }
set { _FileBinery = value; }
}

}
}
