using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireFightBLL;
using FireFightDAL;
using FireFightCL;
using System.Data;

namespace FireFight.Controls
{
    public partial class CtlEpayOrder : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public ClEpayOrder Data {
            get {
                ClEpayOrder cl = new ClEpayOrder();
                cl.EpayOrderID = Convert.ToInt32(LblParamEpayOrderID.Text);
                cl.FirstName = TXTFirstName.Text;
                cl.LastName = TXTLastName.Text;
                cl.PhoneNumber = TXTPhoneNumber.Text;
                cl.Mobile = TXTMobile.Text;
                cl.Email = TXTEmail.Text;
                return cl;
            }
            set {
                ClEpayOrder cl = new ClEpayOrder();
                DataSet ds = EpayOrderClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTEmail.Text = dr["Email"].ToString();
                TXTFirstName.Text = dr["FirstName"].ToString();
                TXTLastName.Text = dr["LastName"].ToString();
                TXTMobile.Text = dr["Mobile"].ToString();
                TXTPhoneNumber.Text = dr["PhoneNumber"].ToString();
                LblParamEpayOrderID.Text = dr["EpayOrderID"].ToString();

            }
        }
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = EpayOrderClass.insert(Data);
            if (i == 0)
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "");
            else
                Response.Redirect("");

        }
    }
}