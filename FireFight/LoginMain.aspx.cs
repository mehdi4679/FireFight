using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using FireFightDAL;
using FireFightCL;
using FireFightBLL;
using System.Data;
using System.Security.Principal;
using System.Web.Security;
using System.Configuration;


namespace FireFight
{
    public partial class LoginMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var dwizard = (HtmlGenericControl)Master.FindControl("dwiz");
            //dwizard.Visible = false;

            var dnavigationHeader = (HtmlGenericControl)Master.FindControl("navigationHeader");
            dnavigationHeader.Visible = false;

            var liActive1 = (HtmlGenericControl)Master.FindControl("step1");
            liActive1.Attributes.Add("class", "complete");

            var liActive2 = (HtmlGenericControl)Master.FindControl("step2");
            liActive2.Attributes.Add("class", "active");

        }

       
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Value == null || txtUserName.Value.Length < 12)
            {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "سریال ثبت نام باید 12 رقمی باشد.در صورت نداشتن این سریال ابتدا باید اقدام به خرید نمایید ");
                return;
            }
            FireFightCL.ClEpayOrder cl = new FireFightCL.ClEpayOrder();
            cl.ResCode = txtUserName.Value;
            cl.VerifyResult =  ConfigurationManager.AppSettings["Price"].ToString() ;
            DataSet ds = FireFightDAL.EpayOrderClass.GetList(cl);
            if (ds.Tables[0].Rows.Count > 0)
            {

                DataRow dr = ds.Tables[0].Rows[0];
                if (dr["ISUse"].ToString() == "1")
                {
                    FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "  این سریال قبلا استفاده شده است و قابل ثبت نام نمیباشد .برای  ویرایش اطلاعات باید از قسمت ویرایش اقدام نمایید");
                    return;
                }
                else {
                    cl.ISUse = 1;
                    cl.UseDate = DateTime.Now.ToShortDateString();
                    cl.EpayOrderID = Convert.ToInt32(dr["EpayOrderID"].ToString());
                    int v = 0;
                    v = EpayOrderClass.Update(cl);
                    if (v == 0)
                    {
                        Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا در ورود  به سامانه .لطفا با مرکز تماس بگیرید");
                        return;
                    }
                    

                }

                ////////create PrsonalID 
                ClPersonal clPersonal1 = new ClPersonal();
                clPersonal1.EpeyOrderID = Convert.ToInt32(dr["EpayOrderID"].ToString());
                int i = 0;
                i = PersonalClass.insert(clPersonal1);
                if (i == 0)
                    FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا در سیستم");

                Session["PersonalID"] = i.ToString();

                //////////////////////Add Role To Coocki
                String userid = i.ToString();
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
                Response.Redirect("~/Public/FirstInfo.aspx");
            }
            else
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "سریال 12 رقمی ثبت نام صحیح نمی باشد");

        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (txtmobile.Value == "" || txtmobile.Value.Length < 11) {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "شماره موبایل را 11 رقمی وارد نمایید");
                return;
            }
            string SeryaleAll = "";
            DataRow dr;
            ClEpayOrder cl = new ClEpayOrder();
            cl.Mobile = txtmobile.Value;
            cl.ISUse = 0;
            DataSet ds = EpayOrderClass.GetList(cl);
            if (ds.Tables[0].Rows.Count > 0) {
               
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++) { 
                    dr=ds.Tables[0].Rows[i];
                    SeryaleAll += dr["ResCode"].ToString() + Environment.NewLine;
                }
                 

                    PublicFN.SendSMSs(txtmobile.Value, "سریال خریداری شده توسط شما"+Environment.NewLine+SeryaleAll+"  میباشد.سامانه ثبت نام استخدامی شهرداری های استان قم ");
                Utility.ShowMsg(Page,ProPertyData.MsgType.General_Success,"پیامک با موفقیت ارسال شد لطفا دقایقی منتظر بمانید");

            }
        }
    }
}