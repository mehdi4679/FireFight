using FireFightBLL;
using FireFightCL;
using FireFightDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FireFight.Public
{
    public partial class SecondInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                /////////////////set masterpage
                var r = (HtmlGenericControl)Master.FindControl("contentAfetrSide");
                r.Attributes["class"] = "col-xs-12 col-sm-12  ";
                var t = (HtmlGenericControl)Master.FindControl("dSide");
                t.Visible = false;
                var liActive = (HtmlGenericControl)Master.FindControl("step1");
                liActive.Attributes.Add("class", "complete");
                var liActive2 = (HtmlGenericControl)Master.FindControl("step2");
                liActive2.Attributes.Add("class", "complete");
                var liActive3 = (HtmlGenericControl)Master.FindControl("step3");
                liActive3.Attributes.Add("class", "complete"); 
                var liActive4 = (HtmlGenericControl)Master.FindControl("step4");
                liActive4.Attributes.Add("class", "active");
                var body = (HtmlGenericControl)Master.FindControl("bd1");
                body.Attributes["class"] = "no-skin rtl container ";
                /////////////////////////////////////////////////////////////


                if (Session["IsManage"] == null)
                    lblPersonalID.Text = Session["PersonalID"].ToString();
                else
                    lblPersonalID.Text = Request.QueryString["PersonalID"].ToString();

                BindDD();

                ClPersonal cl = new ClPersonal();
                cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
                DataSet ds = PersonalClass.GetList(cl);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    TXTBimeLong.Text = dr["BimeLong"].ToString();
                    TXTEducationCityName.Text = dr["EducationCityName"].ToString();
                    TXTEducationName.Text = dr["EducationName"].ToString();
                    TXTEducationYear.Text = dr["EducationYear"].ToString();
                    DDEmploymentLong.SelectedValue = dr["EmploymentLong"].ToString();
                    txtEmmloyeYearLong.Text = dr["EmmloyeYearLong"].ToString();
                   // TXTOfficeJobName.Text = dr["OfficeJobName"].ToString();
                    //TXTSacrificeAzadeh.Checked =Utility.ITB( dr["SacrificeAzadeh"].ToString());
                    lblPesonalCode.Text = dr["PesonalCode"].ToString();

 
                     DDCurrentJobID.SelectedValue =  dr["CurrentJobID"].ToString() ;
                    DDEducationLevel.SelectedValue = dr["EducationLevel"].ToString();
                    DDEducationLocationOstan.SelectedValue = dr["EducationLocationOstan"].ToString();
                    ddStudyFiedlD.SelectedValue = dr["StudyFiedlD"].ToString();
                    txtStudyFieldName.Text = dr["StudyFieldName"].ToString();
                    lbljobRequest.Text = dr["JobRequestID"].ToString();

//////////////////////////////////////////check filed///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                   // FieldVisible();
                  


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ddFiNalyNativeCityID.SelectedValue = dr["FiNalyNativeCityID"].ToString();
                    ddFinalyNativeID.SelectedValue = dr["FinalyNativeID"].ToString();
                    setddOfficeName = dr["OfficeJobName"].ToString();

                     ds.Dispose();

                     //if (DDCurrentJobID.SelectedValue == "2") {
                     //    dcurrentjob.Attributes.Add("class", "vv");
                     //}

                }
                Setdd();
                Setdd2();
                setdd3();
                
            }
        }
        private void BindDD()
        {
            DDCurrentJobID.DataSource = CatalogClass.GetListTypeID("10");
            DDCurrentJobID.DataTextField = "CatalogName";
            DDCurrentJobID.DataValueField = "CatalogValue";
            DDCurrentJobID.DataBind();
            DDCurrentJobID.Items.Insert(0,new ListItem("انتخاب نمایید","0"));

            DDEducationLevel.DataSource = CatalogClass.GetListLevel(3,Convert.ToInt32(lblPersonalID.Text));
            DDEducationLevel.DataTextField = "CatalogName";
            DDEducationLevel.DataValueField = "CatalogValue";
            DDEducationLevel.DataBind();
            DDEducationLevel.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

                        DDEducationLocationOstan.DataSource = CatalogClass.GetListTypeID("5");
                        DDEducationLocationOstan.DataTextField = "CatalogName";
                        DDEducationLocationOstan.DataValueField = "CatalogValue";
                        DDEducationLocationOstan.DataBind();
                        DDEducationLocationOstan.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

                        ddStudyFiedlD.DataSource = CatalogClass.GetListTypeID("12");
                        ddStudyFiedlD.DataTextField = "CatalogName";
                        ddStudyFiedlD.DataValueField = "CatalogValue";
                        ddStudyFiedlD.DataBind();
                        ddStudyFiedlD.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));


                        ddFinalyNativeID.DataSource = CatalogClass.GetListTypeID("14");
                       
                        ddFinalyNativeID.DataTextField = "CatalogName";
                        ddFinalyNativeID.DataValueField = "CatalogValue";
                        ddFinalyNativeID.DataBind();
                        ddFinalyNativeID.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

                        ddFiNalyNativeCityID.DataSource = CatalogClass.GetListTypeID("16");
                        
                        ddFiNalyNativeCityID.DataTextField = "CatalogName";
                        ddFiNalyNativeCityID.DataValueField = "CatalogValue";
                        ddFiNalyNativeCityID.DataBind();
                        ddFiNalyNativeCityID.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

                        ddOfficeJobName.DataSource = CatalogClass.GetListTypeID("16");
                        ddOfficeJobName.DataTextField = "CatalogName";
                        ddOfficeJobName.DataValueField = "CatalogName";
                        ddOfficeJobName.DataBind();


             


        }
        private string checkData()
        {
            string i = "";

          
            if (DDCurrentJobID.SelectedValue=="0")
                i = "وضعیت اشتغال فعلی خود را انتخاب نمایید";
            if (DDEducationLevel.SelectedValue=="0")
                i = "وضعیت تحصیلی فعلی خود را انتخاب نمایید";
            //if (DDEducationLocationOstan.SelectedValue=="0")
            //    i = "استان محل تحصیل خود را انتخاب نمایید";
            if ( Convert.ToInt32( DDEducationLevel.SelectedValue)>1 && ddStudyFiedlD.SelectedValue == "0")
                i = "رشته تحصیلی را انتخاب فرمایید";

            //if (Convert.ToInt32(DDEducationLevel.SelectedValue) > 1 && ddStudyFiedlD.SelectedValue == "1" && DDCurrentJobID.SelectedValue != "2")
            //    i = "ثبت نام در مقطع دیپلم برای متقاضیان شغل کاردان آتش نشان به استثنا کارکنان تا پایان سال 90 مجاط نمیباشد";

            if(Convert.ToInt32( DDCurrentJobID.SelectedValue)==2 && (DDEmploymentLong.SelectedValue=="0" && (txtEmmloyeYearLong.Text=="" || txtEmmloyeYearLong.Text=="0")))
            i = "مدت اشتغال را وارد نمایید";

            if (ddFiNalyNativeCityID.SelectedValue == "0" && ddFinalyNativeID.SelectedValue != "0")
                i = "  شهر مربوطه بومی بودن  را انتخاب نمایید";

            if(DDCurrentJobID.SelectedValue!="0" || DDCurrentJobID.SelectedValue!="1")
            {
                if (((txtEmmloyeYearLong.Text == "0" || txtEmmloyeYearLong.Text == "")&&DDEmploymentLong.SelectedValue=="0") && (DDCurrentJobID.SelectedValue!="1" &&DDCurrentJobID.SelectedValue!="0")   )
                     i = "وارد کردن سابقه اشتغال به ماه و سال و محل خدمت الزامی است";

            }


            return i;
        }
        protected void aanneexxtt_ServerClick(object sender, EventArgs e)
        {
            string alaram = checkData();
            if (alaram != "")
            {
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, alaram);
                return;
            }
            ClPersonal cl = new ClPersonal();
            cl.PersonalID = Convert.ToInt32(lblPersonalID.Text);
            cl.CurrentJobID =Convert.ToInt32( DDCurrentJobID.SelectedValue);
            cl.OfficeJobName = setddOfficeName ;
            cl.EmploymentLong = DDEmploymentLong.SelectedValue;
            cl.BimeLong = TXTBimeLong.Text;
            cl.EducationLevel = Convert.ToInt32(DDEducationLevel.SelectedValue);
            cl.EducationYear = Convert.ToInt32(TXTEducationYear.Text == "" ? "0" : TXTEducationYear.Text);
            cl.EducationName = TXTEducationName.Text;
            cl.EducationCityName = TXTEducationCityName.Text;
            cl.EducationLocationOstan = Convert.ToInt32(DDEducationLocationOstan.SelectedValue);
            
            cl.EmmloyeYearLong = Convert.ToInt32(txtEmmloyeYearLong.Text=="" ?"0" :txtEmmloyeYearLong.Text);
            //cl.SacrificeAzadeh =FireFightBLL.Utility.BTI( TXTSacrificeAzadeh.Checked);
            //cl.SacrificeAzadehChild = FireFightBLL.Utility.BTI(TXTSacrificeAzadehChild.Checked);
            //cl.SacrificeBorther = FireFightBLL.Utility.BTI(TXTSacrificeBorther.Checked);
            //cl.SacrificeChild=FireFightBLL.Utility.BTI(TXTSacrificeChild.Checked);
            //cl.SacrificeJanbaz = FireFightBLL.Utility.BTI(TXTSacrificeJanbaz.Checked);
            //cl.SacrificejanbazChild = FireFightBLL.Utility.BTI(TXTSacrificejanbazChild.Checked);
            //cl.SacrificeNineMonth = FireFightBLL.Utility.BTI(TXTSacrificeNineMonth.Checked);
            //cl.SacrificeSixMonth = FireFightBLL.Utility.BTI(TXTSacrificeSixMonth.Checked);
            //cl.SacrificeUpper = FireFightBLL.Utility.BTI(TXTSacrificeUpper.Checked);
            //cl.SacrificeWife = FireFightBLL.Utility.BTI(TXTSacrificeWife.Checked);

            ////cl.SaFamiliy = Utility.BTI(chSaFamiliy.Checked);
            ////cl.SaJanbaz = Utility.BTI(chSaJanbaz.Checked);
            ////cl.SaSoldure = Utility.BTI(chSaSoldure.Checked);
            ////cl.SaAzadeh = Utility.BTI(chSaAzadeh.Checked);
            ////cl.SaBrotherShahid = Utility.BTI(chSaBrotherShahid.Checked);
            ////cl.StudyFiedlD = Convert.ToInt32(ddStudyFiedlD.SelectedValue);
            ////cl.StudyFieldName = txtStudyFieldName.Text;
            cl.FiNalyNativeCityID =Convert.ToInt32( ddFiNalyNativeCityID.SelectedValue);
            cl.FinalyNativeID =Convert.ToInt32( ddFinalyNativeID.SelectedValue);
            cl.StudyFiedlD =Convert.ToInt32( ddStudyFiedlD.SelectedValue);
            cl.StudyFieldName = txtStudyFieldName.Text;

            int i = 0;
            i = PersonalClass.Update(cl);
            if (i == 0)
                FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "خطا در درج اطلاعات.لطفا با مرکز تماس بگیرید");
            else
            {
                DataSet ds = PersonalClass.CheckAge(Convert.ToInt32(lblPersonalID.Text));
                if (ds != null)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    if (dr["r"].ToString() == "true")
                        NextPagee();
                    else
                        FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "متقاضی گرامی شما شرایط سنی برای شرکت در آزمون را ندارید");
                }
                else
                {
                    NextPagee();
                    FireFightBLL.Utility.ShowMsg(Page, ProPertyData.MsgType.warning, "کاربر گرامی لطفا تاریخ تولد خود را دقیق وارد نمایید تا اجازه ورود به مرحله بعد صادر گردد.در غیر این صورت  لطفا با مرکز تماس بگیرید");

                }
            }
        }

        private void NextPagee() {
            if (Session["IsManage"] != null)
                Response.Redirect("~/Public/AttachDoc.aspx?PersonalID=" + Request.QueryString["PersonalID"] + "&AcceptName=" + Request.QueryString["AcceptName"] + "&PName=" + Request.QueryString["PName"]);
            else
                Response.Redirect("~/Public/AttachDoc.aspx");
        }

        //private int SelectedValueFinalyNativeID
        //{
        //    get
        //    {
        //        int tt = 0;
        //        foreach (RepeaterItem item in rpSacrifice.Items)
        //        {

        //            DropDownList ddNatie = (DropDownList)item.FindControl("ddNative");
        //            RadioButton rd = (RadioButton)item.FindControl("rdNative");
        //            Label lblNatie = (Label)item.FindControl("lblNativeID");
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
        //            DropDownList ddNatie = (DropDownList)item.FindControl("ddNative");
        //            RadioButton rd = (RadioButton)item.FindControl("rdNative");
        //            Label lblNatie = (Label)item.FindControl("lblNativeID");
        //            if (lblNatie.Text == value.ToString())
        //            {
        //                rd.Checked = true;
        //            }
        //        }
        //    }
        //}

        //private int SelectedValueFiNalyNativeCityID
        //{
        //    get
        //    {
        //        int tt = 0;
        //        foreach (RepeaterItem item in rpSacrifice.Items)
        //        {

        //            DropDownList ddNatie = (DropDownList)item.FindControl("ddNative");
        //            RadioButton rd = (RadioButton)item.FindControl("rdNative");
        //            Label lblNatie = (Label)item.FindControl("lblNativeID");
        //            if (rd.Checked)
        //            {
        //                tt = Convert.ToInt32(ddNatie.SelectedValue);
        //            }

        //        }
        //        return tt;
        //    }
        //    set
        //    {
        //        foreach (RepeaterItem item in rpSacrifice.Items)
        //        {
        //            DropDownList ddNatie = (DropDownList)item.FindControl("ddNative");
        //            RadioButton rd = (RadioButton)item.FindControl("rdNative");
        //            Label lblNatie = (Label)item.FindControl("lblNativeID");
        //            if (lblNatie.Text == value.ToString())
        //            {
        //                ddNatie.SelectedValue = value.ToString();
        //            }
        //        }
        //    }
        //}
        protected void ddNative_DataBinding(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)(sender);
            ddl.DataSource = CatalogClass.GetListTypeID("15");
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("انتخاب نمایید", "0"));

        }

        private void Setdd() {
            if (DDCurrentJobID.SelectedValue != "0" && DDCurrentJobID.SelectedValue != "1")
                tblhowlong.Visible =true ;
            else tblhowlong.Visible = false;

            if (DDCurrentJobID.SelectedValue == "2" || DDCurrentJobID.SelectedValue == "8" || DDCurrentJobID.SelectedValue == "3" || DDCurrentJobID.SelectedValue == "6")
                lblshahrdari.Text = "شهرداری";
            else
                lblshahrdari.Text = "";
            /////////////////for diplom and kardan
            if ((DDCurrentJobID.SelectedValue == "8" || DDCurrentJobID.SelectedValue == "3") && lbljobRequest.Text == "1")
            {
                if (DDEducationLevel.Items.FindByValue("1") == null)
                    DDEducationLevel.Items.Insert(1, new ListItem("دیپلم", "1"));
            }
            else if (lbljobRequest.Text == "1")
            {
                if (DDEducationLevel.Items.FindByValue("1") != null)
                    DDEducationLevel.Items.Remove(DDEducationLevel.Items.FindByValue("1"));
            }
        }
        private void Setdd2() {
            if (DDEducationLevel.SelectedValue == "1")//diplom
            {
                txtStudyFieldName.Visible = true;
                ddStudyFiedlD.Visible = false;
            }
            else
            {
                ddStudyFiedlD.Visible = true;
                txtStudyFieldName.Visible = false;
            }
        }
       private void  setdd3(){
         if (ddFinalyNativeID.SelectedValue != "0")
             ddFiNalyNativeCityID.Enabled = true;
            else
             ddFiNalyNativeCityID.Enabled = false;
        }

       private string setddOfficeName
       {
           get
           {
               if (DDCurrentJobID.SelectedValue == "2" || DDCurrentJobID.SelectedValue == "3" || DDCurrentJobID.SelectedValue == "6" || DDCurrentJobID.SelectedValue == "7" || DDCurrentJobID.SelectedValue == "8")
               {
                   ddOfficeJobName.Visible = true;
                   TXTOfficeJobName.Visible = false;
                   return ddOfficeJobName.SelectedValue.ToString();

               }
               else
               {
                   TXTOfficeJobName.Visible = true;
                   ddOfficeJobName.Visible = false;
                   return TXTOfficeJobName.Text;
               }
           }
           set
           {
               if (DDCurrentJobID.SelectedValue == "2" || DDCurrentJobID.SelectedValue == "3" || DDCurrentJobID.SelectedValue == "6" || DDCurrentJobID.SelectedValue == "7" || DDCurrentJobID.SelectedValue == "8")
               {
                   ddOfficeJobName.Visible = true;
                   TXTOfficeJobName.Visible = false;
                   ddOfficeJobName.SelectedValue = value;


               }
               else
               {
                   ddOfficeJobName.Visible = false;
                   TXTOfficeJobName.Visible = true;
                   TXTOfficeJobName.Text = value;
               }
           }
       }
     
        protected void DDCurrentJobID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setdd();
            if (DDCurrentJobID.SelectedValue == "2" || DDCurrentJobID.SelectedValue == "3" || DDCurrentJobID.SelectedValue == "6" || DDCurrentJobID.SelectedValue == "7" || DDCurrentJobID.SelectedValue == "8")
            {
                ddOfficeJobName.Visible = true;
                TXTOfficeJobName.Visible = false;
            }
            else
            {
                ddOfficeJobName.Visible = false;
                TXTOfficeJobName.Visible = true;
            }
        }

        protected void DDEducationLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setdd2();
        }

        protected void ddFinalyNativeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            setdd3();
        }

        //private void FieldVisible()
        //{
        //    //if (lbljobRequest.Text == "1" && DDCurrentJobID.SelectedValue != "2")
        //    //    DDEducationLevel.Items.Remove(DDEducationLevel.Items.FindByValue("1"));
           

        //    if (Convert.ToInt32(DDEducationLevel.SelectedValue) > 1)
        //    {
        //        ddStudyFiedlD.Visible = true;
        //        txtStudyFieldName.Visible = false;
        //    }
        //    else
        //    {
        //        ddStudyFiedlD.Visible = false;
        //        txtStudyFieldName.Visible = true;
        //    }
        //}

        //protected void DDCurrentJobID_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    FieldVisible();

        //}

     
    }
}