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
using System.Web.UI.HtmlControls;

namespace FireFight.Public
{
    public partial class FirstInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {

                var r = (HtmlGenericControl)Master.FindControl("contentAfetrSide");
                r.Attributes["class"] = "col-xs-12 col-sm-12  ";
                var t = (HtmlGenericControl)Master.FindControl("dSide");
                t.Visible = false;
                var body = (HtmlGenericControl)Master.FindControl("bd1");
                body.Attributes["class"] = "no-skin rtl container ";

                var liActive = (HtmlGenericControl)Master.FindControl("step1");
                liActive.Attributes.Add("class", "complete");
                var liActive2 = (HtmlGenericControl)Master.FindControl("step2");
                liActive2.Attributes.Add("class", "complete");
                var liActive3 = (HtmlGenericControl)Master.FindControl("step3");
                liActive3.Attributes.Add("class", "active");





                if (Session["IsManage"] == null)
                    lblPersonalID.Text = Session["PersonalID"].ToString();
                else
                {
                    lblPersonalID.Text = Request.QueryString["PersonalID"].ToString();
                    //var lblLastAccept = (Label)Master.FindControl("lblLastAccept");
                    //var lblPersonalName = (Label)Master.FindControl("lblPersonalName");
                    //lblLastAccept.Text=Request
                }
                BindDD();

                ClPersonal cl = new ClPersonal();
                cl.PersonalID = Convert.ToInt32( lblPersonalID.Text);
                DataSet ds = PersonalClass.GetList(cl);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    TXTBirthPlaceCity.Text = dr["BirthPlaceCity"].ToString();
                    txtcodePosti.Text=dr["codePosti"].ToString();
                    TXTEmergencyMobile.Text = dr["EmergencyMobile"].ToString();
                    TXTEmergencyMobile.Text = dr["EmergencyMobile"].ToString();
                    //TXTFatherAddress.Text = dr["FatherAddress"].ToString();
                    TXTFatherName.Text = dr["FatherName"].ToString();
                    TXTFirstName.Text = dr["FirstName"].ToString();
                    if (dr["HomePhone"].ToString().Length > 3) { 
                    TXTHomePhone.Value = dr["HomePhone"].ToString().Substring(3, dr["HomePhone"].ToString().Length-3);
                    TXTHomePhonePre.Value = dr["HomePhone"].ToString().Substring(0, 3);
                    }
                    TXTLastName.Text = dr["LastName"].ToString();
                    //TXTLocationID.Text = dr["LocationID"].ToString();
                    TXTMobile.Text = dr["Mobile"].ToString();
                    TXTNationalCode.Text = dr["NationalCode"].ToString();
                    TXTOwnerAddress.Text = dr["OwnerAddress"].ToString();
                   // TXTStayLength.Text = dr["StayLength"].ToString();
                   // TXTWifeAddress.Text = dr["WifeAddress"].ToString();
                    TXTYearBirthDate.Text = dr["YearBirthDate"].ToString();
                    lblPesonalCode.Text = dr["PesonalCode"].ToString();

                    DDBitrhPalceState.SelectedValue = dr["BitrhPalceState"].ToString();
                    DDDayBithDate.SelectedValue = dr["DayBithDate"].ToString();
                    DDDriversLicenseID.SelectedValue = dr["DriversLicenseID"].ToString();
                    DDJobRequestID.SelectedValue = dr["JobRequestID"].ToString();
                    DDMilitaryMonthLong.SelectedValue = dr["MilitaryMonthLong"].ToString();
                    DDMilitaryStatusID.SelectedValue = dr["MilitaryStatusID"].ToString();
                    DDMilitaryYearLong.SelectedValue = dr["MilitaryYearLong"].ToString();
                    DDMonthBithDate.SelectedValue = dr["MonthBithDate"].ToString();


                      rdsa.SelectedValue= dr["FinalySacrificeID"].ToString()=="" ? "0" : dr["FinalySacrificeID"].ToString();

