using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFightCL
{
 public   class ClPeriod:Grid
  {
private int? _PeriodID;
public int? PeriodID {
get { return _PeriodID; }
set { _PeriodID = value; }
}
private string _PeriodStartDate;
public string PeriodStartDate
{
get { return _PeriodStartDate; }
set { _PeriodStartDate = value; }
}
private string _PeriodEndDate;
public string PeriodEndDate
{
get { return _PeriodEndDate; }
set { _PeriodEndDate = value; }
}
private String _PeriodName;
public String PeriodName {
get { return _PeriodName; }
set { _PeriodName = value; }
}
private int? _IsActive;
public int? IsActive {
get { return _IsActive; }
set { _IsActive = value; }
}

}
}
