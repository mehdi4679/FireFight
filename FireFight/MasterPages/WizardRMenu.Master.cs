using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FireFight.MasterPages
{
    public partial class WizardRMenu : System.Web.UI.MasterPage
    {
        public bool Wizard {
            get {
                return dwiz.Visible;
            }
            set {
                dwiz.Visible = value;
            }
        }
        public bool SideMenu {
            get { return dSide.Visible; }
            set { 
                dSide.Visible = value;
                if (!value)
                {
                    var r = (HtmlGenericControl)FindControl("contentAfetrSide");
                    r.Attributes["class"] = "col-xs-12 col-sm-12  ";
                }
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {

                //var dnavigationHeader = (HtmlGenericControl)FindControl("navigationHeader");
                //dnavigationHeader.Visible = false;

            string url=HttpContext.Current.Request.Url.AbsolutePath.ToUpper();

            if (url.Contains("PUBLIC"))
                dSide.Visible = false;
            else
                dSide.Visible = true;


            if (Session["IsManage"] != null)
            {
                RightManage.Visible = true;
                lblLastAccept.Visible = true;
                lblLastAccept.Text = Request.QueryString["AcceptName"];
                lblPersonalName.Text = Request.QueryString["PName"];
                liManage.Visible = true;
            }
                

            }

            
        }

        protected void aaccept_ServerClick(object sender, EventArgs e)
        {
            //LightBox2.Value = "1";
            //CtlPersonalAccept1.BinDD();
            //CtlPersonalAccept1.UserRegg = Session["IsManage"].ToString();
            //CtlPersonalAccept1.PersonalIDD =Request.QueryString["PersonalID"];
            //CtlPersonalAccept1.BindGrid();
        }
        }
    }
 