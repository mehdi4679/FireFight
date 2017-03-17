using FireFightBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data;
using FireFightDAL;
using FireFightBLL;
using FireFightCL;
using System.Web.Security;
using System.Security.Principal;

namespace FireFight
{
    public partial class EditLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dnavigationHeader = (HtmlGenericControl)Master.FindControl("navigationHeader");
                dnavigationHeader.Visible = false;
                var dwizard = (HtmlGenericControl)Master.FindControl("dwiz");
                dwizard.Visible = false;
                //var liActive1 = (HtmlGenericControl)Master.FindControl("step1");
                //liActive1.Attributes.Add("class", "complete");

                //var liActive2 = (HtmlGenericControl)Master.FindControl("step2");
                //liActive2.Attributes.Add("class", "active");
                if (Request.QueryString["FirstCard"] != null)
                    dDescc.Visible = true;
                else
                    dDescc.Visible = false;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Value == null || txtUserName.Value.Length < 10 || txtPass.Value.Length<12)
            {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "سریال ثبت نام باید 12 رقمی باشد.و وشماره شماره پرونده باید 10 رقمی باشد ");
                return;
            }

            ClPersonal cl = new ClPersonal();
            cl.PesonalCode = txtUserName.Value;
            cl.RaceCode = txtPass.Value;
            DataSet ds = PersonalClass.GetListFull(cl);
            if (ds.Tables[0].Rows.Count ==0)
                Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.warning, "مشخصات وارده اشتباه است");
            else
            {
            DataRow dr = ds.Tables[0].Rows[0];
            if(Request.QueryString["FirstCard"]==null)
                        Session["PersonalID"] = dr["PersonalID"].ToString();
                            else
              Session["PersonalID"] = dr["PersonalID"].ToString();
            //////////////////////Add Role To Coocki
                String userid="";
          
                userid= dr["PersonalID"].ToString();
                


             string role = "public,ViewPic";
            HttpContext.Current.User = new GenericPrincipal(User.Identity, new string[] { role });
            FormsAuthentication.Initialize();
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, userid, DateTime.Now, DateTime.Now.AddMinutes(540), false, role, FormsAuthentication.FormsCookiePath);
            string hash = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
            if (ticket.IsPersistent == true)
                cookie.Expires = ticket.Expiration;
            Response.Cookies.Add(cookie);
            ///////////////////////////
            ds.Dispose();
 // Response.Redirect("~/Public/FirstInfo.aspx");
    //        if (Request.QueryString["FirstCard"]==null)
                 Response.Redirect("~/Public/firstinfo.aspx?PersonalID="+ dr["PersonalID"].ToString());
    //            else
    //            Response.Redirect("~/Public/Protest.aspx");
            }

            


             


        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (txtmobile.Value == "" || txtmobile.Value.Length < 11)
            {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "شماره موبایل را 11 رقمی وارد نمایید");
                return;
            }
            string SeryaleAll = "";
            DataRow dr;
            ClPersonal cl = new ClPersonal();
            cl.Mobile = txtmobile.Value;
           
            DataSet ds = PersonalClass.GetListFull(cl);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                SeryaleAll += "شماره داوطلبی:" + dr["PesonalCode"].ToString() + Environment.NewLine;
                SeryaleAll += "سریال خرید الکترونیک:" + dr["ResCode"].ToString() + Environment.NewLine;
                PublicFN.SendSMSs(txtmobile.Value, SeryaleAll + "  میباشد.سامانه ثبت نام استخدامی شهرداری های استان قم ");
                Utility.ShowMsg(Page, ProPertyData.MsgType.General_Success, "پیامک با موفقیت ارسال شد لطفا دقایقی منتظر بمانید");
            }
            else
            {
                FireFightBLL.Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.warning, "شماره داوطلبی یا سریال خرید الکترونیک برای این شماره ثیت نشده است");
            }

        }
    }
}