using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using FireFightDAL;
using FireFightCL;
using System.Data;

namespace FireFight.Controls
{
    public partial class CtlPersonalAccept : System.Web.UI.UserControl
    {
        public void BindGrid()
        {
            ClPersonAccept cl = new ClPersonAccept();
             cl.PersonalID =Convert.ToInt32( lblPersonalID.Text);
            //cl.AcceptID = Convert.ToInt32(DDAcceptID.SelectedValue);
            //cl.DescAccept = TXTDescAccept.Text;
            

            DataSet ds = PersonAcceptClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if ( ViewState["PersonAccept"]   == null)
            {
                ViewState["PersonAccept"] = "PersonAcceptID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["PersonAccept"].ToString()).ToString();
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            string StrSortDirection = "desc";
            if (ViewState["PersonAccept" + "Direction"] == null)
            {
                ViewState.Add("PersonAccept" + "Direction", "desc");
            }
            else
            {
                StrSortDirection =  ViewState["PersonAccept" + "Direction"].ToString() ;
            }
            if (StrSortDirection == "desc")
            {
                StrSortDirection = "asc";
            }
            else
            {
                StrSortDirection = "desc";
                ViewState["PersonAccept" + "Direction"] = StrSortDirection;
            }
            ViewState["PersonAccept"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            String PersonAcceptID = ((HtmlAnchor)sender).HRef.ToString();
            int i = PersonAcceptClass.Delete( PersonAcceptID );
            if (i == 0)
            {
                LblMsg.Text = " error ";
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
            }
            else { BindGrid(); }
             
        }
        
        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
           
            BtnInsert.Visible = true;
            BtnSerach.Visible = false;
            
        }
        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            BtnSerach.Visible = true;
            BtnInsert.Visible = false;
            
        }
        protected void BtnSerach_Click1(object sender, EventArgs e)
        {
            ClPersonAccept cl = new ClPersonAccept();
            cl.PersonalID =Convert.ToInt32( LblParamPersonAcceptID.Text);
            cl.AcceptID = Convert.ToInt32(DDAcceptID.SelectedValue);
            cl.DescAccept = TXTDescAccept.Text;

            DataSet ds = PersonAcceptClass.GetList(cl);
            DataView dv = new DataView(ds.Tables[0]);
            String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["PersonAccept"].ToString());
            if (StrSort != null)
            {
                dv.Sort = StrSort;
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();
        }
        public ClPersonAccept Data{
            get {
                ClPersonAccept cl = new ClPersonAccept();
                cl.PersonAcceptID=Convert.ToInt32(LblParamPersonAcceptID.Text);
                cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
                cl.AcceptID = Convert.ToInt32(DDAcceptID.SelectedValue);
                cl.DescAccept = TXTDescAccept.Text;
                cl.UserReg =Convert.ToInt32(lblUserReg.Text);

                return cl;
            }
            set {
                ClPersonAccept cl = new ClPersonAccept();
                DataSet ds = PersonAcceptClass.GetList(Data);
                    DataRow dr=ds.Tables[0].Rows[0];
                    TXTDescAccept.Text = dr["DescAccept"].ToString();
                    DDAcceptID.SelectedValue = dr["AcceptID"].ToString();
                    LblParamPersonAcceptID.Text = dr["PersonAcceptID"].ToString();
                    lblPersonalID.Text = dr["PersonalID"].ToString();
            }
        }
        protected void BtnInsert_Click(Object sender, System.EventArgs e)
        {
            ClPersonAccept cl = Data;
            int t = 0;
            if (CSharp.PublicFunction.ModeInsert(LblParamPersonAcceptID.Text))
                t=PersonAcceptClass.insert(cl);
            else
               t= PersonAcceptClass.Update(cl);

            
            if (t == 0)
            {
                LblMsg.ForeColor = System.Drawing.Color.Red;
                FireFightBLL.Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.warning, "خطا در ثبت");
            }
            else
            {
                LblMsg.ForeColor = System.Drawing.Color.Green;
                FireFightBLL.Utility.ShowMsg(Page, FireFightBLL.ProPertyData.MsgType.accept, "ثبت  انجام شد");
               
                BindGrid();
            }
        }
        protected void EmptyLight()
        {
        }
        public void BinDD() {
            DDAcceptID.DataSource = CatalogClass.GetListTypeID("17");
            DDAcceptID.DataTextField = "CatalogName";
            DDAcceptID.DataValueField = "CatalogValue";
            DDAcceptID.DataBind();


        }
        public string UserRegg {
            get { return lblUserReg.Text; }
            set { lblUserReg.Text = value; }
        }
        public string PersonalIDD {
            get { return lblPersonalID.Text; }
            set { lblPersonalID.Text = value; }
        }
    }
}