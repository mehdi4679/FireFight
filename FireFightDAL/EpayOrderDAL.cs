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
    public class EpayOrderClass
    {
        public static SqlConnection cnn = new SqlConnection(CSharp.PublicFunction.cnstr());
        public static int insert(ClEpayOrder c )

        {

            SqlCommand cmd = new SqlCommand("PRC_EpayOrder_Insert", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

      
       cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.IP);
cmd.Parameters.Add(new SqlParameter("OS", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.OS);
cmd.Parameters.Add(new SqlParameter("Browser", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Browser);
cmd.Parameters.Add(new SqlParameter("Prcie", SqlDbType.Int)).Value =Securenamespace.SecureData.CheckSecurity(c.Prcie);
cmd.Parameters.Add(new SqlParameter("OrderDateStart", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateStart);
cmd.Parameters.Add(new SqlParameter("OrderDateEND", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateEND);
cmd.Parameters.Add(new SqlParameter("OrderStatus", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.OrderStatus);
cmd.Parameters.Add(new SqlParameter("RefId", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.RefId);
cmd.Parameters.Add(new SqlParameter("ResCode", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.ResCode);
cmd.Parameters.Add(new SqlParameter("Comment", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Comment);
cmd.Parameters.Add(new SqlParameter("VerifyResult", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.VerifyResult);
cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.FirstName);
cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.LastName);
cmd.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.PhoneNumber);
cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Mobile);
cmd.Parameters.Add(new SqlParameter("Email", SqlDbType.NVarChar)).Value =Securenamespace.SecureData.CheckSecurity(c.Email);
cmd.Parameters.Add(new SqlParameter("NationalCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.NationalCode);

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
        public static DataSet GetList(ClEpayOrder c)
        {

            SqlCommand cmd = new SqlCommand("PRC_EpayOrder_GetList", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
            cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
            cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
            cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
            cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

            cmd.Parameters.Add(new SqlParameter("EpayOrderID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EpayOrderID);
            cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.IP);
            cmd.Parameters.Add(new SqlParameter("OS", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OS);
            cmd.Parameters.Add(new SqlParameter("Browser", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Browser);
            cmd.Parameters.Add(new SqlParameter("Prcie", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Prcie);
            cmd.Parameters.Add(new SqlParameter("OrderDateStart", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateStart);
            cmd.Parameters.Add(new SqlParameter("OrderDateEND", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateEND);
            cmd.Parameters.Add(new SqlParameter("OrderStatus", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderStatus);
            cmd.Parameters.Add(new SqlParameter("RefId", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RefId);
            cmd.Parameters.Add(new SqlParameter("ResCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ResCode);
            cmd.Parameters.Add(new SqlParameter("Comment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Comment);
            cmd.Parameters.Add(new SqlParameter("VerifyResult", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.VerifyResult);
            cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FirstName);
            cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LastName);
            cmd.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PhoneNumber);
            cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Mobile);
            cmd.Parameters.Add(new SqlParameter("Email", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Email);
            cmd.Parameters.Add(new SqlParameter("ISUse", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ISUse);
            cmd.Parameters.Add(new SqlParameter("UseDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UseDate);

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
        public static int Update(ClEpayOrder c)
        {

            SqlCommand cmd = new SqlCommand("PRC_EpayOrder_Update", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("EpayOrderID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EpayOrderID);
cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.IP);
cmd.Parameters.Add(new SqlParameter("OS", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OS);
cmd.Parameters.Add(new SqlParameter("Browser", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Browser);
cmd.Parameters.Add(new SqlParameter("Prcie", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Prcie);
cmd.Parameters.Add(new SqlParameter("OrderDateStart", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateStart);
cmd.Parameters.Add(new SqlParameter("OrderDateEND", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateEND);
cmd.Parameters.Add(new SqlParameter("OrderStatus", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderStatus);
cmd.Parameters.Add(new SqlParameter("RefId", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RefId);
cmd.Parameters.Add(new SqlParameter("ResCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ResCode);
cmd.Parameters.Add(new SqlParameter("Comment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Comment);
cmd.Parameters.Add(new SqlParameter("VerifyResult", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.VerifyResult);
cmd.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.FirstName);
cmd.Parameters.Add(new SqlParameter("LastName", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.LastName);
cmd.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.PhoneNumber);
cmd.Parameters.Add(new SqlParameter("Mobile", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Mobile);
cmd.Parameters.Add(new SqlParameter("Email", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Email);
cmd.Parameters.Add(new SqlParameter("ISUse", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.ISUse);
cmd.Parameters.Add(new SqlParameter("UseDate", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.UseDate);


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
        public static int UpdateByRaseCode(ClEpayOrder c)
        {

            SqlCommand cmd = new SqlCommand("PRC_EpayOrder_UpdateWhithRaseCode", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

	cmd.Parameters.Add(new SqlParameter("EpayOrderID", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.EpayOrderID);
cmd.Parameters.Add(new SqlParameter("IP", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.IP);
cmd.Parameters.Add(new SqlParameter("OS", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OS);
cmd.Parameters.Add(new SqlParameter("Browser", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Browser);
cmd.Parameters.Add(new SqlParameter("Prcie", SqlDbType.Int)).Value = Securenamespace.SecureData.CheckSecurity(c.Prcie);
cmd.Parameters.Add(new SqlParameter("OrderDateStart", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateStart);
cmd.Parameters.Add(new SqlParameter("OrderDateEND", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderDateEND);
cmd.Parameters.Add(new SqlParameter("OrderStatus", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.OrderStatus);
cmd.Parameters.Add(new SqlParameter("RefId", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.RefId);
cmd.Parameters.Add(new SqlParameter("ResCode", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.ResCode);
cmd.Parameters.Add(new SqlParameter("Comment", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.Comment);
cmd.Parameters.Add(new SqlParameter("VerifyResult", SqlDbType.NVarChar)).Value = Securenamespace.SecureData.CheckSecurity(c.VerifyResult);
 

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
        public static int Delete(string  EpayOrderID)
        {

            SqlCommand cmd = new SqlCommand("PRC_EpayOrder_Delete", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("UserIDLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetUserID();
        cmd.Parameters.Add(new SqlParameter("IpLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetIPAddress();
        cmd.Parameters.Add(new SqlParameter("OSLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetOS();
        cmd.Parameters.Add(new SqlParameter("OSVerLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetBrowser() + CSharp.PublicFunction.GetBrowserVersion();
        cmd.Parameters.Add(new SqlParameter("URLLog", SqlDbType.NVarChar)).Value = CSharp.PublicFunction.GetURL();

   	cmd.Parameters.Add(new SqlParameter("EpayOrderID", SqlDbType.Int)).Value =EpayOrderID ;
 
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