                   // Native_HighScholl.SelectedValue = dr["Native_HighScholl"].ToString();
                    //Native_Parent.Checked =Utility.ITB( dr["Native_Parent"].ToString());
                    ////Native_ParentBime.SelectedValue = dr["Native_ParentBime"].ToString();
                    ////Native_SchoolTwo.SelectedValue = dr["Native_SchoolTwo"].ToString();
                    //Native_ShoolOne.Checked = Utility.ITB(dr["Native_ShoolOne"].ToString());
                    //Native_SodorSH.Checked = Utility.ITB(dr["Native_SodorSH"].ToString());
                    // Native_Wife.Checked = Utility.ITB(dr["Native_Wife"].ToString());
                    //Native_WifeBime.Checked = Utility.ITB(dr["Native_WifeBime"].ToString());

                    chIsChildOfShahdari.Checked =Utility.ITB( dr["IsChildOfShahdari"].ToString());
                     


                    ds.Dispose();

                }
            }

        }



        //private int SelectedValueFinalyNativeID
        //{
        //    get
        //    {
        //        int tt = 0;
        //        foreach (RepeaterItem item in rpSacrifice.Items)
        //        {

                   
        //            RadioButton rd = (RadioButton)item.FindControl("rdsa");
        //            Label lblNatie = (Label)item.FindControl("lblsaID");
        //            if (rd.Checked)
        //            {
        //                tt = Convert.ToInt32(lblNatie.Text);
        //            }

        //        }
        //        return tt;
        //    }
        //    set
        //    {
        //        foreach (RepeaterItem item in rpSacrifice.Items)
        //        {

        //            RadioButton rd = (RadioButton)item.FindControl("rdsa");
        //            Label lblNatie = (Label)item.FindControl("lblsaID");
        //            if (lblNatie.Text == value.ToString())
        //            {
        //                rd.Checked = true;
        //            }
        //        }
        //    }
        //}
        private void BindPriority(){
            ClPriorityCity cl = new ClPriorityCity();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
            DataSet ds = PriorityCityClass.GetList(cl);

            DataRow dr;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dr = ds.Tables[0].Rows[i];
                if (dr["PeriorityID"].ToString() == "1")
                    ddCity1.SelectedValue = dr["CityID"].ToString();
                else if(dr["PeriorityID"].ToString() == "2")
                    ddCity2.SelectedValue = dr["CityID"].ToString();
                else if(dr["PeriorityID"].ToString() == "3")
                    ddCity3.SelectedValue = dr["CityID"].ToString();
            }

        }

         
        private void BindDD() {
           DDBitrhPalceState.DataSource = CatalogClass.GetListTypeID("5");
           DDBitrhPalceState.DataTextField = "CatalogName";
           DDBitrhPalceState.DataValueField = "CatalogValue";
           DDBitrhPalceState.DataBind();

           DDDriversLicenseID.DataSource = CatalogClass.GetListTypeID("2");
           DDDriversLicenseID.DataTextField = "CatalogName";
           DDDriversLicenseID.DataValueField = "CatalogValue";
           DDDriversLicenseID.DataBind();
           DDDriversLicenseID.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

           DDJobRequestID.DataSource = CatalogClass.GetListTypeID("7");
           DDJobRequestID.DataTextField = "CatalogName";
           DDJobRequestID.DataValueField = "CatalogValue";
           DDJobRequestID.DataBind();
           DDJobRequestID.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

           DDMilitaryStatusID.DataSource = CatalogClass.GetListTypeID("6");
           DDMilitaryStatusID.DataTextField = "CatalogName";
           DDMilitaryStatusID.DataValueField = "CatalogValue";
           DDMilitaryStatusID.DataBind();
           DDMilitaryStatusID.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

                DDDayBithDate.DataSource = CatalogClass.GetListTypeID("8");
                DDDayBithDate.DataTextField = "CatalogName";
                DDDayBithDate.DataValueField = "CatalogValue";
                DDDayBithDate.DataBind();              
           
              DDMonthBithDate.DataSource = CatalogClass.GetListTypeID("9");
              DDMonthBithDate.DataTextField = "CatalogName";
              DDMonthBithDate.DataValueField = "CatalogValue";
              DDMonthBithDate.DataBind();


              DataSet dscityAllow = CatalogClass.GetListTypeID("15");
             
                ddCity1.DataSource = dscityAllow;
                ddCity1.DataTextField = "CatalogName";
                ddCity1.DataValueField = "CatalogValue";
                ddCity1.DataBind();
                ddCity1.Items.Insert(0, new ListItem("بدون انتخاب", "-1000"));

                ddCity2.DataSource = dscityAllow;
                ddCity2.DataTextField = "CatalogName";
                ddCity2.DataValueField="CatalogValue";
                ddCity2.DataBind();
                ddCity2.Items.Insert(0, new ListItem("بدون انتخاب", "-2000"));

                ddCity3.DataSource = dscityAllow;
                ddCity3.DataTextField = "CatalogName";
                ddCity3.DataValueField="CatalogValue";
                ddCity3.DataBind();
                ddCity3.Items.Insert(0, new ListItem("بدون انتخاب", "-3000"));
                dscityAllow.Dispose();

                //rpSacrifice.DataSource = CatalogClass.GetListTypeID("14");
                //rpSacrifice.DataBind();
            rdsa.DataSource= CatalogClass.GetListTypeID("13");
            rdsa.DataTextField = "CatalogName";
            rdsa.DataValueField = "CatalogValue";
            rdsa.DataBind();
            //rdsa.Items.Insert(0, new ListItem("", ""));

            BindPriority();
        }
        private string checkData() {
            string i = "";
           
            ///////Check BirthDate//////////////////////////
            DateTime t;
            try {
                t = DateConvert.sh2m(TXTYearBirthDate.Text + "/" + DDMonthBithDate.SelectedValue.ToString() + "/" + DDDayBithDate.SelectedValue.ToString());
            }
            catch{
            i="تاریخ تولد را به صورت صحیح وارد نمایید";
             
            }
            //////////////////////////
          if(  !FireFightBLL.Utility.isValidMelliCode(TXTNationalCode.Text))
              i+="کد ملی اشتباه است";

          if (TXTMobile.Text == "" || TXTMobile.Text.Length < 11 || !Utility.IsNumeric(TXTMobile.Text) || TXTMobile.Text.Substring(0,2)!="09")
          {
              i = "شماره موبایل را 11 رقمی با پیش شماره  09  وارد  نمایید" ;
          }
          if (DDJobRequestID.SelectedValue == "2" && DDDriversLicenseID.SelectedValue == "2")
              i = "متقاضی گرامی:برای تصدی شغل راننده وسائل نقلیه تندروی سنگین شما بایستی دارای گواهینامه رانندگی پایه یک   باشید";

          if (DDDriversLicenseID.SelectedValue == "0")
              i  = "نوع گواهینامه رانندگی خود را انتخاب نمایید"  ;
        
            if (DDJobRequestID.SelectedValue == "0")
              i  = "شغل درخواستی را نتخاب نمایید" ;

            if (DDMilitaryStatusID.SelectedValue == "0")
              i  = "وضعیت خدمت وظیفه عمومی خود را انتخاب نمایید" ;

            if ( DDJobRequestID.SelectedValue=="2" &&(
                ddCity1.SelectedValue == ddCity2.SelectedValue  || ddCity1.SelectedValue == ddCity3.SelectedValue ||
                ddCity2.SelectedValue == ddCity3.SelectedValue
                            )    )
                i = "شهرهای محل خدمت به ترتیب اولویت نباید یکسان باشند";


            if (DDJobRequestID.SelectedValue == "2")
            {
                if (Convert.ToInt32(ddCity1.SelectedValue)<0)
                    i = "انتخاب شهر محل خدمت بااولویت اول  الزامی است  ";

                if (Convert.ToInt32( ddCity3.SelectedValue) >0  && Convert.ToInt32( ddCity2.SelectedValue) < 0)
                    i = "ابتدا اولویت دو و سپس سه را وارد نمایید";
            }
            if (TXTYearBirthDate.Text.Substring(0, 2) != "13" || TXTYearBirthDate.Text.Length != 4 )
                i = "سال را 4 رقمی به صورت 1300 وارد نمایید";



            return i;
        }
        protected void aanneexxtt_ServerClick(object sender, EventArgs e)
        {
            string alaram =checkData();
            if (alaram!= "")
            {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, alaram);
                return;
            }

            ClPersonal cl = new ClPersonal();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
            cl.JobRequestID = Convert.ToInt32(DDJobRequestID.SelectedValue);
            cl.NationalCode = TXTNationalCode.Text;
            cl.FirstName = TXTFirstName.Text;
            cl.LastName = TXTLastName.Text;
            cl.FatherName = TXTFatherName.Text;
            cl.YearBirthDate =Convert.ToInt32( TXTYearBirthDate.Text);
            cl.MonthBithDate =Convert.ToInt32( DDMonthBithDate.SelectedValue);
            cl.DayBithDate =Convert.ToInt32( DDDayBithDate.SelectedValue);
            cl.codePosti = txtcodePosti.Text;
            cl.OwnerAddress = TXTOwnerAddress.Text;
            cl.FatherAddress = "";//TXTFatherAddress.Text;
            cl.WifeAddress = "";// TXTWifeAddress.Text;
            cl.HomePhone = TXTHomePhonePre.Value.ToString()+ TXTHomePhone.Value.ToString();
            cl.Mobile = TXTMobile.Text;
            cl.EmergencyMobile = TXTEmergencyMobile.Text;
            cl.MilitaryStatusID = Convert.ToInt32(DDMilitaryStatusID.SelectedValue);
            cl.MilitaryMonthLong = Convert.ToInt32(DDMilitaryMonthLong.SelectedValue);
            cl.MilitaryYearLong = Convert.ToInt32(DDMilitaryYearLong.SelectedValue);
            cl.BirthPlaceCity = TXTBirthPlaceCity.Text;
            cl.BitrhPalceState = Convert.ToInt32(DDBitrhPalceState.SelectedValue);
            cl.DriversLicenseID=Convert.ToInt32(DDDriversLicenseID.SelectedValue);
          cl.IsChildOfShahdari = Utility.BTI(chIsChildOfShahdari.Checked);
            cl.FinalySacrificeID =Convert.ToInt32( rdsa.SelectedValue);

            int i = 0;
           i= PersonalClass.Update(cl);
           if (i == 0)  
               FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا در درج اطلاعات.لطفا با مرکز تماس بگیرید");
           else if (i == -1)
               FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "با این کد ملی قبلا ثبت نام صورت گرفته و اجازه ثبت نام مجدد ندارد");
           else
           { 
           ///update periority

               if(DDJobRequestID.SelectedValue=="2")
               {

                   int o = PriorityCityClass.insertAllCity(Convert.ToInt32(lblPersonalID.Text), Convert.ToInt32(ddCity1.SelectedValue), Convert.ToInt32(ddCity2.SelectedValue), Convert.ToInt32(ddCity3.SelectedValue));

                    if(o==0)
                    {FireFightBLL.Utility.ShowMsg(Page,ProPertyData.MsgType.warning,"خطا در ثبت اولویت ها.");
                        return;
                    }
                   
               }
               if(Session["IsManage"]!=null)
                   Response.Redirect("~/Public/SecondInfo.aspx?PersonalID=" + Request.QueryString["PersonalID"] + "&AcceptName=" + Request.QueryString["AcceptName"] + "&PName=" + Request.QueryString["PName"]);
                   else
            Response.Redirect("~/Public/SecondInfo.aspx");
           }
              
            

        }

        protected void ddNative_DataBinding(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)(sender);
            ddl.DataSource = CatalogClass.GetListTypeID("15");
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));
        }

        private void SetPeriority() { 
        
        }

        protected void ddCity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddCity2.Items.Remove(ddCity2.Items.FindByValue(ddCity1.SelectedValue));
            ddCity3.Items.Remove(ddCity3.Items.FindByValue(ddCity1.SelectedValue));
        }

        protected void ddCity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddCity3.Items.Remove(ddCity3.Items.FindByValue(ddCity2.SelectedValue));
        }

 

       
    }
}