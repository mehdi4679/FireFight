using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireFightCL
{
 public   class ClPersonal:Grid
  {
private int? _PersonalID;
public int? PersonalID {
get { return _PersonalID; }
set { _PersonalID = value; }
}
private int? _PeriodID;
public int? PeriodID {
get { return _PeriodID; }
set { _PeriodID = value; }
}
private String _PesonalCode;
public String PesonalCode {
get { return _PesonalCode; }
set { _PesonalCode = value; }
}
private int? _JobRequestID;
public int? JobRequestID {
get { return _JobRequestID; }
set { _JobRequestID = value; }
}
private String _NationalCode;
public String NationalCode {
get { return _NationalCode; }
set { _NationalCode = value; }
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
private String _FatherName;
public String FatherName {
get { return _FatherName; }
set { _FatherName = value; }
}
private int? _BitrhPalceState;
public int? BitrhPalceState {
get { return _BitrhPalceState; }
set { _BitrhPalceState = value; }
}
private String _BirthPlaceCity;
public String BirthPlaceCity {
get { return _BirthPlaceCity; }
set { _BirthPlaceCity = value; }
}
private String _StayLength;
public String StayLength {
get { return _StayLength; }
set { _StayLength = value; }
}
private int? _DayBithDate;
public int? DayBithDate {
get { return _DayBithDate; }
set { _DayBithDate = value; }
}
private int? _MonthBithDate;
public int? MonthBithDate {
get { return _MonthBithDate; }
set { _MonthBithDate = value; }
}
private int? _YearBirthDate;
public int? YearBirthDate {
get { return _YearBirthDate; }
set { _YearBirthDate = value; }
}
private String _LocationID;
public String LocationID {
get { return _LocationID; }
set { _LocationID = value; }
}
private String _OwnerAddress;
public String OwnerAddress {
get { return _OwnerAddress; }
set { _OwnerAddress = value; }
}
private String _FatherAddress;
public String FatherAddress {
get { return _FatherAddress; }
set { _FatherAddress = value; }
}
private String _WifeAddress;
public String WifeAddress {
get { return _WifeAddress; }
set { _WifeAddress = value; }
}
private String _HomePhone;
public String HomePhone {
get { return _HomePhone; }
set { _HomePhone = value; }
}
private String _Mobile;
public String Mobile {
get { return _Mobile; }
set { _Mobile = value; }
}
private String _EmergencyMobile;
public String EmergencyMobile {
get { return _EmergencyMobile; }
set { _EmergencyMobile = value; }
}
private int? _MilitaryStatusID;
public int? MilitaryStatusID {
get { return _MilitaryStatusID; }
set { _MilitaryStatusID = value; }
}
private int? _MilitaryMonthLong;
public int? MilitaryMonthLong {
get { return _MilitaryMonthLong; }
set { _MilitaryMonthLong = value; }
}
private int? _MilitaryYearLong;
public int? MilitaryYearLong {
get { return _MilitaryYearLong; }
set { _MilitaryYearLong = value; }
}
private int? _DriversLicenseID;
public int? DriversLicenseID {
get { return _DriversLicenseID; }
set { _DriversLicenseID = value; }
}
private int? _CurrentJobID;
public int? CurrentJobID {
get { return _CurrentJobID; }
set { _CurrentJobID = value; }
}
private String _OfficeJobName;
public String OfficeJobName {
get { return _OfficeJobName; }
set { _OfficeJobName = value; }
}
private String _EmploymentLong;
public String EmploymentLong {
get { return _EmploymentLong; }
set { _EmploymentLong = value; }
}
private String _BimeLong;
public String BimeLong {
get { return _BimeLong; }
set { _BimeLong = value; }
}
private int? _EducationLevel;
public int? EducationLevel {
get { return _EducationLevel; }
set { _EducationLevel = value; }
}
private int? _EducationYear;
public int? EducationYear {
get { return _EducationYear; }
set { _EducationYear = value; }
}
private String _EducationName;
public String EducationName {
get { return _EducationName; }
set { _EducationName = value; }
}
private int? _EducationLocationOstan;
public int? EducationLocationOstan {
get { return _EducationLocationOstan; }
set { _EducationLocationOstan = value; }
}
private String _EducationCityName;
public String EducationCityName {
get { return _EducationCityName; }
set { _EducationCityName = value; }
}
private int? _SacrificeSixMonth;
public int? SacrificeSixMonth {
get { return _SacrificeSixMonth; }
set { _SacrificeSixMonth = value; }
}
private int? _SacrificeNineMonth;
public int? SacrificeNineMonth {
get { return _SacrificeNineMonth; }
set { _SacrificeNineMonth = value; }
}
private int? _SacrificeUpper;
public int? SacrificeUpper {
get { return _SacrificeUpper; }
set { _SacrificeUpper = value; }
}
private int? _SacrificeChild;
public int? SacrificeChild {
get { return _SacrificeChild; }
set { _SacrificeChild = value; }
}
private int? _SacrificeWife;
public int? SacrificeWife {
get { return _SacrificeWife; }
set { _SacrificeWife = value; }
}
private int? _SacrificeBorther;
public int? SacrificeBorther {
get { return _SacrificeBorther; }
set { _SacrificeBorther = value; }
}
private int? _SacrificeAzadeh;
public int? SacrificeAzadeh {
get { return _SacrificeAzadeh; }
set { _SacrificeAzadeh = value; }
}
private int? _SacrificeAzadehChild;
public int? SacrificeAzadehChild {
get { return _SacrificeAzadehChild; }
set { _SacrificeAzadehChild = value; }
}
private int? _SacrificeJanbaz;
public int? SacrificeJanbaz {
get { return _SacrificeJanbaz; }
set { _SacrificeJanbaz = value; }
}
private int? _SacrificejanbazChild;
public int? SacrificejanbazChild {
get { return _SacrificejanbazChild; }
set { _SacrificejanbazChild = value; }
}
private int? _CenterStatusId;
public int? CenterStatusId {
get { return _CenterStatusId; }
set { _CenterStatusId = value; }
}
private string _DateStage1;
public string DateStage1 {
get { return _DateStage1; }
set { _DateStage1 = value; }
}
private string _DateStage2;
public string DateStage2 {
get { return _DateStage2; }
set { _DateStage2 = value; }
}
private string _DateStage3;
public string DateStage3 {
get { return _DateStage3; }
set { _DateStage3 = value; }
}
private string _DateStage4;
public string DateStage4 {
get { return _DateStage4; }
set { _DateStage4 = value; }
}
private int? _EpeyOrderID;
public int? EpeyOrderID
{
    get { return _EpeyOrderID; }
    set { _EpeyOrderID = value; }
}
private string _codePosti;
public string codePosti
{
    get { return _codePosti; }
    set { _codePosti = value; }
}

private string _PersonalTracingCode;
 public string PersonalTracingCode
{
    get { return _PersonalTracingCode; }
    set { _PersonalTracingCode = value; }
}

private string _RaceCode;
 public string RaceCode
{
    get { return _RaceCode; }
    set { _RaceCode = value; }
}

 private int? _Native_SodorSH;
 public int? Native_SodorSH
{
    get { return _Native_SodorSH; }
    set { _Native_SodorSH = value; }
}
 private int? _Native_ShoolOne;
 public int? Native_ShoolOne
{
    get { return _Native_ShoolOne; }
    set { _Native_ShoolOne = value; }
}
 private int? _Native_SchoolTwo;
 public int? Native_SchoolTwo
{
    get { return _Native_SchoolTwo; }
    set { _Native_SchoolTwo = value; }
}
 private int? _Native_HighScholl;
 public int? Native_HighScholl
{
    get { return _Native_HighScholl; }
    set { _Native_HighScholl = value; }
}
 private int? _Native_Univercity;
 public int? Native_Univercity
{
    get { return _Native_Univercity; }
    set { _Native_Univercity = value; }
}
 private int? _Native_Parent;
 public int? Native_Parent
{
    get { return _Native_Parent; }
    set { _Native_Parent = value; }
}
 private int? _Native_ParentBime;
 public int? Native_ParentBime
 {
     get { return _Native_ParentBime; }
     set { _Native_ParentBime = value; }
 }
 private int? _Native_Wife;
 public int? Native_Wife
 {
     get { return _Native_Wife; }
     set { _Native_Wife = value; }
 }
 private int? _Native_WifeBime;
 public int? Native_WifeBime
 {
     get { return _Native_WifeBime; }
     set { _Native_WifeBime = value; }
 }

 private int? _IsChildOfShahdari;
 public int? IsChildOfShahdari
 {
     get { return _IsChildOfShahdari; }
     set { _IsChildOfShahdari = value; }
 }
 private int? _StudyFiedlD;
 public int? StudyFiedlD
 {
     get { return _StudyFiedlD; }
     set { _StudyFiedlD = value; }
 }

 private string _StudyFieldName;
 public string StudyFieldName
 {
     get { return _StudyFieldName; }
     set { _StudyFieldName = value; }
 }
 private int? _SaSoldure;
 public int? SaSoldure
 {
     get { return _SaSoldure; }
     set { _SaSoldure = value; }
 }
 private int? _SaAzadeh;
 public int? SaAzadeh
 {
     get { return _SaAzadeh; }
     set { _SaAzadeh = value; }
 }
 private int? _SaJanbaz;
 public int? SaJanbaz
 {
     get { return _SaJanbaz; }
     set { _SaJanbaz = value; }
 }
 private int? _SaBrotherShahid;
 public int? SaBrotherShahid
 {
     get { return _SaBrotherShahid; }
     set { _SaBrotherShahid = value; }
 }
 private int? _SaFamiliy;
 public int? SaFamiliy
 {
     get { return _SaFamiliy; }
     set { _SaFamiliy = value; }
 }
 private int? _EmmloyeYearLong;
 public int? EmmloyeYearLong
 {
     get { return _EmmloyeYearLong; }
     set { _EmmloyeYearLong = value; }
 }

 private int? _FinalyNativeID;
 public int? FinalyNativeID
 {
     get { return _FinalyNativeID; }
     set { _FinalyNativeID = value; }
 }
 private int? _FiNalyNativeCityID;
 public int? FiNalyNativeCityID
 {
     get { return _FiNalyNativeCityID; }
     set { _FiNalyNativeCityID = value; }
 }

 private int? _FinalySacrificeID;
 public int? FinalySacrificeID
 {
     get { return _FinalySacrificeID; }
     set { _FinalySacrificeID = value; }
 }
 private String _PrintCradFirst;
 public String PrintCradFirst
 {
     get { return _PrintCradFirst; }
     set { _PrintCradFirst = value; }
 }
 private String _PrintCardSecond;
 public String PrintCardSecond
 {
     get { return _PrintCardSecond; }
     set { _PrintCardSecond = value; }
 }

 private String _PrintDate;
 public String PrintDate
 {
     get { return _PrintDate; }
     set { _PrintDate = value; }
 }
 private int? _PrintDateHas;
 public int? PrintDateHas
 {
     get { return _PrintDateHas; }
     set { _PrintDateHas = value; }
 }




 private String _ProtextContent;
 public String ProtextContent
 {
     get { return _ProtextContent; }
     set { _ProtextContent = value; }
 }

 private String _ProtestTitle;
 public String ProtestTitle
 {
     get { return _ProtestTitle; }
     set { _ProtestTitle = value; }
 }

 private String _ProtestDate;
 public String ProtestDate
 {
     get { return _ProtestDate; }
     set { _ProtestDate = value; }
 }

 private String _PerotestReplayDate;
 public String PerotestReplayDate
 {
     get { return _PerotestReplayDate; }
     set { _PerotestReplayDate = value; }
 }


 private String _ProtestReplay;
 public String ProtestReplay
 {
     get { return _ProtestReplay; }
     set { _ProtestReplay = value; }
 }

 private int? _ChairNumber;
 public int? ChairNumber
 {
     get { return _ChairNumber; }
     set { _ChairNumber = value; }
 }

 private String _ExamCardDate;
 public String ExamCardDate
 {
     get { return _ExamCardDate; }
     set { _ExamCardDate = value; }
 }


}
}
