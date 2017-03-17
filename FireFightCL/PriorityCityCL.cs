using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFightCL
{
 public   class ClPriorityCity:Grid
  {
private int? _PriorityCityID;
public int? PriorityCityID {
get { return _PriorityCityID; }
set { _PriorityCityID = value; }
}
private int? _PersonalID;
public int? PersonalID {
get { return _PersonalID; }
set { _PersonalID = value; }
}
private int? _CityID;
public int? CityID {
get { return _CityID; }
set { _CityID = value; }
}
private int? _PeriorityID;
public int? PeriorityID {
get { return _PeriorityID; }
set { _PeriorityID = value; }
}

}
}
