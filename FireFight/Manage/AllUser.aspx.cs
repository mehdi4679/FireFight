using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FireFight.Manage
{
    public partial class AllUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                CtlUser1.BindSemat();
                CtlUser1.BindGrid();
            }

        }
    }
}