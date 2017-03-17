using FireFightDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireFightCL;
using System.Web.UI.HtmlControls;

namespace FireFight.Manage
{
    public partial class EpayList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                BindGrid();
            }
        }
             public void BindGrid(){
                 ClEpayOrder cl = new ClEpayOrder();
       DataSet  ds = EpayOrderClass.GetList(cl);
      DataView  dv = new DataView(ds.Tables[0]);
        if ( ViewState["EpayOrder"]  == null){
        ViewState["EpayOrder"] = "EpayOrderID Desc";
        }
    dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["EpayOrder"].ToString()).ToString() ;
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
   if (ViewState["EpayOrder" + "Direction"] == null)
   {
       ViewState.Add("EpayOrder" + "Direction", "desc");
   }
 else
     {
        StrSortDirection = ViewState["EpayOrder" + "Direction"].ToString() ;
     }
        if (StrSortDirection == "desc"){
            StrSortDirection = "asc";}
   else {
           StrSortDirection = "desc";
        ViewState["EpayOrder" + "Direction"] = StrSortDirection;
    }
    ViewState["EpayOrder" ] = e.SortExpression + " " + StrSortDirection;
    BindGrid();
 }
            public void DeleteItem(object sender, System.EventArgs e)
  {    
       //         String  EpayOrderID  = ((HtmlAnchor)sender).HRef.ToString();
       // int i = EpayOrderClass.Delete(Convert.ToInt32(EpayOrderID));
       // if (i == 0) { LblMsg.Text = " error ";  
       // ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
       // }
       //else { BindGrid(); }
       // LightBox.Value = "0";
    }
    public void  UpItem(object sender, EventArgs e)
    { 
String EpayOrderID   = ((HtmlAnchor)sender).HRef.ToString();
  }
         protected void btnInsertLight_Click(object sender, EventArgs e)
  {      EmptyLight();
         
 }
protected void btnSerachLight_Click(object sender, EventArgs e)
{        EmptyLight() ;
        BtnSerach.Visible = true;
      
 }
public ClEpayOrder Data {
    get {
        ClEpayOrder cl = new ClEpayOrder();
        cl.LastName = TXTLastName.Text;
        cl.FirstName = TXTFirstName.Text;
        cl.NationalCode = TXTNationalCode.Text;
        cl.Mobile = TXTMobile.Text;
        cl.ResCode = TXTResCode.Text;
        cl.RefId = TXTRefId.Text;
        return cl;
    }
     
}
    protected void BtnSerach_Click1(object sender, EventArgs e)
   {    DataSet  ds =EpayOrderClass.GetList(Data);
        DataView  dv   = new DataView(ds.Tables[0]);
        String StrSort = Securenamespace.SecureData.CheckSecurity(ViewState["EpayOrder"].ToString());
        if (StrSort != null) {
        dv.Sort = StrSort;
         }
        GridView1.DataSource = dv;
        GridView1.DataBind();
   }
    protected void BtnInsert_Click(Object sender  ,  System.EventArgs e )
    {  
       // int  t  =  EpayOrderClass.insert(null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null);
       // if (t == 0){
       // LblMsg.ForeColor = System.Drawing.Color.Red; 
       // LblMsg.Text = "خطا در ثبت";
       //} else{
       // LblMsg.ForeColor = System.Drawing.Color.Green;
       // LblMsg.Text = "ثبت  انجام شد.";
       // BindGrid();
       //}
   }
    protected  void EmptyLight(){
    }
   //  protected void BtnUpdate_Click1(object sender, EventArgs e)
   // {   int i   = EpayOrderClass.Update(null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null);
   //     if (i == 0 ){
   //     LblMsg.ForeColor = System.Drawing.Color.Red;
   //     LblMsg.Text = "خطا";
   //    } else{
   //     LblMsg.ForeColor = System.Drawing.Color.Green;
   //     LblMsg.Text = "ویرایش انجام شد";
   //     BindGrid();
   //     }
   //}

        

    }
}