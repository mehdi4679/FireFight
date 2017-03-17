using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FireFight
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var liActive3 = (HtmlGenericControl)Master.FindControl("step1");
            liActive3.Attributes.Add("class", "active");

            

            var dnavigationHeader = (HtmlGenericControl)Master.FindControl("navigationHeader");
            dnavigationHeader.Visible = false;
        }

        protected void anextstep_ServerClick(object sender, EventArgs e)
        {
           
            //if(chAgree.Checked)
            //    Response.Redirect("/loginmain.aspx");
            //else
            //    FireFightBLL.Utility.ShowMsg(Page,FireFightBLL.ProPertyData.MsgType.warning,"داوطلب گرامی شما باید تیک مطالعه کردن شرایط آگهی استخدام را بزنید و سپس روی دکمه مرحله بعد کلیک نمایید");

            
        }
    }
}