using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireFightDAL;
using FireFightCL;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Text;

namespace FireFight.Public
{
    public partial class Protest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {

                if (Session["IsManage"] == null)
                      lblPersonalID.Text = Request.QueryString["PersonalID"].ToString();
                else
                    lblPersonalID.Text = Session["PersonalID"].ToString();

                   BindData();
                   CheckProtestActive();

                  


            }
            
        }
        private void BindData() {
            ClPersonal cl = new ClPersonal();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
            DataSet ds = PersonalClass.GetList(cl);
            DataRow dr=ds.Tables[0].Rows[0];
            txtProtestTitle.Text = dr["ProtestTitle"].ToString();
            txtProtextContent.Text = dr["ProtextContent"].ToString();

            if (dr["ProtestDate"].ToString() == "" || dr["ProtestDate"] == null)
                lblProtestDate.Text = DateConvert.m2sh(DateTime.Now.ToString()).ToString();
            else
                lblProtestDate.Text = DateConvert.m2sh(dr["ProtestDate"].ToString());


            txtProtestReplay.Text = dr["ProtestReplay"].ToString();

            if (dr["PerotestReplayDate"].ToString() == "" || dr["PerotestReplayDate"] == null)
                lblReplayDate.Text = DateConvert.m2sh(DateTime.Now.ToString()).ToString();
            else
                lblReplayDate.Text = DateConvert.m2sh(dr["PerotestReplayDate"].ToString());


            if (Session["IsManage"] == null)
                btnreplay.Visible =false ;
            else
                btnreplay.Visible =true ;



            //if (dr["ProtestReplay"].ToString() == "")
            //    dReplay.Visible = false;
            //else
            //    dReplay.Visible = true;
        }

        private void CheckProtestActive() {
            ClPeriod cl = new ClPeriod();
            cl.PeriodID = 1;
            DataSet ds = PeriodClass.GetList(cl);
            DataRow dr = ds.Tables[0].Rows[0];
            if (dr["ProtestActive"].ToString() == "1")
                btnSave.Visible = true;
            else
                btnSave.Visible = false;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            ClPersonal cl = new ClPersonal();
               cl.PersonalID= Convert.ToInt32(lblPersonalID.Text);
               cl.ProtestTitle =  txtProtestTitle.Text  ;
               cl.ProtextContent = txtProtextContent.Text;
            cl.ProtestDate = DateTime.Now.ToString();
            int t=PersonalClass.Update(cl);
            if (t == 0)
                FireFightBLL.Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.warning, "خطا در ثبت اعتراض.");
            else
                FireFightBLL.Utility.ShowMsg(Page,FireFightBLL.ProPertyData.MsgType.General_Success,"متقاضی گرامی :اعتراض شما ثبت گردبد");

        }

        protected void btnreplay_Click(object sender, EventArgs e)
        {
   ClPersonal cl = new ClPersonal();
               cl.PersonalID= Convert.ToInt32(lblPersonalID.Text);
               cl.ProtestReplay = txtProtestReplay.Text;
            cl.PerotestReplayDate = DateTime.Now.ToString();

            int t=PersonalClass.Update(cl);
            if (t == 0)
                FireFightBLL.Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.warning, "خطا در ثبت .");
            else
                FireFightBLL.Utility.ShowMsg(Page,FireFightBLL.ProPertyData.MsgType.General_Success," ثبت گردبد");

        }
    }
}