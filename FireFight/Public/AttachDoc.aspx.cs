using FireFightBLL;
using FireFightCL;
using FireFightDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data;

namespace FireFight.Public
{
    public partial class AttachDoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var liActive = (HtmlGenericControl)Master.FindControl("step1");
            liActive.Attributes.Add("class", "complete");
            var liActive2 = (HtmlGenericControl)Master.FindControl("step2");
            liActive2.Attributes.Add("class", "complete");
            var liActive3 = (HtmlGenericControl)Master.FindControl("step3");
            liActive3.Attributes.Add("class", "complete"); 
            var liActive4 = (HtmlGenericControl)Master.FindControl("step4");
            liActive4.Attributes.Add("class", "complete"); 
            var liActive5 = (HtmlGenericControl)Master.FindControl("step5");
            liActive5.Attributes.Add("class", "active");
            var r = (HtmlGenericControl)Master.FindControl("contentAfetrSide");
            r.Attributes["class"] = "col-xs-12 col-sm-12  ";
            var body = (HtmlGenericControl)Master.FindControl("bd1");
            body.Attributes["class"] = "no-skin rtl container ";

            if (Session["IsManage"] == null)
                    lblPersonalID.Text = Session["PersonalID"].ToString();
                else
                    lblPersonalID.Text = Request.QueryString["PersonalID"].ToString();

            if (!Page.IsPostBack) {
                BindDD();
                BindMadarek();
            }

        }
        private void BindDD()
        {
            ddAttachType.DataSource = CatalogClass.GetListAllAttach(Convert.ToInt32(lblPersonalID.Text));
            ddAttachType.DataTextField = "CatalogName";
            ddAttachType.DataValueField = "CatalogValue";
            ddAttachType.DataBind();
            ddAttachType.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

            //ClPersonal cl=new ClPersonal();
            //cl.PersonalID=Convert.ToInt32(lblPersonalID.Text);
            //DataSet ds = PersonalClass.GetList(cl);
            //DataRow dr = ds.Tables[0].Rows[0];
            //if(dr[""].ToString()=="")



        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (ddAttachType.SelectedValue == "0") {
                Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "نوع پیوست مدرک را انتخاب نمایید");
                return;
            }
            if (FileUpload1.HasFile)
            {
                string Alarm = CSharp.PublicFunction.CheckFile(FileUpload1.PostedFile);
                if (Alarm != "") { FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, Alarm); return; }
            }
            else  
            { FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "ارسال مدرک  الزاامی است"); return; }




            int t = 0;
             
                ClAttach cl = new ClAttach();
                cl.PersonalID =Convert.ToInt32(lblPersonalID.Text);
                cl.ForCatalogType = 4;
                cl.AttachName = FileUpload1.FileName;
            cl.ForCatalogValue=Convert.ToInt32( ddAttachType.SelectedValue);

                t = AttachClass.insert(cl);
                
                if (t == 0)
                {       
                    FireFightBLL.Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.General_Fault, "خطا در درج پیوست");
                return;
                }
            
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (FileUpload1.HasFile)
            {
                string tempPath = System.Configuration.ConfigurationManager.AppSettings["FolderPath"];
                string fileName = Path.Combine(Server.MapPath(tempPath), FileUpload1.FileName);
               
                int iattach =t;
                //save the file to our local path
                FileUpload1.SaveAs(Path.Combine(Server.MapPath(tempPath), iattach.ToString()) + Path.GetExtension(FileUpload1.FileName));
                if (iattach == 0)
                    FireFightBLL.Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.General_Fault, "خطا در ثبت مدرک");
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            BindMadarek();

           
        }
        private void BindMadarek() { 
         ClAttach cl = new ClAttach();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
            rpPic.DataSource = AttachClass.GetList(cl);
            rpPic.DataBind();
        }
        protected void ADel_ServerClick(object sender, EventArgs e)
        {
            string aid = ((HtmlAnchor)sender).HRef.ToString();
            int t = 0;
            t = AttachClass.Delete(aid);
            if (t == 0)
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا در حذف مدرک");
            else
                BindMadarek();

        }

        protected void aanneexxtt_ServerClick(object sender, EventArgs e)
        {
           
            if (rpPic.Items.Count == 0)
            {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "پیوست مدارک الزامی است");
                return;
            }

            ClPersonal cl = new ClPersonal();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
            DataSet ds = PersonalClass.GetListChechPersonalAttach(cl);
            DataRow dr = ds.Tables[0].Rows[0];

            if (dr["Result"].ToString() == "0")
            {
                Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "پیوست همه مدارک الزامی است");
                return;
            }
            ds.Dispose();


            if (Session["IsManage"] != null)
                Response.Redirect("~/Public/Print.aspx?PersonalID=" + Request.QueryString["PersonalID"] + "&AcceptName=" + Request.QueryString["AcceptName"] + "&PName=" + Request.QueryString["PName"]);
            else
                Response.Redirect("~/Public/Print.aspx");


            //Response.Redirect("~/Public/Print.aspx");
        }
        







    }
}