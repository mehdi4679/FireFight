using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFightCL
{
 public   class ClPersonAccept:Grid
  {
private int? _PersonAcceptID;
public int? PersonAcceptID {
get { return _PersonAcceptID; }
set { _PersonAcceptID = value; }
}
private int? _PersonalID;
public int? PersonalID {
get { return _PersonalID; }
set { _PersonalID = value; }
}
private int? _AcceptID;
public int? AcceptID {
get { return _AcceptID; }
set { _AcceptID = value; }
}
private String _DescAccept;
public String DescAccept {
get { return _DescAccept; }
set { _DescAccept = value; }
}
private String _AcceptDate;
public String AcceptDate
{
get { return _AcceptDate; }
set { _AcceptDate = value; }
}
private int? _UserReg;
public int? UserReg {
get { return _UserReg; }
set { _UserReg = value; }
}

}
}
