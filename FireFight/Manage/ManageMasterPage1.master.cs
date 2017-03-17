using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FireFight.Manage
{
    public partial class ManageMasterPage1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dwizard = (HtmlGenericControl)Master.FindControl("dwiz");
                dwizard.Visible = false;

                var limanage = (HtmlGenericControl)Master.FindControl("limanage");
                if (Session["IsManage"] != null)
                    limanage.Visible = true;

                var r = (HtmlGenericControl)Master.FindControl("contentAfetrSide");
                r.Attributes["class"] = "col-xs-9 col-sm-9  ";

                if(Page.Request.Url.AbsolutePath.ToUpper().Contains("PROTEST.ASPX"))
                    r.Attributes["class"] = "col-xs-12 col-sm-12  ";


                var t = (HtmlGenericControl)Master.FindControl("dSide");
                t.Visible = false;
                var body = (HtmlGenericControl)Master.FindControl("bd1");
                body.Attributes["class"] = "no-skin rtl  ";

 

            }
        }
    }
}