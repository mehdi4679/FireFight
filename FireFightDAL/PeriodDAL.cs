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
    public class PeriodClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClPeriod c )

        {

            SqlCommand cmd = new SqlCommand("PRC_Period_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("PeriodStartDate", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.PeriodStartDate);
cmd.Parameters.Add(new SqlParameter("PeriodEndDate", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.PeriodEndDate);
cmd.Parameters.Add(new SqlParameter("PeriodName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.PeriodName);
cmd.Parameters.Add(new SqlParameter("IsActive", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.IsActive);


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
        public static DataSet GetList(ClPeriod c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Period_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();
            cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodID);

cmd.Parameters.Add(new SqlParameter("PeriodStartDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodStartDate);
cmd.Parameters.Add(new SqlParameter("PeriodEndDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodEndDate);
cmd.Parameters.Add(new SqlParameter("PeriodName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodName);
cmd.Parameters.Add(new SqlParameter("IsActive", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsActive);


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
        public static int Update(ClPeriod c)
        {

            SqlCommand cmd = new SqlCommand("PRC_Period_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodID);
cmd.Parameters.Add(new SqlParameter("PeriodStartDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodStartDate);
cmd.Parameters.Add(new SqlParameter("PeriodEndDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodEndDate);
cmd.Parameters.Add(new SqlParameter("PeriodName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PeriodName);
cmd.Parameters.Add(new SqlParameter("IsActive", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.IsActive);


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
        public static int Delete(string  PeriodID)
        {

            SqlCommand cmd = new SqlCommand("PRC_Period_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("PeriodID", SqlDbType.Int)).Value =PeriodID ;
 
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

