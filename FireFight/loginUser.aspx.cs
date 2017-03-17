using FireFightBLL;
using FireFightCL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FireFight
{
    public partial class loginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["IsManage"] != null && Session["IsManage"] != "0" && Session["IsManage"] != "" && !Page.IsPostBack)
                Response.Redirect("/manage/RegList.aspx");

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //  Response.Redirect("Index.aspx");

            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Value + "~!@", "MD5");
            DataSet ds = TaxiDAL.UsersClass.GetList(null, txtUserName.Value, hash, null, null, null, null, null, null, null, null, null);


            if (ds.Tables[0].Rows.Count != 0)
            {
                //
                DError.Visible = true;
                DataRow dr = ds.Tables[0].Rows[0];
                Session["IsManage"] = dr["userID"].ToString();

                String userid = dr["UserID"].ToString();
                string roles = "IsManage,public";
                //role[0]=;
                //role[1]="public";
                Session["role"] = "IsManage,public,ViewPic";

                HttpContext.Current.User = new GenericPrincipal(User.Identity, new string[] { "IsManage,public"});
                FormsAuthentication.Initialize();
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, userid, DateTime.Now, DateTime.Now.AddMinutes(540), false, roles , FormsAuthentication.FormsCookiePath);
                hash = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
                if (ticket.IsPersistent == true)
                    cookie.Expires = ticket.Expiration;

                Response.Cookies.Add(cookie);
                // Roles.AddUserToRole(userid, role);

                // Roles.AddUserToRole(dr["UserName"].ToString(),"admin");
                Response.Redirect("/Manage/RegList.aspx");


            }
            else
            {
                DError.Visible = true;
                //LblError.Text = "نام کاربری یا کلمه عبور اشتباه میباشد";
            }

        }
        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (txtmobile.Value == "" || txtmobile.Value.Length < 11)
            {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "شماره موبایل را 11 رقمی وارد نمایید");
                return;
            }
            string randomm = Utility.RandomString(7);
            var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(randomm + "~!@", "MD5");

     


            string SeryaleAll = "";
            DataRow dr;

            DataSet ds = TaxiDAL.UsersClass.GetList(null, null, null, null, null, txtmobile.Value, null, null, null, null, null);
            if (ds.Tables[0].Rows.Count > 0)
            {

                
                    dr = ds.Tables[0].Rows[0];
                    SeryaleAll += dr["UserName"].ToString() + Environment.NewLine;

                    int i = TaxiDAL.UsersClass.Update(dr["UserID"].ToString(),   null, hash, null,null,null,null,null,null,null,null);
                    if (i == 0)
                    {
                         
                        Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا");
                    }
                    else
                    {
                        
                    }


                    PublicFN.SendSMSs(txtmobile.Value, "نام کاربری شما" + Environment.NewLine + dr["UserName"] + "کلمه عبور:" + randomm   +Environment.NewLine + "  میباشد.سامانه ثبت نام استخدامی شهرداری های استان قم ");
                Utility.ShowMsg(Page, ProPertyData.MsgType.General_Success, "پیامک با موفقیت ارسال شد لطفا دقایقی منتظر بمانید");

            }
            else{
            FireFightBLL.Utility.ShowMsg(Page,ProPertyData.MsgType.warning,"موبایل موجود نیست");
            }
        }
    }
}