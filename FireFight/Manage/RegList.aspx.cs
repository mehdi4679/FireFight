using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireFightDAL;
using System.Data;
using FireFightCL;
using System.Web.UI.HtmlControls;

namespace FireFight.Manage
{
    public partial class RegList : System.Web.UI.Page
    {
        public void BindDD() {
            DDBitrhPalceState.DataSource = CatalogClass.GetListTypeID("5");
            DDBitrhPalceState.DataTextField = "CatalogName";
            DDBitrhPalceState.DataValueField = "CatalogValue";
            DDBitrhPalceState.DataBind();
            DDBitrhPalceState.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

            DDCurrentJobID.DataSource = CatalogClass.GetListTypeID("10");
            DDCurrentJobID.DataTextField = "CatalogName";
            DDCurrentJobID.DataValueField = "CatalogValue";
            DDCurrentJobID.DataBind();
            DDCurrentJobID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

            DDDriversLicenseID.DataSource = CatalogClass.GetListTypeID("2");
            DDDriversLicenseID.DataTextField = "CatalogName";
            DDDriversLicenseID.DataValueField = "CatalogValue";
            DDDriversLicenseID.DataBind();
            DDDriversLicenseID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

            ddEducationLevel.DataSource = CatalogClass.GetListTypeID("3");
            ddEducationLevel.DataTextField = "CatalogName";
            ddEducationLevel.DataValueField = "CatalogValue";
            ddEducationLevel.DataBind();
            ddEducationLevel.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

                       ddEducationName.DataSource = CatalogClass.GetListTypeID("12");
                       ddEducationName.DataTextField = "CatalogName";
                       ddEducationName.DataValueField = "CatalogValue";
                       ddEducationName.DataBind();
                       ddEducationName.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

            ddFiNalyNativeCityID.DataSource = CatalogClass.GetListTypeID("11");
            ddFiNalyNativeCityID.DataTextField = "CatalogName";
            ddFiNalyNativeCityID.DataValueField = "CatalogValue";
            ddFiNalyNativeCityID.DataBind();
            ddFiNalyNativeCityID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

             ddFinalyNativeID.DataSource = CatalogClass.GetListTypeID("14");
             ddFinalyNativeID.DataTextField = "CatalogName";
             ddFinalyNativeID.DataValueField = "CatalogValue";
             ddFinalyNativeID.DataBind();
             ddFinalyNativeID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

             ddFinalySacrificeID.DataSource = CatalogClass.GetListTypeID("13");
             ddFinalySacrificeID.DataTextField = "CatalogName";
             ddFinalySacrificeID.DataValueField = "CatalogValue";
             ddFinalySacrificeID.DataBind();
             ddFinalySacrificeID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

             DDJobRequestID.DataSource = CatalogClass.GetListTypeID("7");
             DDJobRequestID.DataTextField = "CatalogName";
             DDJobRequestID.DataValueField = "CatalogValue";
             DDJobRequestID.DataBind();
             DDJobRequestID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

             DDMilitaryStatusID.DataSource = CatalogClass.GetListTypeID("6");
             DDMilitaryStatusID.DataTextField = "CatalogName";
             DDMilitaryStatusID.DataValueField = "CatalogValue";
             DDMilitaryStatusID.DataBind();
             DDMilitaryStatusID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

             ClPeriod cl = new ClPeriod();
             ddPeriodID.DataSource = PeriodClass.GetList(cl);
             ddPeriodID.DataTextField = "PeriodName";
             ddPeriodID.DataValueField = "PeriodID";
             ddPeriodID.DataBind();
             ddPeriodID.Items.Insert(0, new ListItem("بدون انتخاب", "-111"));

             //ddPrintDate.DataSource = CatalogClass.GetListTypeID("");
             //ddPrintDate.DataTextField = "CatalogName";
             //ddPrintDate.DataValueField = "CatalogValue";
             //ddPrintDate.DataBind();
             //ddPrintDate.Items.Insert(0, new ListItem("بدون انتخاب", "0"));







       }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                BindDD();
            }
        }

        public ClPersonal Data {
            get {
                ClPersonal cl = new ClPersonal();
                cl.PeriodID = Convert.ToInt32(ddPeriodID.SelectedValue);
                cl.PersonalID = Convert.ToInt32(TXTPersonalID.Text=="" ? "-111" :TXTPersonalID.Text);
                cl.PesonalCode = TXTPesonalCode.Text;
                cl.FirstName = TXTFirstName.Text;
                cl.LastName = TXTLastName.Text;
                cl.FatherName = TXTFatherName.Text;
                cl.NationalCode = TXTNationalCode.Text;
                cl.JobRequestID = Convert.ToInt32( DDJobRequestID.SelectedValue);
                cl.BitrhPalceState = Convert.ToInt32(DDBitrhPalceState.SelectedValue);
                //cl.BirthPlaceCity = TXTBirthPlaceCity.Text;
                //cl.codePosti = TXTcodePosti.Text;
                //cl.OwnerAddress = TXTOwnerAddress.Text;
                cl.Mobile = TXTMobile.Text;
                cl.EmergencyMobile = TXTEmergencyMobile.Text;
                cl.FinalySacrificeID = Convert.ToInt32( ddFinalySacrificeID.SelectedValue);
                cl.FinalyNativeID = Convert.ToInt32(ddFinalyNativeID.SelectedValue);
                cl.CurrentJobID = Convert.ToInt32( DDCurrentJobID.SelectedValue);
               // cl.EmploymentLong = TXTEmploymentLong.Text;
                cl.EducationLevel = Convert.ToInt32( ddEducationLevel.SelectedValue);
               // cl.EducationName = TXTEducationName.Text;
                cl.DriversLicenseID = Convert.ToInt32(DDDriversLicenseID.SelectedValue);
                cl.FiNalyNativeCityID = Convert.ToInt32(ddFinalyNativeID.SelectedValue);
                cl.FinalyNativeID = Convert.ToInt32(ddFinalyNativeID.SelectedValue);
                cl.PrintDateHas = Convert.ToInt32(ddPrintDate.SelectedValue);

                return cl;

            }
        }
        public void BindGrid()
        {
             ClPersonal cl = Data;
            DataSet ds = PersonalClass.GetListAccept(cl);
            DataView dv = new DataView(ds.Tables[0]);
            if ( ViewState["Personal"]   == null)
            {
                ViewState["Personal"] = "PersonalID Desc";
            }
            dv.Sort = Securenamespace.SecureData.CheckSecurity(ViewState["Personal"].ToString()).ToString();
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
            if (ViewState["Personal" + "Direction"] == null)
            {
                ViewState.Add("Personal" + "Direction", "desc");
            }
            else
            {
                StrSortDirection =  ViewState["Personal" + "Direction"].ToString() ;
            }
            if (StrSortDirection == "desc")
            {
                StrSortDirection = "asc";
            }
            else
            {
                StrSortDirection = "desc";
                ViewState["Personal" + "Direction"] = StrSortDirection;
            }
            ViewState["Personal"] = e.SortExpression + " " + StrSortDirection;
            BindGrid();
        }
        //public void DeleteItem(object sender, System.EventArgs e)
        //{
        //    String PersonalID = ((HtmlAnchor)sender).HRef.ToString();
        //    int i = PersonalClass.Delete(Convert.ToInt32(PersonalID));
        //    if (i == 0)
        //    {
        //        LblMsg.Text = " error ";
        //        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('خطا در حذف');", true);
        //    }
        //    else { BindGrid(); }
        //    LightBox.Value = "0";
        //}
        public void UpItem(object sender, EventArgs e)
        {
            String PersonalID = ((HtmlAnchor)sender).HRef.ToString();
        }
        public void AcceptItem(object sender, EventArgs e)
        {
            String PersonalID = ((HtmlAnchor)sender).HRef.ToString();
            LightBox2.Value = "1";
            CtlPersonalAccept1.BinDD();
            CtlPersonalAccept1.UserRegg = Session["IsManage"].ToString();
            CtlPersonalAccept1.PersonalIDD = PersonalID;
            CtlPersonalAccept1.BindGrid();

        }
        protected void btnInsertLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            LightBox.Value = "1";
          
            BtnSerach.Visible = false;
          
        }
        protected void btnSerachLight_Click(object sender, EventArgs e)
        {
            EmptyLight();
            BtnSerach.Visible = true;
        
        }
        protected void BtnSerach_Click1(object sender, EventArgs e)
        {
            BindGrid();
        }
         
        protected void EmptyLight()
        {
        }
        
        protected void BtnSerach_Click(object sender, EventArgs e)
        {
            BindGrid();
            LightBox.Value = "0";
        }

        

    }
}