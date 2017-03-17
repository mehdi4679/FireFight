using FireFightBLL;
using FireFightCL;
using FireFightDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FireFight
{
    public partial class Order : System.Web.UI.Page
    {
        private string MerchantId = ConfigurationManager.AppSettings["MerchantId"];
        protected void Page_Load(object sender, EventArgs e)
        {
            var dwizard = (HtmlGenericControl)Master.FindControl("dwiz");
            dwizard.Visible = false;
            var dnavigationHeader = (HtmlGenericControl)Master.FindControl("navigationHeader");
            dnavigationHeader.Visible = false;

            lblPrice.Text = ConfigurationManager.AppSettings["Price"];
        }
        public ClEpayOrder Data
        {
            get
            {
                ClEpayOrder cl = new ClEpayOrder();
                //cl.EpayOrderID = Convert.ToInt32(LblParamEpayOrderID.Text);
                cl.FirstName = TXTFirstName.Text;
                cl.LastName = TXTLastName.Text;
                cl.PhoneNumber = TXTPhoneNumber.Text;
                cl.Mobile = TXTMobile.Text;
                cl.Email = TXTEmail.Text;
                cl.NationalCode = TXTNationalCode.Text;
                return cl;
            }
            set
            {
                ClEpayOrder cl = new ClEpayOrder();
                DataSet ds = EpayOrderClass.GetList(value);
                DataRow dr = ds.Tables[0].Rows[0];
                TXTEmail.Text = dr["Email"].ToString();
                TXTFirstName.Text = dr["FirstName"].ToString();
                TXTLastName.Text = dr["LastName"].ToString();
                TXTMobile.Text = dr["Mobile"].ToString();
                TXTPhoneNumber.Text = dr["PhoneNumber"].ToString();
                TXTNationalCode.Text = dr["NationalCode"].ToString();

               // LblParamEpayOrderID.Text = dr["EpayOrderID"].ToString();

            }
        }
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
          
                Epay();

        }
        private string GetUniquCode()
        {
            string trancadeCode = "";
            int i = 0;

            DataSet ds = new DataSet();
            while (i == 0)
            {
                trancadeCode = FireFightBLL.Utility.RandomDigit(12).ToUpper();
                ClEpayOrder cl = new ClEpayOrder();
                cl.RefId = trancadeCode;
                ds = EpayOrderClass.GetList(cl);
                if (ds.Tables[0].Rows.Count == 0)
                    i = 1;
            }
            ds.Dispose();
            return trancadeCode;
        }
        private void Epay() {
            try
            {
                if (TXTMobile.Text == "" || TXTMobile.Text.Length < 11)
                {
                    FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "شماره موبایل را 11 رقمی وارد نمایید");
                    return;
                }
                if (!Utility.isValidMelliCode(TXTNationalCode.Text))
                {
                    Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "کد ملی نامعتبر است");
                    return;
                }

                string url = ConfigurationManager.AppSettings["SafhePardakhtPage"];// Properties.Settings.Default.SafhePardakhtPage;
                string Price = ConfigurationManager.AppSettings["Price"];
                string resNum = GetUniquCode();

                string RedirectURL = ConfigurationManager.AppSettings["ReturnAddress"];// Properties.Settings.Default.ReturnAddress;

                ClEpayOrder cl = new ClEpayOrder();
                 
                 cl.OrderDateStart = DateTime.Now.ToString();
                cl.IP = CSharp.PublicFunction.GetIPAddress();
                cl.OS = CSharp.PublicFunction.GetOS();
                cl.Prcie = Convert.ToInt32(Price);
                cl.ResCode = resNum;
                cl.Browser = CSharp.PublicFunction.GetBrowser() + " " + CSharp.PublicFunction.GetBrowserVersion();
                cl.FirstName = TXTFirstName.Text;
                cl.LastName = TXTLastName.Text;
                cl.PhoneNumber = TXTPhoneNumber.Text;
                cl.Mobile = TXTMobile.Text;
                cl.Email = TXTEmail.Text;
                cl.NationalCode = TXTNationalCode.Text;

                int i = EpayOrderClass.insert(cl);
                if (i == 0)
                    Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا در برنامه");
                else
                    Response.Redirect(url + "?ResNum=" + resNum + "&MID=" +
                    MerchantId + "&RedirectURL=" + RedirectURL + "&Amount=" + Price.ToString());

            }
            catch (Exception ex)
            {
            }
        }

    }
}