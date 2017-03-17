using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Data.SqlClient;
using FireFightCL;

namespace FireFightDAL
{
    public class PersonalClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClPersonal c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Personal_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.PeriodID);
cmd.Parameters.Add(new SqlParameter("PesonalCode", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.PesonalCode);
cmd.Parameters.Add(new SqlParameter("JobRequestID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.JobRequestID);
cmd.Parameters.Add(new SqlParameter("NationalCode", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.NationalCode);
cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.FirstName);
cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.LastName);
cmd.Parameters.Add(new SqlParameter("FatherName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.FatherName);
cmd.Parameters.Add(new SqlParameter("BitrhPalceState", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.BitrhPalceState);
cmd.Parameters.Add(new SqlParameter("BirthPlaceCity", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.BirthPlaceCity);
cmd.Parameters.Add(new SqlParameter("StayLength", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.StayLength);
cmd.Parameters.Add(new SqlParameter("DayBithDate", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.DayBithDate);
cmd.Parameters.Add(new SqlParameter("MonthBithDate", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.MonthBithDate);
cmd.Parameters.Add(new SqlParameter("YearBirthDate", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.YearBirthDate);
cmd.Parameters.Add(new SqlParameter("LocationID", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.LocationID);
cmd.Parameters.Add(new SqlParameter("OwnerAddress", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.OwnerAddress);
cmd.Parameters.Add(new SqlParameter("FatherAddress", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.FatherAddress);
cmd.Parameters.Add(new SqlParameter("WifeAddress", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.WifeAddress);
cmd.Parameters.Add(new SqlParameter("HomePhone", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.HomePhone);
cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Mobile);
cmd.Parameters.Add(new SqlParameter("EmergencyMobile", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.EmergencyMobile);
cmd.Parameters.Add(new SqlParameter("MilitaryStatusID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.MilitaryStatusID);
cmd.Parameters.Add(new SqlParameter("MilitaryMonthLong", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.MilitaryMonthLong);
cmd.Parameters.Add(new SqlParameter("MilitaryYearLong", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.MilitaryYearLong);
cmd.Parameters.Add(new SqlParameter("DriversLicenseID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.DriversLicenseID);
cmd.Parameters.Add(new SqlParameter("CurrentJobID", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.CurrentJobID);
cmd.Parameters.Add(new SqlParameter("OfficeJobName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.OfficeJobName);
cmd.Parameters.Add(new SqlParameter("EmploymentLong", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.EmploymentLong);
cmd.Parameters.Add(new SqlParameter("BimeLong", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.BimeLong);
cmd.Parameters.Add(new SqlParameter("EducationLevel", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.EducationLevel);
cmd.Parameters.Add(new SqlParameter("EducationYear", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.EducationYear);
cmd.Parameters.Add(new SqlParameter("EducationName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.EducationName);
cmd.Parameters.Add(new SqlParameter("EducationLocationOstan", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.EducationLocationOstan);
cmd.Parameters.Add(new SqlParameter("EducationCityName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.EducationCityName);
cmd.Parameters.Add(new SqlParameter("SacrificeSixMonth", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeSixMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeNineMonth", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeNineMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeUpper", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeUpper);
cmd.Parameters.Add(new SqlParameter("SacrificeChild", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeChild);
cmd.Parameters.Add(new SqlParameter("SacrificeWife", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeWife);
cmd.Parameters.Add(new SqlParameter("SacrificeBorther", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeBorther);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadeh", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadeh);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadehChild", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadehChild);
cmd.Parameters.Add(new SqlParameter("SacrificeJanbaz", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificeJanbaz);
cmd.Parameters.Add(new SqlParameter("SacrificejanbazChild", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.SacrificejanbazChild);
cmd.Parameters.Add(new SqlParameter("CenterStatusId", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.CenterStatusId);
cmd.Parameters.Add(new SqlParameter("DateStage1", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.DateStage1);
cmd.Parameters.Add(new SqlParameter("DateStage2", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.DateStage2);
cmd.Parameters.Add(new SqlParameter("DateStage3", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.DateStage3);
cmd.Parameters.Add(new SqlParameter("DateStage4", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.DateStage4);
cmd.Parameters.Add(new SqlParameter("EpeyOrderID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EpeyOrderID);


           SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }

        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetList(ClPersonal c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Personal_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalID);

cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodID);
cmd.Parameters.Add(new SqlParameter("PesonalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PesonalCode);
cmd.Parameters.Add(new SqlParameter("JobRequestID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.JobRequestID);
cmd.Parameters.Add(new SqlParameter("NationalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.NationalCode);
cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FirstName);
cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LastName);
cmd.Parameters.Add(new SqlParameter("FatherName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherName);
cmd.Parameters.Add(new SqlParameter("BitrhPalceState", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.BitrhPalceState);
cmd.Parameters.Add(new SqlParameter("BirthPlaceCity", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BirthPlaceCity);
cmd.Parameters.Add(new SqlParameter("StayLength", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StayLength);
cmd.Parameters.Add(new SqlParameter("DayBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DayBithDate);
cmd.Parameters.Add(new SqlParameter("MonthBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonthBithDate);
cmd.Parameters.Add(new SqlParameter("YearBirthDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.YearBirthDate);
cmd.Parameters.Add(new SqlParameter("LocationID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LocationID);
cmd.Parameters.Add(new SqlParameter("OwnerAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OwnerAddress);
cmd.Parameters.Add(new SqlParameter("FatherAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherAddress);
cmd.Parameters.Add(new SqlParameter("WifeAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.WifeAddress);
cmd.Parameters.Add(new SqlParameter("HomePhone", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.HomePhone);
cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Mobile);
cmd.Parameters.Add(new SqlParameter("EmergencyMobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmergencyMobile);
cmd.Parameters.Add(new SqlParameter("MilitaryStatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryStatusID);
cmd.Parameters.Add(new SqlParameter("MilitaryMonthLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryMonthLong);
cmd.Parameters.Add(new SqlParameter("MilitaryYearLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryYearLong);
cmd.Parameters.Add(new SqlParameter("DriversLicenseID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DriversLicenseID);
cmd.Parameters.Add(new SqlParameter("CurrentJobID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CurrentJobID);
cmd.Parameters.Add(new SqlParameter("OfficeJobName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OfficeJobName);
cmd.Parameters.Add(new SqlParameter("EmploymentLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmploymentLong);
cmd.Parameters.Add(new SqlParameter("BimeLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BimeLong);
cmd.Parameters.Add(new SqlParameter("EducationLevel", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLevel);
cmd.Parameters.Add(new SqlParameter("EducationYear", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationYear);
cmd.Parameters.Add(new SqlParameter("EducationName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationName);
cmd.Parameters.Add(new SqlParameter("EducationLocationOstan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLocationOstan);
cmd.Parameters.Add(new SqlParameter("EducationCityName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationCityName);
cmd.Parameters.Add(new SqlParameter("SacrificeSixMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeSixMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeNineMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeNineMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeUpper", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeUpper);
cmd.Parameters.Add(new SqlParameter("SacrificeChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeChild);
cmd.Parameters.Add(new SqlParameter("SacrificeWife", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeWife);
cmd.Parameters.Add(new SqlParameter("SacrificeBorther", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeBorther);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadeh", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadeh);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadehChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadehChild);
cmd.Parameters.Add(new SqlParameter("SacrificeJanbaz", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeJanbaz);
cmd.Parameters.Add(new SqlParameter("SacrificejanbazChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificejanbazChild);
cmd.Parameters.Add(new SqlParameter("CenterStatusId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CenterStatusId);
cmd.Parameters.Add(new SqlParameter("DateStage1", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage1);
cmd.Parameters.Add(new SqlParameter("DateStage2", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage2);
cmd.Parameters.Add(new SqlParameter("DateStage3", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage3);
cmd.Parameters.Add(new SqlParameter("DateStage4", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage4);


           SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }
        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetListKarname(ClPersonal c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Personal_GetListKarname", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            
             cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalID);
           
            
            
            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }


        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetListAccept(ClPersonal c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Personal_GetListAccept", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalID);

            cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodID);
            cmd.Parameters.Add(new SqlParameter("PesonalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PesonalCode);
            cmd.Parameters.Add(new SqlParameter("JobRequestID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.JobRequestID);
            cmd.Parameters.Add(new SqlParameter("NationalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.NationalCode);
            cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FirstName);
            cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LastName);
            cmd.Parameters.Add(new SqlParameter("FatherName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherName);
            cmd.Parameters.Add(new SqlParameter("BitrhPalceState", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.BitrhPalceState);
            cmd.Parameters.Add(new SqlParameter("BirthPlaceCity", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BirthPlaceCity);
            cmd.Parameters.Add(new SqlParameter("StayLength", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StayLength);
            cmd.Parameters.Add(new SqlParameter("DayBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DayBithDate);
            cmd.Parameters.Add(new SqlParameter("MonthBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonthBithDate);
            cmd.Parameters.Add(new SqlParameter("YearBirthDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.YearBirthDate);
            cmd.Parameters.Add(new SqlParameter("LocationID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LocationID);
            cmd.Parameters.Add(new SqlParameter("OwnerAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OwnerAddress);
            cmd.Parameters.Add(new SqlParameter("FatherAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherAddress);
            cmd.Parameters.Add(new SqlParameter("WifeAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.WifeAddress);
            cmd.Parameters.Add(new SqlParameter("HomePhone", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.HomePhone);
            cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Mobile);
            cmd.Parameters.Add(new SqlParameter("EmergencyMobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmergencyMobile);
            cmd.Parameters.Add(new SqlParameter("MilitaryStatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryStatusID);
            cmd.Parameters.Add(new SqlParameter("MilitaryMonthLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryMonthLong);
            cmd.Parameters.Add(new SqlParameter("MilitaryYearLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryYearLong);
            cmd.Parameters.Add(new SqlParameter("DriversLicenseID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DriversLicenseID);
            cmd.Parameters.Add(new SqlParameter("CurrentJobID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CurrentJobID);
            cmd.Parameters.Add(new SqlParameter("OfficeJobName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OfficeJobName);
            cmd.Parameters.Add(new SqlParameter("EmploymentLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmploymentLong);
            cmd.Parameters.Add(new SqlParameter("BimeLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BimeLong);
            cmd.Parameters.Add(new SqlParameter("EducationLevel", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLevel);
            cmd.Parameters.Add(new SqlParameter("EducationYear", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationYear);
            cmd.Parameters.Add(new SqlParameter("EducationName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationName);
            cmd.Parameters.Add(new SqlParameter("EducationLocationOstan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLocationOstan);
            cmd.Parameters.Add(new SqlParameter("EducationCityName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationCityName);
            cmd.Parameters.Add(new SqlParameter("SacrificeSixMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeSixMonth);
            cmd.Parameters.Add(new SqlParameter("SacrificeNineMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeNineMonth);
            cmd.Parameters.Add(new SqlParameter("SacrificeUpper", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeUpper);
            cmd.Parameters.Add(new SqlParameter("SacrificeChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeChild);
            cmd.Parameters.Add(new SqlParameter("SacrificeWife", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeWife);
            cmd.Parameters.Add(new SqlParameter("SacrificeBorther", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeBorther);
            cmd.Parameters.Add(new SqlParameter("SacrificeAzadeh", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadeh);
            cmd.Parameters.Add(new SqlParameter("SacrificeAzadehChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadehChild);
            cmd.Parameters.Add(new SqlParameter("SacrificeJanbaz", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeJanbaz);
            cmd.Parameters.Add(new SqlParameter("SacrificejanbazChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificejanbazChild);
            cmd.Parameters.Add(new SqlParameter("CenterStatusId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CenterStatusId);
            cmd.Parameters.Add(new SqlParameter("DateStage1", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage1);
            cmd.Parameters.Add(new SqlParameter("DateStage2", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage2);
            cmd.Parameters.Add(new SqlParameter("DateStage3", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage3);
            cmd.Parameters.Add(new SqlParameter("DateStage4", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage4);

            cmd.Parameters.Add(new SqlParameter("FinalyNativeID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FinalyNativeID);
            cmd.Parameters.Add(new SqlParameter("FiNalyNativeCityID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FiNalyNativeCityID);
            cmd.Parameters.Add(new SqlParameter("FinalySacrificeID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FinalySacrificeID);
            cmd.Parameters.Add(new SqlParameter("PrintDatess", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PrintDateHas);

            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }
        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetListChechPersonalAttach(ClPersonal c)
        {

            SqlCommand cmd = new SqlCommand("Prc_ChechPersonalAttach", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
              cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalID);
              SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
              prmResult.Direction = ParameterDirection.Output;
              cmd.Parameters.Add(prmResult);
              DataSet ds = new DataSet();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              try
              {
                  cnn.Open();
                  da.Fill(ds);
                  return ds;
              }
              catch (Exception ex)
              {
                  return null;
              }
              finally
              {
                  cnn.Close();
              }

        }
        //---------------------------------------------------------------------------------------------------------
        public static DataSet GetListFull(ClPersonal c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Personal_GetListFull", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalID);

cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodID);
cmd.Parameters.Add(new SqlParameter("PesonalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PesonalCode);
cmd.Parameters.Add(new SqlParameter("JobRequestID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.JobRequestID);
cmd.Parameters.Add(new SqlParameter("NationalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.NationalCode);
cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FirstName);
cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LastName);
cmd.Parameters.Add(new SqlParameter("FatherName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherName);
cmd.Parameters.Add(new SqlParameter("BitrhPalceState", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.BitrhPalceState);
cmd.Parameters.Add(new SqlParameter("BirthPlaceCity", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BirthPlaceCity);
cmd.Parameters.Add(new SqlParameter("StayLength", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StayLength);
cmd.Parameters.Add(new SqlParameter("DayBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DayBithDate);
cmd.Parameters.Add(new SqlParameter("MonthBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonthBithDate);
cmd.Parameters.Add(new SqlParameter("YearBirthDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.YearBirthDate);
cmd.Parameters.Add(new SqlParameter("LocationID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LocationID);
cmd.Parameters.Add(new SqlParameter("OwnerAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OwnerAddress);
cmd.Parameters.Add(new SqlParameter("FatherAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherAddress);
cmd.Parameters.Add(new SqlParameter("WifeAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.WifeAddress);
cmd.Parameters.Add(new SqlParameter("HomePhone", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.HomePhone);
cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Mobile);
cmd.Parameters.Add(new SqlParameter("EmergencyMobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmergencyMobile);
cmd.Parameters.Add(new SqlParameter("MilitaryStatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryStatusID);
cmd.Parameters.Add(new SqlParameter("MilitaryMonthLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryMonthLong);
cmd.Parameters.Add(new SqlParameter("MilitaryYearLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryYearLong);
cmd.Parameters.Add(new SqlParameter("DriversLicenseID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DriversLicenseID);
cmd.Parameters.Add(new SqlParameter("CurrentJobID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CurrentJobID);
cmd.Parameters.Add(new SqlParameter("OfficeJobName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OfficeJobName);
cmd.Parameters.Add(new SqlParameter("EmploymentLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmploymentLong);
cmd.Parameters.Add(new SqlParameter("BimeLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BimeLong);
cmd.Parameters.Add(new SqlParameter("EducationLevel", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLevel);
cmd.Parameters.Add(new SqlParameter("EducationYear", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationYear);
cmd.Parameters.Add(new SqlParameter("EducationName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationName);
cmd.Parameters.Add(new SqlParameter("EducationLocationOstan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLocationOstan);
cmd.Parameters.Add(new SqlParameter("EducationCityName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationCityName);
cmd.Parameters.Add(new SqlParameter("SacrificeSixMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeSixMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeNineMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeNineMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeUpper", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeUpper);
cmd.Parameters.Add(new SqlParameter("SacrificeChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeChild);
cmd.Parameters.Add(new SqlParameter("SacrificeWife", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeWife);
cmd.Parameters.Add(new SqlParameter("SacrificeBorther", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeBorther);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadeh", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadeh);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadehChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadehChild);
cmd.Parameters.Add(new SqlParameter("SacrificeJanbaz", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeJanbaz);
cmd.Parameters.Add(new SqlParameter("SacrificejanbazChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificejanbazChild);
cmd.Parameters.Add(new SqlParameter("CenterStatusId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CenterStatusId);
cmd.Parameters.Add(new SqlParameter("DateStage1", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage1);
cmd.Parameters.Add(new SqlParameter("DateStage2", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage2);
cmd.Parameters.Add(new SqlParameter("DateStage3", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage3);
cmd.Parameters.Add(new SqlParameter("DateStage4", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage4);
cmd.Parameters.Add(new SqlParameter("RaceCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RaceCode);


           SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }
        //---------------------------------------------------------------------------------------------------------
        public static DataSet CheckAge(int PErsonalID){
            SqlCommand cmd = new SqlCommand("Prc_CheckAge", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.NVarChar)).Value =PErsonalID;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }

        }
        //---------------------------------------------------------------------------------------------------------
        public static int Update(ClPersonal c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Personal_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PersonalID);
cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodID);
cmd.Parameters.Add(new SqlParameter("PesonalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PesonalCode);
cmd.Parameters.Add(new SqlParameter("JobRequestID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.JobRequestID);
cmd.Parameters.Add(new SqlParameter("NationalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.NationalCode);
cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FirstName);
cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LastName);
cmd.Parameters.Add(new SqlParameter("FatherName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherName);
cmd.Parameters.Add(new SqlParameter("BitrhPalceState", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.BitrhPalceState);
cmd.Parameters.Add(new SqlParameter("BirthPlaceCity", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BirthPlaceCity);
cmd.Parameters.Add(new SqlParameter("StayLength", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StayLength);
cmd.Parameters.Add(new SqlParameter("DayBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DayBithDate);
cmd.Parameters.Add(new SqlParameter("MonthBithDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MonthBithDate);
cmd.Parameters.Add(new SqlParameter("YearBirthDate", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.YearBirthDate);
cmd.Parameters.Add(new SqlParameter("LocationID", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LocationID);
cmd.Parameters.Add(new SqlParameter("OwnerAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OwnerAddress);
cmd.Parameters.Add(new SqlParameter("FatherAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FatherAddress);
cmd.Parameters.Add(new SqlParameter("WifeAddress", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.WifeAddress);
cmd.Parameters.Add(new SqlParameter("HomePhone", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.HomePhone);
cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Mobile);
cmd.Parameters.Add(new SqlParameter("EmergencyMobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmergencyMobile);
cmd.Parameters.Add(new SqlParameter("MilitaryStatusID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryStatusID);
cmd.Parameters.Add(new SqlParameter("MilitaryMonthLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryMonthLong);
cmd.Parameters.Add(new SqlParameter("MilitaryYearLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.MilitaryYearLong);
cmd.Parameters.Add(new SqlParameter("DriversLicenseID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.DriversLicenseID);
cmd.Parameters.Add(new SqlParameter("CurrentJobID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CurrentJobID);
cmd.Parameters.Add(new SqlParameter("OfficeJobName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OfficeJobName);
cmd.Parameters.Add(new SqlParameter("EmploymentLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EmploymentLong);
cmd.Parameters.Add(new SqlParameter("BimeLong", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.BimeLong);
cmd.Parameters.Add(new SqlParameter("EducationLevel", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLevel);
cmd.Parameters.Add(new SqlParameter("EducationYear", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationYear);
cmd.Parameters.Add(new SqlParameter("EducationName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationName);
cmd.Parameters.Add(new SqlParameter("EducationLocationOstan", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationLocationOstan);
cmd.Parameters.Add(new SqlParameter("EducationCityName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.EducationCityName);
cmd.Parameters.Add(new SqlParameter("SacrificeSixMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeSixMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeNineMonth", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeNineMonth);
cmd.Parameters.Add(new SqlParameter("SacrificeUpper", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeUpper);
cmd.Parameters.Add(new SqlParameter("SacrificeChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeChild);
cmd.Parameters.Add(new SqlParameter("SacrificeWife", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeWife);
cmd.Parameters.Add(new SqlParameter("SacrificeBorther", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeBorther);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadeh", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadeh);
cmd.Parameters.Add(new SqlParameter("SacrificeAzadehChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeAzadehChild);
cmd.Parameters.Add(new SqlParameter("SacrificeJanbaz", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificeJanbaz);
cmd.Parameters.Add(new SqlParameter("SacrificejanbazChild", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SacrificejanbazChild);
cmd.Parameters.Add(new SqlParameter("CenterStatusId", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.CenterStatusId);
cmd.Parameters.Add(new SqlParameter("DateStage1", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage1);
cmd.Parameters.Add(new SqlParameter("DateStage2", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage2);
cmd.Parameters.Add(new SqlParameter("DateStage3", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage3);
cmd.Parameters.Add(new SqlParameter("DateStage4", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.DateStage4);

cmd.Parameters.Add(new SqlParameter("Native_HighScholl", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_HighScholl);
cmd.Parameters.Add(new SqlParameter("Native_Parent", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_Parent);
cmd.Parameters.Add(new SqlParameter("Native_ParentBime", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_ParentBime);
cmd.Parameters.Add(new SqlParameter("Native_SchoolTwo", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_SchoolTwo);
cmd.Parameters.Add(new SqlParameter("Native_ShoolOne", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_ShoolOne);
cmd.Parameters.Add(new SqlParameter("Native_SodorSH", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_SodorSH);
cmd.Parameters.Add(new SqlParameter("Native_Univercity", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_Univercity);
cmd.Parameters.Add(new SqlParameter("Native_Wife", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_Wife);
cmd.Parameters.Add(new SqlParameter("Native_WifeBime", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Native_WifeBime);

cmd.Parameters.Add(new SqlParameter("codePosti", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.codePosti);

cmd.Parameters.Add(new SqlParameter("IsChildOfShahdari", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsChildOfShahdari);
cmd.Parameters.Add(new SqlParameter("StudyFiedlD", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.StudyFiedlD);
cmd.Parameters.Add(new SqlParameter("StudyFieldName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.StudyFieldName);

cmd.Parameters.Add(new SqlParameter("SaAzadeh", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SaAzadeh);
cmd.Parameters.Add(new SqlParameter("SaBrotherShahid", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SaBrotherShahid);
cmd.Parameters.Add(new SqlParameter("SaFamiliy", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SaFamiliy);
cmd.Parameters.Add(new SqlParameter("SaJanbaz", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SaJanbaz);
cmd.Parameters.Add(new SqlParameter("SaSoldure", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.SaSoldure);

cmd.Parameters.Add(new SqlParameter("EmmloyeYearLong", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EmmloyeYearLong);

cmd.Parameters.Add(new SqlParameter("FinalyNativeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.FinalyNativeID);
cmd.Parameters.Add(new SqlParameter("FiNalyNativeCityID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.FiNalyNativeCityID);
cmd.Parameters.Add(new SqlParameter("FinalySacrificeID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.FinalySacrificeID);

cmd.Parameters.Add(new SqlParameter("PrintDate", SqlDbType.VarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PrintDate);
cmd.Parameters.Add(new SqlParameter("PrintCradFirst", SqlDbType.VarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PrintCradFirst);
cmd.Parameters.Add(new SqlParameter("PrintCardSecond", SqlDbType.VarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PrintCardSecond);

cmd.Parameters.Add(new SqlParameter("ProtestTitle", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestTitle);
cmd.Parameters.Add(new SqlParameter("ProtextContent", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtextContent);
cmd.Parameters.Add(new SqlParameter("ProtestReplay", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestReplay);
cmd.Parameters.Add(new SqlParameter("PerotestReplayDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PerotestReplayDate);
cmd.Parameters.Add(new SqlParameter("ProtestDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ProtestDate);

cmd.Parameters.Add(new SqlParameter("ExamCardDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ExamCardDate);
cmd.Parameters.Add(new SqlParameter("ChairNumber", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ChairNumber);

            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }




       
        //---------------------------------------------------------------------------------------------------------
        public static int Delete(string  PersonalID)
        {

            SqlCommand cmd = new SqlCommand("PRC_Personal_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("PersonalID", SqlDbType.Int)).Value =PersonalID ;
 
            SqlParameter prmResult = new SqlParameter("Result", SqlDbType.Int);
            prmResult.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmResult);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(prmResult.Value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cnn.Close();
            }

        }
    }

    //---------------------------------------------------------------------------------------------------------
}

